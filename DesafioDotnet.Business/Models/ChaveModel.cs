using System;
using static DesafioDotnet.Business.Models.Enumerado;

namespace DesafioDotnet.Business.Models
{
    public class ChaveModel
    {
        public Guid Id { get; set; }
        public ETipoChave TipoChave { get; set; }
        public string Descricao { get; set; }
    }
}

