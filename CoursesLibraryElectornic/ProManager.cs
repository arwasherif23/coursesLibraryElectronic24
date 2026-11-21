
using CoursesLibraryElectornic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace CoursesLibraryElectornic
{
    public class ProMng
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public static bool RegAc = true;

        public void conntion()
        {
           
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            conn.Open();
            cmd.Connection = conn;
        }

        public string RunInsDelUpd(string statement)
        {
            try
            {
                cmd.CommandText = statement;
                conntion();
                cmd.ExecuteNonQuery();
                conn.Close();

                if (RegAc) RegActiv(statement);

                conn.Close();
                return "OK";
            }
            catch (SqlException ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                if (ex.Number == 2627) return "Exist value";
                else return ex.Message;
            }
        }

        public DataTable RunSelect(string strselect)
        {
            try
            {
                DataTable tbl = new DataTable();
                cmd.CommandText = strselect;
                conntion();
                tbl.Load(cmd.ExecuteReader());
                conn.Close();
                return tbl;
            }
            catch
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                return null;
            }
        }
        public string newID(string table, string id)
        {
            string s = "SELECT ISNULL(MAX(" + id + "), 0) + 1 FROM " + table;
            DataTable dt = RunSelect(s);
            if (dt.Rows.Count > 0) return dt.Rows[0][0].ToString();
            return "1";
        }

        public void RegActiv(string str)
        {
            C_SYSTEMACTIVITY u = new C_SYSTEMACTIVITY();

            str = str.Replace("'", "''");
            string activityID = newID("SystemActivity", "ActivityID");

            string insert = "insert into SystemActivity (ActivityID , Activity , ActivityDate , Username) values ('"
                + activityID + "', N'" + str + "', GETDATE(), N'"
                + u.ID_User + "')";

            conntion();
            cmd.CommandText = insert;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }



}

