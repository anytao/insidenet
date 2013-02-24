// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.OCP
// Release     : 2007/12/06 1.0
// Description : 2.3  开放封闭原则

using System;

namespace InsideDotNet.OOPolicy.OCP.Sub
{
    class SRP_new
    {
    }

    class BankProcess
    {
        public static void Main_1_3_1()//Main_1_3_1
        {
        }
    }

    abstract class Client
    {
        public double Money;
        public virtual void ToTrade(double money) { }
    }

    class DepositClient : Client
    {
        //public void Deposit(double money) { }
        public override void ToTrade(double money)
        {
            //ToDeposit()
        }

    }

    class TransferClient : Client
    {
        //public void Transfer(double money) { }
        public override void ToTrade(double money)
        {
            //ToTransfer()
        }
    }

    class DrawMoneyClient : Client
    {
        //public void DrawMoney(double money) { }
        public override void ToTrade(double money)
        {
            //ToDrawMoney()
        }
    }

    class EasyBankStaff
    {
        public void BankProcess(Client client)
        {
            client.ToTrade(client.Money);
        }
    }
}
