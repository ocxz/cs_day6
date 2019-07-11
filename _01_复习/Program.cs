using System;

namespace _01_复习
{
    class Program
    {
        // 声明一个Gender枚举，用来存储性别
        public enum Gender
        {
            男,
            女
        }

        // 声明一个Person结构体，用来存储个人信息
        public struct Person
        {
            public string _name;    // 字段
            public int _age;
            public Gender _gender;
            public int _grade;
        }


        static void Main(string[] args)
        {

            /** 
             *   复习内容：常量 枚举 结构 数组
             *   常量声明方式：const int number = 100;
             * 
             */

            #region 枚举类型的复习使用
            ////Gender gender = Gender.男;

            //string s = "男";
            //Gender g = (Gender)Enum.Parse(typeof(Gender), s);
            //Console.WriteLine(g);
            //Console.ReadKey(); 
            #endregion

            #region 结构类型的复习使用
            //Person zsPerson;
            //zsPerson._name = "张三";
            //zsPerson._age = 18;
            //zsPerson._gender = Gender.男;
            //zsPerson._grade = 3; 
            #endregion

            #region 数组的声明使用  冒泡排序  Array.Sort() + Array.Reverse() 数组降序排列
            ///** 
            // *   数组：可以一次性存储多个相同类型的变量
            // *   不可超过下标
            // *   冒泡排序：双重循环
            // * 
            // */

            //int[] nums = new int[10];

            //// 冒泡排序：双重循环，第一重循环取出，第二次：依次和后面未排序的比较交换
            //int[] nums2 = { 1,2,55,64,3,9,7};

            //Console.Write("排序后的数组：");
            //for (int i = 0; i < nums2.Length; i++)
            //{
            //    for (int j = i+1; j < nums2.Length; j++)
            //    {
            //        if (nums2[i] > nums2[j])
            //        {
            //            int temp = nums2[i];
            //            nums2[i] = nums2[j];
            //            nums2[j] = temp;
            //        }
            //    }
            //    Console.Write("{0} ", nums2[i]);
            //}

            //Console.ReadKey();

            //// Array.Sort(nums) 数组升序排序
            //// Array.Reverse(nums)   数组反转
            //// Array.Sort(nums) + Array.Reverse(nums)  实现数组降序排列
            //int[] nums3 = { 1, 2, 55, 64, 3, 9, 7 };
            //Array.Sort(nums3);
            //Array.Reverse(nums3);
            //Console.Write("降序排列后的数组：");
            //for (int i = 0; i < nums3.Length; i++)
            //{
            //    Console.Write("{0} ", nums3[i]);
            //}
            //Console.ReadKey(); 
            #endregion

        }
    }
}
