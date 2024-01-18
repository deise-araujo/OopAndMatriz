using OopBall.Model;
namespace OopBall;
public class BallPower : Ball
{
    private string ballPowerName;

    public BallPower(string color, int volume, int hardness, int weight, string ballPowerName) : base(color, volume, hardness, weight)
    {
        this.ballPowerName = ballPowerName;
    }

    public void DisplayBallPowerName()
    {
        Console.WriteLine($"Ball Power Name is: {this.ballPowerName}");
    }
}
