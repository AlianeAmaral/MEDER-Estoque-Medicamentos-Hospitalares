namespace MederApplication.Models
{
    public class Medicamento
    {
        public int MedicamentoId { get; set; }
    
        public string Nome { get; set; }
        public int Dose { get; set; }
        public string Tipo { get; set; }
        public string Lote { get; set; }
        public DateTime Validade { get; set; }
        public string Localizacao { get; set; }
        public int Quantidade { get; set; }

        // Relacionamento com Movimentacao
        public List<Movimentacao> Movimentacoes { get; set; }
    }
}