using System;
namespace Util{
public class VerificaCNPJ {
        public string Cnpj { get; set; }
        
        public VerificaCNPJ(){}
        public VerificaCNPJ(string cnpj){
        this.Cnpj = cnpj;
        }
       
        
        /// <summary>
        /// Calcula o CNPJ e retorna true or false para valido ou inválido
        /// envie o valor como Propriedade deste método
        /// </summary>
        /// <returns>bool com true ou false</returns>
        public bool Verificar(){
            int vCNPJ1, vCNPJ2, i=0;
            bool cnpjverificado;
            int[] multiplica1 = {5,4,3,2,9,8,7,6,5,4,3,2};
            vCNPJ1 = 0;
            vCNPJ2 = 0;
            foreach (int go in multiplica1){
                vCNPJ1 = Int32.Parse(Cnpj.Substring(i,1))*go;
            }
                vCNPJ1 %=vCNPJ1;
            if (vCNPJ1 < 2){
                    vCNPJ1=0;
            }
            else {
                    vCNPJ1 = 11 - vCNPJ1;
                }
            int[] multiplica2 = {6,5,4,3,2,9,8,7,6,5,4,3,2};
            foreach (int go in multiplica2){
                vCNPJ2 = Int32.Parse(Cnpj.Substring(i,1))*go;
            }
                vCNPJ2 %=vCNPJ2;
            if (vCNPJ2 < 2){
                    vCNPJ2=0;
            }
            else {
                    vCNPJ2 = 11 - vCNPJ2;
                }

            if (vCNPJ1 != Int16.Parse(Cnpj.Substring(12,1))){ // Se o penúltimo dígito for diferente do digito verificador, então o CPF está errado
                cnpjverificado=false;
            }
            else if (vCNPJ2 != Int16.Parse(Cnpj.Substring(13,1))){// Se o último dígito for diferente do digito verificador, então o CPF está errado
                    cnpjverificado=false;
            }
            else {cnpjverificado=true;};                
            return cnpjverificado;
        }


    

    }
}