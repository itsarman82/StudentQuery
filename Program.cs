namespace StudentQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentList = StudentList.setStudentsInformations();

            // is active, over 80, in NYC 

            var query1 = studentList.Where(x => x.score > 80 && x.isActive == true && x.city == "NYC")
                                    .Select(x => x);
            
            foreach (var item in query1) 
            {
                Console.Write(item.ID + " | ");
                Console.Write(item.name + " | ");
                Console.Write(item.score + " | ");
                Console.Write(item.city + " | ");
                Console.WriteLine(item.isActive);
            }

            Console.WriteLine("---------------------------");

            // over 80 or in NYC, just names

            var query2 = studentList.Where(x => x.score > 80 || x.city == "NYC")
                                    .Select(x => x);

            foreach (var item in query2) 
            {
                Console.WriteLine(item.name);
            }

            Console.WriteLine("---------------------------");

            // b include in name, project to smaller object

            var query3 = studentList.Where(x => x.name.Contains("b"))
                                    .Select(x => new MinimalStudents()
                                    {
                                        name= x.name,
                                        score = x.score
                                    });

            foreach (var item in query3)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.score);
            }

            Console.WriteLine("---------------------------");

            // deactivated students sort by score decending

            var query4 = studentList.Where(x => x.isActive == false)
                                    .OrderByDescending(x => x.score);

            foreach (var item in query4)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.score);
            }

            Console.WriteLine("---------------------------");

            // min score of all class

            var query5 = studentList.Average(x => x.score);

            Console.WriteLine(query5);

            Console.WriteLine("---------------------------");

            // min score of CA only, activated and include r or d in their names 

            var query6 = studentList.Where(x => x.isActive == true &&
                                                x.city == "CA" &&
                                                x.name.Contains("r") ||
                                                x.name.Contains("d"))
                                    .Average(x => x.score);

            Console.WriteLine(query6);
        }
    }
}