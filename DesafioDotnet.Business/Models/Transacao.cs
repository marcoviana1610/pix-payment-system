using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioDotnet.Business.Models
{
    public class Transacao
    {
        public Guid Id { get; set; }
        public DateTime DataTransacao { get; set; }
        public Pagador Pagador { get; set; }
        public int PagadorId { get; set; }
        public Recebedor Recebedor { get; set; }
        public int RecebedorId { get; set; }

    }
}
