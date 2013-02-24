// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.ExceptionEx
// Release     : 2007/11/09 1.0
// Description : 8.6 ֱ���쳣--�쳣�ع�ʾ��

using System;
using System.Data;
using System.Data.SqlClient;

namespace InsideDotNet.Framework.ExceptionEx
{
    class RollbackException
    {
        /// <summary>
        /// ʵ��������ع����쳣����
        /// </summary>
        /// <param name="conString">�����ַ���</param>
        /// <param name="cmdString">SQL����</param>
        public void ExcuteSql(string conString, string cmdString)
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand(cmdString, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    tran.Commit();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    //ʵ������ع�
                    tran.Rollback();

                    throw new Exception("SQL Error!", ex);
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
