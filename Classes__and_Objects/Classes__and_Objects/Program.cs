// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Student
{
    int rollNo;
    string name;
    int age;
    int standard;

    public void setStudent(int rollNo, string name, int age, int standard)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.age = age;
        this.standard = standard;
    }

    public void getStudent()
    {
        //return this.rollNo; 
        //using PLaceholder Syntax { index of the field } eg:- {0} 
        Console.WriteLine("Your Rollno is {0}",this.rollNo);
        Console.WriteLine("Your Name is {0}",this.name);
        Console.WriteLine("Your age is {0}",this.age);
        Console.WriteLine("Your Standard is {0}",this.standard);
    }
    //public void setName(String name)
    //{
    //    this.name = name;
    //}
    //public String getName()
    //{
    //    return this.name;
    //}

    static void Main(String[] args)
    {
        //Creation of object of class Student.
        Student stu = new Student();

        //setting properties of student
        //stu.setRollNo(1);
        //stu.setName("Ram");
        //stu.setName("Arjun");

        ////getting properties of student
        //int rollno = stu.getRollNo();
        //string name = stu.getName();
        //string name1 = stu.getName();


        // Console.WriteLine("Student with roll no "+rollno+" name is "+name1 );

        Console.Write("Enter Your Roll NO : ");
        int rollno = int.Parse(Console.ReadLine());
        Console.Write("Enter Your Name : ");
        string name = (Console.ReadLine());
        Console.Write("Enter Your Age : ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter Your Standard : ");
        int standard = int.Parse(Console.ReadLine());
        Console.WriteLine("--------------xxxxxxxxxx--------------");


        //Setting all the properties of student 
        //stu.setStudent(1, "Ram", 17, 10);

        stu.setStudent(rollno, name, age, standard);

        //Getting all the properties of student 
        stu.getStudent();

    }
}
