using System;

namespace _02_方法的调用问题
{
    class Program
    {
        // 字段  放于类或者struct结构体中
        public static int _number = 10;  // 静态字段模拟全局变量
        static void Main(string[] args)
        {
            #region 方法 传参 学习 练习
            //int a = 3;
            //a = Program.Test(a);
            //Console.WriteLine(a);
            //Console.WriteLine(_number);
            //Console.ReadKey(); 
            #endregion
        }

        public static int Test(int a)
        {
            a = a + 5;
            return a;
            //Console.WriteLine(_number);
        }

        public static void TestTwo()
        {
            Console.WriteLine(_number);
        }
    }
}
