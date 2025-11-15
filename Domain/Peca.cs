using System;

namespace ControlePecas.Domain
{
    public class Peca
    {
        public int CodigoControle { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public decimal VolumeM3 { get; set; }
        public decimal PesoKg { get; set; }
        public string Status { get; set; }
        public int CodObra { get; set; }
    }
}
