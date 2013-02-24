// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.OCP
// Release     : 2007/12/06 1.0
// Description : 2.3  ���ŷ��ԭ��

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
        //�û����
        public void Deposit()
        {
        }
        //�û�ת��
        public void Transfer()
        {
        }
        //�û�ȡ��
        public void DrawMoney()
        {
        }
    }

    class BusyBankStaff
    {
        private BankProcess bankProc = new BankProcess();

        //��������Ա����ҵ�����
        public void HandleProcess(Client client)
        {
            switch (client.ClientType)
            {
                case "����û�":
                    bankProc.Deposit();
                    break;
                case "ת���û�":
                    bankProc.Transfer();
                    break;
                case "ȡ���û�":
                    bankProc.DrawMoney();
                    break;
            }
        }
    }
}
