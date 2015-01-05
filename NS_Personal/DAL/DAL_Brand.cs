using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using NS_Personal.Basicas;

namespace NS_Personal.DAL
{
    class DAL_Brand
    {
        private static DAL_Brand instancia;

        public static DAL_Brand getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DAL_Brand();
            }
            return instancia;
        }

        public void InsertBrand(string brand)
        {
            try
            {
                Conex.Conex g = new Conex.Conex();
                g.abrirConexao();

                string strInsertBrand = @" INSERT INTO Brand 
                                        (id, Brand)
                                         VALUES (@Guid, @Name); ";



                SqlCommand comm = new SqlCommand(strInsertBrand, g.sqlConn);

                //parametros 

                Guid guid = Guid.NewGuid();
                comm.Parameters.AddWithValue("@Guid", guid);
                comm.Parameters.AddWithValue("@Name", brand);

                comm.ExecuteNonQuery();

                comm.Dispose();
                g.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }


        }

        public DataTable GetBrands()
        {
            DataTable retorno = null;

            try
            {

                List<Brand> list = new List<Brand>();

                Conex.Conex g = new Conex.Conex();
                g.abrirConexao();

               
                SqlCommand comm = new SqlCommand("SELECT * FROM BRAND order by brand", g.sqlConn);

                SqlDataReader DbReader = comm.ExecuteReader();

                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Brand r = new Brand();

                    //acessando os dados

                    r.Id = DbReader.GetGuid(DbReader.GetOrdinal("id"));
                    r.Name = DbReader.GetString(DbReader.GetOrdinal("Brand"));
                   
                    list.Add(r);
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
                    retorno.Columns.Add("Brand");

                    foreach (var item in list)
                    {
                        var row = retorno.NewRow();

                        row["ID"] = item.Id;
                        row["Brand"] = item.Name;

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
