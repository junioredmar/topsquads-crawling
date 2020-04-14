using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using HtmlAgilityPack;
using System.Text;
using System.Data.Odbc;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CrawlerDemo
{
    class Program
    {

        //private const string PathResults = "./results";

        //static void MainCrawler(string[] args)
        //{
        //    startCrawlerasync();

        //    Console.ReadLine();
        //}

        //private static async Task startCrawlerasync()
        //{
        //    int pageNumber = 567;
        //    var players = new List<Player>();
        //    bool gathered = true;
        //    while (gathered)
        //    {
        //        gathered = await CrawlPage(pageNumber, players);
        //        pageNumber++;
        //    }

        //    Console.WriteLine("Saving to json....");
        //    var toSave = JsonConvert.SerializeObject(players);
        //    Directory.CreateDirectory(PathResults);
        //    File.WriteAllText($"{PathResults}/players.json", toSave);
        //    Console.WriteLine("Saved!");

        //    Console.WriteLine("Press Enter to exit the program...");
        //    ConsoleKeyInfo keyinfor = Console.ReadKey(true);
        //    if (keyinfor.Key == ConsoleKey.Enter)
        //    {
        //        System.Environment.Exit(0);
        //    }
        //}

        //private static async Task<bool> CrawlPage(int pageNumber, List<Player> players)
        //{
        //    try
        //    {
        //        var url = $"https://www.______.com/players?page={pageNumber}";
        //        Console.Write($"Crawling page {url}.");

        //        var httpClient = new HttpClient();
        //        var html = await httpClient.GetStringAsync(url);
        //        var htmlDocument = new HtmlDocument();
        //        htmlDocument.LoadHtml(html);

        //        Console.Write(".");
        //        var table = htmlDocument.DocumentNode.Descendants("table").FirstOrDefault(t => t.GetAttributeValue("id", "").Equals("repTb"));
        //        var tbody = table.Descendants("tbody").FirstOrDefault();
        //        var tableRows = tbody.Descendants("tr");
        //        Console.Write(".");
        //        foreach (var row in tableRows)
        //        {
        //            Console.Write(".");
        //            var player = new Player
        //            {
        //                Id = 
        //                Name = row.Descendants("a").FirstOrDefault(r => r.GetAttributeValue("class", "").Equals("player_name_players_table")).InnerText,
        //                ImageUrl = row.Descendants("img").FirstOrDefault(i => i.GetAttributeValue("class", "").Contains("player_img"))
        //                              .ChildAttributes("data-original").FirstOrDefault().Value,
        //                Club = row.Descendants("span").FirstOrDefault(r => r.GetAttributeValue("class", "").Equals("players_club_nation"))
        //                          .Descendants("a").ElementAt(0).ChildAttributes("data-original-title").FirstOrDefault().Value,

        //                ClubImg = row.Descendants("span").FirstOrDefault(r => r.GetAttributeValue("class", "").Equals("players_club_nation"))
        //                             .Descendants("a").ElementAt(0)
        //                             .Descendants("img").FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value,
        //                Nation = row.Descendants("span").FirstOrDefault(r => r.GetAttributeValue("class", "").Equals("players_club_nation"))
        //                            .Descendants("a").ElementAt(1).ChildAttributes("data-original-title").FirstOrDefault().Value,
        //                NationImg = row.Descendants("span").FirstOrDefault(r => r.GetAttributeValue("class", "").Equals("players_club_nation"))
        //                               .Descendants("a").ElementAt(1)
        //                               .Descendants("img").FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value,
        //                League = row.Descendants("span").FirstOrDefault(r => r.GetAttributeValue("class", "").Equals("players_club_nation"))
        //                            .Descendants("a").ElementAt(2).ChildAttributes("data-original-title").FirstOrDefault().Value,
        //                LeagueImg = row.Descendants("span").FirstOrDefault(r => r.GetAttributeValue("class", "").Equals("players_club_nation"))
        //                               .Descendants("a").ElementAt(2)
        //                               .Descendants("img").FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value,
        //                Rating = Int32.Parse(row.Descendants("span").FirstOrDefault(s => s.GetAttributeValue("class", "").Contains("rating")).InnerText),
        //                Price = row.Descendants("span").FirstOrDefault(s => s.GetAttributeValue("class", "").Contains("ps4_color")).InnerText
        //                        .Convert()
        //                Position = row.Descendants("td").ElementAt(2).InnerText,
        //                Color = row.Descendants("span").FirstOrDefault(s => s.GetAttributeValue("class", "").Contains("rating"))
        //                           .GetAttributeValue("class", ""),
        //                Pace = Int32.Parse(row.Descendants("span").Where(s => s.GetAttributeValue("class", "").Contains("badge")).ElementAt(0).InnerText),
        //                Shooting = Int32.Parse(row.Descendants("span").Where(s => s.GetAttributeValue("class", "").Contains("badge")).ElementAt(1).InnerText),
        //                Passing = Int32.Parse(row.Descendants("span").Where(s => s.GetAttributeValue("class", "").Contains("badge")).ElementAt(2).InnerText),
        //                Dribbling = Int32.Parse(row.Descendants("span").Where(s => s.GetAttributeValue("class", "").Contains("badge")).ElementAt(3).InnerText),
        //                Defending = Int32.Parse(row.Descendants("span").Where(s => s.GetAttributeValue("class", "").Contains("badge")).ElementAt(4).InnerText),
        //                Physicality = Int32.Parse(row.Descendants("span").Where(s => s.GetAttributeValue("class", "").Contains("badge")).ElementAt(5).InnerText)
        //            };

        //            players.Add(player);
        //        }
        //        Console.Write(" OK");
        //        Console.WriteLine();
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine(e.Message);
        //        return false;
        //    }

        //}
    }
}