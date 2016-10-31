/*  Task 8. By inheriting the Employee entity class create a class which allows employees to access their corresponding territories 
    as property of type EntitySet<T>.
*/

using System.Collections.Generic;

namespace NorthwindDb
{
    public partial class Employee
    {
        public ICollection<Territory> TerritoriesSet
        {
            get
            {
                var territoriesSet = new List<Territory>();
                territoriesSet.AddRange(this.Territories);
                return territoriesSet;
            }
        }
    }
}
