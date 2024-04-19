using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RexControl.Text
{
    /// <summary>
    /// Enum KeyBoardType
    /// </summary>
    public enum KeyBoardType
    {
        /// <summary>
        /// The null
        /// </summary>
        Null = 1,
        /// <summary>
        /// The uc key border all en
        /// </summary>
        UCKeyBorderAll_EN = 2,
        /// <summary>
        /// The uc key border all number
        /// </summary>
        UCKeyBorderAll_Num = 4,
        /// <summary>
        /// The uc key border number
        /// </summary>
        UCKeyBorderNum = 8,
        /// <summary>
        /// The uc key border hand
        /// </summary>
        UCKeyBorderHand = 16
    }
}
