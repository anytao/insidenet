// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.OCP
// Release     : 2007/12/06 1.0
// Description : 2.3  ���ŷ��ԭ��

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

        //�û����
        public void ToDeposit(double moeny)
        {
        }
        //�û�ת��
        public void ToTransfer(double money)
        {
        }
        //�û�ȡ��
        public void ToDrawMoney(double money)
        {
        }

    }

    class BusyBankStaff
    {
        //��������Ա����ҵ�����
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
