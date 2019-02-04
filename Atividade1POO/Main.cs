using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1POO
{
    class Principal
    {
        public static void Main( String [] args) {

            while (true)
            {
                Console.WriteLine("Digite a opcao desejada.");
                Console.WriteLine("1 - Banco");
                Console.WriteLine("2 - Agencia");
                Console.WriteLine("3 - Conta");
                Console.WriteLine("0 - Sair");

                int op = int.Parse(Console.ReadLine());
                Console.WriteLine(op);
                if (op == 0)
                {
                    break;
                }

                if (op == 1)
                {
                    Console.WriteLine("Banco.");
                    Console.WriteLine("1 - Criar");
                    Console.WriteLine("2 - Remover");
                    Console.WriteLine("3 - Buscar");
                    Console.WriteLine("4 - Adicionar Agencias");
                    Console.WriteLine("0 - Voltar");
                    op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        Listas.AdicionarBanco();
                    } else if (op == 2)
                    {
                        Console.WriteLine("Digite o nome do banco.");
                        string nome = Console.ReadLine();
                        Listas.RemoverBanco(nome);
                    } else if (op == 3)
                    {
                        Console.WriteLine("Digite o nome do banco.");
                        string nome = Console.ReadLine();
                        Banco b = Listas.BuscaBanco(nome);
                        if (b == null)
                        {
                            Console.WriteLine("Banco nao encontrado.");
                        } else
                        {
                            Console.WriteLine("Nome do banco: " + b.Nome);
                            Console.WriteLine("Agencias:");
                            for (int i = 0; i < b.ListaAgencia.Count; i++)
                            {
                                Console.WriteLine(Listas.BuscaAgencia(b.ListaAgencia[i]).NumeroAgencia);
                            }
                        }
                    } else if (op == 4)
                    {
                        Console.WriteLine("Digite o nome do banco.");
                        string banco = Console.ReadLine();
                        Banco b = Listas.BuscaBanco(banco);
                        if (b == null)
                        {
                            Console.WriteLine("Banco nao encontrado.");
                        } else
                        {
                            Console.WriteLine("Digite o numero da agencia.");
                            string agencia = Console.ReadLine();
                            Agencia a = Listas.BuscaAgencia(agencia);
                            if (a != null)
                            {
                                b.AdicionarAgencia(a.NumeroAgencia);
                            }
                            else
                            {
                                Console.WriteLine("Agencia não encontrada.");
                            }
                        }
                    } else if (op == 0)
                    {
                        continue;
                    }
                }
                else if (op == 2)
                {
                    Console.WriteLine("Agencia.");
                    Console.WriteLine("1 - Criar");
                    Console.WriteLine("2 - Remover");
                    Console.WriteLine("3 - Buscar");
                    Console.WriteLine("4 - Adicionar Conta");
                    Console.WriteLine("0 - Voltar");
                    op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        Listas.AdicionarAgencia();
                    }
                    else if (op == 2)
                    {
                        Console.WriteLine("Digite o numero da agencia.");
                        string nome = Console.ReadLine();
                        Listas.RemoverBanco(nome);
                    }
                    else if (op == 3)
                    {
                        Console.WriteLine("Digite o numero da agencia.");
                        string agencia = Console.ReadLine();
                        Agencia a = Listas.BuscaAgencia(agencia);
                        if (a == null)
                        {
                            Console.WriteLine("Agencia nao encontrada.");
                        } else
                        {
                            Console.WriteLine("Numero da agencia: " + a.NumeroAgencia);
                            Console.WriteLine("Contas:");
                            Console.WriteLine(a.ListaConta.Count);
                            foreach (String conta in a.ListaConta)
                            {
                                Console.WriteLine("Identificador: " + Listas.BuscaConta(conta).ID + " | Saldo: " + Listas.BuscaConta(conta).Saldo);
                            }
                        }
                    } else if (op == 4)
                    {
                        Console.WriteLine("Digite o numero da agencia.");
                        string agencia = Console.ReadLine();
                        Agencia a = Listas.BuscaAgencia(agencia);
                        if (a == null)
                        {
                            Console.WriteLine("Agencia nao encontrada.");
                        }
                        else
                        {
                            Console.WriteLine("Digite o identificador da conta.");
                            string conta = Console.ReadLine();
                            Conta c = Listas.BuscaConta(conta);
                            if (c != null)
                            {
                                a.AdicionarConta(c.ID);
                            }
                            else
                            {
                                Console.WriteLine("Conta não encontrada.");
                            }
                        }
                    } else if (op == 0)
                    {
                        continue;
                    }
                }
                else if (op == 3)
                {
                    Console.WriteLine("Conta.");
                    Console.WriteLine("1 - Criar");
                    Console.WriteLine("2 - Remover");
                    Console.WriteLine("3 - Buscar");
                    Console.WriteLine("4 - Solicitar");
                    Console.WriteLine("0 - Voltar");

                    op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        Conta c = Listas.AdicionarConta();
                        if (c != null)
                        {
                            Listas.AdicionarCliente(c);
                        }
                    } else if (op == 2)
                    {
                        Console.WriteLine("Digite o nome da conta.");
                        string conta = Console.ReadLine();
                        Listas.RemoverConta(conta);
                    } else if (op == 3)
                    {
                        Console.WriteLine("Digite o identificador da conta.");
                        string conta = Console.ReadLine();
                        Conta c = Listas.BuscaConta(conta);
                        if (c == null)
                        {
                            Console.WriteLine("Conta nao encontrada.");
                        } else
                        {
                            Console.WriteLine("ID: " + c.ID);
                            Console.WriteLine("Saldo: " + c.Saldo);
                            Console.WriteLine("Titular: " + c.Titular);
                        }
                    }
                    else if (op == 4)
                    {   
                        ClienteSolicitacao.FazerSolicitacao();
                    }
                    else if (op == 0)
                    {
                        continue;
                    }
                } 
               
            }
        }
    }
}
