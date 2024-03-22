public class Vehicle
{
    int HIZ;
    public Vehicle(int _yil, int _hiz)
    {
        hiz = _hiz;

    }
    public int hiz
    {
        get { return HIZ; }
        set
        {
            if (value <=250) 
            {
                Console.WriteLine("hizin +10 artti");
                HIZ = value+10;
            }
        }

    }
    public static void Main(string[] args)
    {
        Vehicle Audi = new Vehicle(2012, 320);
        Console.WriteLine(Audi.hiz);
        Vehicle honda = new Motorcycle(2008,300);
    }
}

public class Motorcycle:Vehicle
{
    public Motorcycle(int _yil,int _hiz) : base(_yil,_hiz)
    {

    }


}

