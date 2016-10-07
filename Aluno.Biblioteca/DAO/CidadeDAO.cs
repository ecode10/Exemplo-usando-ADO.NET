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
    internal class CidadeDAO
    {
        /// <summary>
        /// Método que busca as cidades usando o ID
        /// </summary>
        /// <param name="dto">CidadeDTO - IdEstado</param>
        /// <returns>DataSet</returns>
        internal DataSet buscarCidades(CidadeDTO dto)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SQLConexaoLocal"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT IdEstado, IdCidade, DescCidade FROM Cidades WHERE IdEstado = @idEstado";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@idEstado", dto.idEstado);

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
