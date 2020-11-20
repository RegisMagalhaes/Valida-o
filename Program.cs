using System;

namespace Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 - Faça um programa que leia e valide as seguintes informações:
            //1. Nome: diferente de vazio;
            //2. Idade: entre 0 e 150;
            //3. Salário: maior que zero;
            //4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

            string nome;
            int idade;
            double salario;
            char estadoCivil;

            do
            {
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
            }while(nome == "" || nome == " ");

            do
            {
                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
            }while(idade <= 0 || idade > 150);

            do
            {
                Console.WriteLine("Digite o seu estado civil: 's' (solteiro) 'c' (casado) 'v'(viúvo) 'd' (divorceado)");
                string estado = Console.ReadLine();
                estadoCivil = estado.ToCharArray()[0];
            }while(estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd');

            Console.WriteLine("Valores aceitos");

        }
    }
}
