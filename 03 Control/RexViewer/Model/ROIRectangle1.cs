using System;
using HalconDotNet;
using System.Xml.Serialization;

namespace RexView
{
    /// <summary>
    /// This class demonstrates one of the possible implementations for a 
    /// (simple) rectangularly shaped ROI. ROIRectangle1 inherits 
    /// from the base class ROI and implements (besides other auxiliary
    /// methods) all virtual methods defined in ROI.cs.
    /// Since a simple rectangle is defined by two data points, by the upper 
    /// left corner and the lower right corner, we use four values (row1/col1) 
    /// and (row2/col2) as class members to hold these positions at 
    /// any time of the program. The four corners of the rectangle can be taken
    /// as handles, which the user can use to manipulate the size of the ROI. 
    /// Furthermore, we define a midpoint as an additional handle, with which
    /// the user can grab and drag the ROI. Therefore, we declare NumHandles
    /// to be 5 and set the activeHandle to be 0, which will be the upper left
    /// corner of our ROI.
    /// </summary>
    [Serializable]
    public class ROIRectangle1 : ROI
    {
        public string color = "yellow";
        public double row1, col1;   // upper left
        public double row2, col2;   // lower right 
        public double midR, midC;   // midpoint 
        /// <summary>Constructor</summary>
        public ROIRectangle1()
        {
            NumHandles = 5; // 4 corner points + midpoint
            ActiveHandleId = 4;
        }

        public ROIRectangle1(double row1, double col1, double row2, double col2)
        {
            CreateRectangle1(row1, col1, row2, col2);
        }
        public override void CreateRectangle1(double row1, double col1, double row2, double col2)
        {
            base.CreateRectangle1(row1, col1, row2, col2);
            this.row1 = row1;
            this.col1 = col1;
            this.row2 = row2;
            this.col2 = col2;
            midR = (this.row1 + this.row2) / 2.0;
            midC = (this.col1 + this.col2) / 2.0;
        }
        /// <summary>Creates a new ROI instance at the mouse position</summary>
        /// <param name="midX">
        /// x (=column) coordinate for interactive ROI
        /// </param>
        /// <param name="midY">
        /// y (=row) coordinate for interactive ROI
        /// </param>
        public override void CreateROI(double midX, double midY)
        {
            midR = midY;
            midC = midX;

            row1 = midR - 6;
            col1 = midC - 6;
            row2 = midR + 6;
            col2 = midC + 6;
        }

        /// <summary>Paints the ROI into the supplied window</summary>
        /// <param name="window">HALCON window</param>
        public override void Draw(HWindow window)
        {
            window.SetDraw("margin");
            window.DispRectangle1(row1, col1, row2, col2);
            window.SetDraw("fill");
            window.DispRectangle2(row1, col1, 0,6,6);
            window.DispRectangle2(row1, col2, 0,6,6);
            window.DispRectangle2(row2, col2, 0,6,6);
            window.DispRectangle2(row2, col1, 0,6,6);
            window.DispRectangle2(midR, midC, 0,6,6);
        }

        /// <summary> 
        /// Returns the distance of the ROI handle being
        /// closest to the image point(x,y)
        /// </summary>
        /// <param name="x">x (=column) coordinate</param>
        /// <param name="y">y (=row) coordinate</param>
        /// <returns> 
        /// Distance of the closest ROI handle.
        /// </returns>
        public override double DistToClosestHandle(double x, double y)
        {

            double max = 10000;
            double[] val = new double[NumHandles];

            midR = ((row2 - row1) / 2) + row1;
            midC = ((col2 - col1) / 2) + col1;

            val[0] = HMisc.DistancePp(y, x, row1, col1); // upper left 
            val[1] = HMisc.DistancePp(y, x, row1, col2); // upper right 
            val[2] = HMisc.DistancePp(y, x, row2, col2); // lower right 
            val[3] = HMisc.DistancePp(y, x, row2, col1); // lower left 
            val[4] = HMisc.DistancePp(y, x, midR, midC); // midpoint 

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
        /// <param name="window">HALCON window</param>
        public override void DisplayActive(HalconDotNet.HWindow window)
        {
            switch (ActiveHandleId)
            {
                case 0:
                    window.DispRectangle2(row1, col1, 0, 6, 6);
                    break;
                case 1:
                    window.DispRectangle2(row1, col2, 0, 6, 6);
                    break;
                case 2:
                    window.DispRectangle2(row2, col2, 0, 6, 6);
                    break;
                case 3:
                    window.DispRectangle2(row2, col1, 0, 6, 6);
                    break;
                case 4:
                    window.DispRectangle2(midR, midC, 0, 6, 6);
                    break;
            }
        }

        /// <summary>Gets the HALCON region described by the ROI</summary>
        public override HRegion GetRegion()
        {
            HRegion region = new HRegion();
            region.GenRectangle1(row1, col1, row2, col2);
            return region;
        }
        public override HXLDCont GetXLD()
        {
            HXLDCont xld = new HXLDCont();
            HTuple row = new HTuple(col1, col2, col2, row1,  col1 );
            HTuple col = new HTuple(row1, row1, row2, row2, row1);
            xld.GenContourPolygonXld(row, col);
            return xld;
        }
        /// <summary>
        /// Gets the model information described by 
        /// the interactive ROI
        /// </summary> 
        public override HTuple GetModelData()
        {
            return new HTuple(new double[] { row1, col1, row2, col2 });
        }


        /// <summary> 
        /// Recalculates the shape of the ROI instance. Translation is 
        /// performed at the active handle of the ROI object 
        /// for the image coordinate (x,y)
        /// </summary>
        /// <param name="newX">x mouse coordinate</param>
        /// <param name="newY">y mouse coordinate</param>
        public override void moveByHandle(double newX, double newY)
        {
            double len1, len2;
            double tmp;

            switch (ActiveHandleId)
            {
                case 0: // upper left 
                    row1 = newY;
                    col1 = newX;
                    break;
                case 1: // upper right 
                    row1 = newY;
                    col2 = newX;
                    break;
                case 2: // lower right 
                    row2 = newY;
                    col2 = newX;
                    break;
                case 3: // lower left
                    row2 = newY;
                    col1 = newX;
                    break;
                case 4: // midpoint 
                    len1 = ((row2 - row1) / 2);
                    len2 = ((col2 - col1) / 2);

                    row1 = newY - len1;
                    row2 = newY + len1;

                    col1 = newX - len2;
                    col2 = newX + len2;

                    break;
            }

            if (row2 <= row1)
            {
                tmp = row1;
                row1 = row2;
                row2 = tmp;
            }

            if (col2 <= col1)
            {
                tmp = col1;
                col1 = col2;
                col2 = tmp;
            }

            midR = ((row2 - row1) / 2) + row1;
            midC = ((col2 - col1) / 2) + col1;

        }//end of method  
        public object Clone()
        {
            return this.MemberwiseClone();
    }
}//end of class
}//end of namespace
