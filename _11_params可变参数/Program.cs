using System;

namespace _11_params可变参数
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *   问题引入：写一个方法，传入姓名，和成绩单（int数组）,计算输出总成绩
             *   问题：成绩项目不确定，可能后面会加，而数组长度又是不变的
             *   所以有了可变参数params的概念
             *   函数声明：public static void GetGradeSumForParams(string name, params int[] grades)
             *   使用：GetGradeSumForParams(lsName, 80, 72, 86, 93);
             *   params作用：将同一类型，后面传入的参数，封装成一个数组传入
             *   注意：可变参数列表，类型要相同，放在最后
             * 
             *   小练习：求任意长度数组的最大值 整数类型的
             */

            #region 写一个方法，传入姓名，和成绩单（int数组）,计算输出总成绩
            //string zsName = "张三";
            //int[] grades = { 80, 95, 86 };
            //GetGradeSum(zsName, grades);

            //string lsName = "李四";
            //GetGradeSumForParams(lsName, 80, 72, 86, 93);
            //Console.ReadKey(); 
            #endregion

            #region params可变参数列表小练习：求任意长度数组的最大值 整数类型的

            int maxValue = GetIntArrayMaxValue(10, 50, 67, 30, 58, 76, 43, 15);
            Console.WriteLine("最大值为{0}", maxValue);
            Console.ReadKey();

            #endregion
        }

        /// <summary>
        /// 计算并输出总成绩
        /// </summary>
        /// <param name="name">学生名</param>
        /// <param name="grades">成绩列表</param>
        public static void GetGradeSum(string name, int[] grades)
        {
            int sum = 0;   // 声明一个变量，用来存储总成绩
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            Console.WriteLine("{0}这次考试的总成绩是{1}", name, sum);
        }

        /// <summary>
        /// 计算并输出总成绩 利用params可变参数传入成绩
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="grades">可变成绩单</param>
        public static void GetGradeSumForParams(string name, params int[] grades)
        {
            int sum = 0;   // 声明一个变量，用来存储总成绩
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            Console.WriteLine("{0}这次考试的总成绩是{1}", name, sum);
        }

        /// <summary>
        /// 输入int参数列表，得到其中最大值
        /// </summary>
        /// <param name="nums">int参数列表</param>
        /// <returns>返回的最大值</returns>
        public static int GetIntArrayMaxValue(params int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                max = max > nums[i] ? max : nums[i];
            }
            return max;
        }
    }
}
