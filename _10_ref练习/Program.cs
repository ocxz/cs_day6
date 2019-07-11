using System;

namespace _10_ref练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用方法来交换两个int类型的变量

            int num1 = 10, num2 = 100;
            Console.WriteLine("交换前的两个数num1={0}，num2={1}", num1, num2);
            SwapTwoInt(ref num1, ref num2);
            Console.WriteLine("交换后的两个数num1={0}，num2={1}", num1, num2);
            Console.ReadKey();
        }

        /// <summary>
        /// 交换两个数字
        /// </summary>
        /// <param name="num1">第一个数字</param>
        /// <param name="num2">第二个数字</param>
        public static void SwapTwoInt(ref int num1, ref int num2)
        {
            //// 第三方变量交换
            //int temp = num1;
            //num1 = num2;
            //num2 = temp;

            // 利用加减数学运算进行交换
            num1 = num1 - num2;
            num2 = num1 + num2;
            num1 = num2 - num1;
        }
    }
}
