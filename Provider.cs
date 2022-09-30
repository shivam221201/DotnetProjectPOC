using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Toolkit.Forms.UI.Controls;


namespace GoogleMaps_Application
{
    [Serializable]
    class Provider
    {
        /*Data item*/
        private string cs = @"Data Source= WSAMZN-TPSVGI3F\SQLEXPRESS; initial catalog = locations ; integrated security = true";
        private string query = null;
        private SqlConnection cn = null;
        private SqlCommand cm = null;
        private SqlDataReader dr = null;
        private DataTable dt = null;

        /*set value to null*/
        private void Initial()
        {
            query = null;
            cn = null;
            cm = null;
            dr = null;
            dt = null;
        }

        /*load data from database*/
        public DataTable Load(string table)
        {
            DataTable d = null;
            try
            {
                cn = new SqlConnection(cs);
                query = "select * from " + table;
                cm = new SqlCommand(query, cn);
                dt = new DataTable();
                cn.Open();
                dr = cm.ExecuteReader();
                dt.Load(dr);
                cn.Close();
                d = dt;
                Initial();
                return d;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                return dt;
            }
        }

        public DataTable Loading(string query)
        {
            DataTable d = null;
            try
            {
                cn = new SqlConnection(cs);
                cm = new SqlCommand(query, cn);
                dt = new DataTable();
                cn.Open();
                dr = cm.ExecuteReader();
                dt.Load(dr);
                cn.Close();
                d = dt;
                Initial();
                return d;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                return dt;
            }
        }
    }
}
