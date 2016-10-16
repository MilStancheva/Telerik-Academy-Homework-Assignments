using System;
using System.Linq;
using System.Net;

namespace DownloadFile
{
    public class DownloadFile
    {
        public static void Main()
        {
            string fileName = "NinjaImage.png";
            string downloadSucceededMessage = "Download is complete. Please, check";

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", fileName);
                }

            }
            catch (Exception ex)
            {
                string exceptionMessage = string.Format("Exception caught!\n{0}:{1}", ex.GetType().Name, ex.Message);
                Console.WriteLine(exceptionMessage);
            }

            Console.WriteLine(downloadSucceededMessage);
        }
    }
}
