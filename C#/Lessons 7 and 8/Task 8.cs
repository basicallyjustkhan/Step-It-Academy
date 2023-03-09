// Task 8
class Student
{
    int[] _marks = new int[31];
    private int _days;
    public string _lastName { get; set; }
    public string _firstName { get; set; }
    public string _patronymic { get; set; }
    public string _group { get; set; }
    public int _age { get; set; }
        
       
    public Student(string firstName, string lastName, string patronymic, int age)
    {
        _days = 0;
        _firstName = firstName;
        _lastName = lastName;
        _patronymic = patronymic;
        _age = age;
    }

    public Student(string firstName, string lastName, string patronymic, string group, int age)
    {
        _days = 0;
        _firstName = firstName;
        _lastName = lastName;
        _patronymic = patronymic;
        _group = group;
        _age = age;
    }

    public void addMark(int mark)
    {
        _marks[_days] = mark;
        _days++;
    }
    
    public void printStudent()
    {
        Console.WriteLine("                Student");
        Console.WriteLine("Firstname:  {0}", _firstName);
        Console.WriteLine("Lastname:   {0}", _lastName);
        Console.WriteLine("Patronymic: {0}", _patronymic);
        Console.WriteLine("Group Name: {0}", _group);
        Console.WriteLine();
        Console.WriteLine();
        
        Console.WriteLine("                All Marks");
        for (int i = 0; i < _days; i++)
        {
            Console.Write(" Day: {0}, Mark: {1}", i, _marks[i]);
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Shamsaddin", "Khan-Babayev", "Samir", "VIP", 15);
        student.addMark(5);
        student.addMark(3);
        student.addMark(7);
        student.addMark(4);
        student.addMark(3);
        student.addMark(6);
        student.addMark(8);
        student.addMark(9);
        student.addMark(17);
        student.addMark(13);
        student.printStudent();
    }
}
