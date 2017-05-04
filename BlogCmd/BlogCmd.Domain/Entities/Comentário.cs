using System;

namespace BlogCmd.Domain.Entities
{
    public class Comentário
    {
        public Guid Id { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdPostagem { get; set; }
        public string Texto { get; set; }
        public bool Ativo { get; set; }

        public Usuario Usuario { get; set; }
        public Postagem Postagem { get; set; }
    }
}