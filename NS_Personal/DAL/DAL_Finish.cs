using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using NS_Personal.Basicas;

namespace NS_Personal.DAL
{
    class DAL_Finish
    {
        private static DAL_Finish instancia;

        public static DAL_Finish getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DAL_Finish();
            }
            return instancia;
        }

        public void InsertFinish(string finish)
        {
            try
            {
                Conex.Conex g = new Conex.Conex();
                g.abrirConexao();

                string strInsertFinish = @" INSERT INTO Finish 
                                        (id, Finish)
                                         VALUES (@Guid, @Name); ";



                SqlCommand comm = new SqlCommand(strInsertFinish, g.sqlConn);

                //parametros 

                Guid guid = Guid.NewGuid();
                comm.Parameters.AddWithValue("@Guid", guid);
                comm.Parameters.AddWithValue("@Name", finish);

                comm.ExecuteNonQuery();

                comm.Dispose();
                g.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }


        }

        public DataTable GetFinish()
        {
            DataTable retorno = null;

            try
            {

                List<Finish> list = new List<Finish>();

                Conex.Conex g = new Conex.Conex();
                g.abrirConexao();


                SqlCommand comm = new SqlCommand("SELECT * FROM Finish order by Finish", g.sqlConn);

                SqlDataReader DbReader = comm.ExecuteReader();

                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Finish f = new Finish();
                    //acessando os dados

                    f.Id = DbReader.GetGuid(DbReader.GetOrdinal("id"));
                    f.Name = DbReader.GetString(DbReader.GetOrdinal("Finish"));

                    list.Add(f);
                }

                //fechando o leitor
                DbReader.Close();

                //liberando a memoria
                comm.Dispose();

                //fecha a conexao
                g.fecharConexao();

                //convert to datatable
                if (list.Count > 0)
                {
                    retorno = new DataTable();
                    retorno.Columns.Add("ID");
                    retorno.Columns.Add("Finish");

                    foreach (var item in list)
                    {
                        var row = retorno.NewRow();

                        row["ID"] = item.Id;
                        row["Finish"] = item.Name;

                        retorno.Rows.Add(row);
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }
    }
}
