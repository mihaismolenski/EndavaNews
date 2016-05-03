using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Entities;
using DataAccessLayer.EntitiesDao;

namespace testdb
{
    class Program
    {
        static void Main(string[] args)
        {
            //var db = new UserDao();
            //var user = new User() {Name = "msmolenschi"};
            //db.Save(user);

            //    var db = new ArticleStatusDao();
            //    var status = new ArticleStatus()
            //    {
            //        Name = "asas"
            //    };
            //    db.Save(status);
            //var db = new ContentTypeDao();
            //var type = new ContentType()
            //{
            //    Name = "asas"
            //};
            //db.Save(type);

            //var db = new GenericEntityDao();
            //var artCat = new ArticleCategory()
            //{
            //    Name = "Birthday"
            //};
            //db.Save(artCat);
            var db = new GenericEntityDao();
            //var artCat = new ArticleCategory()
            //{
            //    Name = "Birthday"
            //};
            //db.Save(artCat);

            var artStatus = db.Read<ArticleStatus>(1);
            var user = db.Read<User>(1);
            var content = db.Read<ContentType>(1);
            var artCat = db.Read<ArticleCategory>(1);
            var artSt = db.Read<ArticleStatus>(1);
            
            //var art = new Article()
            //{
            //    User = user,
            //    Title = "new article",
            //    DateCreated = DateTime.Now,
            //    ArticleCategory = artCat,
            //    ContentType = content,
            //    Data = "blablabla",
            //    Duration = 10000,
            //    EndDate = DateTime.Now.AddDays(1),
            //    LastModifiedBy = user,
            //    LastModifiedDate = DateTime.Now,
            //    StartDate = DateTime.Now,
            //    ArticleStatus = artSt
            //};
            //db.Save(art);

            //var user = new User() { Name = "msmolenschi" };
            //user.UserCategory = userCat;
            //db.Save(user);
            var art = db.Read<Article>(1);
            art.Data = "ceva nou";
            db.Update(art);

            var playlist = db.Read<Playlist>(1);
            playlist.Articles.Add(art);
            db.Update(playlist);

            
            //Comentariu
            //Cristian
            //Hai odata


            //Sergiu
            //asda
        }
    }
}
