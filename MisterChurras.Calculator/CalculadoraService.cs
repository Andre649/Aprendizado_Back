namespace MisterChurras.Calculator
{
    public class CalculadoraService
    {
        // Nossas regras de negócio
        private const double MediaCarneAdulto = 0.4;
        private const double MediaCarneCrianca = 0.2;
        
        private const double MediaLinguicaAdulto = 0.2;
        private const double MediaLinguicaCrianca = 0.1;
        
        private const int MediaPaoAlhoAdulto = 2;
        private const int MediaPaoAlhoCrianca = 1;

        // O método devolve o "pacote" simplificado
        public ResultadoChurrasco Calcular(int numAdultos, int numCriancas)
        {
            ResultadoChurrasco resultado = new ResultadoChurrasco();

            resultado.TotalCarneKg = (numAdultos * MediaCarneAdulto) + (numCriancas * MediaCarneCrianca);
            resultado.TotalLinguicaKg = (numAdultos * MediaLinguicaAdulto) + (numCriancas * MediaLinguicaCrianca);
            resultado.TotalPaoDeAlhoUnid = (numAdultos * MediaPaoAlhoAdulto) + (numCriancas * MediaPaoAlhoCrianca);

            return resultado;
        }
    }
}