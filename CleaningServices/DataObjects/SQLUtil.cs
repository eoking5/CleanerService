using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace CleaningServices.Utilities
{
    public class SQLUtil
    {
        private SqlConnection conn;
        #region Constructors
        public SQLUtil()
        {
            this.conn = new SQLUtil("Data Source = hgws27.win.hostgator.com; Initial Catalog = eoking5_MSSQL; Persist Security Info = True; User ID = eoking5_5; Password = VDaqm123").conn;
        }
        public SQLUtil(String connectionString)
        {
            this.conn = new SqlConnection(connectionString);
        }
        #endregion
        public DataTable ExecuteSQLCommand(String CommandText, List<SqlParameter> sqlParameters, CommandType CommandType = CommandType.StoredProcedure)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlCommand cmd = new SqlCommand(CommandText, this.conn);
                cmd.CommandType = CommandType;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                adapter.Dispose();
                this.conn.Close();
            }
            return dt;
        }
        public DataRow ExecuteSQLCommandDR(String CommandText, List<SqlParameter> sqlParameters, CommandType CommandType = CommandType.StoredProcedure)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlCommand cmd = new SqlCommand(CommandText, this.conn);
                cmd.CommandType = CommandType;
                cmd.Parameters.AddRange(sqlParameters.ToArray());
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                adapter.Dispose();
                this.conn.Close();
            }
            if (dt.Rows.Count >= 1) return dt.Rows[0];
            else return null;
        }
    }
}