namespace FactoryPattern;

public class VehicleFactory
{
    public static IVehicle CreateVehicle(int wheelCount)
    {
        switch (wheelCount)
        {
            case 2:
                return new Motorcycle();
            case 4:
                return new Car();
            case 18:
                return new Bigrig();
            default:
                return new Car();
            
        }
    }
}