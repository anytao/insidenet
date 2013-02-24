// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.ExceptionEx
// Release     : 2007/11/09 1.0
// Description : 8.6 直面异常--异常回滚示例

using System;
using System.Data;
using System.Data.SqlClient;

namespace InsideDotNet.Framework.ExceptionEx
{
    class RollbackException
    {
        /// <summary>
        /// 实现了事务回滚的异常处理
        /// </summary>
        /// <param name="conString">连接字符串</param>
        /// <param name="cmdString">SQL命令</param>
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
                    //实现事务回滚
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
