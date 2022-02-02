using Behavior.Strategy;

class Program
{
    static void Main (string[] args)
    {
        #region Strategy
        Car auto = new Car(4, "Volvo", new PetrolMove());
        auto.Move();
        auto.Movable = new ElectricMove();
        auto.Move();

        #endregion
    }
}