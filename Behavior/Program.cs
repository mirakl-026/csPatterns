using Behavior.Strategy;
using Behavior.Observer;

class Program
{
    static void Main (string[] args)
    {
        #region Strategy
        //Car auto = new Car(4, "Volvo", new PetrolMove());
        //auto.Move();
        //auto.Movable = new ElectricMove();
        //auto.Move();

        #endregion

        #region Observer
        Stock stock = new Stock();
        Bank bank = new Bank("ЮнитБанк", stock);
        Broker broker = new Broker("Иван Иваныч", stock);

        // имитация торгов
        stock.Market();
        // брокер прекращает наблюдать за торгами
        broker.StopTrade();
        // имитация торгов
        stock.Market();

        #endregion
    }
}