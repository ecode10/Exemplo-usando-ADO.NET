using Aluno.Biblioteca.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aluno.Biblioteca.DAO;

namespace Aluno.Biblioteca.MODEL
{
    public class DisciplinaModel
    {
        private DAO.DisciplinasDAO _disciplinasDAO;

        public DisciplinaModel()
        {
            if (_disciplinasDAO == null)
                _disciplinasDAO = new DAO.DisciplinasDAO();
        }

        public Boolean inserirDisciplinas(DisciplinasDTO dto)
        {
            return _disciplinasDAO.inserirDisciplina(dto);
        }

        public DataTable buscarDisciplinas()
        {
            return _disciplinasDAO.buscarDisciplinas().Tables[0];
        }
    }
}
