namespace Laboratorio2;

public class Faculty
{
    // fields (campos)
    public string course;
    
    // Construct
    public Faculty()
    {
        course = "Programming 3";
    }
    
    // Destruct
    ~Faculty()
    {
        Console.WriteLine("Destructing...");
    }
}