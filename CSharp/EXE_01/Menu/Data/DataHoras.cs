namespace manipulacao_de_datas
{
    public class DataHoras
    {
         public DataHoras()
        {
            Main();
        }
        static void Main()
        {
            DateTime data = DateTime.Now;
            Console.WriteLine(data.ToLocalTime());
            if (data.DayOfYear == 365)
            {
                Console.WriteLine("Dia do Medico");
                Console.WriteLine("Dia do Animal");
                Console.WriteLine("Dia do Cliente");
                Console.WriteLine(data.DayOfWeek);
            }
            else
                Console.WriteLine("Dia normal");
            Console.ReadKey();
        }
    }
}