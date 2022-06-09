using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double successRate;
        if(speed == 0)
            successRate = 0;
        else if(speed >= 1 && speed <=4)
            successRate = 1;
        else if(speed >= 5 && speed <= 8)
            successRate = 0.9;
        else if(speed == 9)
            successRate = 0.8;
        else if(speed == 10)
            successRate = 0.77;
        else
            throw new ArgumentOutOfRangeException("Speed cannot be below 0 or exceed 10");

        return successRate;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return (double)(speed * SuccessRate(speed) * 221);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        var calculation = ProductionRatePerHour(speed) / 60;
        var result = (int)calculation;
        return result;
    }
}
