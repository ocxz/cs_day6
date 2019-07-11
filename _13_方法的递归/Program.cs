using System;

namespace _13_方法的递归
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
             *    递归概念：方法自己调用自己
             *    有点类似于死循环，需要设置结束调用
             * 
             */

            TellStory(10);

        }

        /// <summary>
        /// 讲故事，通过递归不断讲
        /// </summary>
        public static void TellStory(int i)
        {

            if (i > 0)
            {
                Console.WriteLine("还是剩下几遍{0}", i-1);
                Console.WriteLine("从前有座山");
                Console.WriteLine("山上有座庙");
                Console.WriteLine("庙里有个老和尚和小和尚");
                Console.WriteLine("有一天，小和尚哭了，老和尚给小和尚讲了一个故事");
                Console.ReadKey();
                TellStory(--i);
            }
        }
    }
}
