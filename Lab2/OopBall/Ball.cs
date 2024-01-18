namespace OopBall.Model;

//Encapsulates
public class Ball : IBall
{

    // Construct
    private string color;
    private int volume;
    private int hardness;
    private int weight;
    
    //Contructor
    public Ball (string color, int volume, int hardness, int weight){
        this.color = color;
        this.volume = volume;
        this.hardness = hardness;
        this.weight = weight;
    }
    
    public bool Roll()
    {
        return false;
    }

    public bool Rebound()
    {
        return false;
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public int Volume
    {
        get {return volume; }
        set { volume = value; }
    }

    public int Hardness
    {
        get { return hardness; }
        set { hardness = value; }
    }

    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }
    
}