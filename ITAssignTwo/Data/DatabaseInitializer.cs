using ITAssignTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITAssignTwo.Data
{
    public static class DatabaseInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();            if (context.About.Any()) { return; } //Do nothing if there is an entry            AboutModel model = new AboutModel(context);            model.Title = "About Page";            model.Message = "Software Engineering";            model.AdditionalInfo = "Google, Skype, intelligent cars, online banking and apps for your smartphone " +
                "are but a few examples of how software plays an increasingly more important role in our everyday lives. " +
                "With a degree in Software Engineering you can help create new possibilities with the software of the future. ";
            context.About.Add(model);

            context.SaveChanges();
        }
    }


}
