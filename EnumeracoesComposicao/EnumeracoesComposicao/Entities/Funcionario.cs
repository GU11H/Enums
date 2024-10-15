using EnumeracoesComposicao.Entities.Enums;

namespace EnumeracoesComposicao.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }

        public LevelFuncionario Level { get; set; }

        public double SalarioBase { get; set; }

        public Departamento Departamento { get; set; }

        public List<ContratoHora> Contratos { get; set; } = new List<ContratoHora>();

        public Funcionario()
        {
        }

        public Funcionario(string nome, LevelFuncionario level, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Level = level;
            SalarioBase = salarioBase;
            Departamento = departamento;

        }

        public void AdicionarContrato(ContratoHora contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(ContratoHora contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Salario(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach (ContratoHora contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }                                
            }
            return soma;
        }

    }
}
