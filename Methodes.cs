using System.ComponentModel;
namespace TAproject
{
    internal class Methodes
    {

        public List<Student> Students;
        public List<Paper> Papers;
        public long LastPaperId;
        public Methodes()
        {
            Students = new List<Student>
            {
                new(982013001, "Pouria Azardar"),
                new(992011009, "Mohamad Reza Afshar"),
                new(4012013003, "Saeid Akbarzadeh"),
                new(4012013004, "Hosein Omarai"),
                new(992013005, "Ali Amini Dehghi"),
                new(4012013005, "Erfan Ouraki"),
                new(4002013011, "Mohamad Mehdi Avsati Ashtiani"),
                new(4012013007, "Abolfazl Balande"),
                new(4002013013, "Maryam Basharian"),
                new(4012013009, "Pouyan Pooryoosefi Koodehi"),
                new(992013010, "Ali Tajik"),
                new(4013333412, "Ghazal Taghi Loo"),
                new(4012013013, "Reyhane Jafar Khani"),
                new(4002013018, "Shayan Jahan Bakhshi"),
                new(992025004, "Mohamad Hafezian Zadeh"),
                new(4002013020, "Amir Hosein Hosein Zade Fakhari"),
                new(4012013016, "Seyede Hasti Hosein"),
                new(4002013022, "Anahita Heydar Pak"),
                new(4012013019, "Mehshad Khodadadi"),
                new(4012013020, "Mehdi Khoda Karami"),
                new(4002013023, "Amir Hosein Dashti"),
                new(4002013024, "Mohamad Domorchi Loo"),
                new(982013013, "Amir Mohamad Dehnavi"),
                new(4002013025, "Shahab Aldin Rajabi"),
                new(992025012, "Mohamad Sina Sheykh Rahimi"),
                new(4002013059, "Zahra Rezai"),
                new(4002013060, "Morteza Rezai"),
                new(4002013028, "Seyed Mohamad Reza Razavian"),
                new(4012013023, "Sina Riahi"),
                new(4002013029, "Hourie Zamani"),
                new(4002013030, "Zahra Zamani"),
                new(4002013033, "Mohamad Matin Shabani"),
                new(4012013028, "Alireza Shams"),
                new(992013029, "Erfan Sayadi"),
                new(4012013030, "Aria Abasi Dokht"),
                new(4002013036, "Hosein Atalou"),
                new(4012013034, "Tahmine Alijani"),
                new(4012013035, "Mohamad Gholami"),
                new(4012013038, "Navid Ghasemi"),
                new(9920130, "Mobin Ghahremanian"),
                new(4012013044, "Mohamad HAdi Goli Bid Goli"),
                new(4012013046, "Elahe Mahram Pour CHalek"),
                new(4012013047, "Romina Mohamadi"),
                new(4002013046, "Maryam Mohamadi"),
                new(4002013048, "Ali Mansour Falah"),
                new(4012013053, "Negin Mehr Parvar"),
                new(4002013049, "Maryam Mirzai"),
                new(4002013056, "Tofigh Nael Ahmad"),
                new(4002013051, "Farbod Naseri"),
                new(4012013055, "Masoume Nadarli"),
                new(4012013056, "Mohamad Mehdi Noroozi"),
                new(4012013057, "Navid Vali"),
                new(4013333130, "Hanane Vahab")
            };
            Papers = new List<Paper>();
            LastPaperId = 0;
        }

        public Student? FindStudent(long studentId)
        {
            foreach (var student in Students)
            {
                if (student.StudentId == studentId) return student;
            }
            return null;
        }

        public long Addpaper(long exerciseNumber, long studentId, bool isdelayed, List<int> points)
        {
            LastPaperId++;
            Paper paper = new Paper(LastPaperId, exerciseNumber, studentId, isdelayed, points);
            Papers.Add(paper);
            return paper.Id;
        }
        public void modify(string studentId)
        {
            //if (studentId == "") Console.WriteLine("");
        }
        //      nulleable student bejaye bool va out e student
        public bool IsStudentId(string command, out Student student)
        {  
            if (long.TryParse(command, out long studentId) == false || FindStudent(studentId) == null)
            {
                Console.WriteLine("this is not a Students Id number, please retry");
                student = null;
                return false;
            }
            student = FindStudent(studentId);
            return true;
        }

        public int GetInt(string? s)
        {
            var number = 0;
            if (int.TryParse(s, out number) == true)
            {
                return number;
            }
            Console.WriteLine("this is not a number, please try again");
            return GetInt(Console.ReadLine());
        }

        public void GetBool(string? isdelayed1, out bool isdelayed2)
        {
            if (isdelayed1 == "1" || isdelayed1 == "yes" || isdelayed1 == "true")
            {
                isdelayed2 = true;
                return;
            }
            if (isdelayed1 == "0" || isdelayed1 == "no" || isdelayed1 == "flase")
            {
                isdelayed2 = false;
                return;
            }
            Console.WriteLine("what?");
            GetBool(Console.ReadLine(), out isdelayed2);
        }

        
        public void PrintPaper(long id)
        {
            Paper paper = GetPaper(id);
            paper.Print();
        }
        public Paper? GetPaper(long id)
        {
            //return Papers.First(p => p.Id == id);
            foreach (Paper paper in Papers)
            {
                if (paper.Id.Equals(id))
                {
                    return paper;
                }
            }
            return null;
        }
    }
}
