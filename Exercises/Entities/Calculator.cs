using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Entities
{
    static class Calculator
    {
        public static void Media(double primeiraNota, double segundaNota, double terceiraNota)
        {
            if (!double.TryParse(Console.ReadLine(), out primeiraNota))
                throw new ArgumentException("Precisa ser um número");

            if (!double.TryParse(Console.ReadLine(), out segundaNota))
                throw new ArgumentException("Precisa ser um número");

            if (!double.TryParse(Console.ReadLine(), out terceiraNota))
                throw new ArgumentException("Precisa ser um número");

            var media = (primeiraNota + segundaNota + terceiraNota) / 3;

            if (media >= 7)
                Console.WriteLine("Parabéns! Aluno aprovado.");
            else
                Console.WriteLine("Aluno reprovado.");
        }

        public static bool VeficaParOuImpar(int num)
        {
            return num % 2 == 0;
        }

        public static void MaiorNumero(int num1, int num2)
        {
            if (num1 == num2)
                Console.WriteLine($"{num1} é igual a {num2}");

            else if (num1 > num2)
                Console.WriteLine($"{num1} é maior que {num2}");

            if (num1 < num2)
                Console.WriteLine($"{num1} é menor que {num2}");
        }

        public static void CalcularIMC(double peso, double altura)
        {
            var imc = peso / (altura * altura);

            if (imc < 18.5)
                Console.WriteLine("Abaixo do peso");

            else if (imc >= 18.5 && imc <= 25.9)
                Console.WriteLine("Peso normal");

            else if (imc >= 25 && imc <= 29.9)
                Console.WriteLine("Sobrepeso");

            else
                Console.WriteLine("Obesidade");
        }

        public static void Multiplos(int num1, int num2)
        {
            if (num1 % num2 == 0)
                Console.WriteLine("São multiplos um do outro");
            else
                Console.WriteLine("Não são multiplos");
        }

        public static void Desconto(double valor, int tipoPagamento)
        {
            if (tipoPagamento == 1)
            {
                valor -= (valor * 0.1);
                Console.WriteLine("Valor com desconto de 10%. R${0}", valor);
            }
            else
            {
                Console.WriteLine("Valor sem Desconto. R${0}", valor);
            }
        }

        public static void ClassificarTriangulo(double primeiroLado, double segundoLado, double terceiroLado)
        {
            if (primeiroLado == segundoLado && segundoLado == terceiroLado)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (primeiroLado == segundoLado
                || primeiroLado == terceiroLado
                || segundoLado == terceiroLado)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }

        public static void MediaPonderada(double nota1, int peso1, 
                                          double nota2, int peso2,
                                          double nota3, int peso3)
        {
            var media = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3)) / (peso1 + peso2 + peso3);

            switch (media)
            {
                case >= 9:
                    Console.WriteLine("Você recebeu A");
                    break;

                case >= 7:
                    Console.WriteLine("Você recebeu B");
                    break;

                case >= 5:
                    Console.WriteLine("Você recebeu C");
                    break;

                case < 5:
                    Console.WriteLine("Você recebeu D");
                    break;
            }
        }
    }
}
