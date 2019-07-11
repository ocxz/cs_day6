using System;

namespace _04_方法概念
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 比较两个数字的大小，返回最大的

            //int maxValue = GetMaxVaule(10, 100);   // 实参
            //Console.WriteLine(maxValue);
            //Console.ReadKey();

            #endregion
        }

        /// <summary>
        /// 获得两个int类型数的最大值
        /// </summary>
        /// <param name="num1">第一个int数</param>
        /// <param name="num2">第二个int数</param>
        /// <returns>两个int数的最大值</returns>
        public static int GetMaxVaule(int num1, int num2)   // 形参
        {
            return num1 > num2 ? num1 : num2;
        }
    }
}
