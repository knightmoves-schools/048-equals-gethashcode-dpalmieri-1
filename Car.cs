namespace knightmoves;

public class Car{
    public string Make {get;}
    public string Model {get;}

    public Car(string make, string model)
    {
        Make = make;
        Model = model;
    }
    
    public override bool Equals(object? obj)
    {
        if (obj is Car otherCar)
        {
            return Make == otherCar.Make && Model == otherCar.Model;
        }
        return false;
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Make, Model);
    }
}