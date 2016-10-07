using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Biblioteca.DTO
{
    /// <summary>
    /// DTO que trabalha com os dados da tabela Cidades
    /// </summary>
    public class CidadeDTO
    {
        public int idCidade { get; set; }

        public int idEstado { get; set; }

        public string descCidade { get; set; }
    }
}
