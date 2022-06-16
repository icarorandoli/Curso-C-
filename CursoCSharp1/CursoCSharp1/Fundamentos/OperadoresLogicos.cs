using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp1.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() {
            var ExecutouTrabalho1 = false;
            var ExecutouTrabalho2 = true;


            bool ComprouTv50 = ExecutouTrabalho1 && ExecutouTrabalho2;
            Console.WriteLine("Comprou Tv 50? {0}", ComprouTv50);

            var ComprouSorvete = ExecutouTrabalho1 || ExecutouTrabalho2;
            Console.WriteLine("Comprou Sorvete? {0}", ComprouSorvete);

            var ComprouTv32 = ExecutouTrabalho1 ^ ExecutouTrabalho2;
            Console.WriteLine("Comprou Tv 32? {0}", ComprouTv32);

            Console.WriteLine("Mais Saldavel? {0}", !ComprouSorvete);


        }
    }
}