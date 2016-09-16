using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlunoWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Aluno.Biblioteca.DTO.DisciplinasDTO dto = new Aluno.Biblioteca.DTO.DisciplinasDTO();
            dto.descricaoDisc = "Química";


        }
    }
}