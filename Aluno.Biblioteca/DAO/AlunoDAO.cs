using Aluno.Biblioteca.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Biblioteca.DAO
{
    internal class AlunoDAO
    {
        internal bool deletarAluno(AlunoDTO dto)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SQLConexaoLocal"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = "DELETE FROM Alunos WHERE IdAluno = @id ";

                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@id", dto.idAluno);
                    command.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        internal bool atualizaAluno(AlunoDTO dto)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SQLConexaoLocal"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = "UPDATE Alunos SET NomeAluno = @nome, EmailAluno = @email WHERE IdAluno = @id";

                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@nome", dto.nomeAluno);
                    command.Parameters.AddWithValue("@email", dto.emailAluno);
                    command.Parameters.AddWithValue("@id", dto.idAluno);
                    command.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        internal DataSet buscarTodosAlunos()
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SQLConexaoLocal"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT IdAluno, NomeAluno, EmailAluno FROM Alunos ORDER BY NomeAluno";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.Text;

                    DataSet dtSet = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(command);

                    dtAdapter.Fill(dtSet);
                    return dtSet;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        internal DataSet buscarTodosAlunosPeloNome(AlunoDTO dto)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SQLConexaoLocal"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT IdAluno, NomeAluno, EmailAluno FROM Alunos WHERE NomeAluno Like @nome ORDER BY NomeAluno";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@nome", '%' + dto.nomeAluno + '%');

                    DataSet dtSet = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(command);

                    dtAdapter.Fill(dtSet);
                    return dtSet;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        internal DataSet buscarAlunoPeloId(AlunoDTO dto)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SQLConexaoLocal"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT IdAluno, NomeAluno, EmailAluno FROM Alunos WHERE IdAluno =  @id";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@id", dto.idAluno);

                    DataSet dtSet = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(command);

                    dtAdapter.Fill(dtSet);
                    return dtSet;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
