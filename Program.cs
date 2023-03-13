namespace TAproject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.Write("goozoo adad bede : ");
            //var a = Console.ReadLine();

            //Console.WriteLine(int.Parse(a) * int.Parse(a));
            var methodes = new Methodes();
            
            //Console.WriteLine("in chandomin tamrine? ");
            //int exercisenumber = new();
            //methodes.GetInt(Console.ReadLine()!, out exercisenumber);

            Console.WriteLine("How many problems does thius exercise have? ");
            //methodes.GetInt(Console.ReadLine()!, out int problemsCount);
            int problemcount = methodes.GetInt(Console.ReadLine()!);
            Console.WriteLine(problemcount);

            Console.WriteLine("give me a command");
            var command = Console.ReadLine();
            //while (command != "exit")
            //{

            //    //if(s == "modify")
            //    //{
            //    //    Console.WriteLine("okey which students paper would you like to modify? ");
            //    //    var studentId = Console.ReadLine()!;
            //    //    methodes.modify(studentId);
            //    //}
            //    if (command == "help")
            //    {
            //        Console.WriteLine("modify, addpaper, exit, help");
            //        Console.WriteLine("give me a new command");
            //        command = Console.ReadLine();
            //        continue;
            //    }
            //    if (methodes.IsStudentId(command, out var student))
            //    {
            //        Console.Write($"good, is the student's name {student.Name}? (Y/n)\t");
            //        var yesno = Console.ReadLine();
            //        if( yesno == "Y" || yesno == "y")
            //        {
            //            Console.WriteLine($"was {student.Name}'s paper delayed? ");
            //            bool isdelayed = new();
            //            methodes.GetBool(Console.ReadLine(), out isdelayed);

            //            Console.WriteLine($"okey what were the points that {student.Name} got on his paper?");
            //            List<int> points = new();
            //            for (int i = 0; i < problemsCount; i++)
            //            {
            //                Console.Write($"problem {i + 1} : ");
            //                methodes.GetInt(Console.ReadLine(), out int number);
            //                points.Add(number);
            //            }

            //            long id  = methodes.Addpaper(exerciseNumber: exercisenumber, studentId: student.StudentId, isdelayed: isdelayed, points: points);
            //            methodes.PrintPaper(id);
            //            Console.WriteLine("okey got it, next?");
            //        }
            //        else
            //        {
            //            Console.WriteLine("okey, try again then");
            //        }
            //        command = Console.ReadLine();
            //        continue;
            //    }
            //    command = Console.ReadLine();
            //}
        }
    }
}