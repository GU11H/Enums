using EnumeracoesComposicao.Entities;
using EnumeracoesComposicao.Entities.Enums;

namespace Curso {
    class Programa {
        static void Main(String[] args) {
            Console.Write("Informe o nome do departamento:");
            string nomeDep = Console.ReadLine();

            Console.WriteLine("Informe os dados do funcionário:");
            Console.Write("Nome:");
            string nomeFunc = Console.ReadLine();

            Console.WriteLine("Level - Junior / Mid Level / Senior ");
            LevelFuncionario level = Enum.Parse<LevelFuncionario>(Console.ReadLine());

            Console.WriteLine("Informe o salário base:");
            double salBase = double.Parse(Console.ReadLine());
            
            Departamento departamento = new Departamento(nomeDep);

            Funcionario funcionario = new Funcionario(nomeFunc, level, salBase, departamento);

            Console.WriteLine("Quantos contratos esse funcionário terá?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Informe o #{i}° contrato");
                Console.Write("Data DD/MM/AAAA");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora:");
                double valorHora = double.Parse(Console.ReadLine());
                Console.Write("Duração (horas)");
                int horas = int.Parse(Console.ReadLine());

                ContratoHora contrato = new ContratoHora(data, valorHora, horas);
                funcionario.AdicionarContrato(contrato);
            }

            Console.WriteLine("Informe o mês e ano para calcular o ganho: MM/AAAA");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Departamento: " + funcionario.Departamento.Nome);
            Console.WriteLine("Salario do mes " + mesAno + ": " + funcionario.Salario(ano, mes));


        }
    }
}
