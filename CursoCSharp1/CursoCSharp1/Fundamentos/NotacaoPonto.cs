using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp1.Fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, "World!");
            Console.WriteLine(saudacao);

            string valorImportante = null;
            Console.WriteLine(valorImportante.Length);
    }
    }
}

