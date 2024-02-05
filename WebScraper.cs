using HtmlAgilityPack;


namespace Web_Scraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Send get request to weather.com
            string url = "https://weather.com/pl-PL/pogoda/dzisiaj/l/PLXX0028:1:PL?Goto=Redirected";
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url).Result;
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            // Get the temperature
            var temperatureElement = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='CurrentConditions--tempValue--MHmYY']");
            var temperature = temperatureElement.InnerText.Trim();
            Console.WriteLine(temperature);

            // Get the weather
            var weatherElement = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var weather = weatherElement.InnerText.Trim();
            Console.WriteLine(weather);

            // get day and night
            var dayAndNight = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--tempHiLoValue--3T1DG']");
            var dayNight = dayAndNight.InnerText.Trim();
            Console.WriteLine(dayNight);

        }
    }
}