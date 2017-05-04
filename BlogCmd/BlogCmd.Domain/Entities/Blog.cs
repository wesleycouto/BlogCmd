using System;
using System.Collections.Generic;

namespace BlogCmd.Domain.Entities
{
    public class Blog
    {
        public Guid Id { get; set; }
        public Guid IdDono { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public Usuario Dono { get; set; }
        public IEnumerable<Postagem> Postagens { get; set; }
    }
}