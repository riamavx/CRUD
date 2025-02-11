using System.Data;

namespace Sistema_Financeiro.Api.Model
{
    public class ContaModel
    {
        public Guid Id { get; set; }
        public string NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataAbertura{ get; set; }
        public Guid ClienteId { get; set; }
        public Guid TipoContaId { get; set; }

    }
}
