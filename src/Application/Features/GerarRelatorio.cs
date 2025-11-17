using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Data;
using System.IO;

namespace ControlePecas.Features
{
    public class GerarRelatorio
    {
        public void Executar(DataTable relatorio)
        {
            if (relatorio == null || relatorio.Rows.Count == 0)
                throw new ArgumentException("O DataTable está vazio.");

            string nomeObra = relatorio.Rows[0]["Obra"]?.ToString() ?? "Desconhecida";

            string caminhoDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pastaRelatorios = Path.Combine(caminhoDocuments, "Relatorios");
            if (!Directory.Exists(pastaRelatorios))
                Directory.CreateDirectory(pastaRelatorios);

            string nomeArquivo = $"RelatorioPecas_{nomeObra}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string caminhoArquivo = Path.Combine(pastaRelatorios, nomeArquivo);

            PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

            float[] colWidths = { 50, 150, 80, 100, 100 };

            using (var fs = new FileStream(caminhoArquivo, FileMode.Create, FileAccess.Write, FileShare.None))
            using (var pdfWriter = new PdfWriter(fs))
            using (var pdfDoc = new PdfDocument(pdfWriter))
            using (var document = new Document(pdfDoc, iText.Kernel.Geom.PageSize.A4.Rotate()))
            {
                document.Add(new Paragraph($"Relatório de Peças na Obra: {nomeObra}")
                    .SetFont(boldFont)
                    .SetFontSize(16));
                document.Add(new Paragraph($"Gerado em {DateTime.Now}").SetFontSize(10));
                document.Add(new Paragraph("\n"));

                Table tabelaPdf = new Table(colWidths).UseAllAvailableWidth();

                foreach (DataColumn coluna in relatorio.Columns)
                {
                    tabelaPdf.AddHeaderCell(new Cell()
                        .Add(new Paragraph(coluna.ColumnName).SetFont(boldFont))
                        .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                        .SetTextAlignment(TextAlignment.CENTER));
                }

                bool linhaColorida = false;
                foreach (DataRow row in relatorio.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        Cell cell = new Cell()
                            .Add(new Paragraph(item?.ToString() ?? ""))
                            .SetTextAlignment(TextAlignment.CENTER);

                        if (linhaColorida)
                            cell.SetBackgroundColor(ColorConstants.LIGHT_GRAY);

                        tabelaPdf.AddCell(cell);
                    }
                    linhaColorida = !linhaColorida;
                }

                document.Add(tabelaPdf);
            }
        }
    }
}
