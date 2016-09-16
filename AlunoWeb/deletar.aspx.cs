using Aluno.Biblioteca.DTO;
using Aluno.Biblioteca.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlunoWeb
{
    public partial class deletar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null)
            {
                var _idAluno = Request["id"].ToString();

                //envio o dado recebido para a minha DTO;
                AlunoDTO dto = new AlunoDTO();
                dto.idAluno = Convert.ToInt32(_idAluno);

                //chamo a minha model
                AlunoModel model = new AlunoModel();
                if (model.deletarAluno(dto))
                    Response.Redirect("Alunos.aspx");
                else
                    Response.Write("Não deletou, tente novamente.");

            }
        }
    }
}