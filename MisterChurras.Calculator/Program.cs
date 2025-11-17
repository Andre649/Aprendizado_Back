namespace MisterChurras.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("--- MISTER CHURRAS NA ÁREA ---");
            Console.WriteLine("Vamos calcular seu kit braseiro essencial!");
            Console.WriteLine();

            // --- 1. Coletar Entradas ---
            int numAdultos = PedirNumero("Quantos mestres churrasqueiros (adultos)? ");
            int numCriancas = PedirNumero("E quantos aprendizes (crianças)? ");

            // --- 2. Chamar o Cérebro ---
            CalculadoraService servico = new CalculadoraService(); 
            ResultadoChurrasco kit = servico.Calcular(numAdultos, numCriancas);

            // --- 3. Exibir Resultado ---
            Console.WriteLine();
            Console.WriteLine("--- SEU KIT BRASEIRO ESSENCIAL ---");
            Console.WriteLine($"Carne: {kit.TotalCarneKg:F2} Kg");
            Console.WriteLine($"Linguiça: {kit.TotalLinguicaKg:F2} Kg");
            Console.WriteLine($"Pão de Alho: {kit.TotalPaoDeAlhoUnid} unidades");
            
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"O Brazeiro é para {numAdultos} mestres e {numCriancas} aprendizes.");
        }

        // Função de Ajuda (não mudou)
        static int PedirNumero(string mensagem)
        {
            int numero;
            Console.Write(mensagem);
            
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.WriteLine("Opa, valor inválido. Apenas números positivos.");
                Console.Write("Digite de novo: ");
            }
            return numero;
        }
    }
}