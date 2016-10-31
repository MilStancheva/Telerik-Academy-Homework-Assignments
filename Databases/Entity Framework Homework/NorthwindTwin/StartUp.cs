using NorthwindDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTwin
{
    public class StartUp
    {
        public static void Main()
        {
            var dbContext = new NorthwindEntities();

            dbContext.Database.CreateIfNotExists();
        }
    }
}
