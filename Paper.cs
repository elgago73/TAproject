namespace TAproject
{
    public class Paper
    {

        public long Id;
        public long ExerciseNumber;
        public long StudentId;
        public bool IsDelayed;
        public List<int> Points;
        public Paper(long id, long exerciseNumber, long studentId, bool isdelayed, List<int> points)
        {
            Id = id;
            ExerciseNumber = exerciseNumber;
            StudentId = studentId;
            IsDelayed = isdelayed;
            Points = points;
        }
        public void Print()
        {
            Console.WriteLine($"IsDelayed : {IsDelayed}");
            Console.WriteLine($"StudentId : {StudentId}");
            Console.WriteLine($"ExerciseNumber : {ExerciseNumber}");
            Console.WriteLine("Points : ");
            foreach (var point in Points)
            {
                Console.Write($"{point}, ");
            }
            Console.WriteLine("");
            //delete last ","
        }
        // modify
    }
}