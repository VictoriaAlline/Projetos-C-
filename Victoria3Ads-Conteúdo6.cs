using System;
using System.Threading;

namespace Lista4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite um número para cada exercício (1, 2, 3, 4), digite 0 para encerrar");
                numero = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (numero)
                {

                    case 1:
                        Console.WriteLine("Para calcular a fórmula de Bhaskara digite o número A");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite B");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite c");
                        int c = int.Parse(Console.ReadLine());
                        Console.Clear();

                        int delta;
                        double x1, x2;

                        delta = (int)Math.Pow(b, 2) - (4 * (a * c));

                        x1 = (-b + (Math.Sqrt(delta))) / (2 * a);
                        x2 = (-b - (Math.Sqrt(delta))) / (2 * a);

                        Console.WriteLine("Delta = {0}", delta);
                        Console.WriteLine("Bhaskara = {0}, {1}", x1, x2);

                        Console.ReadKey(); break;

                    case 2:
                        Console.WriteLine("Digite seu Nome");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite seu Sobrenome");
                        string sobrenome = Console.ReadLine();
                        Console.WriteLine("Qual sua Orientaçõa Sexual? M ou F");
                        char orientacao = char.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o Horário?");
                        int horario = int.Parse(Console.ReadLine());
                        Console.Clear();

                        string honorifico;
                        if (orientacao == 'M')
                        {
                            honorifico = "Sr.";
                        }
                        else
                        {
                            honorifico = "Sra.";
                        }
                        if (horario >= 0 & horario <= 12)
                        {
                            Console.WriteLine("Bom Dia {0}{1} {2}!", honorifico, nome, sobrenome);
                        }
                        else if (horario >= 13 & horario <= 17)
                        {
                            Console.WriteLine("Boa Tarde {0}!", nome);
                        }
                        else
                        {
                            Console.WriteLine("Boa Noite {0}{1}!", honorifico, sobrenome);
                        }
                        Console.ReadKey(); break;

                    case 3:
                        int matricula, horas;
                        float porHora, salario;

                        Console.Write("Número de Matrícula: ");
                        matricula = int.Parse(Console.ReadLine());
                        Console.Write("Horas Trabalhadas: ");
                        horas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Quanto Recebe por hora?");
                        porHora = float.Parse(Console.ReadLine());
                        Console.Clear();

                        salario = porHora * horas;
                        Console.WriteLine("Funcionário: {0}", matricula);
                        Console.WriteLine("Salário: {0}", salario.ToString("F2"));
                        Console.ReadKey(); break;

                    case 4:
                        do
                        {
                            double A, B, C, area;
                            Console.WriteLine("O que quer calcular? Área do Triângulo Retângulo(AT), Área do Círculo (AC), Área do Trapézio (ATr), Área do Quadrado (AQ), Área do retângulo (AR)");
                            Console.WriteLine("Para sair digite 0");
                            string letra = Console.ReadLine();
                            Console.Clear();

                            switch (letra)
                            {
                                case "AC":
                                    double pi = 3.14159;
                                    Console.WriteLine("Para calcular a Área do Círculo digite seu Raio");
                                    C = double.Parse(Console.ReadLine());
                                    area = pi * (double)Math.Pow(C, 2);
                                    Console.Clear();

                                    Console.WriteLine("Área do Círculo de Raio {0} é de: {1}", C, area.ToString("F2"));
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case "AT":
                                    Console.WriteLine("Para calcular a área do triângulo Retângulo digite a Base");
                                    A = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Agora digite a Altura do Triângulo Retângulo");
                                    C = double.Parse(Console.ReadLine());
                                    area = (A * C) / 2;
                                    Console.Clear();

                                    Console.WriteLine("Área do Triângulo Retângulo com Base de {0} e Altura de {1} é de: {2}", A, C, area);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case "ATr":
                                    Console.WriteLine("Para calcular a área do Trapézio digite a Primeira Base");
                                    A = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Agora digite a Segunda Base");
                                    B = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Por fim, digite a Altura do Trapézio");
                                    C = double.Parse(Console.ReadLine());
                                    area = (A + B) * (C / 2);
                                    Console.Clear();

                                    Console.WriteLine("A Área do trapézio com Bases {0} e {1}, com altura de {2} é de: {3}", A, B, C, area);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case "AQ":
                                    Console.WriteLine("Para calcular a Área do Quadrado digite Lado");
                                    B = double.Parse(Console.ReadLine());
                                    area = (double)Math.Pow(B, 2);
                                    Console.Clear();

                                    Console.WriteLine("A Área do Círculo que tem lado de {0} é de: {1}", B, area);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case "AR":
                                    Console.WriteLine("Para calcular a Área do Retângulo digite seu primeiro Lado");
                                    A = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Agora digite o Segundo Lado do Retângulo");
                                    B = double.Parse(Console.ReadLine());
                                    area = A * B;
                                    Console.Clear();

                                    Console.WriteLine("A Área do Retângulo que tem lado de {0} e {1} é de: {2}", A, B, area);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                default:
                                    Console.WriteLine("Voltando para programa principal");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        }
                        while (numero != 1);
                        Console.ReadKey(); break;
                }
            }
            while (numero != 0);
        }
    }
}