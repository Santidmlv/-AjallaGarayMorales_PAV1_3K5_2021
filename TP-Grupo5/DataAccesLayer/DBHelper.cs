using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System;
using System.Data;

namespace TP_Grupo5.DataAccesLayer
{
    public class DBHelper
    {
        private string string_conexion;
        private static DBHelper instance = new DBHelper();
        private DBHelper()
        {
            string_conexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=BugTracker;Integrated Security=True";
        }
        public static DBHelper GetDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

        public int EjecutarSQL(string strSql)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;
            int rtdo = 0;

            try
            {
                conexion.ConnectionString = string_conexion;
                
                conexion.Open();
                t = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.Transaction = t;
                cmd.CommandType = CommandType.Text;
                
                cmd.CommandText = strSql;
                
                rtdo = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                    t.Rollback();
            }
            finally
            {
                
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                conexion.Dispose();
            }
            return rtdo;
        }

        public DataTable ConsultaSQL(string strSql)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }

        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
        }


    }
}
