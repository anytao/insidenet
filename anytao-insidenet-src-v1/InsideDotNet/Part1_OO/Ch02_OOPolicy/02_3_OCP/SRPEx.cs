// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.OCP
// Release     : 2007/12/06 1.0
// Description : 2.3  开放封闭原则

using System;

namespace InsideDotNet.OOPolicy.OCP.Sub
{
    class SRPEx
    {
    }

    interface IBankProcess
    {
        void Deposit(double money);
        void Transfer(double money);
        void DrawMoney(double money);
    }

    interface IBudget
    {
        void Deposit(double money);
        void DrawMoney(double money);
    }

    interface ITransfer
    {
        void Transfer(double money);
    }

    public class BankManager
    {
    }

    //public interface IList : ICollection, IEnumerable
    //{
    //    // Methods
    //    int Add(object value);
    //    void Clear();
    //    bool Contains(object value);
    //    int IndexOf(object value);
    //    void Insert(int index, object value);
    //    void Remove(object value);
    //    void RemoveAt(int index);

    //    // Properties
    //    bool IsFixedSize { get; }
    //    bool IsReadOnly { get; }
    //    object this[int index] { get; set; }
    //}
}
