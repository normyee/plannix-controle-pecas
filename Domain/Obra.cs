using System;

namespace ControlePecas.Domain
{
    public class Obra
    {
        public int CodObra { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public DateTime DataEntrega { get; set; }
        public string Status { get; set; }
    }
}
