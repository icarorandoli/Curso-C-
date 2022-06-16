using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp1.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia 1 define o tipo da variavel

            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);

            // tipos internos

            bool estaChovendo = true;

            Console.WriteLine("esta chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            int menorValor = int.MinValue; //Mais usado dos inteiros
            Console.WriteLine("Menor int " + menorValor);

            uint populacaoBrasileira = 207_600_00; //nao é obrigado a colocar o _
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;

            ulong populacaoMundial = 7_600_000_00;
            Console.WriteLine("Populãção munfial " + populacaoMundial);
            // double é o dobro do float 
            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador " + precoComputador);

            double valorDeMercadoDaApple = 1000000000; // esse cod é o mais usado no mundo real DOUBLE
            Console.WriteLine("Valor Apple" + valorDeMercadoDaApple);


            decimal DistanciaEntreEstrelas = 2000000000000;
            Console.WriteLine("Distancia entre Estrelas "+ DistanciaEntreEstrelas);


            char letra = 'b';
            Console.WriteLine("Letra "+ letra);

            string texto = "Seja Bem Vindo";
               Console.WriteLine("Seja Bem Vindo " + texto);


        }
    }
}
