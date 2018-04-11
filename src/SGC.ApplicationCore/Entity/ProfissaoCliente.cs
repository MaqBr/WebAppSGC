using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.ApplicationCore.Entity
{
    public class ProfissaoCliente
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int ProfissaoId { get; set; }
        public Profissao Profissao { get; set; }

    }
}
