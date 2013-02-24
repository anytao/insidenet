// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.EnumEx
// Release     : 2007/10/30 1.0
// Description : 8.4 ���ײ��򵥣�ö�ٺ�λ���

using System;
using System.Globalization;

namespace InsideDotNet.Framework.EnumEx
{
    class EnumMethod
    {
        public static void Main_8_4_2()//Main_8_4_2
        {
            //��GetName��ȡö�ٳ������Ƶ�����
            foreach (string item in Enum.GetNames(typeof(Week)))
            {
                Console.WriteLine(item.ToString());
            }

            //��GetValues��ȡö�ٳ���ֵ������
            foreach (Week item in Enum.GetValues(typeof(Week)))
            {
                Console.WriteLine("{0} : {1}", item.ToString("D"), item.ToString());
            }

            //��IsDefined�������жϷ��Ż�������������ö��
            if (Enum.IsDefined(typeof(Week), "Fri"))
            {
                Console.WriteLine("Today is {0}.", Week.Fri.ToString("G"));
            }

            //���������߷��������ַ���ת��Ϊ��Ч��ö������
            Week myday = (Week)Enum.Parse(typeof(Week), "Mon", true);
            Console.WriteLine(myday);
            //��ͬ����ֵ�ĵ�Чӳ��
            Week theDay = (Week)Enum.Parse(typeof(Week), "7");
            Console.WriteLine(theDay.ToString());

            //��GetUnderlyingType������������
            Console.WriteLine(Enum.GetUnderlyingType(typeof(Week)));

            //ö�����ͺ��������͵��໥ת��
            //ö��ת��Ϊ����
            int i = (int)Week.Sun;
            //������ת��Ϊö��
            Week day = (Week)Enum.Parse(typeof(Week), "10");
            Console.WriteLine(day.ToString());
            Week da2y = (Week)3;
            da2y++;
            Console.WriteLine(da2y.ToString());

            //��ͬö�����͵��໥ת��
            MusicType mtToday = MusicType.Jazz;
            Week today = (Week)mtToday;
            Console.WriteLine(today.ToString());

            //ö�����ͺͽӿ����͵�ת��
            IConvertible iConvert = (IConvertible)MusicType.Jazz;
            Int32 x = iConvert.ToInt32(CultureInfo.CurrentCulture);
            Console.WriteLine(x);

            //ö�ٵĳ�ʼ��
            Week myweek = new Week();
            Console.WriteLine(myweek.ToString("G"));

            Console.WriteLine("***************************************");

            WithZero wz = new WithZero();
            Console.WriteLine(wz.ToString("G"));

            WithNonZero wnz = new WithNonZero();
            Console.WriteLine(wnz.ToString("G"));
            //ִ�н��
            //Zero
            //0


        }

    }
}
