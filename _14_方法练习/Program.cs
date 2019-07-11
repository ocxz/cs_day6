using System;

namespace _14_方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *   题目：
             *   1、输入两数字，求两数字间所有整数和
             * 
             * 
             */

            #region 题目一：输入两数字，求两数字间所有整数和

            #region 提示用户输入的方法
            //// 第一种提示用户输入
            //Console.WriteLine("请输入第一个数字");
            //int num1, num2;
            //while(!int.TryParse(Console.ReadLine(),out num1))   // 当用户输入的第一个数没有转换成功时
            //{
            //    Console.WriteLine("第一个数字输入错误，请重新输入");
            //}

            //Console.WriteLine("请输入第二个数字");
            //while (!int.TryParse(Console.ReadLine(), out num2))   // 当用户输入的第二个数没有转换成功时
            //{
            //    Console.WriteLine("第二个数字输入错误，请重新输入");
            //}

            //// 第二种提示用户输入
            //int num1, num2;
            //Console.WriteLine("请输入第一个数");
            //bool num1IsOk = int.TryParse(Console.ReadLine(), out num1);
            //while (true)
            //{
            //    if (num1IsOk)    // 判断第一个数是否输入正确
            //    {
            //        Console.WriteLine("请输入第二个数");   // 第一个数输入正确，提示用户输入第二个数
            //        if(int.TryParse(Console.ReadLine(), out num2))
            //        {
            //            Console.WriteLine("输入完成！");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("第二个数输入有误，请重新输入");
            //        }
            //    }
            //    else   // 第一个数输入错误，提示用户重新输入
            //    {
            //        Console.WriteLine("第一个数输入有误，请重新输入");
            //        num1IsOk = int.TryParse(Console.ReadLine(), out num1);
            //    }
            //}


            //Console.WriteLine("刚刚输入的第一个数为{0}，第二个数为{1}", num1, num2);
            //Console.ReadKey(); 
            #endregion

            #region 利用方法 方法重载 实现提示用户输入 
            //int num1 = GetIntValue();    // 不传任何参数
            //int num2 = GetIntValue("请输入第二个数", "第二个数输入错误，请重新输入");    // 传入 inputMsg 和 errMsg
            //int num3 = GetIntValue(null, "第三个数输入错误，请重新输入");   // 传入 inputMsg==null 和 errMsg
            //int num4 = GetIntValue("第四个数");   // 传入 inputMsg
            //int num5 = GetIntValue("");   // 传入 inputMsg==""

            //Console.WriteLine("刚刚输入的第一个数{0}，第二个数{1}，第三个数{2}，第四个数{3}，第四个数{4}", num1, num2, num3, num4, num5);
            //Console.ReadKey();
            //Console.ReadKey(); 
            #endregion

            int num1 = GetIntValue("第一个数");
            int num2 = GetIntValue("第二个数");
            //JudgeNumber(ref num1, ref num2);
            //JudgeNumber(ref num1, ref num2,"怎么回事，第一个数不大于第二数，还不快重新输入");
            JudgeNumber(ref num1, ref num2, null);

            Console.WriteLine("{0}到{1}直接的所有整数和为{2}",num1,num2,GetSum(num1,num2));
            Console.ReadKey();

            #endregion
        }

        /// <summary>
        /// 用户输入函数，将用户输入的转换为数字，输入不是数字，则一直提示要求重新输入
        /// </summary>
        /// <param name="inputMsg">用户的输入信息</param>
        /// <param name="errMsg">输入错误的信息</param>
        /// <returns>返回转换后的值</returns>
        public static int GetIntValue(string inputMsg, string errMsg)
        {
            if (inputMsg == "" || inputMsg == null)
            {
                return GetIntValue();
            }
            while (true)
            {
                try
                {
                    Console.WriteLine(inputMsg);
                    int num = int.Parse(Console.ReadLine());
                    return num;
                }
                catch
                {
                    if (errMsg != null && errMsg != null)
                    {
                        Console.WriteLine(errMsg);
                    }
                    else
                    {
                        Console.WriteLine("输入错误，请重新输入");
                    }
                }
            }
        }

        /// <summary>
        /// 用户输入函数，将用户输入的转换为数字，输入不是数字，则一直提示要求重新输入
        /// </summary>
        /// <param name="numName">输入数字的名字</param>
        /// <returns>返回转换后的数字</returns>
        public static int GetIntValue(string numName)
        {
            if (numName == "" || numName == null)
            {
                return GetIntValue();
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("请输入{0}", numName);
                    int num = int.Parse(Console.ReadLine());
                    return num;
                }
                catch
                {
                    Console.WriteLine("{0}输入错误，请重新输入", numName);
                }
            }
        }

        /// <summary>
        /// 用户输入函数，将用户输入的转换为数字，输入不是数字，则一直提示要求重新输入
        /// </summary>
        /// <returns>转换后的数字</returns>
        public static int GetIntValue()
        {
            while (true)
            {
                Console.WriteLine("请输入一个数");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("输入错误，请重新输入");
                }
            }
        }

        /// <summary>
        /// 判断前一个数是否大于后一个数，是则结束判断，不是则要求用户重新输入判断，直到符合条件为止
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        public static void JudgeNumber(int n1, int n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    return;   // 如果符合前一个小于后一个，则结束方法
                }
                else   // 否则 提示用户从小输入，并判断
                {
                    Console.WriteLine("系统检测到前一个不小于后一个，输入不合法，请重新输入");
                    n1 = GetIntValue("第一个数");
                    n2 = GetIntValue("第二个数");
                }
            }
        }

        /// <summary>
        /// 判断前一个数是否大于后一个数，是则结束判断，不是则要求用户重新输入判断，直到符合条件为止
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        public static void JudgeNumber(ref int n1, ref int n2, string errMsg)
        {
            if (errMsg == "" || errMsg == null)
            {
                JudgeNumber(ref n1,ref n2);
                return;
            }
            while (true)
            {
                if (n1 < n2)
                {
                    return;   // 如果符合前一个小于后一个，则结束方法
                }
                else   // 否则 提示用户从小输入，并判断
                {
                    Console.WriteLine(errMsg);
                    n1 = GetIntValue("第一个数");
                    n2 = GetIntValue("第二个数");
                }
            }
        }

        /// <summary>
        /// 判断前一个数是否大于后一个数，是则结束判断，不是则要求用户重新输入判断，直到符合条件为止
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        public static void JudgeNumber(ref int n1, ref int n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    return;   // 如果符合前一个小于后一个，则结束方法
                }
                else   // 否则 提示用户从小输入，并判断
                {
                    Console.WriteLine("系统检测到前一个不小于后一个，输入不合法，请重新输入");
                }
                n1 = GetIntValue("第一个数");
                n2 = GetIntValue("第二个数");
            }
        }

        public static int GetSum(int n1, int n2)
        {
            int sum = 0;
            for (int i = n1; i < n2; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
