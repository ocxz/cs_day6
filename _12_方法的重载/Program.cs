using System;

namespace _12_方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            // 方法重载使用
            string h = M("hello ","world!");
            Console.WriteLine(h);
            Console.ReadKey();
        }

        /// <summary>
        /// 实现两个整数类型数相加
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        public static void M(int n1, int n2)
        {
            int result = n1 + n2;
        }

        /// <summary>
        /// 实现两个double类型数相加
        /// </summary>
        /// <param name="d1">第一个double数</param>
        /// <param name="d2">第二个double数</param>
        /// <returns></returns>
        public static double M(double d1, double d2)
        {
            return d1 + d2;
        }

        /// <summary>
        /// 实现三个int类型数相加
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <param name="n3">第三个整数</param>
        public static void M(int n1, int n2, int n3)
        {
            int result = n1 + n2 + n3;
        }

        /// <summary>
        /// 实现两个字符串的拼接
        /// </summary>
        /// <param name="s1">第一个字符串</param>
        /// <param name="s2">第二个字符串</param>
        /// <returns></returns>
        public static string M(string s1, string s2)
        {
            return s1 + s2;
        }

        public static  void M(double d1, string s1)
        {

        }

        public static void M(string s1, double d1)
        {

        }
    }
}
