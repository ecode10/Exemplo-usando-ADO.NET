
using Aluno.Biblioteca.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Aluno.Biblioteca.DAO
{
    internal class DisciplinasDAO
    {

        internal DataSet buscarDisciplinas()
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SQLConexaoLocal"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT IdDisc, DescricaoDisc FROM Disciplinas ORDER BY DescricaoDisc";
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

        /// <summary>
        /// Método responsável por inserir dados no banco de dados
        /// Tabela: Disciplinas
        /// Banco: BDAluno
        /// </summary>
        /// <param name="dto">DisciplinasDTO</param>
        /// <returns>Boolean</returns>
        internal Boolean inserirDisciplina(DisciplinasDTO dto)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SQLConexaoLocal"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = "INSERT INTO Disciplinas (DescricaoDisc) VALUES (@descricao) ";

                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@descricao", dto.descricaoDisc);
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


    }
}
