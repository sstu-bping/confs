using AutoMapper;
using Client.Entities;
using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.DAL
{
    public class ConfsInitializer : System.Data.Entity.DropCreateDatabaseAlways<ConfsContext>
    {
        protected override void Seed(ConfsContext context)
        {
            var news = new List<NewsModel>
            {
              new NewsModel{Title="Test Title #1",Text="Dummy Text #1", Date=DateTime.Parse("2015-11-06")},
              new NewsModel{Title="Test Title #2",Text="Dummy Text #2", Date=DateTime.Parse("2015-11-07")},
              new NewsModel{Title="Test Title #3",Text="Dummy Text #3", Date=DateTime.Parse("2015-11-08")},
              new NewsModel{Title="Test Title #4",Text="Dummy Text #4", Date=DateTime.Parse("2015-11-09")},
              new NewsModel{Title="Test Title #5",Text="Dummy Text #5", Date=DateTime.Parse("2015-11-10")},
            };

            news.ForEach(s => context.News.Add(s));
            context.SaveChanges();

            var confs = new List<ConferenceModel>
            {
                new ConferenceModel{Name="Умник-2015",Description="Описание конференции Умник-2015",StartDate=DateTime.Parse("2015-12-15")},
                new ConferenceModel{Name="Microsoft Challenge-2016",Description="Описание конференции Microsoft Challenge-2016",StartDate=DateTime.Parse("2016-02-12")}
            };

            confs.ForEach(c => context.Conferences.Add(c));
            context.SaveChanges();

            // Users
            var user = new User { 
                Id = Guid.NewGuid().ToString(),
                Login = "user",
                Password = "user",
                Email = "user@mail.ru",
                VUZ = "SGTU",
                Position = "studend",
                Role = "user"
            };

            var organizer = new User {
                Id = Guid.NewGuid().ToString(),
                Login = "organizer",
                Password = "organizer",
                Email = "organizer@mail.ru",
                VUZ = "SGTU",
                Position = "organizer",
                Role = "organizer"
            };


            var admin = new User
            {
                Id = Guid.NewGuid().ToString(),
                Login = "admin",
                Password = "admin",
                Email = "admin@mail.ru",
                VUZ = "SGTU",
                Position = "admin",
                Role = "admin"
            };
            context.Users.Add(user);
            context.Users.Add(organizer);
            context.Users.Add(admin);
            context.SaveChanges();

            var pconf = context.Conferences.FirstOrDefault();
            var puser = context.Users.FirstOrDefault();

            var part = new ParicipationModel
            {
                Title = "123",
                Anotation = "123",
                User = puser,
                Conference = pconf
            };
            
            context.Paricipations.Add(part);
            context.SaveChanges();

        }
    }
}