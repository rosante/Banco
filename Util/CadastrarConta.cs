using System.IO;
using System;
using Dados;
namespace Util
{
    public class CadastrarConta
    {
        public string SalvaContaPJ()
        {
            string msg=null;
            StreamWriter wr = null;
            if (new FileInfo("Contas.csv").Exists){
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
            else{
                try{
                wr = new StreamWriter("Contas.csv", true);
                Empresa empresa = new Empresa();
                ContaPJ cpj = new ContaPJ();
                wr.WriteLine("RAZAOSOCIAL/NOME;CNPJ/CPF;ABERTURA/NASCIMENTO/AGENCIA/CONTA/NUMEROCTA/SALDO/PF/PJ");
                wr.WriteLine(empresa.RazaoSocial+";"+empresa.CNPJ+";"+empresa.Abertura+";"+cpj.Agencia+";"+cpj.Numero+";"+cpj.Saldo+"0;1");
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
}