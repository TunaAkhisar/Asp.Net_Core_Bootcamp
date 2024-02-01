using BloggApp.Data.Abstract;
using BloggApp.Data.Concrate.EfCore;
using BloggApp.Entity;

namespace BloggApp.Data.Concrate
{
    public class EfPostRepository : IPostRepository
    {
        private BlogContext _context;

        public EfPostRepository(BlogContext context)
        {
            _context = context;
        }

        public IQueryable<Post> Posts => _context.Posts;

        IQueryable<Post> IPostRepository.Posts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CreatePost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }
    }
}