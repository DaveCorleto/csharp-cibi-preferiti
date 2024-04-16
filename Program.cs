namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] food = { "1 Pizza", "3 Lasagne", "4 Grigliata", "5 Pasta", "2 Tiramisù", "6 Torta Sacher" };

            Console.WriteLine("Ecco i miei cibi preferiti: ");
            foreach (string cibo in food)
            {
                Console.WriteLine(cibo);
            }

            Console.WriteLine("La lunghezza della classifica è: " + food.Length);

            var classifica = food.OrderBy(s => int.Parse(s.Split()[0]));

            Console.WriteLine("Array food ordinato in base al numero iniziale:");
            foreach (string cibo in classifica)
            {
                Console.WriteLine(cibo);
            }
          
            string primo = classifica.First();
            Console.WriteLine("Il mio cibo preferito è " + primo);

            string ultimo = classifica.Last();
            Console.WriteLine("Il mio cibo preferito è " + ultimo);

        }



    }

    
}
