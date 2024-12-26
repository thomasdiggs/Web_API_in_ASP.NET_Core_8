using Web_API.Models;

namespace Web_API.Services;

public class PostsService : IPostService
{
    // This is just for demonstration purposes, please do not use this in production
    // Will be replaced with a database in the future
    private static readonly List<Post> AllPosts = [];

    public Task CreatePost(Post item)
    {
        AllPosts.Add(item);
        return Task.CompletedTask;
    }

    public Task<Post?> UpdatePost(int id, Post item)
    {
        var post = AllPosts.FirstOrDefault(x => x.Id == id);
        if (post != null)
        {
            post.Title = item.Title;
            post.Body = item.Body;
            post.UserId = item.UserId;
        }
        return Task.FromResult(post);
    }

    public Task<Post?> GetPost(int id)
    {
        return Task.FromResult(AllPosts.FirstOrDefault(x => x.Id == id));
    }

    public Task<List<Post>> GetAllPosts()
    {
        return Task.FromResult(AllPosts);
    }

    public Task DeletePost(int id)
    {
        var post = AllPosts.FirstOrDefault(x => x.Id == id);
        if (post != null)
        {
            AllPosts.Remove(post);
        }
        return Task.CompletedTask;
    }
}