namespace TransportDemo.Model;
/// <summary>
/// 
/// </summary>
internal class Car(double averageSpeed) : TransportMode
{
    private readonly double _averageSpeed = averageSpeed;
    
    /*
     * Provides a car-specific implementation, for determining travel time.
     */
    public override double GetTravelTime(double distance)
    {
        return distance / _averageSpeed;
    }

    /*
     * We tailor fare calculations for cars by overriding the virtual method.
     * This method leverages the existing default base fare, from the base class and then
     * incorporates the fuel cost into the final calculation.
     */
    public override double CalculateBaseFare(double distance)
    {
        return base.CalculateBaseFare(distance) + 2.5;
    }
}