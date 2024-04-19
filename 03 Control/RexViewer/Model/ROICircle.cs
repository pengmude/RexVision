using System;
using HalconDotNet;
using System.Xml.Serialization;

namespace RexView
{
    /// <summary>
    /// This class demonstrates one of the possible implementations for a 
    /// circular ROI. ROICircle inherits from the base class ROI and 
    /// implements (besides other auxiliary methods) all virtual methods 
    /// defined in ROI.cs.
    /// </summary>
    [Serializable]
    public class ROICircle : ROI
    {
        public bool Status;
        public string PointOrder = "positive";
        public double Radius;
        public double StartPhi, EndPhi;  // first handle
        public double CenterY, CenterX;  // second handle
        public ROICircle()
        {
            NumHandles = 2; // one at corner of circle + midpoint
            ActiveHandleId = 1;
            Status = true;
        }
        public string GetName()
        {
            return "";
        }
        public ROICircle(double row, double col, double Radius)
        {
            CreateCircle(row, col, Radius);
        }
        public override void CreateCircle(double row, double col, double Radius)
        {
            base.CreateCircle(row, col, Radius);
            CenterY = row;
            CenterX = col;

            this.Radius = Radius;

            StartPhi = CenterY;
            EndPhi = CenterX + Radius;
            Status = true;
        }
        /// <summary>Creates a new ROI instance at the mouse position</summary>
        public override void CreateROI(double midX, double midY)
        {
            CenterY = midY;
            CenterX = midX;

            Radius = 100;

            StartPhi = CenterY;
            EndPhi = CenterX + Radius;
        }
        /// <summary>Paints the ROI into the supplied window</summary>
        /// <param name="window">HALCON window</param>
        public override void Draw(HalconDotNet.HWindow window)
        {
            window.SetDraw("margin");
            window.DispCircle(CenterY, CenterX, Radius);
            window.SetDraw("fill");
            window.DispRectangle2(StartPhi, EndPhi, 0, 4, 4);
            window.DispRectangle2(CenterY, CenterX, 0, 4, 4);
        }
        /// <summary> 
        /// Returns the distance of the ROI handle being
        /// closest to the image point(x,y)
        /// </summary>
        public override double DistToClosestHandle(double x, double y)
        {
            double max = 10000;
            double[] val = new double[NumHandles];

            val[0] = HMisc.DistancePp(y, x, StartPhi, EndPhi); // border handle 
            val[1] = HMisc.DistancePp(y, x, CenterY, CenterX); // midpoint 

            for (int i = 0; i < NumHandles; i++)
            {
                if (val[i] < max)
                {
                    max = val[i];
                    ActiveHandleId = i;
                }
            }// end of for 
            return val[ActiveHandleId];
        }
        /// <summary> 
        /// Paints the active handle of the ROI object into the supplied window 
        /// </summary>
        public override void DisplayActive(HalconDotNet.HWindow window)
        {

            switch (ActiveHandleId)
            {
                case 0:
                    window.DispRectangle2(StartPhi, EndPhi, 0, 4, 4);
                    break;
                case 1:
                    window.DispRectangle2(CenterY, CenterX, 0, 4, 4);
                    break;
            }
        }
        /// <summary>Gets the HALCON region described by the ROI</summary>
        public override HRegion GetRegion()
        {
            HRegion region = new HRegion();
            region.GenCircle(CenterY, CenterX, Radius);
            return region;
        }
        public override HXLDCont GetXLD()
        {
            HXLDCont xld = new HXLDCont();
            xld.GenCircleContourXld(CenterX, CenterY, Radius, StartPhi, EndPhi, PointOrder, 1.0);
            return xld;
        }
        public override double GetDistanceFromStartPoint(double row, double col)
        {
            double sRow = CenterY; // assumption: we have an angle starting at 0.0
            double sCol = CenterX + 1 * Radius;

            double angle = HMisc.AngleLl(CenterY, CenterX, sRow, sCol, CenterY, CenterX, row, col);

            if (angle < 0)
                angle += 2 * Math.PI;

            return (Radius * angle);
        }
        /// <summary>
        /// Gets the model information described by 
        /// the  ROI
        /// </summary> 
        public override HTuple GetModelData()
        {
            return new HTuple(new double[] { CenterY, CenterX, Radius });
        }
        /// <summary> 
        /// Recalculates the shape of the ROI. Translation is 
        /// performed at the active handle of the ROI object 
        /// for the image coordinate (x,y)
        /// </summary>
        public override void moveByHandle(double newX, double newY)
        {
            HTuple distance;
            double shiftX, shiftY;

            switch (ActiveHandleId)
            {
                case 0: // handle at circle border

                    StartPhi = newY;
                    EndPhi = newX;
                    HOperatorSet.DistancePp(new HTuple(StartPhi), new HTuple(EndPhi),
                                            new HTuple(CenterY), new HTuple(CenterX),
                                            out distance);

                    Radius = distance[0].D;
                    break;
                case 1: // midpoint 

                    shiftY = CenterY - newY;
                    shiftX = CenterX - newX;

                    CenterY = newY;
                    CenterX = newX;

                    StartPhi -= shiftY;
                    EndPhi -= shiftX;
                    break;
            }
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }//end of class
}//end of namespace
