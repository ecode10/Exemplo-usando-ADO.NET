using Aluno.Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Biblioteca.MODEL
{
    public class EstadoModel
    {
        private EstadoDAO _estadoDAO;

        public EstadoModel()
        {
            if (_estadoDAO == null)
                _estadoDAO = new EstadoDAO();
        }

        public DataSet buscarTodosEstados()
        {
            return _estadoDAO.buscarTodosEstados();
        }
    }
}
