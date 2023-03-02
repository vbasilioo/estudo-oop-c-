using System;

namespace Program{
    class Aluno{
        public int idade { get; set; }
        public string nome { get; set; }
    }

    class Program{
        static void Main(string[] args){
            Aluno[] alunos = new Aluno[5];

            Console.WriteLine("Escolha um programa: \n" +
            "1- Diagrama de Chapin\n" +
            "2- Média da idade de alunos\n" +
            "3- Número par ou ímpar\n" +
            "4- Área do retângulo\n" + 
            "5- Idade em anos\n" +
            "6- Maior de 18 anos\n");
            int op = int.Parse(Console.ReadLine());

            switch(op){
                default:
                    Console.WriteLine("Nenhuma opção válida foi escolhida.");
                    break;
                case 1:
                    Console.WriteLine("Escolha um programa: " +
                    "1- A\n" +
                    "2- B\n" +
                    "3- C\n" +
                    "4- D\n" + 
                    "5- E\n" +
                    "6- F\n\n");
                    int opc = int.Parse(Console.ReadLine());
                    float numA, numB, numC, numX, numY, numZ;

                    switch(opc){
                        default:
                            Console.WriteLine("Nenhuma opção válida foi encontrada.");
                            break;
                        case 1:
                            numA = 10;
                            numB = 20;
                            Console.WriteLine(numB);
                            numB = 5;
                            Console.WriteLine(numB);
                            break;
                        case 2:
                            numA = 30;
                            numB = 20;
                            numC = numA+numB;
                            Console.WriteLine(numC);
                            numB = 10;
                            Console.WriteLine(numB + " " + numC);
                            numC = numA+numB;
                            Console.WriteLine(numA + " " + numB + " " + numC);
                            break;
                        case 3:
                            numA = 10;
                            numB = 20;
                            numC = numA;
                            numB = numC;
                            numA = numB;
                            Console.WriteLine(numA + " " + numB + " " + numC);
                            break;
                        case 4:
                            numA = 10;
                            numB = numA++;
                            numA = numB++;
                            numB = numA++;
                            Console.WriteLine(numA);
                            numA = numB++;
                            Console.WriteLine(numA + " " + numB);
                            break;
                        case 5:
                            numA = 10;
                            numB = 5;
                            numC = numA + numB;
                            numB = 20;
                            numA = 10;
                            Console.WriteLine(numA + " " + numB + " " + numC);
                            break;
                        case 6:
                            numX = 1;
                            numY = 2;
                            numZ = numY - numX;
                            Console.WriteLine(numZ);
                            numX = 5;
                            numY = numX + numZ;
                            Console.WriteLine(numX + " " + numY + " " + numZ);
                            break;
                    }

                    break;
                case 2:
                    float calc = 0;
                    for (int i = 0; i < alunos.Length; i++){
                        alunos[i] = new Aluno();
                        
                        Console.Write("Digite o nome do aluno {0}: ", i+1);
                        alunos[i].nome = Console.ReadLine();

                        Console.Write("Digite a idade do aluno {0}: ", i+1);
                        alunos[i].idade = int.Parse(Console.ReadLine());

                        calc += alunos[i].idade;
                    }

                    foreach (Aluno aluno in alunos){
                        Console.WriteLine("Nome do aluno: {0}", aluno.nome);
                        Console.WriteLine("idade do aluno: {0}", aluno.idade);
                    }

                    float media = calc / alunos.Length;
                    Console.WriteLine("\nMédia dos alunos: {0}", media);

                    break;
                case 3:
                    Console.Write("\nDigite um número: ");
                    int numero = int.Parse(Console.ReadLine());

                    if(numero%2==0) Console.WriteLine("O número {0} é par.", numero);
                    else Console.WriteLine("O número {0} é ímpar.", numero);

                    break;
                case 4:
                    Console.Write("\nInsira o número da base do retângulo: ");
                    float a = float.Parse(Console.ReadLine());
                    Console.Write("\nInsira o número da altura do retângulo: ");
                    float b = float.Parse(Console.ReadLine());
                    float area = b*a;
                    Console.Write("A área do retângulo é de {0}", area);

                    break;
                case 5:
                    Console.Write("\nDigite a idade em anos: ");
                    int anos = int.Parse(Console.ReadLine());

                    Console.Write("Digite a idade em meses: ");
                    int meses = int.Parse(Console.ReadLine());

                    Console.Write("Digite a idade em dias: ");
                    int dias = int.Parse(Console.ReadLine());

                    int idadeEmDias = anos * 365 + meses * 30 + dias;

                    Console.WriteLine("A idade em dias é: {0}", idadeEmDias);
                    break;
                case 6:
                    int maioresDezoito = 0;

                    for (int i = 0; i < 10; i++){
                        Console.Write("\nDigite a idade da {0}º pessoa: ", i+1);
                        int idade = int.Parse(Console.ReadLine());

                        if (idade > 18) maioresDezoito++;
                    }

                    Console.WriteLine("\nO número de pessoas com 18 anos ou mais é: {0}", maioresDezoito);
                    break;
            }
        }
    }
}