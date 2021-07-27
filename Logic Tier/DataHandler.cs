using System.Data;
using DataTier;
namespace LogicTier
{
    public class DataHandler
    {
        DataTable pizza = new DataTable();
        DataTable fries = new DataTable();
        DataTable drinks = new DataTable();
        DatabaseHandler dataHandler = new DatabaseHandler();

        public DataTable LoadPizzaDataGird()
        {
            pizza = dataHandler.LoadPizzaData();
            //Showing only the necessary columns
            pizza = pizza.DefaultView.ToTable(true, "ImagePath", "Name");
            return pizza;
        }
        public DataTable LoadFriesDataGird()
        {
            fries = dataHandler.LoadFriesData();
            //Showing only the necessary columns
            fries = fries.DefaultView.ToTable(true, "ImagePath", "Name");
            return fries;
        }
        public DataTable LoadDrinksDataGird()
        {
            drinks = dataHandler.LoadDrinksData();
            //Showing only the necessary columns
            drinks = drinks.DefaultView.ToTable(true, "ImagePath", "Name");
            return drinks;
        }
        public DataTable getPizzaSizes(string pizzaType)
        {
            DataTable pizzaSizes = new DataTable();
            pizzaSizes = dataHandler.getPizzaSizes(pizzaType);
            return pizzaSizes;
        }
        public DataTable getFriesSizes(string FriesType)
        {
            DataTable FriesSizes = new DataTable();
            FriesSizes = dataHandler.getFriesSizes(FriesType);
            return FriesSizes;
        }
        public DataTable getDrinkSizes(string DrinkType)
        {
            DataTable DrinkSizes = new DataTable();
            DrinkSizes = dataHandler.getDrinksSizes(DrinkType);
            return DrinkSizes;
        }
        public DataTable getPizzaPrices(string pizzaType)
        {
            DataTable pizzaPrice = new DataTable();
            pizzaPrice = dataHandler.getPizzaData(pizzaType);
            return pizzaPrice;
        }
        public DataTable getFriesPrices(string FriesType)
        {
            DataTable FriesPrice = new DataTable();
            FriesPrice = dataHandler.getFriesData(FriesType);
            return FriesPrice;
        }
        public DataTable getDrinkPrices(string DrinkType)
        {
            DataTable DrinkPrice = new DataTable();
            DrinkPrice = dataHandler.getDrinksData(DrinkType);
            return DrinkPrice;
        }
        public void close()
        {
            dataHandler.CloseConnection();
        }
    }
}
