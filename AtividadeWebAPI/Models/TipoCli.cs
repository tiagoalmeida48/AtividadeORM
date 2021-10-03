﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AtividadeWebAPI.Models
{
    public partial class TipoCli
    {
        public TipoCli()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int CodTipoCli { get; set; }
        public string NomeTipoCli { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
