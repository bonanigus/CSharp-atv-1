using System;

namespace AgeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            // Solicita ao usuário que digite a idade do primeiro aluno
            Console.WriteLine("Digite a idade do primeiro aluno:");
            int age1 = int.Parse(Console.ReadLine()); // Converte o texto digitado em número inteiro

            // Solicita ao usuário que digite a idade do segundo aluno
            Console.WriteLine("Digite a idade do segundo aluno:");
            int age2 = int.Parse(Console.ReadLine()); // Converte o texto digitado em número inteiro

            // Calcula a diferença absoluta entre as idades
            int diferenca = Math.Abs(age1 - age2);

            // Comparação de idade
            // Se a idade do primeiro aluno for maior que a do segundo:
            if (age1 > age2)
            {
                Console.WriteLine($"O primeiro aluno é mais velho do que o segundo aluno por {diferenca} ano(s).");
            }
            // Caso contrário, se a idade do segundo aluno for maior que a do primeiro:
            else if (age2 > age1)
            {
                Console.WriteLine($"O segundo aluno é mais velho do que o primeiro aluno por {diferenca} ano(s).");
            }
            // Se nenhuma das condições acima for verdadeira, significa que as idades são iguais:
            else
            {
                Console.WriteLine("Ambos os alunos têm a mesma idade.");
            }

            // Saída final
            // Mantém o console aberto até o usuário pressionar uma tecla.
            // Isso evita que o programa feche imediatamente após mostrar o resultado.
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
