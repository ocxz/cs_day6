using System;

namespace _03_利用方法来实现判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 写一个方法，判断一个年份是否是闰年
            //// 写一个方法，判断一个年份是否是闰年
            //bool isLeapYear = IsLeapYear(2000);
            //Console.WriteLine(isLeapYear);
            //Console.ReadKey();
            #endregion

        }

        /// <summary>
        /// 判断一个年份是否位闰年
        /// </summary>
        /// <param name="year">要判断的年份</param>
        /// <returns>是否为闰年</returns>
        public static bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 100 !=0 && year % 4 == 0);
        }


    }

}
