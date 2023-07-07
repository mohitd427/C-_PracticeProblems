// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Employee 
{
    int EmpId,EmpAge;
    string EmpName;
    
    //Default Constructor
    public Employee()
    {
        Console.WriteLine("I am Default Constructor.");
    }

    //Parameterized Constructor
    public Employee(int EmpId,string EmpName, int EmpAge)
    {
        this.EmpId = EmpId;
        this.EmpName = EmpName;
        this.EmpAge = EmpAge;
    }

    public int EmployeeId()
    {
        return this.EmpId;        
    }
    public void GetEmployee() 
    {
        Console.WriteLine("Emp Id is {0}", this.EmpId);
        Console.WriteLine("Emp Name is {0}", this.EmpName);
        Console.WriteLine("Emp Age is {0}", this.EmpAge);

    }

    static void Main()
    {
        //Default Constructor will be called at object creation only It's no need to call it.
        Employee employee = new Employee();

        //Parameterised Ctor calling
        Employee employee1 = new Employee(1,"Ram",2000);

        //Console.WriteLine("EmpId is {0}",employee1.EmployeeId());
        employee1.GetEmployee();
    }
}


