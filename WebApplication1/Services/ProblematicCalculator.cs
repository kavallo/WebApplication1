namespace WebApplication1.Services;

public class ProblematicCalculator
{
    public int Calculate(int value)
    {
        if (value < 0)
        {
            return 0;
        }
        else if (value == 0)
        {
            return 1;
        }
        else if (value == 1)
        {
            return 2;
        }
        else if (value == 2)
        {
            return 4;
        }
        else
        {
            return value * 10;
        }
    }
}
