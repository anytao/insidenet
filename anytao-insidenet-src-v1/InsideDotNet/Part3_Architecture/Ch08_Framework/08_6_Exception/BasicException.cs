// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.ExceptionEx
// Release     : 2007/11/06 1.0
// Description : 8.6 直面异常

using System;
using System.IO;

namespace InsideDotNet.Framework.ExceptionEx
{
    class BasicException
    {
        public static void Main()//Main_8_7_1
        {
            int a = 1;
            int b = 0;
            GetResultToText(a, b);
        }

        public static void GetResultToText(int a, int b)
        {
            StreamWriter sw = null;
            try
            {
                sw = File.AppendText(@"E:\temp.txt");

                int c = a / b;

                //将运算结果输出到文本
                sw.WriteLine(c.ToString());
                Console.WriteLine(c.ToString());
            }
            catch (DivideByZeroException)
            {
                //实现从DivideByZeroException恢复的代码
                //并重新给出异常提示信息
                throw new DivideByZeroException("除数不能为零！");
            }
            catch (FileNotFoundException ex)
            {
                //实现从IOException恢复的代码
                //并再次引发异常信息
                throw (ex);
            }

            catch (Exception ex)
            {
                //实现从任何与CLS兼容的异常恢复的代码
                //并重新抛出
                throw;
            }

            catch
            {
                //实现任何异常恢复的代码，无论是否与CLS兼容
                //并重新抛出
                throw;
            }
            finally
            {
                sw.Flush();
                sw.Close();
            }

            //未有异常抛出，或者catch捕获而未抛出异常，
            //或catch块重新抛出别的异常，此处才被执行
            Console.WriteLine("执行结束。");
        }
    }
}
