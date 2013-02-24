// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.FCL.Sub
// Release     : 2007/11/20 1.0
// Description : 9.4 ����---System�μ������ռ�--Serialization���

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace InsideDotNet.FCL.Sub
{
    class SerializationEx
    {
        public static void BinarySerialize(UserInfo user)
        {
            FileStream fs = new FileStream("MySerialze.bin", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            //ִ�ж��������л�
            formatter.Serialize(fs, user);
            fs.Close();
        }

        public static UserInfo BinaryDeserialize()
        {
            FileStream fs = new FileStream("MySerialze.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            //ִ�ж����Ʒ����л�
            UserInfo user = formatter.Deserialize(fs) as UserInfo;
            fs.Close();

            return user;
        }

        public static void Main_9_4_7()//Main_9_4_7
        {
            UserInfo user = new UserInfo("С��", 26, true);
            //ִ�����л�
            BinarySerialize(user);
            //ִ�з����л�
            UserInfo user2 = BinaryDeserialize();
            Console.WriteLine("Name:{0}\nAge:{1}\nVip:{2}", user2.Name, user2.Age, user2.IsVIP);
        }

        public static void Main_9_4_8()//Main_9_4_8
        {
            UserInfo user = new UserInfo("С��", 27, false);
            XmlSerializer serialsizer = new XmlSerializer(typeof(UserInfo));

            //ִ�����л�����
            StreamWriter sw = new StreamWriter("MySerialze.xml");
            serialsizer.Serialize(sw, user);
            sw.Close();

            //ִ�з����л�����
            FileStream fs = new FileStream("MySerialze.xml", FileMode.Open);
            UserInfo user2 = serialsizer.Deserialize(fs) as UserInfo;

            Console.WriteLine("Name:{0}\nAge:{1}\nVip:{2}\nDes:{3}", user2.Name, user2.Age, user2.IsVIP, user2.ShowDes());
        }

    }

    [Serializable]
    public class UserInfo
    {
        public string Name;
        public Int32 Age;
        public bool IsVIP;
        private string Des = "I'm tao";

        public UserInfo(string name, Int32 age, bool isVip)
        {
            Name = name;
            Age = age;
            IsVIP = isVip;
        }

        public UserInfo()
        {
        }

        public string ShowDes()
        {
            return Des;
        }
    }
}
