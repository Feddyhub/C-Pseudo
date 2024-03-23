public class EmployeeTest
{
    public string NAME;
    public static void Main(string[] args)
    {
        Date no1 = new Date(30, 12);
        Employee kisi = new Employee("MEHMET",no1);
        Console.WriteLine(no1.day);
        Date no2 = new Date(15, 15);
        Employee kisi2 = new Employee("AHMET",no2);
        Console.WriteLine(no2.day);
    }
}


public class Date
{
    
     int MONTH;
     int DAY;
    
    public Date(int _day, int _month)
    {
        
        month = _month;
        day = _day;
    }
    
    public int month
    {
        get { return MONTH; }
        set { MONTH = value; }
    }
    public int day
    { get { return DAY; }
        set
        {
            DAY = value;
        }
    }
}

public class Employee
{
    public Date birthday;
    public string NAME;

    public Employee(string _name , Date _birthdate)
    {
        NAME= _name;
        birthday = _birthdate;
    }
    public  Date getBirthday()
    {
        return birthday ;
    }
    
}
