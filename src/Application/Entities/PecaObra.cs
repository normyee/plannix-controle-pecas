using System;

namespace ControlePecas.Entities
{
    public class PecaObra
    {
        public int? CodControle { get; set; }
        public string NomePeca { get; set; }
        public DateTime DataPeca { get; set; }
        public string PecaStatus { get; set; }
        public decimal PesoKg { get; set; }
        public decimal VolumeM3 { get; set; }
        public int RegiaoEstoque { get; set; }

        public string AcabamentoStatus { get; set; }
        public DateTime AcabamentoDataInicio { get; set; }
        public DateTime AcabamentoDataFim { get; set; }
        public int SetorAcabamento { get; set; }

        public int EstoqueTotal { get; set; }
        public DateTime DataEstoque { get; set; }
        public string EstoqueStatus { get; set; }

        public int CodObra { get; set; }
    }
}
