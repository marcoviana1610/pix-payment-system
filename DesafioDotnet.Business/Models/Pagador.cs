using System;
using System.Collections.Generic;

namespace DesafioDotnet.Business.Models
{
    public class Pagador
    {
        public Guid Id { get; set; }
        public ChaveModel Chave { get; set; }
        public string Nome { get; set; }

        public ICollection<Transacao> Transacoes { get; set; }
    }
}
