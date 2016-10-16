using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DownloadAndParseXmlToJson
{
    public class StartUp
    {
        public static void Main()
        {
            var address = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            var filePath = @"C:\Users\User\Documents\DataBases\Processing JSON in .NET\data\ta-rss.xml";
            var jsonTaFeed = @"C:\Users\User\Documents\DataBases\Processing JSON in .NET\data\ta-rss.json";
            var htmlTaFeedVideos = @"C:\Users\User\Documents\DataBases\Processing JSON in .NET\data\ta-rss.html";

            DownloadXmlToFile(address, filePath);
            var json = ParseXmlToJson(filePath);
            Console.WriteLine(json);
            //SaveToFile(jsonTaFeed, json);

            Console.WriteLine("-------------------------");
            Console.WriteLine("Video Titles: ");
            Console.WriteLine("-------------------------");

            SelectVideoTitles(filePath);

            Console.WriteLine("-------------------------");
            Console.WriteLine("Videos: ");
            Console.WriteLine("-------------------------");
            var videos = GetAllVideosFromJson(jsonTaFeed);

            foreach (var video in videos)
            {
                Console.WriteLine($"{video.Id} - {video.Title} - {video.Link}");
            }

            var html = GenerateHtml(videos);
            File.WriteAllText(htmlTaFeedVideos, html, Encoding.UTF8);
        }

        static string GenerateHtml(IEnumerable<Video> videos)
        {
            var builder = new StringBuilder();
            builder.AppendLine("<!DOCTYPE html><html><head><title>Telerik Academy YouTube RSS Videos</title></head><body><ul>");

            foreach (var video in videos)
            {
                builder.AppendFormat("<li style=\"list-style-type:none;\"><a href=\"{0}\"><strong>{1}</strong></a></li>", video.Link.Href, video.Title);
                builder.AppendFormat(@"<iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/{0}"" frameborder=""0"" allowfullscreen></iframe>", video.Id);
            }

            builder.AppendLine("</ul></body></html>");

            return builder.ToString();
        }

        static IEnumerable<Video> GetAllVideosFromJson(string jsonPath)
        {
            var json = File.ReadAllText(jsonPath);
            var jsonObject = JObject.Parse(json);
            var videos = jsonObject["feed"]["entry"].Select(video => JsonConvert.DeserializeObject<Video>(video.ToString()));

            return videos;
        }    

        static void SelectVideoTitles(string filePath)
        {
            var json = ParseXmlToJson(filePath);

            var jObject = JObject.Parse(json);

            var titles = jObject["feed"]["entry"]
                .Select(entry => entry["title"]);

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }    

        static void DownloadXmlToFile(string address, string filePath)
        { 
            WebClient myWebClient = new WebClient();

            myWebClient.DownloadFile(address, filePath);

            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", filePath, address);
        }

        static string ParseXmlToJson(string filePath)
        {
            var xml = File.ReadAllText(filePath);
            var doc = XDocument.Parse(xml);
            var json = JsonConvert.SerializeXNode(doc, Formatting.Indented);

            return json;
        }

        private static void SaveToFile(string url, string content)
        {
            var json = JsonConvert.SerializeObject(content, Formatting.Indented);
            File.WriteAllText(url, json);
        }
    }
}