using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyVision.EVControl.EVForms
{
    public class SharedClass
    {
        private static DateTime dtErrorMessage;

        public static bool DesignMode()
        {
            return (((AppDomain.CurrentDomain != null) && !string.IsNullOrEmpty(AppDomain.CurrentDomain.FriendlyName)) && (AppDomain.CurrentDomain.FriendlyName == "DefaultDomain"));
        }

        public static void ExceptionOutOfMemory(OutOfMemoryException ex)
        {
            ExceptionOutOfMemory(ex, false);
        }

        public static void ExceptionOutOfMemory(OutOfMemoryException ex, bool bForce)
        {
            try
            {
                if (bForce || (dtErrorMessage.AddSeconds(10.0) <= DateTime.Now))
                {
                    dtErrorMessage = DateTime.Now;
                    if (!DesignMode())
                    {
                        //MessageDialog.StockShow(ControlBase.mesCommonErr0);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
