using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Singleton_Implement
{
    public class FxFunction
    {
        private static FxFunction _instance;

        //Ctor
        private FxFunction()
        {

        }

        public static FxFunction GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FxFunction();
            }

            return _instance;
        }

        SqlConnection baglan = new SqlConnection("Server=.; Database=Northwind; UID=sa; PWD=123");
        
        public int Insert(string sqlCmd)
        {
            SqlCommand cmd = new SqlCommand(sqlCmd, baglan);
            if (baglan.State == System.Data.ConnectionState.Closed)
            {
                baglan.Open();
            }

            int sonuc = cmd.ExecuteNonQuery();
            baglan.Close();

            return sonuc;
        }

        public DataTable GetData(string sqlCmd)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sqlCmd, baglan);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            return dt;
        }
    }
}
