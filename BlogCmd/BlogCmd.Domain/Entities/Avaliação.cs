using System;

namespace BlogCmd.Domain.Entities
{
    public class Avaliação
    {
        public Guid Id { get; set; }
        public Guid IdPostagem { get; set; }
        public Guid IdUsuario { get; set; }
        public byte ValorAvaliação { get; set; }
        public bool Ativa { get; set; }

        public Postagem Postagem { get; set; }
        public Usuario Usuario { get; set; }
    }
}