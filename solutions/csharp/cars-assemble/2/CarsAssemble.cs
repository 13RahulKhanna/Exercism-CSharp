static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        switch(speed){
            case 0:
                return 0;
            case <5:
                return 1;
            case <9:
                return 0.9;
            case 9:
                return 0.8;
            case 10:
                return 0.77;
            default:
                return 0;
        }
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        int carProductionPerHour = 221;
        return speed * SuccessRate(speed) * carProductionPerHour;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {    
        return (int)ProductionRatePerHour(speed) / 60;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
