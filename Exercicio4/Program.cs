using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            /*
            fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestre de uma disciplina anual.
            Em seguida, mostrar a nota final que o aluno obteve no ano juntamente com um texto explicativo.
            Caso a nota final do aluno seja inferior a 60.00, mostrar mensagem “REPROVADO”, conforme exemplos.
            todos os valores devem ter uma casa decimal.
            ex = "NOTA FINAL = (VALOR DAS NOTAS)
            em caso de reprovação:
                 "NOTA FINAL = (VALOR DAS NOTAS
                 "REPROVADO"
            */

            double nota1, nota2, soma;

            nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            soma = nota1 + nota2;


            Console.WriteLine("NOTA FINAL = " + soma.ToString("F1",CultureInfo.InvariantCulture));

            if (soma < 60.0 )
            {
                Console.WriteLine("REPROVADO!");
            }

            Console.ReadLine();


        }
    }
}
