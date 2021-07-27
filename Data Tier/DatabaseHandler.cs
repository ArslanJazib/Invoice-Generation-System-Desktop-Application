using System;
using System.Data.SqlClient;
using System.Data;
namespace DataTier
{
    public class DatabaseHandler
    {
        SqlConnection connection;
        public DatabaseHandler()
        {
            try
            {
                connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\arsla\source\repos\VPAssignment5\DataTier\ResturantMenu.mdf;Integrated Security=True");
                connection.Open();
            }
            catch (Exception e) { }
        }
        public DataTable LoadPizzaData()
        {
            string loadQuery = "Select Name,Price,ImagePath,Size from Pizzas";
            DataTable PizzaMenu = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(loadQuery, connection);
            dataAdapter.Fill(PizzaMenu);
            return PizzaMenu;
        }
        public DataTable getPizzaSizes(string value)
        {
            string loadQuery = "Select Size from Pizzas where Name = '" + value + "'";
            DataTable PizzaMenu = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(loadQuery, connection);
            dataAdapter.Fill(PizzaMenu);
            return PizzaMenu;
        }
        public DataTable getPizzaData(string value)
        {
            string loadQuery = "Select Price,Size from Pizzas where Name = '" + value + "'";
            DataTable PizzaMenu = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(loadQuery, connection);
            dataAdapter.Fill(PizzaMenu);
            return PizzaMenu;
        }
        public DataTable LoadFriesData()
        {
            string loadQuery = "Select Name,Price,ImagePath,Size from Chips";
            DataTable ChipsMenu = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(loadQuery, connection);
            dataAdapter.Fill(ChipsMenu);
            return ChipsMenu;
        }
        public DataTable getFriesSizes(string value)
        {
            string loadQuery = "Select Size from Chips where Name = '" + value + "'";
            DataTable FriesMenu = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(loadQuery, connection);
            dataAdapter.Fill(FriesMenu);
            return FriesMenu;
        }
        public DataTable getFriesData(string value)
        {
            string loadQuery = "Select Price,Size from Chips where Name = '" + value + "'";
            DataTable FriesMenu = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(loadQuery, connection);
            dataAdapter.Fill(FriesMenu);
            return FriesMenu;
        }
        public DataTable LoadDrinksData()
        {
            string loadQuery = "Select Name,Price,ImagePath,Size from Drinks";
            DataTable DrinksMenu = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(loadQuery, connection);
            dataAdapter.Fill(DrinksMenu);
            return DrinksMenu;
        }
        public DataTable getDrinksSizes(string value)
        {
            string loadQuery = "Select Size,Price from Drinks where Name = '" + value + "'";
            DataTable DrinksMenu = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(loadQuery, connection);
            dataAdapter.Fill(DrinksMenu);
            return DrinksMenu;
        }
        public DataTable getDrinksData(string value)
        {
            string loadQuery = "Select Price,Size from Drinks where Name = '" + value + "'";
            DataTable DrinksMenu = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(loadQuery, connection);
            dataAdapter.Fill(DrinksMenu);
            return DrinksMenu;
        }
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
