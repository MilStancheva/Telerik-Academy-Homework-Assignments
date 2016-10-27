using System;
using System.Linq;
using DecoratorExampleEventCompany.Contracts;
using DecoratorExampleEventCompany.Models;

namespace DecoratorExampleEventCompany
{
    public class StartUp
    {
        public static void Main()
        {
            IEventService seminarService = new SeminarService();
            PhotographyService photographyService = new PhotographyService(seminarService);
            CateringService cateringService = new CateringService(photographyService);
            Console.WriteLine($"Seminar cost: {cateringService.Cost} $");

            IEventService weddingService = new WeddingService();
            PhotographyService photographyWeddingService = new PhotographyService(weddingService);
            CateringService cateringWeddingService = new CateringService(photographyWeddingService);
            Console.WriteLine($"Wedding cost: {cateringWeddingService.Cost} $");
        }
    }
}
