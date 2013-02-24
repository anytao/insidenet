// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.ExceptionEx
// Release     : 2007/11/06 1.0
// Description : 8.6 ֱ���쳣

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

                //��������������ı�
                sw.WriteLine(c.ToString());
                Console.WriteLine(c.ToString());
            }
            catch (DivideByZeroException)
            {
                //ʵ�ִ�DivideByZeroException�ָ��Ĵ���
                //�����¸����쳣��ʾ��Ϣ
                throw new DivideByZeroException("��������Ϊ�㣡");
            }
            catch (FileNotFoundException ex)
            {
                //ʵ�ִ�IOException�ָ��Ĵ���
                //���ٴ������쳣��Ϣ
                throw (ex);
            }

            catch (Exception ex)
            {
                //ʵ�ִ��κ���CLS���ݵ��쳣�ָ��Ĵ���
                //�������׳�
                throw;
            }

            catch
            {
                //ʵ���κ��쳣�ָ��Ĵ��룬�����Ƿ���CLS����
                //�������׳�
                throw;
            }
            finally
            {
                sw.Flush();
                sw.Close();
            }

            //δ���쳣�׳�������catch�����δ�׳��쳣��
            //��catch�������׳�����쳣���˴��ű�ִ��
            Console.WriteLine("ִ�н�����");
        }
    }
}
