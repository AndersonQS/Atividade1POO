using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Atividade1
{
    class Exercicios
    {
       static string reverseString(string texto)
        {
            char[] arrChar = texto.ToCharArray();
            Array.Reverse(arrChar);
            string textoinv = new String(arrChar);

            return textoinv;
        }
        static void Exerciocio1()
        {
            int n;
            string opt = "sim";

            while (opt != "nao")
            {

                Console.WriteLine("Insira um valor : ");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine("O valor inserido eh par !");
                }
                else
                {
                    Console.WriteLine("O valor inserido eh impar!");
                }

                Console.WriteLine("Deseja continuar: ");
                opt = Console.ReadLine();
            }
        }
        static void Exercicio2()
        { 
            string texto;
            Console.WriteLine("DIgite o texto  ser invertido");
            texto = (Console.ReadLine());
            Console.WriteLine(texto);
            Console.WriteLine(reverseString(texto));
            Console.ReadKey();

           
        }
        static void Exercicio6()
        {
            Console.WriteLine("DIgite uma frase");
            string frase = Console.ReadLine();
            char[] frasemod = frase.ToCharArray();
            for (int i = 0; i < frase.Length;i++)
            {
                if(frasemod[i] == 'A'|| frasemod[i] == 'a')
                {
                    frasemod[i] = '&';
                }
            }
            frase = new String(frasemod);
            Console.WriteLine(frase);
            Console.ReadKey();
          
        }
        static void Exercicio7()
        {
            double salario;
            Console.WriteLine("digite o salario");
            salario = double.Parse(Console.ReadLine());
            if(salario < 1700)
            {
                salario += 300;
            }
            else
            {
                salario += 200;
            }
            Console.WriteLine("Salario reajustado : " + salario);
            Console.ReadKey();
        }
        static void Exercicio8()
        {
            string nome, rg, email,telefone;
            Stream escreve = File.Open("arquivo.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(escreve);
            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Rg: ");
            rg = Console.ReadLine();
            Console.WriteLine("Email: ");
            email = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            telefone = Console.ReadLine();

            escritor.WriteLine(nome);
            escritor.WriteLine(rg);
            escritor.WriteLine(email);
            escritor.WriteLine(telefone);

            escritor.Close();
            escreve = File.Open("arquivo.txt", FileMode.Open);
            StreamReader Leitor = new StreamReader(escreve);

            Console.WriteLine("Nome: " + Leitor.ReadLine());
            Console.WriteLine("Rg: " + Leitor.ReadLine());
            Console.WriteLine("Email: " + Leitor.ReadLine());
            Console.WriteLine("Telefone: " + Leitor.ReadLine());
            Console.ReadKey();

            Leitor.Close();
            escritor.Close();
        }
        static void Exercicio3()
        {
                double numero1, numero2, resultado = 0;
                Char operacao;

                Console.WriteLine("Digite a operação: ");
                operacao = Char.Parse(Console.ReadLine());

                Console.WriteLine("Digite o primeiro número: ");
                numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                numero2 = double.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case '+':
                        resultado = numero1 + numero2;
                        break;
                    case '-':
                        resultado = numero1 - numero2;
                        break;
                    case '*':
                        resultado = numero1 * numero2;
                        break;
                    case '/':
                        resultado = numero1 / numero2;
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Total = " + resultado);
            Console.ReadKey();

            }
        static void Exercicio4()
        {
             int idade;

            Console.WriteLine("Qual a sua idade ? ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Permissão conssedida");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Sem permissão ");
            }
            Console.ReadKey();
        }
        static void Exercicio5()
        {
            String nome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Olá meu nome é: { " + nome + " }");

            Console.ReadKey();
        }
        static void Exercicio9()
        {
        
                Stream arq = File.Open("imc.txt", FileMode.OpenOrCreate);
                StreamReader ler = new StreamReader(arq);
                StreamWriter esc = new StreamWriter(arq);

                Console.Write("Digite 1 para cadastrar novo IMC ou 2 para verificar os existentes: ");
                string op = Console.ReadLine();

                if (op.Equals("1"))
                {
                    ler.ReadToEnd();
                    Console.Write("Digite seu nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite sua idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.Write("Digite sua altura: ");
                    double altura = double.Parse(Console.ReadLine());
                    Console.Write("Digite seu peso: ");
                    double peso = double.Parse(Console.ReadLine());

                    esc.WriteLine(nome + ";" + idade + ";" + (peso / (altura * altura)));
                }
                else
                {
                    string[] nomes = new string[1000];
                    int[] idades = new int[1000];
                    double[] imcs = new double[1000];
                    int cont = 0;

                    string linha = ler.ReadLine();
                    do
                    {
                        string[] pessoa = linha.Split(';', 3, StringSplitOptions.None);
                        string nome = new String(pessoa[0]);
                        int idade = int.Parse(pessoa[1]);
                        double imc = double.Parse(pessoa[2]);

                        nomes[cont] = nome;
                        idades[cont] = idade;
                        imcs[cont] = imc;

                        cont++;
                        linha = ler.ReadLine();
                    } while (linha != null);

                    Console.Write("Informe o nome da pessoa: ");
                    string nomePesq = Console.ReadLine();

                    for (int i = 0; i < cont; i++)
                    {
                        if (nomes[i].Equals(nomePesq))
                        {
                            Console.WriteLine("O IMC de " + nomePesq + " é " + imcs[i]);
                            break;
                        }
                    }
                }

                esc.Close();
                ler.Close();
                arq.Close();
            }
        static void Exercicio10()
        {

            double Altura;
            int Matricula;

            List<double> altura = new List<double>();
            List<int> matricula = new List<int>();

            if (Matricula.Count >= 2)
            {

                Console.WriteLine("Digite a matricula do aluno:");
                Matricula = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do aluno:");
                Altura = double.Parse(Console.ReadLine());

            }
            altura.Add(Altura);
            matricula.Add(Matricula);


            int Maior = 0;
            double maior = altura[1];

            foreach (var alt in altura)
            {
                if (alt > maior)
                {
                    maior = alt;
                }
            }

            Maior = altura.IndexOf(Maior);

            Console.WriteLine("Matricula com maior altura:" + matricula[Maior]);
        }
        static void Main(String[] args)
        {
            Exercicio10();

        }
    }
}

