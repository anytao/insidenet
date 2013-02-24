// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.OCP
// Release     : 2007/12/06 1.0
// Description : 2.3  开放封闭原则

using System;

namespace InsideDotNet.OOPolicy.OCP
{
    class OCP_BadDesign
    {
    }

    class Client
    {
        public string ClientType;
        public double Money;
    }

    class BankProcess
    {
        //用户存款
        public void Deposit()
        {
        }
        //用户转帐
        public void Transfer()
        {
        }
        //用户取款
        public void DrawMoney()
        {
        }
    }

    class BusyBankStaff
    {
        private BankProcess bankProc = new BankProcess();

        //定义银行员工的业务操作
        public void HandleProcess(Client client)
        {
            switch (client.ClientType)
            {
                case "存款用户":
                    bankProc.Deposit();
                    break;
                case "转帐用户":
                    bankProc.Transfer();
                    break;
                case "取款用户":
                    bankProc.DrawMoney();
                    break;
            }
        }
    }
}
