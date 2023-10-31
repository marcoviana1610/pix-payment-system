using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioDotnet.Business.Models
{
    public class Recebedor
    {
        public Guid Id { get; set; }
        public ChaveModel Chave { get; set; }
        public string Nome { get; set; }
    }
}
