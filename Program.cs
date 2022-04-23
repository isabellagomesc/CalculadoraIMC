using System;

namespace CalculadoraIMC
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("---Ola---\nQual seu nome?");
         String nome = Console.ReadLine();

         Console.WriteLine("Qual é sua altura em metros? Exemplo:1,58 ");
         float altura = Convert.ToSingle(Console.ReadLine());

         Console.WriteLine("Qual é seu peso em kg? Exemplo:58,3 ");
         float peso = Convert.ToSingle(Console.ReadLine());

         double imc = peso / (altura * altura);

         Console.WriteLine("-----Processando-----\n{0} sua altura é --> {1}\ne seu peso é --> {2}", nome, altura, peso);
         Console.WriteLine("-----------------------\nSendo assim seu IMC é-->{0}\n-------------------", imc);
         Console.WriteLine("\n--------Peso ideial---------\n" + PesoIdeal(altura, peso));
         Console.WriteLine("-----------------------\n");

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
      }
         public static String PesoIdeal(float altura, float peso)
         {
            float imc = peso / (altura * altura);
            double PerderPeso = peso-(24.9*(altura*altura));
            double GanharPeso = (18.5*(altura*altura))-peso;
            Console.WriteLine("" + GanharPeso);
               if(imc < 18.5)
               {
                  return "Você vai precisar ganhar-->" + GanharPeso + " para chegar ao peso ideal";
               }
               if(imc > 24.99)
               {
                  return "Você vai precisa perder-->" + PerderPeso + " para chegar ao peso ideal";
              }
         return "-----------------------\nVocê está com o peso ideal!!!!";
         }
   }
}