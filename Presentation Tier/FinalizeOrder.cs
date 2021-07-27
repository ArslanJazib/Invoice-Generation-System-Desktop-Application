using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VPAssignment5
{
    public partial class FinalizeOrder : Form
    {
        resturant menuRef = new resturant();//Will hold the reference of the resturnt form
        List<DataTable> pizzaSizes = new List<DataTable>();//Will result of pizza sizes query
        List<DataTable> friesSizes = new List<DataTable>();//Will result of fries sizes query
        List<DataTable> drinkSizes = new List<DataTable>();//Will result of drinks sizes query
        List<Item> pizza = new List<Item>();//This list stores the pizzas selected by the cutomer
        List<Item> fries = new List<Item>();//This list stores the pizzas selected by the cutomer
        List<Item> drinks = new List<Item>();//This list stores the pizzas selected by the cutomer
        List<Item> Order = new List<Item>();//This list stores all order items
        // Used to calculate total price
        int pizzaPrice;
        int friesPrice;
        int drinksPrice;
        //Create private font collection object.
        PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        public FinalizeOrder()
        {
            InitializeComponent();
        }
        public FinalizeOrder(resturant reference)
        {
            InitializeComponent();
            menuRef = reference;// Passing the reference to variable
            CustomizedFont();

        }
        private void FinalizeOrder_Load(object sender, EventArgs e)
        {
            // Loading the data selected in the previous form into the controls
            loadPizzaData();
            loadFriesData();
            loadDrinksData();
        }
        public void loadPizzaData()
        {
            foreach (Item item in menuRef.SelectedPizza)
            {
                DataTable pizzaData = new DataTable();
                //Adding to combox collections
                pizzaType.Items.Add(item.ItemName);
                //Storing pizza sizes
                pizzaSizes.Add(menuRef.DataHandler.getPizzaSizes(item.ItemName));
                // Table holds all sizes and price options for an indiviual item
                pizzaData=menuRef.DataHandler.getPizzaPrices(item.ItemName);
                // Adding all available sizes and prices for an indiviual item to a list of items
                foreach (DataRow row in pizzaData.Rows)
                {
                    Item itemPizza = new Item();
                    itemPizza.ItemName = item.ItemName;
                    itemPizza.Price = row[0].ToString();
                    itemPizza.Size = row[1].ToString();
                    pizza.Add(itemPizza);
                }
            }
            //Adding to combox collections
            if (pizzaSizes.Count > 0)
            {
                foreach (DataRow row in pizzaSizes[0].Rows)
                {
                    pizzaSize.Items.Add(row[0].ToString());
                }
            }
        }
        public void loadFriesData()
        {
            foreach (Item item in menuRef.SelectedFries)
            {
                DataTable friesPrices = new DataTable();
                //Adding to combox collections
                friesType.Items.Add(item.ItemName);
                //Storing fries sizes
                friesSizes.Add(menuRef.DataHandler.getFriesSizes(item.ItemName));
                // Table holds all sizes and price options for an indiviual item
                friesPrices = menuRef.DataHandler.getFriesPrices(item.ItemName);
                // Adding all available sizes and prices for an indiviual item to a list of items
                foreach (DataRow row in friesPrices.Rows)
                {
                    Item itemFries = new Item();
                    itemFries.ItemName = item.ItemName;
                    itemFries.Price = row[0].ToString();
                    itemFries.Size = row[1].ToString();
                    fries.Add(itemFries);
                }
            }
            //Adding to combox collections
            if (friesSizes.Count>0)
            {
                foreach (DataRow row in friesSizes[0].Rows)
                {
                    friesSize.Items.Add(row[0].ToString());
                }
            }
        }
        public void loadDrinksData()
        {
            foreach (Item item in menuRef.SelectedDrinks)
            {
                DataTable drinksPrices = new DataTable();
                //Adding to combox collections
                drinkType.Items.Add(item.ItemName);
                //Storing drink sizes
                drinkSizes.Add(menuRef.DataHandler.getDrinkSizes(item.ItemName));
                // Table holds all sizes and price options for an indiviual item
                drinksPrices = menuRef.DataHandler.getDrinkPrices(item.ItemName);
                // Adding all available sizes and prices for an indiviual item to a list of items
                foreach (DataRow row in drinksPrices.Rows)
                {
                    Item itemDrinks = new Item();
                    itemDrinks.ItemName = item.ItemName;
                    itemDrinks.Price = row[0].ToString();
                    itemDrinks.Size = row[1].ToString();
                    drinks.Add(itemDrinks);
                }
            }
            //Adding to combox collections
            if (drinkSizes.Count>0)
            {
                foreach (DataRow row in drinkSizes[0].Rows)
                {
                    drinkSize.Items.Add(row[0].ToString());
                }
            }
        }
        private void CustomizedFont()
        {


            //Select your font from the resources.
            int fontLength = Properties.Resources.docktrin.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.docktrin;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            privateFontCollection.AddMemoryFont(data, fontLength);

            label1.Font = new Font(privateFontCollection.Families[0], label1.Font.Size);


        }

        private void orderGroupbox_Enter(object sender, EventArgs e)
        {

        }

        private void pizzaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If all controls are filled updating total cost
            //Traversing all the items in the list of items selected in previous form
            foreach (Item item in pizza)
            {
                if(pizzaSize.SelectedItem!=null)
                {
                    if (item.Size == pizzaSize.SelectedItem.ToString()
                       && item.ItemName == pizzaType.SelectedItem.ToString()
                       && pizzaQuantity.Text != "")
                    {
                        pizzaPrice = int.Parse(pizzaQuantity.Text) * (int)double.Parse(item.Price);
                        total_tbox.Text = (pizzaPrice+friesPrice+drinksPrice).ToString();
                        break;

                    }
                }
            }
        }

        private void pizzaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If all controls are filled updating total cost
            //Traversing all the items in the list of items selected in previous form
            foreach (Item item in pizza)
            {
                if(pizzaType.SelectedItem!=null)
                {
                    if (item.Size == pizzaSize.SelectedItem.ToString()
                       && item.ItemName == pizzaType.SelectedItem.ToString()
                       && pizzaQuantity.Text != "")
                    {
                        pizzaPrice = int.Parse(pizzaQuantity.Text) * (int)double.Parse(item.Price);
                        total_tbox.Text = (pizzaPrice + friesPrice + drinksPrice).ToString();
                        break;

                    }
                }
            }
        }

        private void pizzaQuantity_TextChanged(object sender, EventArgs e)
        {
            // If all controls are filled updating total cost
            //Traversing all the items in the list of items selected in previous form
            if (pizzaType.SelectedIndex>=0 && pizzaSize.SelectedIndex >= 0)
            {
                foreach (Item item in pizza)
                {
                    if (item.Size == pizzaSize.SelectedItem.ToString()
                        && item.ItemName == pizzaType.SelectedItem.ToString()
                        && pizzaQuantity.Text != "")
                    {
                        pizzaPrice = (int.Parse(pizzaQuantity.Text) * (int)double.Parse(item.Price));
                        total_tbox.Text = (pizzaPrice + friesPrice + drinksPrice).ToString();
                        break;

                    }
                }
            }

        }

        private void friesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If all controls are filled updating total cost
            //Traversing all the items in the list of items selected in previous form
            foreach (Item item in fries)
            {
               if (friesSize.SelectedItem != null)
               {
                    if (item.Size == friesSize.SelectedItem.ToString()
                    && item.ItemName == friesType.SelectedItem.ToString()
                    && friesQuantity.Text != "")
                    {
                     friesPrice = int.Parse(friesQuantity.Text) * (int)double.Parse(item.Price);
                     total_tbox.Text  = (pizzaPrice + friesPrice + drinksPrice).ToString();
                     break;

                    }
               }
            }
        }

        private void friesSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If all controls are filled updating total cost
            //Traversing all the items in the list of items selected in previous form
            foreach (Item item in fries)
            {
                if (friesType.SelectedItem != null)
                {
                    if (item.Size == friesSize.SelectedItem.ToString()
                        && item.ItemName == friesType.SelectedItem.ToString()
                        && friesQuantity.Text != "")
                    {
                        friesPrice = int.Parse(friesQuantity.Text) * (int)double.Parse(item.Price);
                        total_tbox.Text = total_tbox.Text = (pizzaPrice + friesPrice + drinksPrice).ToString();
                        break;

                    }
                }
            }
        }

        private void friesQuantity_TextChanged(object sender, EventArgs e)
        {
            // If all controls are filled updating total cost
            //Traversing all the items in the list of items selected in previous form
            foreach (Item item in fries)
            {
                if (friesType.SelectedIndex >= 0 && friesSize.SelectedIndex >= 0)
                {
                    if (item.Size == friesSize.SelectedItem.ToString()
                    && item.ItemName == friesType.SelectedItem.ToString()
                    && friesQuantity.Text != "")
                    {
                        friesPrice = int.Parse(friesQuantity.Text) * (int)double.Parse(item.Price);
                        total_tbox.Text = (pizzaPrice + friesPrice + drinksPrice).ToString();
                        break;

                    }
                }
            }
        }

        private void drinkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If all controls are filled updating total cost
            //Traversing all the items in the list of items selected in previous form
            foreach (Item item in drinks)
            {
                if(drinkSize.SelectedItem!=null)
                {
                    if (item.Size == drinkSize.SelectedItem.ToString()
                       && item.ItemName == drinkType.SelectedItem.ToString()
                       && drinkQuantity.Text != "")
                    {
                        drinksPrice = int.Parse(drinkQuantity.Text) * (int)double.Parse(item.Price);
                        total_tbox.Text = (pizzaPrice + friesPrice + drinksPrice).ToString();
                        break;

                    }
                }
            }
        }

        private void drinkSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If all controls are filled updating total cost
            //Traversing all the items in the list of items selected in previous form
            foreach (Item item in drinks)
            {
                if(drinkType.SelectedItem!=null)
                {
                    if (item.Size == drinkSize.SelectedItem.ToString()
                       && item.ItemName == drinkType.SelectedItem.ToString()
                       && drinkQuantity.Text != "")
                    {
                        drinksPrice = int.Parse(drinkQuantity.Text) * (int)double.Parse(item.Price);
                        total_tbox.Text = (pizzaPrice + friesPrice + drinksPrice).ToString();
                        break;

                    }
                }
            }
        }

        private void drinkQuantity_TextChanged(object sender, EventArgs e)
        {
            // If all controls are filled updating total cost
            //Traversing all the items in the list of items selected in previous form
            foreach (Item item in drinks)
            {
                if (drinkType.SelectedIndex >= 0 && drinkSize.SelectedIndex >= 0)
                {
                    if (item.Size == drinkSize.SelectedItem.ToString()
                    && item.ItemName == drinkType.SelectedItem.ToString()
                    && drinkQuantity.Text != "")
                    {
                        drinksPrice = int.Parse(drinkQuantity.Text) * (int)double.Parse(item.Price);
                        total_tbox.Text = (pizzaPrice + friesPrice + drinksPrice).ToString();
                        break;

                    }
                }
            }
        }

        private void memberCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cashGiven_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearOrder_Click(object sender, EventArgs e)
        {
            total_tbox.Clear();
            drinkQuantity.Clear();
            friesQuantity.Clear();
            pizzaQuantity.Clear();
            Order.Clear();
            invoice_tbox.Clear();
            pizzaPrice=0;
            friesPrice=0;
            drinksPrice=0;
        }

        private void submitOrder_Click(object sender, EventArgs e)
        {
            // If all controls are filled adding the item in order list
            //Traversing all the items in the list of items selected in previous form
            foreach (Item item in pizza)
            {
                if (pizzaType.SelectedItem != null && pizzaSize.SelectedItem!=null && pizzaQuantity.Text != "")
                {
                    if (item.Size == pizzaSize.SelectedItem.ToString()
                       && item.ItemName == pizzaType.SelectedItem.ToString())
                    {
                        int quantity = int.Parse(pizzaQuantity.Text);
                        do//Will add the same item in the list according to quantity
                        {
                            Item OrderedPizza = new Item();
                            OrderedPizza.ItemName = item.ItemName;
                            OrderedPizza.Price = item.Price;
                            OrderedPizza.Size = item.Size;
                            Order.Add(OrderedPizza);
                            --quantity;
                        } while (quantity!=0);
                        break;

                    }
                }
                else
                {
                    break;
                }
            }
            // If all controls are filled adding the item in order list
            //Traversing all the items in the list of items selected in previous form
            foreach (Item item in fries)
            {
                if (friesType.SelectedItem != null && friesSize.SelectedItem != null && friesQuantity.Text != "")
                {
                    if (item.Size == friesSize.SelectedItem.ToString()
                       && item.ItemName == friesType.SelectedItem.ToString())
                    {
                        int quantity = int.Parse(friesQuantity.Text);
                        do//Will add the same item in the list according to quantity
                        {
                            Item OrderedFries = new Item();
                            OrderedFries.ItemName = item.ItemName;
                            OrderedFries.Price = item.Price;
                            OrderedFries.Size = item.Size;
                            Order.Add(OrderedFries);
                            --quantity;
                        } while (quantity != 0);
                        break;

                    }
                }
                else
                {
                    break;
                }
            }
            // If all controls are filled adding the item in order list
            //Traversing all the items in the list of items selected in previous form
            foreach (Item item in drinks)
            {
                if (drinkType.SelectedItem != null && drinkSize.SelectedItem != null && drinkQuantity.Text != "")
                {
                    if (item.Size == drinkSize.SelectedItem.ToString()
                       && item.ItemName == drinkType.SelectedItem.ToString())
                    {
                        int quantity = int.Parse(drinkQuantity.Text);
                        do//Will add the same item in the list according to quantity
                        {
                            Item OrderedDrinks = new Item();
                            OrderedDrinks.ItemName = item.ItemName;
                            OrderedDrinks.Price = item.Price;
                            OrderedDrinks.Size = item.Size;
                            Order.Add(OrderedDrinks);
                            --quantity;
                        } while (quantity != 0);
                        break;

                    }
                }
                else
                {
                    break;
                }
            }
            MessageBox.Show("Add the next item to order", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //To display the currnt total in the invoice textbox
            int total = 0;
            int discount = 0;
            if (invoice_tbox.Text!="")//Updating the previous total
            {
                total = int.Parse(invoice_tbox.Text.Substring(15));
                total += int.Parse(total_tbox.Text);
                if (memberCheckBox.Checked)//Applying discount
                {
                    discount = (int)(0.5f + ((10/100f) *total ));
                    total = total - discount;
                }
            }
            else
            {
                total += int.Parse(total_tbox.Text);
                if (memberCheckBox.Checked)
                {
                    discount = (int)(0.5f + ((10 / 100f) * total));
                    total = total - discount;
                }
            }
            invoice_tbox.Clear();
            invoice_tbox.Text = "Current total: "+total.ToString()+"\n";
            discount_tbox.Text=  discount.ToString();
            drinkQuantity.Clear();
            friesQuantity.Clear();
            pizzaQuantity.Clear();
        }

        private void generateInvoice_Click(object sender, EventArgs e)
        {
            invoice_tbox.Clear();
            int total=0;
            int discount=0;
            if(cashGiven_tbox.Text!="")
            {
                foreach (Item item in Order)//Totaling all items in the order list
                {
                    total+= (int)(double.Parse(item.Price));
                }
                if(int.Parse(cashGiven_tbox.Text)>=total)
                {
                    if(memberCheckBox.Checked)
                    {
                        discount = (int)(0.5f + ((10 / 100f) * total));
                        total = total - discount;
                        total_tbox.Text = total.ToString();
                        discount_tbox.Text = discount.ToString();
                    }
                    change_tbox.Text = (int.Parse(cashGiven_tbox.Text)-total).ToString();
                    foreach (Item item in Order)
                    {
                        invoice_tbox.Text += item.ItemName + "\n";
                        invoice_tbox.Text += item.Size + "\n";
                        invoice_tbox.Text += item.Price + "\n";
                        invoice_tbox.Text += "\n";
                    }
                    invoice_tbox.Text += "Total: " + total.ToString() + "\n";
                    invoice_tbox.Text += "Discount: " + discount + "\n";
                    invoice_tbox.Text += "Change: " + change_tbox.Text;
                }
                else
                {
                    MessageBox.Show("Insufficent amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Enter the amount paid by the cutsomer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void backArrow_Click(object sender, EventArgs e)
        {
            menuRef.Invalidate();
            menuRef.Show();
            this.Hide();
        }
    }
}
