using System;
using System.Collections.Generic;

namespace BlogCmd.Domain.Entities
{
    public class Postagem
    {
        public Guid Id { get; set; }
        public Guid IdBlog { get; set; }
        public Guid IdUsuario { get; set; }
        public string Texto { get; set; }
        public bool PermiteComentários { get; set; }
        public bool Ativa { get; set; }

        public Usuario Usuario { get; set; }
        public Blog Blog { get; set; }
        public IEnumerable<Avaliação> Avaliações { get; set; }
        public IEnumerable<Comentário> Comentários { get; set; }
    }
}