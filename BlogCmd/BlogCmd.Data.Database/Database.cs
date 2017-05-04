using BlogCmd.Domain.Entities;
using System.Collections.Generic;

namespace BlogCmd.Data
{
    public static class Database
    {
        public static IEnumerable<Avaliação> DbAvaliação { get; set; } = new List<Avaliação>();
        public static IEnumerable<Blog> DbBlog { get; set; } = new List<Blog>();
        public static IEnumerable<Comentário> DbComentário { get; set; } = new List<Comentário>();
        public static IEnumerable<Postagem> DbPostagem { get; set; } = new List<Postagem>();
        public static IEnumerable<Usuario> DbUsuario { get; set; } = new List<Usuario>();
    }
}