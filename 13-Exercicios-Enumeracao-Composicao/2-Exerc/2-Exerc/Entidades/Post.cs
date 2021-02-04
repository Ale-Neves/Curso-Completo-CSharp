using System;
using System.Collections.Generic;
using System.Text;
using _2_Exerc.Entidades;

namespace _2_Exerc.Entidades
{
    class Post
    {
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }

        public List<Comentario> listComentarios { get; set; } = new List<Comentario>();

        public Post()
        { }
        public Post(DateTime data, string titulo, string conteudo, int likes)
        {
            Data = data;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }
        public void addComentario(Comentario comentarios)
        {
            listComentarios.Add(comentarios);
        }
        public void RemoveComentario(Comentario comentarios)
        {
            listComentarios.Remove(comentarios);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Data.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comments:");
            foreach (Comentario c in listComentarios)
            {
                sb.AppendLine(c.Texto);
            }
            return sb.ToString();
        }

    }
}
