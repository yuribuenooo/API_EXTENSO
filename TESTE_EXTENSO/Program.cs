using API_EXTENSO;

namespace TESTE_EXTENSO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
          
            for (int i = 0; i <10000; i++)
        {
            Console.WriteLine("{0} = {1}",
                i,APiExtenso.Imprimir(i));
        }
            
                     
        Console.ReadKey();

        }
    }
}