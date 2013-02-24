// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.DIP
// Release     : 2007/12/16 1.0
// Description : 2.4 依赖倒置原则

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

        public void HandleProcess(IClient client)
        {
            //业务处理
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
