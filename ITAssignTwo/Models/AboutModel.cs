using ITAssignTwo.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITAssignTwo.Models
{
    public class AboutModel
    {
        public int ID { get; set; } // Needed for EntityFramework to work (Primary Key)
        public string Title { get; set; }
        public string Message { get; set; }
        public string AdditionalInfo { get; set; }

        public AboutModel() { } // Needed for EntityFramework to create the table
        public AboutModel(ApplicationDbContext context)
        {
            //Pull info from DB to here
            AboutModel[] aboutArray = context.About.ToArray();
            if (!aboutArray.Any()) return;
            this.Title = aboutArray[0].Title;
            this.Message = aboutArray[0].Message;
            this.AdditionalInfo = aboutArray[0].AdditionalInfo;


        }
    }
}
