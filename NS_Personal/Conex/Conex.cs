using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace NS_Personal.Conex
{
    class Conex
    {
        public SqlConnection sqlConn;

        string connStringSqlServer = "Data Source=localhost; Initial Catalog=NS_Personal;UId=liviasouza;Password=12345";
        public void abrirConexao()
        {
            this.sqlConn = new SqlConnection(connStringSqlServer);
            this.sqlConn.Open();
        }

        public void fecharConexao()
        {
            this.sqlConn.Close();
            this.sqlConn.Dispose();
        }
    }
}
