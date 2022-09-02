using HtmlAgilityPack;

namespace Class_Library_For_Pase
{
    public class Parser
    {
        string[] zodiac_sign = new string[] { "aries", "taurus", "gemini",
                                              "cancer", "leo", "virgo",
                                              "libra", "scorpio", "sagittarius",
                                              "capricorn", "aquarius", "pisces"};
        public string[] ParsHoroscope(int num_zodiack)
        {
            string[] text = new string[2];

            string url = $"https://horoscopes.rambler.ru/{zodiac_sign[num_zodiack]}/";

            HtmlWeb webDoc = new HtmlWeb();

            HtmlDocument doc = webDoc.Load(url);
            HtmlNode par = doc.DocumentNode.SelectSingleNode("//h1[@class='_3wtsS _1W8Ro _2kQY7']");

            text[0] = par.InnerText;

            par = doc.DocumentNode.SelectSingleNode("//p[@class='mtZOt']");

            text[1] = par.InnerText;

            return text;
        }


    }
}
