using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace NumberDeal.Helper
{
    public class DbHelper
    {
        //连接字符串
        //static string strConn = ConfigurationManager.AppSettings["JiTuanShangWuDB"].ToString();
        static string strConn = "server=.;database=NumDeal;integrated security=SSPI";

        #region 执行查询，返回DataTable对象-----------------------

        public static DataTable GetTable(string strSQL)
        {
            return GetTable(strSQL, null);
        }
        public static DataTable GetTable(string strSQL, SqlParameter[] pas)
        {
            return GetTable(strSQL, pas, CommandType.Text);
        }
        /// <summary>
        /// 执行查询，返回DataTable对象
        /// </summary>
        /// <param name="strSQL">sql语句</param>
        /// <param name="pas">参数数组</param>
        /// <param name="cmdtype">Command类型</param>
        /// <returns>DataTable对象</returns>
        public static DataTable GetTable(string strSQL, SqlParameter[] pas, CommandType cmdtype)
        {
            DataTable dt = new DataTable(); ;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
                    da.SelectCommand.CommandType = cmdtype;
                    if (pas != null)
                    {
                        da.SelectCommand.Parameters.AddRange(pas);
                    }
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
            }
            return dt;
        }

        #region 根据枚举连接数据库
        public static DataTable GetTable(string strSQL, DataBaseName dataBaseName)
        {
            return GetTable(strSQL, null, dataBaseName);
        }
        public static DataTable GetTable(string strSQL, SqlParameter[] pas, DataBaseName dataBaseName)
        {
            return GetTable(strSQL, pas, CommandType.Text, dataBaseName);
        }
        /// <summary>
        /// 执行查询，返回DataTable对象
        /// </summary>
        /// <param name="strSQL">sql语句</param>
        /// <param name="pas">参数数组</param>
        /// <param name="cmdtype">Command类型</param>
        /// <returns>DataTable对象</returns>
        public static DataTable GetTable(string strSQL, SqlParameter[] pas, CommandType cmdtype, DataBaseName dataBaseName)
        {
            DataTable dt = new DataTable(); ;
            using (SqlConnection conn = new SqlConnection(GetEnumDes(dataBaseName.ToString())))
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
                da.SelectCommand.CommandType = cmdtype;
                if (pas != null)
                {
                    da.SelectCommand.Parameters.AddRange(pas);
                }
                da.Fill(dt);
            }
            return dt;
        }
        #endregion

        #endregion

        #region 执行查询，返回DataSet对象-------------------------

        public static DataSet GetDataSet(string strSQL)
        {
            return GetDataSet(strSQL, null);
        }
        public static DataSet GetDataSet(string strSQL, SqlParameter[] pas)
        {
            return GetDataSet(strSQL, pas, CommandType.Text);
        }
        /// <summary>
        /// 执行查询，返回DataSet对象
        /// </summary>
        /// <param name="strSQL">sql语句</param>
        /// <param name="pas">参数数组</param>
        /// <param name="cmdtype">Command类型</param>
        /// <returns>DataSet对象</returns>
        public static DataSet GetDataSet(string strSQL, SqlParameter[] pas, CommandType cmdtype)
        {
            DataSet dt = new DataSet(); ;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
                da.SelectCommand.CommandType = cmdtype;
                if (pas != null)
                {
                    da.SelectCommand.Parameters.AddRange(pas);
                }
                da.Fill(dt);
                if (dt != null && dt.Tables.Count == 2)
                {
                    dt.Tables[0].TableName = "DataList";
                    dt.Tables[1].TableName = "DataTotal";
                }
                else if (dt != null && dt.Tables.Count == 1)
                {
                    dt.Tables[0].TableName = "DataList";
                }
            }
            return dt;
        }


        #region 根据枚举连接数据库


        public static DataSet GetDataSet(string strSQL, DataBaseName dataBaseName)
        {
            return GetDataSet(strSQL, null, dataBaseName);
        }
        public static DataSet GetDataSet(string strSQL, SqlParameter[] pas, DataBaseName dataBaseName)
        {
            return GetDataSet(strSQL, pas, CommandType.Text, dataBaseName);
        }
        /// <summary>
        /// 执行查询，返回DataSet对象
        /// </summary>
        /// <param name="strSQL">sql语句</param>
        /// <param name="pas">参数数组</param>
        /// <param name="cmdtype">Command类型</param>
        /// <returns>DataSet对象</returns>
        public static DataSet GetDataSet(string strSQL, SqlParameter[] pas, CommandType cmdtype, DataBaseName dataBaseName)
        {
            DataSet dt = new DataSet(); ;
            using (SqlConnection conn = new SqlConnection(GetEnumDes(dataBaseName.ToString())))
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
                da.SelectCommand.CommandType = cmdtype;
                if (pas != null)
                {
                    da.SelectCommand.Parameters.AddRange(pas);
                }
                da.Fill(dt);
                if (dt != null && dt.Tables.Count == 2)
                {
                    dt.Tables[0].TableName = "DataList";
                    dt.Tables[1].TableName = "DataTotal";
                }
                else if (dt != null && dt.Tables.Count == 1)
                {
                    dt.Tables[0].TableName = "DataList";
                }
            }
            return dt;
        }
        #endregion

        #endregion

        #region 执行非查询存储过程和SQL语句-----------------------------


        public static int ExcuteProc(string ProcName)
        {
            return ExcuteSQL(ProcName, null, CommandType.StoredProcedure);
        }
        public static int ExcuteProc(string ProcName, SqlParameter[] pars)
        {
            return ExcuteSQL(ProcName, pars, CommandType.StoredProcedure);
        }
        public static int ExcuteSQL(string strSQL)
        {
            return ExcuteSQL(strSQL, null);
        }
        public static int ExcuteSQL(string strSQL, SqlParameter[] paras)
        {
            return ExcuteSQL(strSQL, paras, CommandType.Text);
        }
        /// 执行非查询存储过程和SQL语句
        /// 增、删、改
        /// </summary>
        /// <param name="strSQL">要执行的SQL语句</param>
        /// <param name="paras">参数列表，没有参数填入null</param>
        /// <param name="cmdType">Command类型</param>
        /// <returns>返回影响行数</returns>
        public static int ExcuteSQL(string strSQL, SqlParameter[] paras, CommandType cmdType)
        {
            int i = 0;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = cmdType;
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                conn.Open();
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return i;
        }

        #region 执行sql返回自增ID
        /// <summary>
        /// 执行SQL语句，返回自增ID
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSQLReturnID(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        cmd.CommandText += ";\nSELECT SCOPE_IDENTITY() AS NewID;";
                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        return id;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        #endregion

        #region 执行sql返回自增ID
        /// <summary>
        /// 执行SQL语句，返回自增ID
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSQLReturnID(string SQLString, SqlParameter[] paras, DataBaseName dataBaseName)
        {
            using (SqlConnection connection = new SqlConnection(GetEnumDes(dataBaseName.ToString())))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        if (paras != null)
                        {
                            cmd.Parameters.AddRange(paras);
                        }
                        connection.Open();
                        cmd.CommandText += ";\nSELECT SCOPE_IDENTITY() AS NewID;";
                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        return id;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        #endregion

        #region 根据枚举连接数据库
        public static int ExcuteProc(string ProcName, DataBaseName dataBaseName)
        {
            return ExcuteSQL(ProcName, null, CommandType.StoredProcedure, dataBaseName);
        }
        public static int ExcuteProc(string ProcName, SqlParameter[] pars, DataBaseName dataBaseName)
        {
            return ExcuteSQL(ProcName, pars, CommandType.StoredProcedure, dataBaseName);
        }
        public static int ExcuteSQL(string strSQL, DataBaseName dataBaseName)
        {
            return ExcuteSQL(strSQL, null, dataBaseName);
        }
        public static int ExcuteSQL(string strSQL, SqlParameter[] paras, DataBaseName dataBaseName)
        {
            return ExcuteSQL(strSQL, paras, CommandType.Text, dataBaseName);
        }
        /// 执行非查询存储过程和SQL语句
        /// 增、删、改
        /// </summary>
        /// <param name="strSQL">要执行的SQL语句</param>
        /// <param name="paras">参数列表，没有参数填入null</param>
        /// <param name="cmdType">Command类型</param>
        /// <returns>返回影响行数</returns>
        public static int ExcuteSQL(string strSQL, SqlParameter[] paras, CommandType cmdType, DataBaseName dataBaseName)
        {
            int i = 0;
            using (SqlConnection conn = new SqlConnection(GetEnumDes(dataBaseName.ToString())))
            {
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = cmdType;
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                conn.Open();
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return i;
        }

        #region 执行sql返回自增ID
        /// <summary>
        /// 执行SQL语句，返回自增ID
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSQLReturnID(string SQLString, DataBaseName dataBaseName)
        {
            using (SqlConnection connection = new SqlConnection(GetEnumDes(dataBaseName.ToString())))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        cmd.CommandText += ";\nSELECT SCOPE_IDENTITY() AS NewID;";
                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        return id;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        #endregion
        #endregion

        #endregion

        #region 执行查询返回第一行，第一列---------------------------------

        /// <summary>
        /// 执行SQL语句，返回第一行，第一列
        /// </summary>
        /// <param name="strSQL">要执行的SQL语句</param>
        /// <param name="paras">参数列表，没有参数填入null</param>
        /// <param name="paras">执行类型，</param>
        /// <returns>返回结果</returns>
        public static object ExcuteScalarSQLObj(string strSQL, SqlParameter[] paras)
        {
            object i;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                conn.Open();
                if (DBNull.Value == cmd.ExecuteScalar())
                {
                    i = null;
                }
                else
                {
                    i = cmd.ExecuteScalar();
                }
                conn.Close();
            }
            return i;
        }

        public static int ExcuteScalarSQL(string strSQL)
        {
            return ExcuteScalarSQL(strSQL, null);
        }

        public static int ExcuteScalarSQL(string strSQL, SqlParameter[] paras)
        {
            return ExcuteScalarSQL(strSQL, paras, CommandType.Text);
        }
        public static int ExcuteScalarProc(string strSQL, SqlParameter[] paras)
        {
            return ExcuteScalarSQL(strSQL, paras, CommandType.StoredProcedure);
        }
        /// <summary>
        /// 执行SQL语句，返回第一行，第一列
        /// </summary>
        /// <param name="strSQL">要执行的SQL语句</param>
        /// <param name="paras">参数列表，没有参数填入null</param>
        /// <returns>返回影响行数</returns>
        public static int ExcuteScalarSQL(string strSQL, SqlParameter[] paras, CommandType cmdType)
        {
            int i = 0;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = cmdType;
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                conn.Open();
                if (DBNull.Value == cmd.ExecuteScalar())
                {
                    i = 0;
                }
                else
                {
                    i = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conn.Close();
            }
            return i;
        }

        #region 根据枚举连接数据库
        public static int ExcuteScalarSQL(string strSQL, DataBaseName dataBaseName)
        {
            return ExcuteScalarSQL(strSQL, null);
        }
        public static int ExcuteScalarSQL(string strSQL, SqlParameter[] paras, DataBaseName dataBaseName)
        {
            return ExcuteScalarSQL(strSQL, paras, CommandType.Text, dataBaseName);
        }
        public static int ExcuteScalarProc(string strSQL, SqlParameter[] paras, DataBaseName dataBaseName)
        {
            return ExcuteScalarSQL(strSQL, paras, CommandType.StoredProcedure, dataBaseName);
        }
        /// <summary>
        /// 执行SQL语句，返回第一行，第一列
        /// </summary>
        /// <param name="strSQL">要执行的SQL语句</param>
        /// <param name="paras">参数列表，没有参数填入null</param>
        /// <returns>返回影响行数</returns>
        public static int ExcuteScalarSQL(string strSQL, SqlParameter[] paras, CommandType cmdType, DataBaseName dataBaseName)
        {
            int i = 0;
            using (SqlConnection conn = new SqlConnection(GetEnumDes(dataBaseName.ToString())))
            {
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = cmdType;
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                conn.Open();
                if (DBNull.Value == cmd.ExecuteScalar())
                {
                    i = 0;
                }
                else
                {
                    i = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conn.Close();
            }
            return i;
        }
        #endregion

        #endregion

        #region 查询获取单个值------------------------------------


        /// <summary>
        /// 调用不带参数的存储过程获取单个值
        /// </summary>
        /// <param name="ProcName"></param>
        /// <returns></returns>
        public static object GetObjectByProc(string ProcName)
        {
            return GetObjectByProc(ProcName, null);
        }
        /// <summary>
        /// 调用带参数的存储过程获取单个值
        /// </summary>
        /// <param name="ProcName"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static object GetObjectByProc(string ProcName, SqlParameter[] paras)
        {
            return GetObject(ProcName, paras, CommandType.StoredProcedure);
        }
        /// <summary>
        /// 根据sql语句获取单个值
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public static object GetObject(string strSQL)
        {
            return GetObject(strSQL, null);
        }
        /// <summary>
        /// 根据sql语句 和 参数数组获取单个值
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static object GetObject(string strSQL, SqlParameter[] paras)
        {
            return GetObject(strSQL, paras, CommandType.Text);
        }
        /// <summary>
        /// 执行SQL语句，返回首行首列
        /// </summary>
        /// <param name="strSQL">要执行的SQL语句</param>
        /// <param name="paras">参数列表，没有参数填入null</param>
        /// <returns>返回的首行首列</returns>
        public static object GetObject(string strSQL, SqlParameter[] paras, CommandType cmdtype)
        {
            object o = null;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = cmdtype;
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);

                }

                conn.Open();
                o = cmd.ExecuteScalar();
                conn.Close();
            }
            return o;
        }

        #region 根据枚举连接数据库
        /// <summary>
        /// 调用不带参数的存储过程获取单个值
        /// </summary>
        /// <param name="ProcName"></param>
        /// <returns></returns>
        public static object GetObjectByProc(string ProcName, DataBaseName dataBaseName)
        {
            return GetObjectByProc(ProcName, null, dataBaseName);
        }
        /// <summary>
        /// 调用带参数的存储过程获取单个值
        /// </summary>
        /// <param name="ProcName"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static object GetObjectByProc(string ProcName, SqlParameter[] paras, DataBaseName dataBaseName)
        {
            return GetObject(ProcName, paras, CommandType.StoredProcedure, dataBaseName);
        }
        /// <summary>
        /// 根据sql语句获取单个值
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public static object GetObject(string strSQL, DataBaseName dataBaseName)
        {
            return GetObject(strSQL, null, dataBaseName);
        }
        /// <summary>
        /// 根据sql语句 和 参数数组获取单个值
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static object GetObject(string strSQL, SqlParameter[] paras, DataBaseName dataBaseName)
        {
            return GetObject(strSQL, paras, CommandType.Text, dataBaseName);
        }
        /// <summary>
        /// 执行SQL语句，返回首行首列
        /// </summary>
        /// <param name="strSQL">要执行的SQL语句</param>
        /// <param name="paras">参数列表，没有参数填入null</param>
        /// <returns>返回的首行首列</returns>
        public static object GetObject(string strSQL, SqlParameter[] paras, CommandType cmdtype, DataBaseName dataBaseName)
        {
            object o = null;
            using (SqlConnection conn = new SqlConnection(GetEnumDes(dataBaseName.ToString())))
            {
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = cmdtype;
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);

                }

                conn.Open();
                o = cmd.ExecuteScalar();
                conn.Close();
            }
            return o;
        }
        #endregion

        #endregion

        #region 查询获取DataReader------------------------------------


        /// <summary>
        /// 调用不带参数的存储过程，返回DataReader对象
        /// </summary>
        /// <param name="procName">存储过程名称</param>
        /// <returns>DataReader对象</returns>
        public static SqlDataReader GetReaderByProc(string procName)
        {
            return GetReaderByProc(procName, null);
        }
        /// <summary>
        /// 调用带有参数的存储过程，返回DataReader对象
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="paras">参数数组</param>
        /// <returns>DataReader对象</returns>
        public static SqlDataReader GetReaderByProc(string procName, SqlParameter[] paras)
        {
            return GetReader(procName, paras, CommandType.StoredProcedure);
        }
        /// <summary>
        /// 根据sql语句返回DataReader对象
        /// </summary>
        /// <param name="strSQL">sql语句</param>
        /// <returns>DataReader对象</returns>
        public static SqlDataReader GetReader(string strSQL)
        {
            return GetReader(strSQL, null);
        }
        /// <summary>
        /// 根据sql语句和参数返回DataReader对象
        /// </summary>
        /// <param name="strSQL">sql语句</param>
        /// <param name="paras">参数数组</param>
        /// <returns>DataReader对象</returns>
        public static SqlDataReader GetReader(string strSQL, SqlParameter[] paras)
        {
            return GetReader(strSQL, paras, CommandType.Text);
        }
        /// <summary>
        /// 查询SQL语句获取DataReader
        /// </summary>
        /// <param name="strSQL">查询的SQL语句</param>
        /// <param name="paras">参数列表，没有参数填入null</param>
        /// <returns>查询到的DataReader（关闭该对象的时候，自动关闭连接）</returns>
        public static SqlDataReader GetReader(string strSQL, SqlParameter[] paras, CommandType cmdtype)
        {
            SqlDataReader sqldr = null;
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.CommandType = cmdtype;
            if (paras != null)
            {
                cmd.Parameters.AddRange(paras);
            }
            conn.Open();
            //CommandBehavior.CloseConnection的作用是如果关联的DataReader对象关闭，则连接自动关闭
            sqldr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return sqldr;
        }

        #region 根据枚举连接数据库
        /// <summary>
        /// 调用不带参数的存储过程，返回DataReader对象
        /// </summary>
        /// <param name="procName">存储过程名称</param>
        /// <returns>DataReader对象</returns>
        public static SqlDataReader GetReaderByProc(string procName, DataBaseName dataBaseName)
        {
            return GetReaderByProc(procName, null, dataBaseName);
        }
        /// <summary>
        /// 调用带有参数的存储过程，返回DataReader对象
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="paras">参数数组</param>
        /// <returns>DataReader对象</returns>
        public static SqlDataReader GetReaderByProc(string procName, SqlParameter[] paras, DataBaseName dataBaseName)
        {
            return GetReader(procName, paras, CommandType.StoredProcedure, dataBaseName);
        }
        /// <summary>
        /// 根据sql语句返回DataReader对象
        /// </summary>
        /// <param name="strSQL">sql语句</param>
        /// <returns>DataReader对象</returns>
        public static SqlDataReader GetReader(string strSQL, DataBaseName dataBaseName)
        {
            return GetReader(strSQL, null, dataBaseName);
        }
        /// <summary>
        /// 根据sql语句和参数返回DataReader对象
        /// </summary>
        /// <param name="strSQL">sql语句</param>
        /// <param name="paras">参数数组</param>
        /// <returns>DataReader对象</returns>
        public static SqlDataReader GetReader(string strSQL, SqlParameter[] paras, DataBaseName dataBaseName)
        {
            return GetReader(strSQL, paras, CommandType.Text, dataBaseName);
        }
        /// <summary>
        /// 查询SQL语句获取DataReader
        /// </summary>
        /// <param name="strSQL">查询的SQL语句</param>
        /// <param name="paras">参数列表，没有参数填入null</param>
        /// <returns>查询到的DataReader（关闭该对象的时候，自动关闭连接）</returns>
        public static SqlDataReader GetReader(string strSQL, SqlParameter[] paras, CommandType cmdtype, DataBaseName dataBaseName)
        {
            SqlDataReader sqldr = null;
            SqlConnection conn = new SqlConnection(GetEnumDes(dataBaseName.ToString()));
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.CommandType = cmdtype;
            if (paras != null)
            {
                cmd.Parameters.AddRange(paras);
            }
            conn.Open();
            //CommandBehavior.CloseConnection的作用是如果关联的DataReader对象关闭，则连接自动关闭
            sqldr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return sqldr;
        }
        #endregion

        #endregion

        #region 批量插入数据---------------------------------------------


        /// <summary>
        /// 往数据库中批量插入数据
        /// </summary>
        /// <param name="sourceDt">数据源表</param>
        /// <param name="targetTable">服务器上目标表</param>
        public static void BulkToDB(DataTable sourceDt, string targetTable)
        {
            SqlConnection conn = new SqlConnection(strConn);
            SqlBulkCopy bulkCopy = new SqlBulkCopy(conn);   //用其它源的数据有效批量加载sql server表中
            bulkCopy.DestinationTableName = targetTable;    //服务器上目标表的名称
            bulkCopy.BatchSize = sourceDt.Rows.Count;   //每一批次中的行数

            try
            {
                conn.Open();
                if (sourceDt != null && sourceDt.Rows.Count != 0)
                    bulkCopy.WriteToServer(sourceDt);   //将提供的数据源中的所有行复制到目标表中
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                if (bulkCopy != null)
                    bulkCopy.Close();
            }

        }

        #region 根据枚举连接数据库
        /// <summary>
        /// 往数据库中批量插入数据
        /// </summary>
        /// <param name="sourceDt">数据源表</param>
        /// <param name="targetTable">服务器上目标表</param>
        public static void BulkToDB(DataTable sourceDt, string targetTable, DataBaseName dataBaseName)
        {
            SqlConnection conn = new SqlConnection(GetEnumDes(dataBaseName.ToString()));
            SqlBulkCopy bulkCopy = new SqlBulkCopy(conn);   //用其它源的数据有效批量加载sql server表中
            bulkCopy.DestinationTableName = targetTable;    //服务器上目标表的名称
            bulkCopy.BatchSize = sourceDt.Rows.Count;   //每一批次中的行数

            try
            {
                conn.Open();
                if (sourceDt != null && sourceDt.Rows.Count != 0)
                    bulkCopy.WriteToServer(sourceDt);   //将提供的数据源中的所有行复制到目标表中
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                if (bulkCopy != null)
                    bulkCopy.Close();
            }

        }
        #endregion

        #endregion

        #region 根据枚举返回数据库连接字符串
        public static string GetEnumDes(string dataBaseName)
        {
            string conn = string.Empty;
            if (dataBaseName == "集团商务")
            {
                conn = ConfigurationManager.AppSettings["JiTuanShangWuDB"].ToString();
            }
            else if (dataBaseName == "数据平台")
            {
                conn = ConfigurationManager.AppSettings["ShuJuPingTai"].ToString();
            }
            else if (dataBaseName == "牛经纪")
            {
                conn = ConfigurationManager.AppSettings["NiuJingJi"].ToString();
            }
            else if (dataBaseName == "会员")
            {
                conn = ConfigurationManager.AppSettings["MobilePlatformDB"].ToString();
            }
            else if (dataBaseName == "电商官网")
            {
                conn = ConfigurationManager.AppSettings["ElectricityDB"].ToString();
            }
            else if (dataBaseName == "数据平台DI")
            {
                conn = ConfigurationManager.AppSettings["ShuJuPingTaiDI"].ToString();
            }
            else
            {
                conn = ConfigurationManager.AppSettings["JiTuanShangWuDB"].ToString();
            }
            return conn;
        }
        #endregion

        #region MyRegion 执行事务逻辑
        /// <summary>
        /// 有锁的事务方法 插入数据
        /// </summary>
        /// <param name="tran"></param>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(IDbTransaction tran, string sql, params SqlParameter[] pms)
        {

            using (SqlCommand cmd = new SqlCommand(sql, (SqlConnection)tran.Connection, (SqlTransaction)tran))
            {
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }

                return cmd.ExecuteNonQuery();

            }


        }
        #endregion
    }

    #region 数据库--枚举（DataBaseName）
    /// <summary>
    /// 数据库类型枚举：集团商务、牛经纪
    /// </summary>
    public enum DataBaseName
    {
        集团商务,
        数据平台,
        牛经纪,
        会员,
        电商官网,
        数据平台DI
    }
    #endregion

    #region MyRegion 事务sql
    public class TransactionDal
    {
        public string CreateConnection = string.Empty;
        public DbConnection dbconnection = null;
        public DbTransaction transaction = null;
        public TransactionDal(string Connection)
        {
            CreateConnection = Connection;
        }
        public void BeginTransaction()
        {
            dbconnection = new SqlConnection(CreateConnection);
            dbconnection.Open();
            transaction = dbconnection.BeginTransaction();

        }

        public void CommitTransaction()
        {
            if (null != transaction)
            {
                transaction.Commit();
            }

        }

        public void RollbackTransaction()
        {
            if (null != transaction)
            {
                transaction.Rollback();
            }

        }

        public void DisposeTransaction()
        {
            if (dbconnection.State == ConnectionState.Open)
            {
                dbconnection.Close();
            }
            if (null != transaction)
            {
                transaction.Dispose();
            }

        }
    }
    #endregion
}
