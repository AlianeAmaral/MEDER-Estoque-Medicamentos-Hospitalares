namespace MederApplication.Models
{
    public enum TipoDeAcesso
    {
        Admin, 
        Leitura 
    }

    public class Usuario
    {
        public string UsuarioId { get; set; }
    
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public string Email { get; set; }
        public string TipoDeAcesso { get; set; }

        // Relacionamento com Movimentacao
        public List<Movimentacao> Movimentacoes { get; set; }
    }
}