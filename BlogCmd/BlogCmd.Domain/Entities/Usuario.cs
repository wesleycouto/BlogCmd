using System;
using System.Collections.Generic;

namespace BlogCmd.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Comentário> Comentários { get; set; }
        public IEnumerable<Avaliação> Avaliações { get; set; }
        public IEnumerable<Postagem> Postagens { get; set; }
    }
}