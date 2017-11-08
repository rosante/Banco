using System;
using System.IO;
using Util;
using Dados;
namespace Terminal
{
    public class CadastroContaPJ
    {
        public void CadastroTerminal()
        {
            Console.Write("Digite seu CNPJ: ");
                    string ucnpj;
                    ucnpj = Console.ReadLine();
                    VerificaCNPJ verifcnpj = new VerificaCNPJ();
                    verifcnpj.Cnpj = ucnpj;
                    while (verifcnpj.Verificar() == false){
                        Console.Clear();
                        Console.WriteLine("CNPJ Inválido!");
                        Console.Write("Digite seu CNPJ: ");
                        ucnpj = Console.ReadLine();
                        verifcnpj.Cnpj = ucnpj;
                    }
            Empresa empresa = new Empresa();
            empresa.CNPJ = ucnpj;    
            Console.Write("Digite a Razão Social: ");
            empresa.RazaoSocial = Console.ReadLine();
            Console.Write("Digite a Data de Abertura (DD/MM/AAAA): ");
            try{
            empresa.Abertura = DateTime.Parse(Console.ReadLine());
            }
            catch(Exception e){
                Console.WriteLine("Quem mandou digitar formato inválido!");
                System.Threading.Thread.Sleep(1000);
                int i=0;
                while (i < 1000){
                    Console.WriteLine("*");
                    System.Threading.Thread.Sleep(100);
                    Console.WriteLine("\t*");
                    System.Threading.Thread.Sleep(100);
                    Console.WriteLine("\t\t*");
                    System.Threading.Thread.Sleep(100);
                    Console.WriteLine("\t\t\t*");
                    System.Threading.Thread.Sleep(100);
                    Console.WriteLine("\t\t\t\t*");
                    System.Threading.Thread.Sleep(100);
                    Console.WriteLine("\t\t\t*");
                    System.Threading.Thread.Sleep(100);
                    Console.WriteLine("\t\t*");
                    System.Threading.Thread.Sleep(100);
                    Console.WriteLine("\t*");
                    System.Threading.Thread.Sleep(100);
                }
            }
            finally{
                Console.Write("nada");
            }
            ContaPJ cpj = new ContaPJ();
            Console.Write("Digite a Agencia: ");
            cpj.Agencia = Console.ReadLine();
            Console.Write("Digite o número da Conta: ");
            cpj.Numero = Console.ReadLine();
                  
        }
        public string SalvaConta()
        {
            string msg=null;
            StreamWriter wr = null;
            try{
            wr = new StreamWriter("Contas.csv", true);
            Empresa empresa = new Empresa();
            ContaPJ cpj = new ContaPJ();
            wr.WriteLine(empresa.RazaoSocial+";"+empresa.CNPJ+";"+empresa.Abertura+";"+cpj.Agencia+";"+cpj.Numero+";"+cpj.Saldo);
            }
            catch(Exception e){
                msg = "Ocorreu um erro ao Salvar sua conta.\nErro: "+e.Message;
            }
            finally{
                wr.Close();
                msg = "Conta Salva com Sucesso!";
            }
            return msg;
        } 
    }
}