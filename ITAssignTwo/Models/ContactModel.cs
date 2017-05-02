using System;
namespace ITAssignTwo.Models
{
    public class ContactModel
    {

        public string Title { get; }
        public string Message { get; }
        public string AdressLine1 { get; }
		public string AdressLine2 { get; }
        public string Phone { get; }
        public string Mail { get; }

        public ContactModel()
        {
            Title = "Contact information";
            Message = "University of Southern Denmark";
            AdressLine1 = "Campusvej 55,";
            AdressLine2 = "5230 Odense M ";
            Phone = "+45 28 52 57 40";
            Mail = "Support: support@sdu.dk";
        }
    }
}

