using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITAssignTwo.Models
{
    public class AboutModel
    {
        public string Title { get; }
        public string Message { get; }
        public string AdditionalInfo { get; }

        public AboutModel()
        {
            Title = "About Page";
            Message = "Software Engineering";
            AdditionalInfo = "Google, Skype, intelligent cars, online banking and apps for your smartphone " +
                "are but a few examples of how software plays an increasingly more important role in our everyday lives. " +
                "With a degree in Software Engineering you can help create new possibilities with the software of the future. ";
        }
    }
}
