
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PCCC.Common.Utils
{
    public class Util
    {
        //đổi đầu số +84 = 0
        /// <summary>
        /// Chuyển đổi đầu 84 thành 0
        /// </summary>
        /// <param name="phonenumber"></param>
        /// <returns></returns>
        public static string convertPhone(string phonenumber)
        {
            if (phonenumber.Contains("+84"))
            {
                int length = phonenumber.Length - 3;
                phonenumber = "0" + phonenumber.Substring(3, length);
            }
            return phonenumber;
        }
        public static string convertPhone84(string phonenumber)
        {
            int length = phonenumber.Length - 1;
            phonenumber = "84" + phonenumber.Substring(1, length);
            return phonenumber;
        }
        //check định dạng sđt
        public static bool validPhone(string phone)
        {
            return Regex.Match(phone, @"^0[1-9]{1}[0-9]{8}$").Success;
        }

        public static bool ValidateEmail(string Email)
        {
            return Regex.Match(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success;
        }
        //check định dạng số
        public static bool validNumber(string number)
        {
            // \d bắt buộc là số, dấu + bắt buộc xuất hiện 1 lần
            return Regex.Match(number, @"^[\d]+$").Success;
        }


        public static string CreateMD5(string input)
        {
            //bam du lieu
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        public static string ConvertCurrency(long Price)
        {
            return Price.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("is"));
        }
        public static string CheckNullString(string input)
        {
            string output = "";
            try
            {
                output = input.ToString();
            }
            catch
            {

            }
            return output;
        }
       

    }
}
