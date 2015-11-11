using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.DAL
{
    public class ConfsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ConfsContext>
    {
        protected override void Seed(ConfsContext context)
        {
            var news = new List<News>
            {
              new News{Title="Test Title #1",Text="Dummy Text #1", Date=DateTime.Parse("2015-11-06")},
              new News{Title="Test Title #2",Text="Dummy Text #2", Date=DateTime.Parse("2015-11-07")},
              new News{Title="Test Title #3",Text="Dummy Text #3", Date=DateTime.Parse("2015-11-08")},
              new News{Title="Test Title #4",Text="Dummy Text #4", Date=DateTime.Parse("2015-11-09")},
              new News{Title="Test Title #5",Text="Dummy Text #5", Date=DateTime.Parse("2015-11-10")},
            };

            news.ForEach(s => context.News.Add(s));
            context.SaveChanges();

            var confs = new List<Conference>
            {
                new Conference{Name="Умник-2015",Description="Описание конференции Умник-2015",StartDate=DateTime.Parse("2015-12-15")},
                new Conference{Name="Microsoft Challenge-2016",Description="Описание конференции Microsoft Challenge-2016",StartDate=DateTime.Parse("2016-02-12")}
            };

            confs.ForEach(c => context.Conferences.Add(c));
            context.SaveChanges();

            // Users
            var user = new RegistrationModel { 
                Id = Guid.NewGuid().ToString(),
                Login = "Anakonda",
                Password = "Anakonda_2",
                Email = "anakonda@mail.ru",
                VUZ = "SGTU",
                Position = "studend"
            };
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}