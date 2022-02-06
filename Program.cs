public enum Gender : byte
{
    Male = 1,
    Female = 2
}
public interface IPeople
{
    Gender GetGender();
    bool CanWalk();
    string Speak();
}


public class Male : IPeople
{
    public bool CanWalk()
    {
        return true;
    }

    public Gender GetGender()
    {
        return Gender.Male;
    }

    public string Speak()
    {
        return "Hello, I am male";
    }
}

public class Female : IPeople
{
    public bool CanWalk()
    {
        return true;
    }

    public Gender GetGender()
    {
        return Gender.Female;
    }

    public string Speak()
    {
        return "Hello, I am female";
    }
}


namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPeople male = new Male();
            Console.WriteLine(male.Speak());
        }
    }
}