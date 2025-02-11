using System.Data;

namespace Sistema_Financeiro.Api.Model
{
    public class ClienteModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPF {  get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
