using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HalconDotNet;
using RexView;

namespace RexView.Model
{
    interface IViewWindow
    {
        void displayImage(HObject img);
        void ResetWindowImage();
        void zoomWindowImage();
        void moveWindowImage();
        void noneWindowImage();
        void genPoint(string name, double row, double col, ref Dictionary<string, ROI> rois);
        void genCircle(string name, double row, double col, double radius, ref Dictionary<string, ROI> rois);
        void genCircleArr(string name, double row, double col, double radius, ref Dictionary<string, ROI> rois);
        void genLine(string name, double beginRow, double beginCol, double endRow, double endCol, ref Dictionary<string, ROI> rois);
        void genCoordLine(string name, double beginRow, double beginCol, double endRow, double endCol, ref Dictionary<string, ROI> rois);
        void genRect1(string name, double row1, double col1, double row2, double col2, ref Dictionary<string, ROI> rois);
        void genRect2(string name, double row, double col, double phi, double length1, double length2, ref Dictionary<string, ROI> rois);
        ROI smallestActiveROI(out string name, out string index);
        ROI smallestActiveROI(out List<double> data, out string index);
        void selectROI(string index);
        void selectROI(Dictionary<string, ROI> rois, string index);
        void DispROI(Dictionary<string, ROI> rois);
        void removeActiveROI(ref Dictionary<string, ROI> rois);
        void saveROI(Dictionary<string, ROI> rois, string fileNmae);
        void loadROI(string fileName, out Dictionary<string, ROI> rois);
    }
}
