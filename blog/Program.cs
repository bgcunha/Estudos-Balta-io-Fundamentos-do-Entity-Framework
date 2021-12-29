﻿using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            using var context = new BlogDataContext();

            // var user = new User
            // {
            //     Name = "Bruno Gomes",
            //     Slug = "brunogomes",
            //     Email = "brunogomes@bruno.io",
            //     Bio = "Anaista Senior",
            //     Image = "https://brunogomes.io",
            //     PasswordHash = "123456789"
            // };

            // var category = new Category { Name = "Backend", Slug = "backend" };

            // var post = new Post
            // {
            //     Author = user,
            //     Category = category,
            //     Body = "<p>Hello world</p>",
            //     Slug = "comecando-com-ef-core",
            //     Summary = "Neste artigo vamos aprender EF core",
            //     Title = "Começando com EF Core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now,
            // };

            // context.Posts.Add(post); // Não adicionei autor nem categoria
            // context.SaveChanges();

            // var posts = context
            //     .Posts
            //     .AsNoTracking()
            //     .Include(x => x.Author)
            //     .Include(x => x.Category)
            //     .OrderBy(x => x.LastUpdateDate)
            //     .ToList();

            // foreach (var post in posts)
            //     Console.WriteLine($"{post.Title} por {post.Author.Name} em {post.Category.Name}");

            // var post = context
            //     .Posts
            //     // .AsNoTracking() PRECISA DO TRACKING 
            //     .Include(x => x.Author)
            //     .Include(x => x.Category)
            //     .OrderBy(x => x.LastUpdateDate)
            //     .FirstOrDefault(); // Pegando o primeiro item

            // post.Author.Name = "Uncle Bob";

            // context.Posts.Update(post);
            // context.SaveChanges();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"ERRO>>>:{ex.Message}");
            //}

        }
    }
}