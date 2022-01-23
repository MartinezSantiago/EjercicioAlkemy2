using EjercicioAlkemy2.Context;
using EjercicioAlkemy2.Models;
using Microsoft.EntityFrameworkCore;

namespace EjercicioAlkemy2.Repository
{
    public class UserRepository : Repository<User, AppDbContext>, IUserRepository
    {
        public UserRepository(AppDbContext c) : base(c)
        {
        }
    }
    public class PostRepository : Repository<Post, AppDbContext>, IPostRepository
    {
        public PostRepository(AppDbContext c) : base(c)
        {
        }
    }
    public class CommentRepository : Repository<Comment, AppDbContext>, ICommentRepository
    {
        public CommentRepository(AppDbContext c) : base(c)
        {
        }
    }
}
