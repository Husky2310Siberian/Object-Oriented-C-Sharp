namespace TransportDemo.Model;
/// <summary>
///  We use the abstract class TransportMode(), to mandate that every derived class— Car, Train, or Plane
///  must override the abstract method GetTravelTime().
///  This ensures that every transport mode, provides a way to calculate travel time based on distance,
///  leading to consistency and predictability across all modes.
///  ---------------------------------------------------------------
///  Our virtual method CalculateBaseFare() serves as a starting point for fare calculations,
///  but derived classes can tailor it to their specific needs.
///  This allows us to incorporate fuel costs in the Car class and
///  offer discounts for longer journeys in the Train class.
/// </summary>
internal abstract class TransportMode
{
    /*
     * To determine the total travel time based on the mode of transportation, we use the method GetTravelTime().
     * Is designed as abstract, because travel time varies significantly depending on the transportation mode used.
     * It would not be meaningful, to provide a default travel time in this context.
     */
    public abstract double GetTravelTime(double distance);
    
    /*
     * Provides a default fare that can be applied universally.
     * Derived classes will have the option, to either utilize this default fare directly in their total fare calculations
     * or override the method to implement their specific fare calculation logic, tailored to their unique needs.
     */
    public virtual double CalculateBaseFare(double distance)
    {
        return distance * 0.5;
    }
}