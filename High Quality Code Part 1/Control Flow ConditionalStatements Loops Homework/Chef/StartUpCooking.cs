using Cooking.Models;

namespace Cooking
{
    public class StartUpCooking
    {
        public static void Main(string[] args)
        {
            var chef = new Chef();

            chef.Cook();
        }
    }
}
