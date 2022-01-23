using EjercicioAlkemy2.Models;

namespace EjercicioAlkemy2.Repository
{
    public interface IUserRepository :IRepository<User>
    {
    }
    public interface IPostRepository : IRepository<Post>
    {
    }

    public interface ICommentRepository : IRepository<Comment>
    {
    }


}
