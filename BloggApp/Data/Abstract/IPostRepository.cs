using BloggApp.Entity;

namespace BloggApp.Data.Abstract
{
    public interface IPostRepository{
        IQueryable<Post> Posts { get; set;}

        void CreatePost(Post post);
    }
}