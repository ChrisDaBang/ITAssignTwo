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
            Message = "hello";
            AdditionalInfo = "Google, Skype, intelligente biler, netbank og app’s til din smartphone er blot få eksempler på, " +
                "hvordan software spiller en stadig større og vigtigere rolle i din og andres hverdag. " +
                "Som civilingeniør i Software Engineering kan du blive en af dem, " +
                "der skaber de nye muligheder med fremtidens software" +
                "Som civilingeniør i Software Engineering arbejder du typisk inden for højteknologiske virksomheder" +
                " eller institutioner, som beskæftiger sig med forskning og/eller udvikling. " +
                "Civilingeniøren arbejder oftest inden for forskning, udvikling og innovation med gode muligheder for " +
                "karriereudvikling. Ingeniørerne havde i marts 2015 en ledighed på 2,3 procent, " +
                "og den vejledende startløn er 37.300,- for en civilingeniør. Læs mere om karrieremulighederne.";
        }
    }
}
