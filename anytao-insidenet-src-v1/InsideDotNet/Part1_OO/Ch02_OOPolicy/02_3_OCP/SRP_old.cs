// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.OCP
// Release     : 2007/12/06 1.0
// Description : 2.3  开放封闭原则

using System;

namespace InsideDotNet.OOPolicy.OCP.Sub
{
    class SRP_old
    {
    }

    class ClientEx
    {
        public string ClientType;
        public double Money;

        //用户存款
        public void ToDeposit(double moeny)
        {
        }
        //用户转帐
        public void ToTransfer(double money)
        {
        }
        //用户取款
        public void ToDrawMoney(double money)
        {
        }

    }

    class BusyBankStaff
    {
        //定义银行员工的业务操作
        public void BankProcess(ClientEx client)
        {
            switch (client.ClientType)
            {
                case "Deposit Person":
                    client.ToDeposit(client.Money);
                    break;
                case "Transfer Person":
                    client.ToTransfer(client.Money);
                    break;
                case "Draw Money Person":
                    client.ToDrawMoney(client.Money);
                    break;
            }
        }
    }
}
