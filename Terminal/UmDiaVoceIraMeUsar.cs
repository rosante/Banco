using System;
using Dados;
using Util;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            int pfoupj =0;
            while (pfoupj == 0){
            Console.Write("Digite:\n1- Pessoa Física\n2- Pessoa Jurídica");
            pfoupj = Int32.Parse(Console.ReadLine());
            switch (pfoupj){
                // ###################### Caso for PF ######################
                case 1:
                    Console.Write("Digite seu CPF: ");
                    string ucpf;
                    ucpf = Console.ReadLine();
                    VerificaCPF verifcpf = new VerificaCPF();
                    verifcpf.Cpf = ucpf;
                    while (verifcpf.Verificar() == false){
                        Console.Clear();
                        Console.WriteLine("CPF Inválido!");
                        Console.Write("Digite seu CPF: ");
                        ucpf = Console.ReadLine();
                        verifcpf.Cpf = ucpf;
                    }
                    int saqueoudeposito=0;
                    Conta uconta = new Conta();
                    Console.Write("Digite:\n1- Depósito\n2- Saque ");
                    switch (saqueoudeposito){
                        case 1:
                            Console.Write("Deposite um valor: ");
                            uconta.Depositar(Double.Parse(Console.ReadLine()));
                            Console.WriteLine("Seu saldo é: "+ uconta.Saldo);
                            Console.Write("Digite Enter para sair ");
                            Console.ReadLine();
                        break;
                        case 2:
                            Console.Write("Saque um valor: ");
                            uconta.Sacar(Double.Parse(Console.ReadLine()));
                            Console.WriteLine("Seu saldo é: "+ uconta.Saldo);
                            Console.Write("Digite Enter para sair ");
                            Console.ReadLine();
                        break;
                        default:
                            Console.WriteLine("Opção Inválida! Saindo....");
                            System.Threading.Thread.Sleep(1000);
                        break;
                    }
                break;
                //####################### Caso for PJ #########################
                case 2:
                break;
                default:
                break;
            }
            Console.Write("Digite seu CPF: ");
            string cpf;
            cpf = Console.ReadLine();
            VerificaCPF vcpf = new VerificaCPF();
            vcpf.Cpf = cpf;
            while (vcpf.Verificar() == false){
                Console.Clear();
                Console.WriteLine("CPF Inválido!");
                Console.Write("Digite seu CPF: ");
                cpf = Console.ReadLine();
                vcpf.Cpf = cpf;
            }            
            Conta conta = new Conta();
            Console.Write("Deposite um valor: ");
            conta.Depositar(Double.Parse(Console.ReadLine()));
            Console.WriteLine("Seu saldo é: "+ conta.Saldo);
            Console.ReadLine();

            }
        }
    }
}
