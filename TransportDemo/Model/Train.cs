namespace TransportDemo.Model;

internal class Train(double fixedJourneyTime): TransportMode
{
    private double _fixedJourneyTime = fixedJourneyTime;
    
    /*
     * Direct approach to implementing the abstract method GetTravelTime(),
     * opting for a fixed travel time that remains constant regardless of distance.
     */
    public override double GetTravelTime(double distance)
    {
        return _fixedJourneyTime;
    }

    /*
     * Overrides the virtual method CalculateBaseFare() in the Train class.
     * This method leverages the default base fare from the parent class ,
     * but also offers a 10% discount to encourage longer trips.
     */
    public override double CalculateBaseFare(double distance)
    {
        var baseFare = base.CalculateBaseFare(distance);
        if (distance > 500)
        {
            baseFare *= 0.9;
        }
        return baseFare;
    }
}