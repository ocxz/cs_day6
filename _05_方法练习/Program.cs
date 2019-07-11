using System;

namespace _05_方法练习
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
             *  题目：
             *  1、读取输入整数，定义成方法，多次调用（输入为数字返回，提示重新输入）
             *  2、只允许用户输入yes或no，并且返回yes或no，否则提示 重新输入
             *  3、计算输入的int数组的和
             * 
             */

            #region 第一题 方法实现 读取输入整数 多次调用（输入为数字返回，提示重新输入）

            //while (true)
            //{
            //    Console.WriteLine("请输入一个整数");
            //    int num = StrToInt(Console.ReadLine());
            //    if(num != int.MinValue)
            //    {
            //        Console.WriteLine("刚刚输入的整数为{0}", num);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("你刚刚输入的不是一个整数，请重新输入");
            //    }
            //}

            #endregion

            #region 第二题 方法实现 只允许用户输入yes或no，并且返回yes或no，否则提示 重新输入
            //while (true)
            //{
            //    Console.WriteLine("请输入yes/no");
            //    string str = IsYesOrNo(Console.ReadLine());
            //    if (str == "yes")
            //    {
            //        Console.WriteLine("输入成功！");
            //        Console.WriteLine("您刚刚输入的是{0}", str);
            //        break;
            //    }
            //    else if (str == "no")
            //    {
            //        Console.WriteLine("输入成功！");
            //        Console.WriteLine("您刚刚出任的是{0}", str);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("输入错误，请重新输入");
            //    }
            //}
            #endregion

            #region 第三题 方法实现 计算输入的int数组的所有元素总和
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.Write("计算数组：");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write("{0} ", nums[i]);
            //}
            //Console.Write("的所有元素总和为：{0}", SumIntArray(nums));
            //Console.ReadKey(); 
            #endregion

        }



        /// <summary>
        /// 判断字符串是否能转换为int类型
        /// 如果是能转换为数字，则返回
        /// 如果不能，返回int.MinValue
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <returns>返回转换后的结果</returns>
        public static int StrToInt(string str)
        {
            try
            {
                return int.Parse(str);   // 将用户输入的字符串转换为int类型，并返回
            }
            catch
            {
                return int.MinValue;   // 转换不成功，则返回int类型的最小值
            }
        }

        /// <summary>
        /// 判断string是否为yes或者no
        /// 如果是，返回yes或者no
        /// 如果不是,返回NotYesOrNo
        /// </summary>
        /// <param name="str">要判断的字符串</param>
        /// <returns>判断的结果</returns>
        public static string IsYesOrNo(string str)
        {
            return (str == "yes" || str == "no") ? str : "NotYesOrNo";
        }

        /// <summary>
        /// 计算输入int数组的和，并返回
        /// </summary>
        /// <param name="values">要计算的int数组</param>
        /// <returns>返回int数组的和</returns>
        public static int SumIntArray(int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        ///**
        // *   错误的方法，错误原因：
        // *   1、不符合设计模式，提示用户输入不能写在方法里面
        // *   2、一个方法，功能一定要单一
        // * 
        // */
        //public static int ReadInt()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("请输入一个整数");
        //        try
        //        {
        //            int num = int.Parse(Console.ReadLine());
        //            return num;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("输入的不是一个整数，请重新输入");
        //        }
        //    }
        //}

    }
}
