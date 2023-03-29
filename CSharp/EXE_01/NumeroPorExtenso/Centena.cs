using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumeroPorExtenso
{
    public class Centena
 {
        public string CentenaPorExtenso(int numero)
        {
            string retorno = "";
            Unidade unidade = new Unidade();
            Dezena dezena = new Dezena();

            if( numero >= 100 && numero <= 199 )
            {
                if(numero == 100)
                    retorno = "Cem";
                if(numero >= 101 && numero <= 109) 
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "Cento e ";
                    retorno += unidade.UnidadePorExtenso(
                        Convert.ToInt32(und)
                    );
                }
                if(numero >= 110 && numero <= 199) 
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "Cento e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                }
                

            }

            if( numero >= 200 && numero <= 299 )
            {
                if(numero == 200)
                    retorno = "Duzentos";
                if(numero >= 201 && numero <= 209) 
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "Duzentos e ";
                    retorno += unidade.UnidadePorExtenso(
                        Convert.ToInt32(und)
                    );
                }
                if(numero >= 210 && numero <= 299) 
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "Duzentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                }
                
                
            }

            if( numero >= 300 && numero <= 399 )
            {
                if(numero == 300)
                    retorno = "Trezentos";
                if(numero >= 301 && numero <= 309) 
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "Trezentos e ";
                    retorno += unidade.UnidadePorExtenso(
                        Convert.ToInt32(und)
                    );
                }
                if(numero >= 310 && numero <= 399) 
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "Trezentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                }
                
                
            }

            if( numero >= 400 && numero <= 499 )
            {
                if(numero == 400)
                    retorno = "Quatrocentos";
                if(numero >= 401 && numero <= 409) 
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "Quatrocentos e ";
                    retorno += unidade.UnidadePorExtenso(
                        Convert.ToInt32(und)
                    );
                }
                if(numero >= 410 && numero <= 499) 
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "Quatrocentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                }
                
                
            }

            if( numero >= 500 && numero <= 599 )
            {
                if(numero == 500)
                    retorno = "Quinhentos";
                if(numero >= 501 && numero <= 509) 
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "Quinhentos e ";
                    retorno += unidade.UnidadePorExtenso(
                        Convert.ToInt32(und)
                    );
                }
                if(numero >= 510 && numero <= 599) 
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "Quinhentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                }
                
                
            }

            if( numero >= 600 && numero <= 699 )
            {
                if(numero == 600)
                    retorno = "Seissentos";
                if(numero >= 601 && numero <= 609) 
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "Seissentos e ";
                    retorno += unidade.UnidadePorExtenso(
                        Convert.ToInt32(und)
                    );
                }
                if(numero >= 610 && numero <= 699) 
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "Seissentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                }
                
                
            }

            if( numero >= 700 && numero <= 799 )
            {
                if(numero == 700)
                    retorno = "Setessentos";
                if(numero >= 701 && numero <= 709) 
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "Setessentos e ";
                    retorno += unidade.UnidadePorExtenso(
                        Convert.ToInt32(und)
                    );
                }
                if(numero >= 710 && numero <= 799) 
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "Setessentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                }
                
                
            }

            if( numero >= 800 && numero <= 899 )
            {
                if(numero == 800)
                    retorno = "Oitossentos";
                if(numero >= 801 && numero <= 809) 
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "Oitossentos e ";
                    retorno += unidade.UnidadePorExtenso(
                        Convert.ToInt32(und)
                    );
                }
                if(numero >= 810 && numero <= 899) 
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "Oitossentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                }
                
                
            }

            if( numero >= 900 && numero <= 999 )
            {
                if(numero == 900)
                    retorno = "Novessentos";
                if(numero >= 901 && numero <= 909) 
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "Novessentos e ";
                    retorno += unidade.UnidadePorExtenso(
                        Convert.ToInt32(und)
                    );
                }
                if(numero >= 910 && numero <= 999) 
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "Novessentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                }
                
                
            }

            return retorno;

        }
    }
}
