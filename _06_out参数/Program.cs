using System;

namespace _06_out参数
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
             *    需求：写一个方法，求一个数组中的最大值，最小值，总和，平均值
             *    问题：函数要返回多个值
             *    解决办法：
             *    1、如果返回的值都是同一类型将要，则可考虑放入一个数组中返回
             *    2、如果返回的值有多个类型  则可利用out参数多余返回来返回获取
             */

            #region 演示 返回值为多个相同类型，放入数组中返回 的情况
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.Write("要计算的数组：");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write("{0} ", nums[i]);
            //}

            //int[] results = GetMaxMinSumAvg(nums);

            //Console.WriteLine("\n计算后返回的最大值为：{0}，最小值为：{1}，总和为：{2}，平均值为：{3}", results[0], results[1],
            //    results[2], results[3]);
            //Console.ReadKey();
            #endregion

            #region 演示 返回值为多个相同类型，使用out参数多余返回来返回获取

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ////int[] nums = { };
            ////int[] nums = new int[10];
            //int max, min, sum, avg;    // 声明max、min、sum、avg
            //bool isNotNull;
            //TestOut(nums, out max, out min, out sum, out avg, out isNotNull);

            //if (isNotNull)
            //{
            //    Console.Write("要计算的数组：");
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        Console.Write("{0} ", nums[i]);
            //    }

            //    Console.WriteLine("\n计算后返回的最大值为：{0}，最小值为：{1}，总和为：{2}，平均值为：{3}", max, min, sum, avg);
            //}
            //else
            //{
            //    Console.WriteLine("要计算的数组为空，无法计算！");
            //}
            //Console.ReadKey();
            #endregion

        }

        /// <summary>
        /// 传入一个int数组，求数组的最大值、最小值、总和、平均值并放入int数组中返回
        /// </summary>
        /// <param name="nums">传入的int数组</param>
        /// <returns>返回数组的最大值、最小值、总和、平均值</returns>
        public static int[] GetMaxMinSumAvg(int[] nums)
        {
            int[] result = new int[4];
            // 假设result[0]-->最大值 result[1]-->最小值 result[0]-->总和 result[0]-->平均值
            result[0] = nums[0];   // max
            result[1] = nums[0];  //  min  确保最大值和最小值是nums数组中的元素值

            for (int i = 0; i < nums.Length; i++)
            {
                result[0] = result[0] > nums[i] ? result[0] : nums[i];   // 循环取最大值
                result[1] = result[1] < nums[i] ? result[1] : nums[i];    // 循环取最小值
                result[2] += nums[i];   // 累加总和
            }
            result[3] = result[2] / nums.Length;   // 总和求平均

            return result;

        }

        /// <summary>
        /// 传入一个int数组，求数组的最大值、最小值、总和、平均值并放入int数组中返回
        /// </summary>
        /// <param name="nums">要求值的数组</param>
        /// <param name="max">多余返回的最大值</param>
        /// <param name="min">多余返回的最小值</param>
        /// <param name="sum">多余返回的总和</param>
        /// <param name="avg">多余返回的平均值</param>
        public static void TestOut(int[] nums, out int max, out int min, out int sum, out int avg, out bool isNotNull)
        {
            // out参数要求在方法内部必须为其赋值
            isNotNull = false;    // 默认为空
            max = min = sum = avg = 0;   // 默认为0
            if (nums.Length > 0)    // 当传入数组长度大于0时
            {
                max = min = nums[0];   // 确保最大值和最小值是nums数组中的元素值

                for (int i = 0; i < nums.Length; i++)     // 循环取出nums数字中的元素值
                {
                    max = max > nums[i] ? max : nums[i];
                    min = min < nums[i] ? min : nums[i];
                    sum += nums[i];

                    if (nums[i] != 0)     // 判断传入数组的值是否全为0，全为0则默认数组为空
                    {
                        isNotNull = true;   // 发现数组中有一个值不为0，则判断该数组不为空
                    }
                }
                avg = sum / nums.Length;   // 存储平均值
            }
        }
    }
}
