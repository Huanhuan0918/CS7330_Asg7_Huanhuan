using System;

public class Class1
{
    public const byte sample1 = 0x3A;
    public byte sample2 = 58;
    public int heartRate = 85;
    public double deposit = 135002796;
    public float acceleration = 9.800;
    public float mass = 14.6;
    public double distance = 129.763001;
    public bool lost = true;
    public bool expensive = true;
    public int choice = 2;
    public const char integral = '\u222B';
    public const string greeting = "Hello";
    public string greeting = "Karen";
    public Class1()
	{
	}

    static void Main(string[] args)
    {
        if (sample1 == sample2)
        {
            Console.WriteLine("The samples are equal.");
        }
        else
        {
            Console.WriteLine("The samples are not equal.");
        }


    }

}
