using System;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace RexHelps
{
    public static partial class RString
    {
        #region 匹配方法  
        /// <summary>  
        /// 验证字符串是否匹配正则表达式描述的规则  
        /// </summary>  
        /// <param name="inputStr">待验证的字符串</param>  
        /// <param name="patternStr">正则表达式字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsMatch(string inputStr, string patternStr)
        {
            return IsMatch(inputStr, patternStr, false, false);
        }

        /// <summary>  
        /// 验证字符串是否匹配正则表达式描述的规则  
        /// </summary>  
        /// <param name="inputStr">待验证的字符串</param>  
        /// <param name="patternStr">正则表达式字符串</param>  
        /// <param name="ifIgnoreCase">匹配时是否不区分大小写</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsMatch(string inputStr, string patternStr, bool ifIgnoreCase)
        {
            return IsMatch(inputStr, patternStr, ifIgnoreCase, false);
        }
        /// <summary>  
        /// 验证字符串是否匹配正则表达式描述的规则  
        /// </summary>  
        /// <param name="inputStr">待验证的字符串</param>  
        /// <param name="patternStr">正则表达式字符串</param>  
        /// <param name="ifValidateWhiteSpace">是否验证空白字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsMatchs(string inputStr, string patternStr, bool ifValidateWhiteSpace)
        {
            return IsMatch(inputStr, patternStr, false, ifValidateWhiteSpace);
        }
        /// <summary>  
        /// 验证字符串是否匹配正则表达式描述的规则  
        /// </summary>  
        /// <param name="inputStr">待验证的字符串</param>  
        /// <param name="patternStr">正则表达式字符串</param>  
        /// <param name="ifIgnoreCase">匹配时是否不区分大小写</param>  
        /// <param name="ifValidateWhiteSpace">是否验证空白字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsMatch(string inputStr, string patternStr, bool ifIgnoreCase, bool ifValidateWhiteSpace)
        {
            if (!ifValidateWhiteSpace && string.IsNullOrEmpty(inputStr))
                return false;//如果不要求验证空白字符串而此时传入的待验证字符串为空白字符串，则不匹配  
            Regex regex = null;
            if (ifIgnoreCase)
                regex = new Regex(patternStr, RegexOptions.IgnoreCase);//指定不区分大小写的匹配  
            else
                regex = new Regex(patternStr);
            return regex.IsMatch(inputStr);
        }
        #endregion
        #region 验证方法  
        /// <summary>
        /// 判断字符串是否数字
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        public static bool IsNumber(string strNumber)
        {
            Regex regex = new Regex("[^0-9.-]");
            Regex regex2 = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            Regex regex3 = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            string str = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";
            string str2 = "^([-]|[0-9])[0-9]*$";
            Regex regex4 = new Regex("(" + str + ")|(" + str2 + ")");
            return !regex.IsMatch(strNumber) && !regex2.IsMatch(strNumber) && !regex3.IsMatch(strNumber) && regex4.IsMatch(strNumber);
        }
        /// <summary>  
        /// 验证数字(double类型)  
        /// [可以包含负号和小数点]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsDouble(string input)
        {
            //string pattern = @"^-?\d+$|^(-?\d+)(\.\d+)?$";  
            //return IsMatch(input, pattern);  
            double d = 0;
            if (double.TryParse(input, out d))
                return true;
            else
                return false;
        }
        /// <summary>  
        /// 验证整数  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsInteger(string input)
        {
            //string pattern = @"^-?\d+$";  
            //return IsMatch(input, pattern);  
            int i = 0;
            if (int.TryParse(input, out i))
                return true;
            else
                return false;
        }
        /// <summary>  
        /// 验证非负整数  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsIntegerNotNagtive(string input)
        {
            //string pattern = @"^\d+$";  
            //return IsMatch(input, pattern);  
            int i = -1;
            if (int.TryParse(input, out i) && i >= 0)
                return true;
            else
                return false;
        }
        /// <summary>  
        /// 验证正整数  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsIntegerPositive(string input)
        {
            //string pattern = @"^[0-9]*[1-9][0-9]*$";  
            //return IsMatch(input, pattern);  
            int i = 0;
            if (int.TryParse(input, out i) && i >= 1)
                return true;
            else
                return false;
        }
        /// <summary>  
        /// 验证小数  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsDecimal(string input)
        {
            string pattern = @"^([-+]?[1-9]\d*\.\d+|-?0\.\d*[1-9]\d*)$";
            return IsMatch(input, pattern);
        }
        /// <summary>  
        /// 验证只包含英文字母  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsEnglishCharacter(string input)
        {
            string pattern = @"^[A-Za-z]+$";
            return IsMatch(input, pattern);
        }
        /// <summary>  
        /// 验证只包含数字和英文字母  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsIntegerAndEnglishCharacter(string input)
        {
            string pattern = @"^[0-9A-Za-z]+$";
            return IsMatch(input, pattern);
        }
        /// <summary>  
        /// 验证只包含汉字  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsChineseCharacter(string input)
        {
            string pattern = @"^[\u4e00-\u9fa5]+$";
            return IsMatch(input, pattern);
        }
        /// <summary>  
        /// 验证数字长度范围（数字前端的0计长度）  
        /// [若要验证固定长度，可传入相同的两个长度数值]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <param name="lengthBegin">长度范围起始值（含）</param>  
        /// <param name="lengthEnd">长度范围结束值（含）</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsIntegerLength(string input, int lengthBegin, int lengthEnd)
        {
            //string pattern = @"^\d{" + lengthBegin + "," + lengthEnd + "}$";  
            //return IsMatch(input, pattern);  
            if (input.Length >= lengthBegin && input.Length <= lengthEnd)
            {
                int i;
                if (int.TryParse(input, out i))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        /// <summary>  
        /// 验证字符串包含内容  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <param name="withEnglishCharacter">是否包含英文字母</param>  
        /// <param name="withNumber">是否包含数字</param>  
        /// <param name="withChineseCharacter">是否包含汉字</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsStringInclude(string input, bool withEnglishCharacter, bool withNumber, bool withChineseCharacter)
        {
            if (!withEnglishCharacter && !withNumber && !withChineseCharacter)
                return false;//如果英文字母、数字和汉字都没有，则返回false  
            StringBuilder patternString = new StringBuilder();
            patternString.Append("^[");
            if (withEnglishCharacter)
                patternString.Append("a-zA-Z");
            if (withNumber)
                patternString.Append("0-9");
            if (withChineseCharacter)
                patternString.Append(@"\u4E00-\u9FA5");
            patternString.Append("]+$");
            return IsMatch(input, patternString.ToString());
        }
        /// <summary>  
        /// 验证字符串长度范围  
        /// [若要验证固定长度，可传入相同的两个长度数值]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <param name="lengthBegin">长度范围起始值（含）</param>  
        /// <param name="lengthEnd">长度范围结束值（含）</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsStringLength(string input, int lengthBegin, int lengthEnd)
        {
            //string pattern = @"^.{" + lengthBegin + "," + lengthEnd + "}$";  
            //return IsMatch(input, pattern);  
            if (input.Length >= lengthBegin && input.Length <= lengthEnd)
                return true;
            else
                return false;
        }
        /// <summary>  
        /// 验证字符串长度范围（字符串内只包含数字和/或英文字母）  
        /// [若要验证固定长度，可传入相同的两个长度数值]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <param name="lengthBegin">长度范围起始值（含）</param>  
        /// <param name="lengthEnd">长度范围结束值（含）</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsStringLengthOnlyNumberAndEnglishCharacter(string input, int lengthBegin, int lengthEnd)
        {
            string pattern = @"^[0-9a-zA-Z]{" + lengthBegin + "," + lengthEnd + "}$";
            return IsMatch(input, pattern);
        }
        /// <summary>  
        /// 验证字符串长度范围  
        /// [若要验证固定长度，可传入相同的两个长度数值]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <param name="withEnglishCharacter">是否包含英文字母</param>  
        /// <param name="withNumber">是否包含数字</param>  
        /// <param name="withChineseCharacter">是否包含汉字</param>  
        /// <param name="lengthBegin">长度范围起始值（含）</param>  
        /// <param name="lengthEnd">长度范围结束值（含）</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsStringLengthByInclude(string input, bool withEnglishCharacter, bool withNumber, bool withChineseCharacter, int lengthBegin, int lengthEnd)
        {
            if (!withEnglishCharacter && !withNumber && !withChineseCharacter)
                return false;//如果英文字母、数字和汉字都没有，则返回false  
            StringBuilder patternString = new StringBuilder();
            patternString.Append("^[");
            if (withEnglishCharacter)
                patternString.Append("a-zA-Z");
            if (withNumber)
                patternString.Append("0-9");
            if (withChineseCharacter)
                patternString.Append(@"\u4E00-\u9FA5");
            patternString.Append("]{" + lengthBegin + "," + lengthEnd + "}$");
            return IsMatch(input, patternString.ToString());
        }
        /// <summary>  
        /// 验证字符串字节数长度范围  
        /// [若要验证固定长度，可传入相同的两个长度数值；每个汉字为两个字节长度]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <param name="lengthBegin">长度范围起始值（含）</param>  
        /// <param name="lengthEnd">长度范围结束值（含）</param>  
        /// <returns></returns>  
        public static bool IsStringByteLength(string input, int lengthBegin, int lengthEnd)
        {
            //int byteLength = Regex.Replace(input, @"[^\x00-\xff]", "ok").Length;  
            //if (byteLength >= lengthBegin && byteLength <= lengthEnd)  
            //{  
            //    return true;  
            //}  
            //return false;  
            int byteLength = Encoding.Default.GetByteCount(input);
            if (byteLength >= lengthBegin && byteLength <= lengthEnd)
                return true;
            else
                return false;
        }
        /// <summary>  
        /// 验证日期  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsDateTime(string input)
        {
            DateTime dt;
            if (DateTime.TryParse(input, out dt))
                return true;
            else
                return false;
        }
        /// <summary>  
        /// 验证固定电话号码  
        /// [3位或4位区号；区号可以用小括号括起来；区号可以省略；区号与本地号间可以用减号或空格隔开；可以有3位数的分机号，分机号前要加减号]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsTelePhoneNumber(string input)
        {
            string pattern = @"^(((0\d{2}|0\d{2})[- ]?)?\d{8}|((0\d{3}|0\d{3})[- ]?)?\d{7})(-\d{3})?$";
            return IsMatch(input, pattern);
        }
        /// <summary>  
        /// 验证手机号码  
        /// [可匹配"(+86)013325656352"，括号可以省略，+号可以省略，(+86)可以省略，11位手机号前的0可以省略；11位手机号第二位数可以是3、4、5、8中的任意一个]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsMobilePhoneNumber(string input)
        {
            string pattern = @"^((\+)?86|((\+)?86)?)0?1[3458]\d{9}$";
            return IsMatch(input, pattern);
        }
        /// <summary>  
        /// 验证电话号码（可以是固定电话号码或手机号码）  
        /// [固定电话：[3位或4位区号；区号可以用小括号括起来；区号可以省略；区号与本地号间可以用减号或空格隔开；可以有3位数的分机号，分机号前要加减号]]  
        /// [手机号码：[可匹配"(+86)013325656352"，括号可以省略，+号可以省略，(+86)可以省略，手机号前的0可以省略；手机号第二位数可以是3、4、5、8中的任意一个]]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsPhoneNumber(string input)
        {
            string pattern = @"^((\+)?86|((\+)?86)?)0?1[3458]\d{9}$|^(((0\d{2}|0\d{2})[- ]?)?\d{8}|((0\d{3}|0\d{3})[- ]?)?\d{7})(-\d{3})?$";
            return IsMatch(input, pattern);
        }
        /// <summary>  
        /// 验证邮政编码  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsZipCode(string input)
        {
            //string pattern = @"^\d{6}$";  
            //return IsMatch(input, pattern);  
            if (input.Length != 6)
                return false;
            int i;
            if (int.TryParse(input, out i))
                return true;
            else
                return false;
        }
        /// <summary>  
        /// 验证电子邮箱  
        /// [@字符前可以包含字母、数字、下划线和点号；@字符后可以包含字母、数字、下划线和点号；@字符后至少包含一个点号且点号不能是最后一个字符；最后一个点号后只能是字母或数字]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsEmail(string input)
        {
            ////邮箱名以数字或字母开头；邮箱名可由字母、数字、点号、减号、下划线组成；邮箱名（@前的字符）长度为3～18个字符；邮箱名不能以点号、减号或下划线结尾；不能出现连续两个或两个以上的点号、减号。  
            //string pattern = @"^[a-zA-Z0-9]((?<!(\.\.|--))[a-zA-Z0-9\._-]){1,16}[a-zA-Z0-9]@([0-9a-zA-Z][0-9a-zA-Z-]{0,62}\.)+([0-9a-zA-Z][0-9a-zA-Z-]{0,62})\.?|((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}(25[0-5]|2[0-4]\d|[01]?\d\d?)$";  
            string pattern = @"^([\w-\.]+)@([\w-\.]+)(\.[a-zA-Z0-9]+)$";
            return IsMatch(input, pattern);
        }
        /// <summary>  
        /// 验证网址（可以匹配IPv4地址但没对IPv4地址进行格式验证；IPv6暂时没做匹配）  
        /// [允许省略"://"；可以添加端口号；允许层级；允许传参；域名中至少一个点号且此点号前要有内容]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsURL(string input)
        {
            ////每级域名由字母、数字和减号构成（第一个字母不能是减号），不区分大小写，单个域长度不超过63，完整的域名全长不超过256个字符。在DNS系统中，全名是以一个点“.”来结束的，例如“www.nit.edu.cn.”。没有最后的那个点则表示一个相对地址。   
            ////没有例如"http://"的前缀，没有传参的匹配  
            //string pattern = @"^([0-9a-zA-Z][0-9a-zA-Z-]{0,62}\.)+([0-9a-zA-Z][0-9a-zA-Z-]{0,62})\.?$";  

            //string pattern = @"^(((file|gopher|news|nntp|telnet|http|ftp|https|ftps|sftp)://)|(www\.))+(([a-zA-Z0-9\._-]+\.[a-zA-Z]{2,6})|([0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}))(/[a-zA-Z0-9\&%_\./-~-]*)?$";  
            string pattern = @"^([a-zA-Z]+://)?([\w-\.]+)(\.[a-zA-Z0-9]+)(:\d{0,5})?/?([\w-/]*)\.?([a-zA-Z]*)\??(([\w-]*=[\w%]*&?)*)$";
            return IsMatch(input, pattern);
        }
        /// <summary>  
        /// 验证IPv4地址  
        /// [第一位和最后一位数字不能是0或255；允许用0补位]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsIPv4(string input)
        {
            //string pattern = @"^(25[0-4]|2[0-4]\d]|[01]?\d{2}|[1-9])\.(25[0-5]|2[0-4]\d]|[01]?\d?\d)\.(25[0-5]|2[0-4]\d]|[01]?\d?\d)\.(25[0-4]|2[0-4]\d]|[01]?\d{2}|[1-9])$";  
            //return IsMatch(input, pattern);  
            string[] IPs = input.Split('.');
            if (IPs.Length != 4)
                return false;
            int n = -1;
            for (int i = 0; i < IPs.Length; i++)
            {
                if (i == 0 || i == 3)
                {
                    if (int.TryParse(IPs[i], out n) && n > 0 && n < 255)
                        continue;
                    else
                        return false;
                }
                else
                {
                    if (int.TryParse(IPs[i], out n) && n >= 0 && n <= 255)
                        continue;
                    else
                        return false;
                }
            }
            return true;
        }
        /// <summary>  
        /// 验证IPv6地址  
        /// [可用于匹配任何一个合法的IPv6地址]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsIPv6(string input)
        {
            string pattern = @"^\s*((([0-9A-Fa-f]{1,4}:){7}([0-9A-Fa-f]{1,4}|:))|(([0-9A-Fa-f]{1,4}:){6}(:[0-9A-Fa-f]{1,4}|((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){5}(((:[0-9A-Fa-f]{1,4}){1,2})|:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){4}(((:[0-9A-Fa-f]{1,4}){1,3})|((:[0-9A-Fa-f]{1,4})?:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){3}(((:[0-9A-Fa-f]{1,4}){1,4})|((:[0-9A-Fa-f]{1,4}){0,2}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){2}(((:[0-9A-Fa-f]{1,4}){1,5})|((:[0-9A-Fa-f]{1,4}){0,3}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){1}(((:[0-9A-Fa-f]{1,4}){1,6})|((:[0-9A-Fa-f]{1,4}){0,4}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(:(((:[0-9A-Fa-f]{1,4}){1,7})|((:[0-9A-Fa-f]{1,4}){0,5}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:)))(%.+)?\s*$";
            return IsMatch(input, pattern);
        }
        #region 验证手机号
        /// <summary>
        /// 验证输入字符串为18位的手机号码
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsMobile(string strln)
        {
            return Regex.IsMatch(strln, @"^1[0123456789]\d{9}$", RegexOptions.IgnoreCase);
        }
        #endregion
        /// <summary>
        /// 验证输入字符串为电话号码
        /// </summary>
        /// <param name="P_str_phone">输入字符串</param>
        /// <returns>返回一个bool类型的值</returns>
        public static bool IsPhone(string strln)
        {
            return Regex.IsMatch(strln, @"(^(\d{2,4}[-_－—]?)?\d{3,8}([-_－—]?\d{3,8})?([-_－—]?\d{1,7})?$)|(^0?1[35]\d{9}$)");
            //弱一点的验证：  @"\d{3,4}-\d{7,8}"         
        }
        /// <summary>
        /// 验证是否是有效传真号码
        /// </summary>
        /// <param name="strln">输入的字符</param>
        /// <returns></returns>
        public static bool IsFax(string strln)
        {
            return Regex.IsMatch(strln, @"^[+]{0,1}(\d){1,3}[ ]?([-]?((\d)|[ ]){1,12})+$");
        }
        /// <summary>
        /// 验证是否只含有汉字
        /// </summary>
        /// <param name="strln">输入的字符</param>
        /// <returns></returns>
        public static bool IsOnllyChinese(string strln)
        {
            return Regex.IsMatch(strln, @"^[\u4e00-\u9fa5]+$");
        }
        /// <summary>  
        /// 身份证上数字对应的地址  
        /// </summary>  
        //enum IDAddress  
        //{  
        //    北京 = 11, 天津 = 12, 河北 = 13, 山西 = 14, 内蒙古 = 15, 辽宁 = 21, 吉林 = 22, 黑龙江 = 23, 上海 = 31, 江苏 = 32, 浙江 = 33,  
        //    安徽 = 34, 福建 = 35, 江西 = 36, 山东 = 37, 河南 = 41, 湖北 = 42, 湖南 = 43, 广东 = 44, 广西 = 45, 海南 = 46, 重庆 = 50, 四川 = 51,  
        //    贵州 = 52, 云南 = 53, 西藏 = 54, 陕西 = 61, 甘肃 = 62, 青海 = 63, 宁夏 = 64, 新疆 = 65, 台湾 = 71, 香港 = 81, 澳门 = 82, 国外 = 91  
        //}  

        /// <summary>  
        /// 验证一代身份证号（15位数）  
        /// [长度为15位的数字；匹配对应省份地址；生日能正确匹配]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsIDCard15(string input)
        {
            //验证是否可以转换为15位整数  
            long l = 0;
            if (!long.TryParse(input, out l) || l.ToString().Length != 15)
            {
                return false;
            }
            //验证省份是否匹配  
            //1~6位为地区代码，其中1、2位数为各省级政府的代码，3、4位数为地、市级政府的代码，5、6位数为县、区级政府代码。  
            string address = "11,12,13,14,15,21,22,23,31,32,33,34,35,36,37,41,42,43,44,45,46,50,51,52,53,54,61,62,63,64,65,71,81,82,91,";
            if (!address.Contains(input.Remove(2) + ","))
            {
                return false;
            }
            //验证生日是否匹配  
            string birthdate = input.Substring(6, 6).Insert(4, "/").Insert(2, "/");
            DateTime dt;
            if (!DateTime.TryParse(birthdate, out dt))
            {
                return false;
            }
            return true;
        }
        /// <summary>  
        /// 验证二代身份证号（18位数，GB11643-1999标准）  
        /// [长度为18位；前17位为数字，最后一位(校验码)可以为大小写x；匹配对应省份地址；生日能正确匹配；校验码能正确匹配]  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsIDCard18(string input)
        {
            //验证是否可以转换为正确的整数  
            long l = 0;
            if (!long.TryParse(input.Remove(17), out l) || l.ToString().Length != 17 || !long.TryParse(input.Replace('x', '0').Replace('X', '0'), out l))
            {
                return false;
            }
            //验证省份是否匹配  
            //1~6位为地区代码，其中1、2位数为各省级政府的代码，3、4位数为地、市级政府的代码，5、6位数为县、区级政府代码。  
            string address = "11,12,13,14,15,21,22,23,31,32,33,34,35,36,37,41,42,43,44,45,46,50,51,52,53,54,61,62,63,64,65,71,81,82,91,";
            if (!address.Contains(input.Remove(2) + ","))
            {
                return false;
            }
            //验证生日是否匹配  
            string birthdate = input.Substring(6, 8).Insert(6, "/").Insert(4, "/");
            DateTime dt;
            if (!DateTime.TryParse(birthdate, out dt))
            {
                return false;
            }
            //校验码验证  
            //校验码：  
            //（1）十七位数字本体码加权求和公式   
            //S = Sum(Ai * Wi), i = 0, ... , 16 ，先对前17位数字的权求和   
            //Ai:表示第i位置上的身份证号码数字值   
            //Wi:表示第i位置上的加权因子   
            //Wi: 7 9 10 5 8 4 2 1 6 3 7 9 10 5 8 4 2   
            //（2）计算模   
            //Y = mod(S, 11)   
            //（3）通过模得到对应的校验码   
            //Y: 0 1 2 3 4 5 6 7 8 9 10   
            //校验码: 1 0 X 9 8 7 6 5 4 3 2   
            string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
            string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
            char[] Ai = input.Remove(17).ToCharArray();
            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
            }
            int y = -1;
            Math.DivRem(sum, 11, out y);
            if (arrVarifyCode[y] != input.Substring(17, 1).ToLower())
            {
                return false;
            }
            return true;
        }
        /// <summary>  
        /// 验证身份证号（不区分一二代身份证号）  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsIDCard(string input)
        {
            if (input.Length == 18)
                return IsIDCard18(input);
            else if (input.Length == 15)
                return IsIDCard15(input);
            else
                return false;
        }
        /// <summary>  
        /// 验证经度  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsLongitude(string input)
        {
            ////范围为-180～180，小数位数必须是1到5位  
            //string pattern = @"^[-\+]?((1[0-7]\d{1}|0?\d{1,2})\.\d{1,5}|180\.0{1,5})$";  
            //return IsMatch(input, pattern);  
            float lon;
            if (float.TryParse(input, out lon) && lon >= -180 && lon <= 180)
                return true;
            else
                return false;
        }
        /// <summary>  
        /// 验证纬度  
        /// </summary>  
        /// <param name="input">待验证的字符串</param>  
        /// <returns>是否匹配</returns>  
        public static bool IsLatitude(string input)
        {
            ////范围为-90～90，小数位数必须是1到5位  
            //string pattern = @"^[-\+]?([0-8]?\d{1}\.\d{1,5}|90\.0{1,5})$";  
            //return IsMatch(input, pattern);  
            float lat;
            if (float.TryParse(input, out lat) && lat >= -90 && lat <= 90)
                return true;
            else
                return false;
        }
        #endregion
        /// <summary>
        /// Clones the model.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="classObject">The class object.</param>
        /// <returns>T.</returns>
        public static T CloneModel<T>(this T classObject) where T : class
        {
            T result;
            if (classObject == null)
            {
                result = default(T);
            }
            else
            {
                object obj = Activator.CreateInstance(typeof(T));
                PropertyInfo[] properties = typeof(T).GetProperties();
                PropertyInfo[] array = properties;
                for (int i = 0; i < array.Length; i++)
                {
                    PropertyInfo propertyInfo = array[i];
                    if (propertyInfo.CanWrite)
                        propertyInfo.SetValue(obj, propertyInfo.GetValue(classObject, null), null);
                }
                result = (obj as T);
            }
            return result;
        }
        /// <summary>
        /// ASCII编码的数组转换为英文字符串
        /// </summary>
        /// <param name="s">字符串</param>
        /// <returns>结果</returns>
        public static string ToEnString(this byte[] s)
        {
            return ToEncodeString(s, Encoding.ASCII).Trim('\0').Trim();
        }

        /// <summary>
        /// 数组按指定编码转换为字符串
        /// </summary>
        /// <param name="dealBytes">数组</param>
        /// <param name="encode">编码</param>
        /// <returns>结果</returns>
        public static string ToEncodeString(this byte[] dealBytes, Encoding encode)
        {
            return encode.GetString(dealBytes);
        }
        #region 转换为base64字符串
        /// <summary>
        /// 功能描述:转换为base64字符串
        /// </summary>
        /// <param name="data">data</param>
        /// <returns>返回值</returns>
        public static string ToBase64Str(this string data)
        {
            if (data.IsEmpty())
                return string.Empty;
            byte[] buffer = Encoding.Default.GetBytes(data);
            return Convert.ToBase64String(buffer);
        }
        #endregion
        /// <summary>
        /// 转换为坐标
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>System.Drawing.Point.</returns>
        public static System.Drawing.Point ToPoint(this string data)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(data, @"^\s*\d+(\.\d+)?\s*\,\s*\d+(\.\d+)?\s*$"))
            {
                return System.Drawing.Point.Empty;
            }
            else
            {
                string[] strs = data.Split(',');
                return new System.Drawing.Point(strs[0].ToInt(), strs[1].ToInt());
            }
        }

        #region 数值转换
        /// <summary>
        /// 转换为整型
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>System.Int32.</returns>
        public static int ToInt(this object data)
        {
            if (data == null)
                return 0;
            if (data is bool)
            {
                return (bool)data ? 1 : 0;
            }
            int result;
            var success = int.TryParse(data.ToString(), out result);
            if (success)
                return result;
            try
            {
                return Convert.ToInt32(ToDouble(data, 0));
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 转换为可空整型
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>System.Nullable&lt;System.Int32&gt;.</returns>
        public static int? ToIntOrNull(this object data)
        {
            if (data == null)
                return null;
            int result;
            bool isValid = int.TryParse(data.ToString(), out result);
            if (isValid)
                return result;
            return null;
        }

        /// <summary>
        /// 转换为双精度浮点数
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>System.Double.</returns>
        public static double ToDouble(this object data)
        {
            if (data == null)
                return 0;
            double result;
            return double.TryParse(data.ToString(), out result) ? result : 0;
        }

        /// <summary>
        /// 转换为双精度浮点数,并按指定的小数位4舍5入
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="digits">小数位数</param>
        /// <returns>System.Double.</returns>
        public static double ToDouble(this object data, int digits)
        {
            return Math.Round(ToDouble(data), digits, System.MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// 转换为可空双精度浮点数
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>System.Nullable&lt;System.Double&gt;.</returns>
        public static double? ToDoubleOrNull(this object data)
        {
            if (data == null)
                return null;
            double result;
            bool isValid = double.TryParse(data.ToString(), out result);
            if (isValid)
                return result;
            return null;
        }

        /// <summary>
        /// 转换为高精度浮点数
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>System.Decimal.</returns>
        public static decimal ToDecimal(this object data)
        {
            if (data == null)
                return 0;
            decimal result;
            return decimal.TryParse(data.ToString(), out result) ? result : 0;
        }

        /// <summary>
        /// 转换为高精度浮点数,并按指定的小数位4舍5入
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="digits">小数位数</param>
        /// <returns>System.Decimal.</returns>
        public static decimal ToDecimal(this object data, int digits)
        {
            return Math.Round(ToDecimal(data), digits, System.MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// 转换为可空高精度浮点数
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>System.Nullable&lt;System.Decimal&gt;.</returns>
        public static decimal? ToDecimalOrNull(this object data)
        {
            if (data == null)
                return null;
            decimal result;
            bool isValid = decimal.TryParse(data.ToString(), out result);
            if (isValid)
                return result;
            return null;
        }

        /// <summary>
        /// 转换为可空高精度浮点数,并按指定的小数位4舍5入
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="digits">小数位数</param>
        /// <returns>System.Nullable&lt;System.Decimal&gt;.</returns>
        public static decimal? ToDecimalOrNull(this object data, int digits)
        {
            var result = ToDecimalOrNull(data);
            if (result == null)
                return null;
            return Math.Round(result.Value, digits, System.MidpointRounding.AwayFromZero);
        }

        #endregion
        #region 日期转换
        /// <summary>
        /// 转换为日期
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>DateTime.</returns>
        public static System.DateTime ToDate(this object data)
        {
            try
            {
                if (data == null)
                    return System.DateTime.MinValue;
                if (System.Text.RegularExpressions.Regex.IsMatch(data.ToStringExt(), @"^\d{8}$"))
                {
                    string strValue = data.ToStringExt();
                    return new System.DateTime(strValue.Substring(0, 4).ToInt(), strValue.Substring(4, 2).ToInt(), strValue.Substring(6, 2).ToInt());
                }
                System.DateTime result;
                return System.DateTime.TryParse(data.ToString(), out result) ? result : System.DateTime.MinValue;
            }
            catch
            {
                return System.DateTime.MinValue;
            }
        }

        /// <summary>
        /// 转换为可空日期
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>System.Nullable&lt;DateTime&gt;.</returns>
        public static DateTime? ToDateOrNull(this object data)
        {
            try
            {
                if (data == null)
                    return null;
                if (System.Text.RegularExpressions.Regex.IsMatch(data.ToStringExt(), @"^\d{8}$"))
                {
                    string strValue = data.ToStringExt();
                    return new System.DateTime(strValue.Substring(0, 4).ToInt(), strValue.Substring(4, 2).ToInt(), strValue.Substring(6, 2).ToInt());
                }
                System.DateTime result;
                bool isValid = System.DateTime.TryParse(data.ToString(), out result);
                if (isValid)
                    return result;
                return null;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region 布尔转换
        /// <summary>
        /// 转换为布尔值
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool ToBool(this object data)
        {
            if (data == null)
                return false;
            bool? value = GetBool(data);
            if (value != null)
                return value.Value;
            bool result;
            return bool.TryParse(data.ToString(), out result) && result;
        }

        /// <summary>
        /// 获取布尔值
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private static bool? GetBool(this object data)
        {
            switch (data.ToString().Trim().ToLower())
            {
                case "0":
                    return false;
                case "1":
                    return true;
                case "是":
                    return true;
                case "否":
                    return false;
                case "yes":
                    return true;
                case "no":
                    return false;
                default:
                    return null;
            }
        }

        /// <summary>
        /// 转换为可空布尔值
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool? ToBoolOrNull(this object data)
        {
            if (data == null)
                return null;
            bool? value = GetBool(data);
            if (value != null)
                return value.Value;
            bool result;
            bool isValid = bool.TryParse(data.ToString(), out result);
            if (isValid)
                return result;
            return null;
        }

        #endregion

        #region 字符串转换
        /// <summary>
        /// 字符串转换为byte[]
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>System.Byte[].</returns>
        public static byte[] ToBytes(this string data)
        {
            return System.Text.Encoding.GetEncoding("GBK").GetBytes(data);
        }
        /// <summary>
        /// Converts to bytesdefault.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>System.Byte[].</returns>
        public static byte[] ToBytesDefault(this string data)
        {
            return System.Text.Encoding.Default.GetBytes(data);
        }
        /// <summary>
        /// 转换为字符串
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>System.String.</returns>
        public static string ToStringExt(this object data)
        {
            return data == null ? string.Empty : data.ToString();
        }
        #endregion

        /// <summary>
        /// 安全返回值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">可空值</param>
        /// <returns>T.</returns>
        public static T SafeValue<T>(this T? value) where T : struct
        {
            return value ?? default(T);
        }
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <param name="value">值</param>
        /// <returns><c>true</c> if the specified value is empty; otherwise, <c>false</c>.</returns>
        public static bool IsEmpty(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <param name="value">值</param>
        /// <returns><c>true</c> if the specified value is empty; otherwise, <c>false</c>.</returns>
        public static bool IsEmpty(this Guid? value)
        {
            if (value == null)
                return true;
            return IsEmpty(value.Value);
        }
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <param name="value">值</param>
        /// <returns><c>true</c> if the specified value is empty; otherwise, <c>false</c>.</returns>
        public static bool IsEmpty(this Guid value)
        {
            if (value == Guid.Empty)
                return true;
            return false;
        }
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <param name="value">值</param>
        /// <returns><c>true</c> if the specified value is empty; otherwise, <c>false</c>.</returns>
        public static bool IsEmpty(this object value)
        {
            if (value != null && !string.IsNullOrEmpty(value.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #region 是否数字
        /// <summary>
        /// 功能描述:是否数字
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>返回值</returns>
        public static bool IsNum(this string value)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(value, @"^\d+(\.\d*)?$");
        }
        #endregion
        /// <summary>
        /// 全角转换为半角
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToDBC(string input)
        {
            if (input == null)
            {
                return null;
            }
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        }
        public static Type Typen(string typeName)
        {
            Type type = null;
            Assembly[] assemblyArray = AppDomain.CurrentDomain.GetAssemblies();
            int assemblyArrayLength = assemblyArray.Length;
            for (int i = 0; i < assemblyArrayLength; ++i)
            {
                type = assemblyArray[i].GetType(typeName);
                if (type != null)
                {
                    return type;
                }
            }

            for (int i = 0; (i < assemblyArrayLength); ++i)
            {
                Type[] typeArray = assemblyArray[i].GetTypes();
                int typeArrayLength = typeArray.Length;
                for (int j = 0; j < typeArrayLength; ++j)
                {
                    if (typeArray[j].Name.Equals(typeName))
                    {
                        return typeArray[j];
                    }
                }
            }
            return type;
        }
        public static Type GetType(string str)
        {
            switch (str.ToLower())
            {
                case "bool":
                    return Type.GetType("System.Boolean", true, true);
                case "byte":
                    return Type.GetType("System.Byte", true, true);
                case "sbyte":
                    return Type.GetType("System.SByte", true, true);
                case "char":
                    return Type.GetType("System.Char", true, true);
                case "decimal":
                    return Type.GetType("System.Decimal", true, true);
                case "double":
                    return Type.GetType("System.Double", true, true);
                case "float":
                    return Type.GetType("System.Single", true, true);
                case "int":
                    return Type.GetType("System.Int32", true, true);
                case "uint":
                    return Type.GetType("System.UInt32", true, true);
                case "long":
                    return Type.GetType("System.Int64", true, true);
                case "ulong":
                    return Type.GetType("System.UInt64", true, true);
                case "object":
                    return Type.GetType("System.Object", true, true);
                case "short":
                    return Type.GetType("System.Int16", true, true);
                case "ushort":
                    return Type.GetType("System.UInt16", true, true);
                case "string":
                    return Type.GetType("System.String", true, true);
                case "date":
                case "datetime":
                    return Type.GetType("System.DateTime", true, true);
                case "guid":
                    return Type.GetType("System.Guid", true, true);
                default:
                    return Type.GetType(str, true, true);
            }
        }

    }
}
