namespace Exercicio
{
    public class Conversor
    {
        public static float ValorDolar { get; set; } 
        public static float ValorEuro { get; set; }
        public static float EuroToReal( float valor ){
            float ValorRS1 = ValorEuro * valor;
            return ValorRS1;
        }
        public static float RealToEuro( float valor ){
            float ValorEU = valor / ValorEuro;
            return ValorEU;
        }

        public static float DolarToReal( float valor ){
            float ValorUS = ValorDolar * valor;
            return ValorUS;
        }
        public static float RealToDolar( float valor ){
            float ValorRS2 = valor / ValorDolar;
            return ValorRS2;
        }

        
    }
}