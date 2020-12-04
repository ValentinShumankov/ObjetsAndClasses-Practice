using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions
                .RemoveEmptyEntries)
                .ToArray();

            Article article = new Article(input[0], input[1], input[2]);


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChnageAuthor(command[1]);

                        break;

                    case "Rename":
                        article.RenameArticle(command[1]);
                        break;
                    default:
                        break;
                }

            }
            
            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        string Title { get; set; }
        string Content { get; set; }
        string Author { get; set; }


        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;

        }
        public void RenameArticle(string input)
        {
            this.Title = input;
        }

        public void Edit(string input)
        {
            this.Content = input;

        }

        public void ChnageAuthor(string input)
        {
            this.Author = input;
        }


        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
