using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentQuery
{
    class StudentList
    {
        public static IQueryable<Students> setStudentsInformations()
        {
            return new[] {
                new Students() { ID = 1, name = "john nigel", score = 83, city = "NYC", isActive = true },
                new Students() { ID = 2, name = "alex roma", score = 64, city = "CA", isActive = false },
                new Students() { ID = 3, name = "corbin shamil", score = 78, city = "CA", isActive = true },
                new Students() { ID = 4, name = "james palatto", score = 90 , city = "NYC", isActive = true},
                new Students() { ID = 5, name = "ron jenova", score = 51, city = "NYC", isActive = false },
            }.AsQueryable();
        }
    }
}
