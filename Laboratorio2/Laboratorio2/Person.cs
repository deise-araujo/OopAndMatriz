namespace Laboratorio2;

public class Person
{
    // fields (campos)
    private string name;
    private string lastName;
    private int age;
    
    // properties (Propiedades)
    public string Name
    {
        // methods (metodos)
        get { return name; }
        set {name = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    
    public char[] SplitString(string input)
    {
        return input.ToCharArray();
    }

    public string JoinCharArray(char[] charArray)
    {
        return new string(charArray);
    }

    public string GetSubstring(string input, int startIndex, int length)
    {
        return input.Substring(startIndex, length);
    }

    public bool CompareStrings(string str1, string str2)
    {
        return string.Equals(str1, str2);
    }

    public bool SearchString(string source, string searchString)
    {
        return source.Contains(searchString);
    }
    
}