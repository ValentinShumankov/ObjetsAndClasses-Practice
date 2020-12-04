using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace _01.RandomFakeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                 Console.WriteLine(AdvertiseRandomMessage.GenerateMessageAtRandom());
            }

        }

        public static class AdvertiseRandomMessage
        {
            public static string[] Phrases = new string[]
      {
            "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."
      };
            public static string[] Events = new string[]
            {
            "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            public static string[] Authors = new string[]
            {
            "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            public static string[] Cities = new string[]
            {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            public static string GenerateMessageAtRandom()
            {
                Random random = new Random();
                string phrase = Phrases[random.Next(0, Phrases.Length)];
                string events = Events[random.Next(0, Events.Length)];
                string authors = Authors[random.Next(0, Authors.Length)];
                string cities = Cities[random.Next(0, Cities.Length)];
                string resultMessage = $"{phrase} {events} {authors} – {cities}";
                return resultMessage;
            }
        }

       
    }
}
