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
    public partial class EstadoECidade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //chama método para buscar os estados
                //e preencher a minha drop
                buscarEstados();
            }
        }

        private void buscarEstados()
        {
            EstadoModel _estadoModel = new EstadoModel();
            drpEstado.DataSource = _estadoModel.buscarTodosEstados();

            drpEstado.DataTextField = "DescEstado";
            drpEstado.DataValueField = "IdEstado";

            drpEstado.DataBind();
            
            //adiciona uma nova linha no drop de Estado sempre na primeira linha.
            drpEstado.Items.Insert(0, new ListItem("Selecione", ""));
        }

        protected void drpEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //se o usuario escolhe a opcao selecione 
            if (drpEstado.SelectedValue.ToString().Equals(""))
            {
                lblCidade.Visible = false;
                drpCidade.Visible = false;
            }
            else
            {
                //informar os dados no DTO
                CidadeDTO dto = new CidadeDTO();
                dto.idEstado = int.Parse(drpEstado.SelectedValue.ToString());

                //chamar o método para buscar no banco de dados
                CidadeModel model = new CidadeModel();
                drpCidade.DataSource = model.buscarCidades(dto);

                drpCidade.DataTextField = "DescCidade";
                drpCidade.DataValueField = "IdCidade";

                drpCidade.DataBind();

                //tornar visivel os meus objetos de tela.
                drpCidade.Visible = true;
                lblCidade.Visible = true;
            }
        }
    }
}