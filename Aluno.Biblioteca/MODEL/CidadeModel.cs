using Aluno.Biblioteca.DAO;
using Aluno.Biblioteca.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Biblioteca.MODEL
{
    public class CidadeModel
    {
        private CidadeDAO _cidadeDAO;

        public CidadeModel()
        {
            if (_cidadeDAO == null)
                _cidadeDAO = new CidadeDAO();
        }

        public DataSet buscarCidades(CidadeDTO dto)
        {
            return _cidadeDAO.buscarCidades(dto);
        }
    }
}
