using System;

namespace ControlePecas.Domain
{
    public class Acabamento
    {
        public int CodigoAcabamento { get; set; }
        public int CodigoControle { get; set; }
        public DateTime Data { get; set; }
        public int IdRegiao { get; set; }
    }
}
