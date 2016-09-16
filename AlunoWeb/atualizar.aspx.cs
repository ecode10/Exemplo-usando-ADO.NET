using Aluno.Biblioteca.DTO;
using Aluno.Biblioteca.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlunoWeb
{
    public partial class atualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //buscar os dados e preencher os campos da tela.
                if (Request["id"] != null)
                {
                    var _idAluno = Request["id"].ToString();

                    AlunoDTO dto = new AlunoDTO();
                    dto.idAluno = Convert.ToInt32(_idAluno);

                    //busca do banco de dados
                    AlunoModel model = new AlunoModel();
                    DataTable dt = model.buscarAlunoPeloId(dto).Tables[0];

                    //verifica se as linhas vieram preenchidas
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        //preenche o objeto da tela com o valor que veio do banco de dados.
                        txtNome.Text = dt.Rows[0]["NomeAluno"].ToString();
                        txtEmail.Text = dt.Rows[0]["EmailAluno"].ToString();
                        hfIdAluno.Value = dt.Rows[0]["IdAluno"].ToString();
                    }
                }
            }
        }

        protected void cmdAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoDTO dto = new AlunoDTO();
                dto.nomeAluno = txtNome.Text;
                dto.emailAluno = txtEmail.Text;
                dto.idAluno = Convert.ToInt32(hfIdAluno.Value);

                AlunoModel model = new AlunoModel();
                if (model.atualizarAluno(dto))
                {
                    Response.Write("Dados atualizados.");
                }
                else
                {
                    Response.Write("Dados não atualizados, tente novamente.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}