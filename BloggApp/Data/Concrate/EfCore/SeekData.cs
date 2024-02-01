using BloggApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BloggApp.Data.Concrate.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app){
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if(context != null){
                if(context.Database.GetPendingMigrations().Any()){
                    context.Database.Migrate();
                }

                if(!context.Tags.Any()){
                    context.Tags.AddRange(
                        new Tag {Text = "Web Gelistirme"},
                        new Tag {Text = "Backend Gelistirme"},
                        new Tag {Text = "Frontend Gelistirme"},
                        new Tag {Text = "Game Gelistirme"}
                    );
                    context.SaveChanges();
                }

                if(!context.Users.Any()){
                    context.Users.AddRange(
                        new User{UserName = "ahmetkaya"},
                        new User{UserName = "ayse"}
                    );
                    context.SaveChanges();
                }

                if(!context.Posts.Any()){
                    context.Posts.AddRange(
                        new Post{
                            Title = "Asp.Net Core",
                            Content = ".Net Core",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-10),
                            UserId = 2,
                            Tags = context.Tags.Take(3).ToList()
                        }
                    );
                    context.SaveChanges();
                }



            }



        }
    }
}