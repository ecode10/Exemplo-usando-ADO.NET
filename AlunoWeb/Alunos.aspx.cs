using Aluno.Biblioteca.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlunoWeb
{
    public partial class Alunos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            preencherGrid();
        }

        private void preencherGrid()
        {
            Aluno.Biblioteca.MODEL.AlunoModel alunoModel = new Aluno.Biblioteca.MODEL.AlunoModel();
            grdAluno.DataSource = alunoModel.buscarTodosAlunos();
            grdAluno.DataBind();
        }

        protected void cmdBuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}