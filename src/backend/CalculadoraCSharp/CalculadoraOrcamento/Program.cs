namespace CalculadoraOrcamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Calculo de Orçamento - Seriana.com");
            Console.WriteLine($"Digite o tipo do produto; \n 1 - Wobller \n 2 - Testeira \n 3 - Outros \n 0 - Sair");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Wobller selecionado.");
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
