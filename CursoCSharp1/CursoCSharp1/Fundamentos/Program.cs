using System;
using System.Collections.Generic;
using CursoCSharp1;
using CursoCSharp1.Fundamentos;
using CursoCSharp1.API;
using CursoCSharp1.EstruturaDeControle;

namespace CursoCSharp1 {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes", VariaveisEConstantes.Executar},
                {"Inferencias", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando numeros - fundamentos", FormatandoNumero.Executar},
                {"Conversões - fundamentos", Conversoes.Executar},
                {"Operadores Aritimeticos - fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - fundamentos", OperadoresRelacionais.Executar},
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Operadores Lógicos - Usando API", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - fundamentos", OperadoresAtribuição.Executar},
                {"Estrutura If - Estrutura De Controle", EstruturaIf.Executar},
               // Estrutura de dados
                
                {"Estrutura  If Elsef - Estrutura De Controle", EstruturaIfElsef.Executar},
                {"Estrutura  Switch - Estrutura De Controle", EstruturaSwitch.Executar},
                {"Estrutura  While - Estrutura De Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura De Controle", EstruturaDoWhile.Executar},
               
            });

            central.SelecionarEExecutar();
        }
    }
    class Pessoa { }

}