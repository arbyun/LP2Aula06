using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere um número inteiro:");

            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Número inserido: {i}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Tens que inserir um número inteiro.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Este número é grande demais.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu o seguinte problema: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado por ter utilizado este programa!");
            }
        }
    }
}
