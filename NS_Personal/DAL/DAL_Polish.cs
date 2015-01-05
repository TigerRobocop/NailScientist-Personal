using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NS_Personal.Conex;
using System.Data.SqlClient;
using NS_Personal.Basicas;
using System.Data;

namespace NS_Personal.DAL
{
    class DAL_Polish
    {
        private static DAL_Polish instancia;

        public static DAL_Polish getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DAL_Polish();
            }
            return instancia;
        }

        public void InsertPolish(Polish p)
        {
            try
            {
                Conex.Conex g = new Conex.Conex();
                g.abrirConexao();

                string strInsertPolish = @" INSERT INTO Polish 
                                        (id, Name, Color, Brand, Finish)
                                         VALUES (@Guid, @Name, @Color, @Brand, @Finish); ";



                SqlCommand comm = new SqlCommand(strInsertPolish, g.sqlConn);

                //parametros 

                Guid guid = Guid.NewGuid();
                comm.Parameters.AddWithValue("@Guid", guid);
                comm.Parameters.AddWithValue("@Name", p.Name);
                comm.Parameters.AddWithValue("@Color", p.Color);
                comm.Parameters.AddWithValue("@Brand", p.Brand);
                comm.Parameters.AddWithValue("@Finish", p.Finish);

                comm.ExecuteNonQuery();

                comm.Dispose();
                g.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("DAO: " + ex.Message);
            }


        }

        public DataTable GetPolish()
        {
            string strSelectPolish = @"select p.id, p.Name
,(select b.Brand from brand b where b.id = p.brand) as Brand
,(select f.Finish from finish f where f.id = p.Finish) as Finish
,p.Color
from polish p
order by p.Name";

            DataTable retorno = null;

            try
            {

                List<Polish> list = new List<Polish>();

                Conex.Conex g = new Conex.Conex();
                g.abrirConexao();


                SqlCommand comm = new SqlCommand(strSelectPolish, g.sqlConn);

                SqlDataReader DbReader = comm.ExecuteReader();

                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Polish p = new Polish();

                    //acessando os dados

                    p.ID = DbReader.GetGuid(DbReader.GetOrdinal("id"));
                    p.Name = DbReader.GetString(DbReader.GetOrdinal("Name"));
                    p.Color = DbReader.GetString(DbReader.GetOrdinal("Color"));
                    p.Brand = DbReader.GetString(DbReader.GetOrdinal("Brand"));
                    p.Finish = DbReader.GetString(DbReader.GetOrdinal("Finish"));
                 
                    list.Add(p);
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
                    retorno.Columns.Add("Name");
                    retorno.Columns.Add("Color");
                    retorno.Columns.Add("Brand");
                    retorno.Columns.Add("Finish");

                    foreach (var item in list)
                    {
                        var row = retorno.NewRow();

                        row["ID"] = item.ID;
                        row["Name"] = item.Name;
                        row["Color"] = item.Color;
                        row["Brand"] = item.Brand;
                        row["Finish"] = item.Finish;

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

        public DataTable FindPolish(string brand, string finish)
        {
            string strSelectPolish = @"select p.id, p.Name
,(select b.Brand from brand b where b.id = p.brand) as Brand
,(select f.Finish from finish f where f.id = p.Finish) as Finish
,p.Color
from polish p

where p.brand = isnull(@brand, p.brand) 
and p.finish = isnull(@finish, p.finish)

order by p.Name
";

            DataTable retorno = null;

            try
            {

                List<Polish> list = new List<Polish>();

                Conex.Conex g = new Conex.Conex();
                g.abrirConexao();


                SqlCommand comm = new SqlCommand(strSelectPolish, g.sqlConn);
                comm.Parameters.AddWithValue("@Brand", brand);
                comm.Parameters.AddWithValue("@Finish",finish);

                SqlDataReader DbReader = comm.ExecuteReader();

                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Polish p = new Polish();

                    //acessando os dados

                    p.ID = DbReader.GetGuid(DbReader.GetOrdinal("id"));
                    p.Name = DbReader.GetString(DbReader.GetOrdinal("Name"));
                    p.Color = DbReader.GetString(DbReader.GetOrdinal("Color"));
                    p.Brand = DbReader.GetString(DbReader.GetOrdinal("Brand"));
                    p.Finish = DbReader.GetString(DbReader.GetOrdinal("Finish"));

                    list.Add(p);
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
                    retorno.Columns.Add("Name");
                    retorno.Columns.Add("Color");
                    retorno.Columns.Add("Brand");
                    retorno.Columns.Add("Finish");

                    foreach (var item in list)
                    {
                        var row = retorno.NewRow();

                        row["ID"] = item.ID;
                        row["Name"] = item.Name;
                        row["Color"] = item.Color;
                        row["Brand"] = item.Brand;
                        row["Finish"] = item.Finish;

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
