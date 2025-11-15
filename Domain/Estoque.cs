using System;

namespace ControlePecas.Domain
{
    public class Estoque
    {
        public int CodigoControle { get; set; }
        public int CodigoAcabamento { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public int IdRegiao { get; set; }
    }
}
