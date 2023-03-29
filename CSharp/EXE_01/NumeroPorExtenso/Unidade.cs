namespace NumeroPorExtenso
{
    public class Unidade
    {

        public string UnidadePorExtenso(int numero)
        {
            if(numero == 0)
                return "Zero"; 
            else if( numero == 1 )
                return "Um";    
            else if ( numero == 2)
                return "Dois";
            else if ( numero == 3)
                return "Três";
            else if ( numero == 4)
                return "Quatro";
            else if ( numero == 5)
                return "Cinco";
            else if ( numero == 6)
                return "Seis";
            else if ( numero == 7)
                return "Sete";
            else if ( numero == 8)
                return "Oito";
            else if ( numero == 9)
                return "Nove";
            else 
                return "Número Inválido";
        }


    }
}