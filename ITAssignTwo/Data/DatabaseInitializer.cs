﻿using ITAssignTwo.Models;
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
            context.Database.EnsureCreated();
                "are but a few examples of how software plays an increasingly more important role in our everyday lives. " +
                "With a degree in Software Engineering you can help create new possibilities with the software of the future. ";
            context.About.Add(model);

            context.SaveChanges();
        }
    }


}