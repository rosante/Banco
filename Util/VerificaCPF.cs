using System;

namespace Util
{
    public class VerificaCPF
    {
        public string Cpf { get; set; }
        public VerificaCPF(){}
        public VerificaCPF(string cpf){
        this.Cpf = cpf;
        }

        /// <summary>
        /// Verifica um int CPF somente números e retorna se é válido.!-- Primeiro envie o CPF como propriedade da Classe e depois execute o Verificar
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns>um bool true or false</returns>
        public bool Verificar (){
               int vCPF1=0, vCPF2=0, x=0;
               bool msg;
               x=10;
               for (int i=0;i<9;i++){
                    vCPF1 = Int32.Parse(this.Cpf.Substring(i,1))*x+vCPF1;
                    x--;
               }
               vCPF1 = (vCPF1%11);
                    if (vCPF1 < 2){
                        vCPF1=0;
                    }
                    else{
                        vCPF1 = 11-vCPF1;
                    }
               x=11;
               for (int i=0; i < 10; i++ ){ 
                    vCPF2 = vCPF2 + Int32.Parse(this.Cpf.Substring(i,1)) * x; 
                    x--;
               }
               vCPF2 = (vCPF2%11);
                    if (vCPF2 < 2){
                        vCPF2=0;
                    }
                    else{
                        vCPF2 = 11-vCPF2;
                    }
                if (Int32.Parse(this.Cpf.Substring(9,1)) != vCPF1){
                    msg=false;
                }
                else if (Int32.Parse(this.Cpf.Substring(10,1)) != vCPF2){
                    msg=false;
                }
                else{
                    msg=true;
                }
                
            return msg;
        }
    

            
    }
}

