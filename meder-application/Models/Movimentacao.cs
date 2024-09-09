namespace MederApplication.Models
{
    public class Movimentacao
    {
        public int MovimentacaoId { get; set; } 

        public int MedicamentoId { get; set; }
        public Medicamento Medicamento { get; set; } // Navegação para Medicamento

        public string TipoMovimentacao { get; set; } 
        public int Quantidade { get; set; } 
        public DateTime Data { get; set; } 

        public int UsuarioId { get; set; } 
        public Usuario Usuario { get; set; } // Navegação para Usuario
    }
}