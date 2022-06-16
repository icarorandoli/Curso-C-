﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp1.Fundamentos {
    class FormatandoNumero 
        {
        public static void Executar() {

            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo culture = new CultureInfo("pt-Br");
            Console.WriteLine(valor.ToString("C0", culture));

            int inteiro = 256;
            Console.WriteLine();

        }
    }
}
