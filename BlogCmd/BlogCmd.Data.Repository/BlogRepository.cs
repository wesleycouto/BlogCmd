using BlogCmd.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BlogCmd.Data.Repository
{
    public static class BlogRepository
    {
        public static IEnumerable<Blog> ListarBlogs()
        {
            var blogs = Database.DbBlog as List<Blog>;

            blogs.ForEach(a =>
            {
                if (a.Dono == null)
                    a.Dono = Database.DbUsuario.FirstOrDefault(c => c.Ativo && c.Id == a.IdDono);
            });

            return blogs;
        }
    }
}