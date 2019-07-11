using System;

namespace _07_使用out参数做登录
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *   题目：分别的提示用户输入用户名和密码，写方法判断输入是否正确，返回登录结果，单独返回登录信息
             *   若：用户名错误，除返回登录错误外，还要返回用户名错误
             *   若：密码错误，除返回登录错误外，还要返回密码错误
             * 
             */

            string userPwd = null;
            bool nameIsOk, pwdIsOk;

            Console.WriteLine("请输入用户名");
            string userName = Console.ReadLine();
            Login(userName, userPwd, out nameIsOk, out pwdIsOk);     // 登录一次 判断name是否正确
            while (true)
            {
                if (nameIsOk)    // 如果用户名正确，提示判断输入密码
                {
                    Console.WriteLine("请输入密码");
                    userPwd = Console.ReadLine();
                    Login(userName, userPwd, out nameIsOk, out pwdIsOk);      // 在用户名正确的情况下再登录一次
                    if (pwdIsOk)    //  再用户名正确的情况下，判断密码是否正确
                    {
                        Console.WriteLine("恭喜您，登录成功");   // 用户名、密码都正确，跳出输入循环
                        break;
                    }
                    else
                    {
                        Console.WriteLine("密码输入错误，请重新输入");   // 用户名正确，但密码不正确，提示重新输入一次密码
                    }
                }
                else   // 用户名不正确 提示循环输出
                {
                    Console.WriteLine("用户名不存在，请重新输入");
                    Console.WriteLine("请输入用户名");
                    userName = Console.ReadLine();
                    Login(userName, userPwd, out nameIsOk, out pwdIsOk);     // 登录一次 判断name是否正确
                }
            }
            Console.ReadKey();

        }

        /// <summary>
        /// 判断用户登录的用户名和密码是否正确
        /// 如果用户名正确那就判断密码
        /// 如果用户名不正确，不用判断密码，都为false
        /// </summary>
        /// <param name="userName">用户输入的用户名</param>
        /// <param name="userPwd">用户输入的密码</param>
        /// <param name="nameIsOk">返回用户名是否正确</param>
        /// <param name="pwdIsOk">返回密码是否正确</param>
        public static void Login(string userName, string userPwd, out bool nameIsOk, out bool pwdIsOk)
        {
            nameIsOk = pwdIsOk = false;    // 初始化，默认name和pwd不ok
            if (userName == "admin")      // 判断name是否正确
            {
                nameIsOk = true;       // 如果name正确，name就ok
                if (userPwd == "password")    // name正确，判断passwod是否正确
                {
                    pwdIsOk = true;    // 如果password正确，passwod就ok
                }
            }
        }
    }
}
