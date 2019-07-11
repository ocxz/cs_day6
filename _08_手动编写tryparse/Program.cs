using System;

namespace _08_手动编写tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *   tryParse的使用：
             *   bool b = int.TryParse("123",out num)
             *   要点：返回一个bool值，一个多余参数num，当无法转换返回false,out多余返回0
             */

            #region TryParse 的使用
            //int num;
            //bool b = int.TryParse("123a", out num);
            //Console.WriteLine(b);
            //Console.WriteLine(num);
            //Console.ReadKey(); 
            #endregion

        }

        /// <summary>
        /// 自己编写，实现str转换为int的TryParse方法
        /// </summary>
        /// <param name="str">要转换的string</param>
        /// <param name="num">out返回的多余参数，用来存储转换后的值</param>
        /// <returns>返回转换的结果（true/flase)</returns>
        public static bool MyTryParseInt(string str, out int num)
        {
            try
            {
                num = int.Parse(str);    // 转换str
                return true;    // 成功返回true，out多余赋值为str转换的结果
            }
            catch
            {
                num = 0;        // 转换失败，out多余赋值0
                return false;    // 转换失败，返回false
            }
        }
    }
}
