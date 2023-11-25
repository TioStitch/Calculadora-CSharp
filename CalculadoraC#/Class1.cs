using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraC_ {
    internal class Class1 {

        static void Main(string[] args) {

            Console.WriteLine("Por favor, insira o primeiro número:");
            String s = Console.ReadLine();
            int i = int.Parse(s);

            Console.WriteLine("Primeiro número escolhido:" + i);

            Console.WriteLine("Por favor, insira o segundo número:");
            String s2 = Console.ReadLine();
            int i2 = int.Parse(s2);

            Console.WriteLine("Segundo número escolhido:" + i2);

            Console.WriteLine("Agora escolha um símbolo de operação:");
            Console.WriteLine("+ - / * %");
            String s3 = Console.ReadLine();

            int i3 = 0;
            switch (s3) {
                case "+":
                    i3 = i + i2;
                    break;
                case "-":
                    i3 = i - i2;
                    break;
                case "/":
                    i3 = i / i2;
                    break;
                case "*":
                    i3 = i * i2;
                    break;
                case "%":
                    i3 = i % i2;
                    break;
            }

            Console.WriteLine(i3);

            Console.WriteLine("Digite 'Fechar' ou outro...");
            String s4 = Console.ReadLine();
        }
    }
}
