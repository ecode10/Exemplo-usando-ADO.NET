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
    public class AlunoModel
    {
        private AlunoDAO _alunoDAO;
        public AlunoModel()
        {
            if (_alunoDAO == null)
                _alunoDAO = new AlunoDAO();
        }

        public DataSet buscarTodosAlunos()
        {
            return _alunoDAO.buscarTodosAlunos();
        }

        public DataSet buscarAlunosPeloNome(AlunoDTO dto)
        {
            return _alunoDAO.buscarTodosAlunosPeloNome(dto);
        }

        public bool deletarAluno(AlunoDTO dto)
        {

            //se tiver regra de negocio, coloco aqu
            return _alunoDAO.deletarAluno(dto);
        }

        public DataSet buscarAlunoPeloId(AlunoDTO dto)
        {
            return _alunoDAO.buscarAlunoPeloId(dto);
        }

        public bool atualizarAluno(AlunoDTO dto)
        {
            return _alunoDAO.atualizaAluno(dto);
        }
    }
}
