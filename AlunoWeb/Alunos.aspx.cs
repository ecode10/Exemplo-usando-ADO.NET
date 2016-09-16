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

        }

        protected void cmdBuscar_Click(object sender, EventArgs e)
        {
            AlunoDTO dto = new AlunoDTO();
            dto.nomeAluno = txtAluno.Text;


            Aluno.Biblioteca.MODEL.AlunoModel alunoModel = new Aluno.Biblioteca.MODEL.AlunoModel();
            grdAluno.DataSource = alunoModel.buscarAlunosPeloNome(dto);
            grdAluno.DataBind();
        }
    }
}