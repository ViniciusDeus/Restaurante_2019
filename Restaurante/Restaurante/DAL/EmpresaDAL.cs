using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Restaurante.Models;

namespace Restaurante.DAL
{
    public class EmpresaDAL
    {

        public List<Empresa> BuscaEmpresa()
        {
            try 
            {
                Conexao.abreConexao();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.connection;
                cmd.CommandText = "SELECT * FROM tb_empresa" ;
                //parametro
                //cmd.Parameters.AddWithValue("@USUARIO", usuario);

                var reader = cmd.ExecuteReader();

                List<Empresa> list = new List<Empresa>();

                while(reader.Read())
                {
                    Empresa emp = new Empresa();

                    emp.Id = Convert.ToInt32(reader["id_empresa"]);
                    emp.NomeEmpresa = reader["nome_empresa"].ToString();

                    list.Add(emp);
                }
                return list;

            }
            catch (Exception ex)
            {
               throw;
            }

            finally
            {
                Conexao.fechaConexao(); 
            }
        
        }

        internal void Delete(int id)
        {
            try
            {
                Conexao.abreConexao();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.connection;
                cmd.CommandText = "DELETE FROM tb_empresa where id_empresa = @idempresa";
                //parametro
                cmd.Parameters.AddWithValue("@idempresa", id);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                Conexao.fechaConexao();
            }
        }

        public void Save(Empresa modal)
        {
            try
            {
                Conexao.abreConexao();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.connection;
                cmd.CommandText = "INSERT INTO tb_empresa(NOME_EMPRESA) VALUES(@nomeempresa)";
                //parametro
                cmd.Parameters.AddWithValue("@nomeempresa", modal.NomeEmpresa);

                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                Conexao.fechaConexao();
            }
        }

        public void EditarUpdate(Empresa model)
        {
            try
            {
                Conexao.abreConexao();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.connection;
                cmd.CommandText = "update TB_EMPRESA set NOME_EMPRESA = @NOMEEMPRESA where ID_EMPRESA = @id";
                //parametro
                cmd.Parameters.AddWithValue("@id", model.Id);
                cmd.Parameters.AddWithValue("@NOMEEMPRESA", model.NomeEmpresa);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }

            finally
            {
                Conexao.fechaConexao();
            }
        }

        public Empresa BuscaEmpresaId(int id)
        {
            try
            {
                Conexao.abreConexao();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.connection;
                cmd.CommandText = "SELECT * FROM tb_empresa where id_empresa = @id";
                //parametro
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();
                Empresa emp = new Empresa();

                while (reader.Read())
                {
                    
                    emp.Id = Convert.ToInt32(reader["id_empresa"]);
                    emp.NomeEmpresa = reader["nome_empresa"].ToString();
                }
                return emp;

            }
            catch (Exception ex)
            {
                throw;
            }

            finally
            {
                Conexao.fechaConexao();
            }
        }
    }
}