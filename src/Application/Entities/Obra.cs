using System;

namespace ControlePecas.Entities
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
