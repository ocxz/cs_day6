using System;

namespace _09_ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *   问题引入：工资问题，加奖金工资涨500，减奖金工资扣500
             *   解决办法：
             *   1、分别写、调用两个方法，实现工资增500或减500  正常方法：声明变量，传入参数，接收返回值
             *   2、使用ref声明，不需要返回值，接收参数，能直接讲带入的ref参数做出改变
             *   
             *   带ref参数的函数声明：public static void TestRef(ref decimal salary)
             *   使用ref参数：TestRef(ref salary);
             *   ref参数salary在函数中的变化就可以得以保存
             *   
             */

            decimal salary = 5000;
            salary = SalaryIncrease(salary);   // 正常方法
            Console.WriteLine(salary);
            TestRef(ref salary);
            Console.WriteLine(salary);
            Console.ReadKey();
        }

        /// <summary>
        /// 奖金500
        /// </summary>
        /// <param name="s">原工资</param>
        /// <returns>奖后工资</returns>
        public static decimal SalaryIncrease(decimal s)
        {
            return s += 500;
        }
        
        /// <summary>
        /// 扣500工资
        /// </summary>
        /// <param name="s">原工资</param>
        /// <returns>扣后工资</returns>
        public static decimal SalaryDecuce(decimal s)
        {
            return s -= 500;
        }

        /// <summary>
        /// 测试Ref函数 传入工资，涨500
        /// </summary>
        /// <param name="salary"></param>
        public static void TestRef(ref decimal salary)
        {
            salary += 500;
        }
    }
}
