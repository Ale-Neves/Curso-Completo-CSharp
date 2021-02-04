using System;
using _2_Exerc.Entidades;

namespace _2_Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentario c1 = new Comentario("Have a nice trip");
            Comentario c2 = new Comentario("Wow that's awesome!");

            Post post = new Post(
                DateTime.Now,
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);
            post.addComentario(c1);
            post.addComentario(c2);

            Comentario c3 = new Comentario("Good night");
            Comentario c4 = new Comentario("May the Force be with you");

            Post post2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            post2.addComentario(c3);
            post2.addComentario(c4);

            Console.WriteLine(post);
            Console.WriteLine(post2);

        }
    }
}
