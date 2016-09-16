using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlunoWeb
{
    public partial class InserirDisciplinas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                buscarDisciplinas();
            }
        }

        private void buscarDisciplinas()
        {
            Aluno.Biblioteca.MODEL.DisciplinaModel disciplina = new Aluno.Biblioteca.MODEL.DisciplinaModel();
            this.grdDisciplinas.DataSource = disciplina.buscarDisciplinas();
            this.grdDisciplinas.DataBind();
        }

        protected void cmdInserir_Click(object sender, EventArgs e)
        {
            //chamar o dto passando o parametro
            Aluno.Biblioteca.DTO.DisciplinasDTO dto = new Aluno.Biblioteca.DTO.DisciplinasDTO();
            dto.descricaoDisc = txtNomeDisciplina.Text;

            //chamar a dao passando o parametro
            Aluno.Biblioteca.MODEL.DisciplinaModel model = new Aluno.Biblioteca.MODEL.DisciplinaModel();
            if (model.inserirDisciplinas(dto))
            {
                lblResultado.Text = "Disciplina inserida com sucesso.";
                txtNomeDisciplina.Text = "";
                buscarDisciplinas();
            }
            else
            {
                lblResultado.Text = "Algum erro aconteceu, tente novamente mais tarde.";
            }
        }

        protected void grdDisciplinas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grdDisciplinas.PageIndex = e.NewPageIndex;
            buscarDisciplinas();
        }
    }
}