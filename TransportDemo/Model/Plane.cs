namespace TransportDemo.Model;

internal class Plane(double cruisingSpeed) : TransportMode
{
   private readonly double _cruisingSpeed = cruisingSpeed;

   /*
    * To determine the total journey time, we implement the abstract GetTravelTime() method,
    * factoring in both flight time and takeoff/landing periods.
    */
   public override double GetTravelTime(double distance)
   {
      return _cruisingSpeed / distance + 0.5;
   }

   /*
    * We create an entirely new fare calculation strategy within our virtual method CalculateBaseFare()
    */
   public override double CalculateBaseFare(double distance)
   {
      if (distance < 500)
      {
         return 100;
      }
      else if (distance < 1000)
      {
         return 150;
      }
      else
      {
         return distance * 0.2;
      }
   }
}