// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.OCP
// Release     : 2007/12/06 1.0
// Description : 2.3  ���ŷ��ԭ��

using System;

namespace InsideDotNet.OOPolicy.OCP.Good
{
    class OCP_GoodDesign
    {
    }

    class Client
    {
        private string ClientType;

        public Client(string clientType)
        {
            ClientType = clientType;
        }

        public IBankProcess CreateProcess()
        {
            //ʵ�ʵĴ���
            switch (ClientType)
            {
                case "����û�":
                    return new DepositProcess();
                    break;
                case "ת���û�":
                    return new TransferProcess();
                    break;
                case "ȡ���û�":
                    return new DrawMoneyProcess();
                    break;
            }
            return null;
        }
    }

    interface IBankProcess
    {
        void Process();
    }

    //�����а�ҵ����з���
    class DepositProcess : IBankProcess
    {
        public void Process()
        {
            //������ҵ��
            Console.WriteLine("�����");
        }
    }

    class TransferProcess : IBankProcess
    {
        public void Process()
        {
            //����ת��ҵ��
            Console.WriteLine("����ת�ʡ�");
        }
    }

    class DrawMoneyProcess : IBankProcess
    {
        public void Process()
        {
            //����ȡ��ҵ��
        }
    }

    class FundProcess : IBankProcess
    {
        public void Process()
        {
            //�������ҵ��
        }
    }

    class EasyBankStaff
    {
        private IBankProcess bankProc = null;

        public void HandleProcess(Client client)
        {
            //ҵ����
            bankProc = client.CreateProcess();
            bankProc.Process();
        }
    }

    class BankProcess
    {
        public static void Main()//Main_2_3_1
        {
            EasyBankStaff bankStaff = new EasyBankStaff();
            bankStaff.HandleProcess(new Client("ת���û�"));
        }
    }
}
