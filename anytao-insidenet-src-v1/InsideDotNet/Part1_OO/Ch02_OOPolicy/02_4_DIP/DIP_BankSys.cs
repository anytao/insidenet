// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.DIP
// Release     : 2007/12/16 1.0
// Description : 2.4 ��������ԭ��

using System;

namespace InsideDotNet.OOPolicy.DIP
{
    class DIP_BankSys
    {
    }

    interface IClient
    {
        IBankProcess CreateProcess();
    }

    class DepositClient : IClient
    {
        IBankProcess IClient.CreateProcess()
        {
            return new DepositProcess();
        }
    }

    class TransferClient : IClient
    {
        IBankProcess IClient.CreateProcess()
        {
            return new TransferProcess();
        }
    }

    class DrawMoneyClient : IClient
    {
        IBankProcess IClient.CreateProcess()
        {
            return new DrawMoneyProcess();
        }
    }

    class FundClient : IClient
    {
        IBankProcess IClient.CreateProcess()
        {
            return new FundProcess();
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

        public void HandleProcess(IClient client)
        {
            //ҵ����
            bankProc = client.CreateProcess();
            bankProc.Process();
        }
    }

    class BankProcess
    {
        public static void Main()//Main_2_4_1
        {
            EasyBankStaff bankStaff = new EasyBankStaff();
            bankStaff.HandleProcess(new TransferClient());
        }
    }

}
