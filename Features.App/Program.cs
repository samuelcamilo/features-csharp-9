using System;
using System.Threading.Tasks;

namespace Features.App
{
    class Program
    {
        public static bool StatusCode(int status) => status != 3 ? true : false;
     
        public static async Task<bool> ExampleSwitchCase() 
        {
            return await Task.FromResult(2).ConfigureAwait(false) switch
            {
                (1) => StatusCode(1),
                (2) => StatusCode(2),
                _ => StatusCode(3)
            };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Example Switch: " + ExampleSwitchCase().Result); // Example Switch 
        }
    }
}
