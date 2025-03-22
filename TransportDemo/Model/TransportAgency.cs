using System.Numerics;
using System.Transactions;

namespace TransportDemo.Model;

internal class TransportAgency
{
    public TransportMode CreateTransportMode(TransportModeType modeType)
    {
        return modeType switch
        {
            TransportModeType.Car => new Car(60),
            TransportModeType.Plane => new Plane(800),
            TransportModeType.Train => new Train(4), _ => throw new ArgumentException("Invalid transport mode type"),
        };
    }
}