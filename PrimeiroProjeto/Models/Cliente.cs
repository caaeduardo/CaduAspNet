namespace PrimeiroProjeto.Models
{
    public class Cliente
    {
        //GET - inserir ou entregar o valor do Id
        //SET -

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        
    }
}
