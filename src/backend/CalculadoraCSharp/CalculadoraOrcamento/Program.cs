namespace CalculadoraOrcamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Calculo de Orçamento - Seriana.com");
            Console.WriteLine($"Digite o tipo do produto; \n 1 - Wobller \n 2 - Testeira \n 3 - Outros \n 0 - Sair");
            int opcao = int.Parse(Console.ReadLine());
            string servico, cliente;
            int os;
            int quantidade;
            double materiaPrimaPreco, producaoPreco, terceirosPreco;
            double margemLucro;
            var mu = 0.20;
            var ca = 0.05;
            var cv = 0.03;
            var ci = 0.02;
            var ce = 0.03;
            var nf = 0.15;
            var tj = 0.03;
            var somaporcentagem = mu + ca + cv + ci + ce + nf + tj;
            double impostos;
            double juros;
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Nome do Cliente:");
                    cliente = Console.ReadLine();
                    Console.WriteLine("Serviço:");
                    servico = Console.ReadLine();
                    Console.WriteLine("Número da OS:");
                    os = int.Parse(Console.ReadLine());
                    Console.WriteLine("Quantidade:");
                    quantidade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Materia Prima - Preço:");
                    materiaPrimaPreco = double.Parse(Console.ReadLine());
                    Console.WriteLine("Produção - Preço:");
                    producaoPreco = double.Parse(Console.ReadLine());
                    Console.WriteLine("Terceiros - Preço:");
                    terceirosPreco = double.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.Write("------------------------------------------------------------------------------\n");
                    double PrecoCusto = materiaPrimaPreco + producaoPreco + terceirosPreco;
                    Console.WriteLine($"Preço de Custo: {PrecoCusto}");
                    Console.Write("------------------------------------------------------------------------------\n");
                    var indice = 1 - somaporcentagem;
                    Console.WriteLine($"Indice de Venda: {indice} ");

                    break;
                case 2:
                    Console.WriteLine("Testeira selecionada.");
                    break;
                case 3:
                    Console.WriteLine("Outros selecionado.");
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
             
            }
           


            Console.ReadLine();
        }
    }
}
