using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumeroPorExtenso
{
    public class Milhar
    {
      public string MilharPorExtenso(int numero)
        {
            string retorno = "";
            Unidade unidade = new Unidade();
            Dezena dezena = new Dezena();
            Centena centena = new Centena();


            if(numero >= 1000 && numero <= 1999)
            {
                if(numero == 1000)
                 retorno = "Mil";
                if(numero >= 1001 && numero <= 1009)
                {
                    string und = numero.ToString().Substring(3,1);
                    retorno = "Mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if(numero >= 1010 && numero <= 1099)
                {
                    string dnz = numero.ToString().Substring(2,2);
                    retorno = "Mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dnz));
                }
                if(numero >= 1100 && numero <= 1999)
                {
                    string cnt = numero.ToString().Substring(1,3);
                    retorno = "Mil ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(cnt));
                }
            }
            if(numero >= 2000 && numero <= 2999)
            {
                if(numero == 2000)
                 retorno = "Dois Mil";
                if(numero >= 2001 && numero <= 2009)
                {
                    string und = numero.ToString().Substring(3,1);
                    retorno = "Dois Mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if(numero >= 2010 && numero <= 2099)
                {
                    string dnz = numero.ToString().Substring(2,2);
                    retorno = "Dois Mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dnz));
                }
                if(numero >= 2100 && numero <= 2999)
                {
                    string cnt = numero.ToString().Substring(1,3);
                    retorno = "Dois Mil ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(cnt));
                }
            }
            if(numero >= 3000 && numero <= 3999)
            {
                if(numero == 3000)
                 retorno = "Três Mil";
                if(numero >= 3001 && numero <= 3009)
                {
                    string und = numero.ToString().Substring(3,1);
                    retorno = "Três Mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if(numero >= 3010 && numero <= 3099)
                {
                    string dnz = numero.ToString().Substring(2,2);
                    retorno = "Três Mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dnz));
                }
                if(numero >= 3100 && numero <= 3999)
                {
                    string cnt = numero.ToString().Substring(1,3);
                    retorno = "Três Mil ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(cnt));
                }
            }
            if(numero >= 4000 && numero <= 4999)
            {
                if(numero == 4000)
                 retorno = "Quatro Mil";
                if(numero >= 4001 && numero <= 4009)
                {
                    string und = numero.ToString().Substring(3,1);
                    retorno = "Quatro Mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if(numero >= 4010 && numero <= 4099)
                {
                    string dnz = numero.ToString().Substring(2,2);
                    retorno = "Quatro Mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dnz));
                }
                if(numero >= 4100 && numero <= 4999)
                {
                    string cnt = numero.ToString().Substring(1,3);
                    retorno = "Quatro Mil ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(cnt));
                }
            }
            if(numero >= 5000 && numero <= 5999)
            {
                if(numero == 5000)
                 retorno = "Cinco Mil";
                if(numero >= 5001 && numero <= 5009)
                {
                    string und = numero.ToString().Substring(3,1);
                    retorno = "Cinco Mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if(numero >= 5010 && numero <= 5099)
                {
                    string dnz = numero.ToString().Substring(2,2);
                    retorno = "Cinco Mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dnz));
                }
                if(numero >= 5100 && numero <= 5999)
                {
                    string cnt = numero.ToString().Substring(1,3);
                    retorno = "Cinco Mil ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(cnt));
                }
            }
            if(numero >= 6000 && numero <= 6999)
            {
                if(numero == 6000)
                 retorno = "Seis Mil";
                if(numero >= 6001 && numero <= 6009)
                {
                    string und = numero.ToString().Substring(3,1);
                    retorno = "Seis Mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if(numero >= 6010 && numero <= 6099)
                {
                    string dnz = numero.ToString().Substring(2,2);
                    retorno = "Seis Mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dnz));
                }
                if(numero >= 6100 && numero <= 6999)
                {
                    string cnt = numero.ToString().Substring(1,3);
                    retorno = "Seis Mil ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(cnt));
                }
            }
            if(numero >= 7000 && numero <= 7999)
            {
                if(numero == 7000)
                 retorno = "Sete Mil";
                if(numero >= 7001 && numero <= 7009)
                {
                    string und = numero.ToString().Substring(3,1);
                    retorno = "Sete Mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if(numero >= 7010 && numero <= 7099)
                {
                    string dnz = numero.ToString().Substring(2,2);
                    retorno = "Sete Mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dnz));
                }
                if(numero >= 7100 && numero <= 7999)
                {
                    string cnt = numero.ToString().Substring(1,3);
                    retorno = "Sete Mil ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(cnt));
                }
            }
            if(numero >= 8000 && numero <= 8999)
            {
                if(numero == 8000)
                 retorno = " Oito Mil";
                if(numero >= 8001 && numero <= 8009)
                {
                    string und = numero.ToString().Substring(3,1);
                    retorno = "Oito Mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if(numero >= 8010 && numero <= 8099)
                {
                    string dnz = numero.ToString().Substring(2,2);
                    retorno = "Oito Mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dnz));
                }
                if(numero >= 8100 && numero <= 8999)
                {
                    string cnt = numero.ToString().Substring(1,3);
                    retorno = "Oito Mil ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(cnt));
                }
            }
            if(numero >= 9000 && numero <= 9999)
            {
                if(numero == 9000)
                 retorno = "Nove Mil";
                if(numero >= 9001 && numero <= 9009)
                {
                    string und = numero.ToString().Substring(3,1);
                    retorno = "Nove Mil e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                if(numero >= 9010 && numero <= 9099)
                {
                    string dnz = numero.ToString().Substring(2,2);
                    retorno = "Nove Mil e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dnz));
                }
                if(numero >= 9100 && numero <= 9999)
                {
                    string cnt = numero.ToString().Substring(1,3);
                    retorno = "Nove Mil ";
                    retorno += centena.CentenaPorExtenso(Convert.ToInt32(cnt));
                }
            }
            
            return retorno;
        }
          
    }
}