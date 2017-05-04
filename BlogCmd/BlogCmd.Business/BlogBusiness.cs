using BlogCmd.Data.Repository;
using BlogCmd.Domain.Entities;
using System.Collections.Generic;

namespace BlogCmd.Business
{
    public class BlogBusiness
    {
        public IEnumerable<Blog> ListarBlogs()
        {
            return BlogRepository.ListarBlogs();
        }
    }
}