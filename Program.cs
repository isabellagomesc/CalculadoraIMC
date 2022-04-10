using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Ola---\nQual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é sua altura em metros? Exemplo:1,58 ");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual é seu peso em kg? Exemplo:58,3 ");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("-----Processando-----\n{0} sua altura é --> {1}\ne seu peso é --> {2}\n", nome, altura, peso);
            Console.WriteLine("-----------------------\nSendo assim seu IMC é -->{0}\n-------------------", imc);

            if (imc < 17)
            {
               Console.WriteLine("Muito abaixo do peso");
            }

            if (imc >= 17 && imc <= 18.49)
            {
               Console.WriteLine("Abaixo do peso");
            }

            if(imc >= 18.50 && imc <= 24.99)
            {
               Console.WriteLine("Peso normal");
            }

            if(imc >= 25 && imc <= 29.99)
            {
               Console.WriteLine("Acima do peso");
            }       

            if(imc >= 30 && imc <= 34.99)
            {
                Console.WriteLine("Obesidade I");
            }

            if(imc >= 35 && imc <= 39.99)
            {
               Console.WriteLine("Obesidade II - severa");
            }

            if(imc > 40)
            {
               Console.WriteLine("Obesidade III - mórbida");
            }
                Console.WriteLine("Valor inválido");
            }
        }
    }
}