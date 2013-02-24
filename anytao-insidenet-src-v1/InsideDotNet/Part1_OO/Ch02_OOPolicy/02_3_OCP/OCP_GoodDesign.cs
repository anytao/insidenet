// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.OCP
// Release     : 2007/12/06 1.0
// Description : 2.3  开放封闭原则

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
            //实际的处理
            switch (ClientType)
            {
                case "存款用户":
                    return new DepositProcess();
                    break;
                case "转帐用户":
                    return new TransferProcess();
                    break;
                case "取款用户":
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

    //按银行按业务进行分类
    class DepositProcess : IBankProcess
    {
        public void Process()
        {
            //办理存款业务
            Console.WriteLine("处理存款。");
        }
    }

    class TransferProcess : IBankProcess
    {
        public void Process()
        {
            //办理转帐业务
            Console.WriteLine("处理转帐。");
        }
    }

    class DrawMoneyProcess : IBankProcess
    {
        public void Process()
        {
            //办理取款业务
        }
    }

    class FundProcess : IBankProcess
    {
        public void Process()
        {
            //办理基金业务
        }
    }

    class EasyBankStaff
    {
        private IBankProcess bankProc = null;

        public void HandleProcess(Client client)
        {
            //业务处理
            bankProc = client.CreateProcess();
            bankProc.Process();
        }
    }

    class BankProcess
    {
        public static void Main()//Main_2_3_1
        {
            EasyBankStaff bankStaff = new EasyBankStaff();
            bankStaff.HandleProcess(new Client("转帐用户"));
        }
    }
}
