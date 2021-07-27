using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using LogicTier;
namespace VPAssignment5
{
    public partial class resturant : Form
    {
        DataHandler dataHandler = new DataHandler();
        DataTable pizza = new DataTable();
        DataTable fries = new DataTable();
        DataTable drinks = new DataTable();
        List<Item> selectedPizza = new List<Item>();
        List<Item> selectedFries = new List<Item>();
        List<Item> selectedDrinks = new List<Item>();
        // To use cutomized font
        PrivateFontCollection privateFontCollection = new PrivateFontCollection();

        public DataTable Pizza { get => pizza; set => pizza = value; }
        public DataTable Fries { get => fries; set => fries = value; }
        public DataTable Drinks { get => drinks; set => drinks = value; }
        internal List<Item> SelectedPizza { get => selectedPizza; set => selectedPizza = value; }
        internal List<Item> SelectedFries { get => selectedFries; set => selectedFries = value; }
        internal List<Item> SelectedDrinks { get => selectedDrinks; set => selectedDrinks = value; }
        public DataHandler DataHandler { get => dataHandler; set => dataHandler = value; }

        public resturant()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomizedFont();
            //Loading Data from the database into the datagrid
            pizzaGridView.DataSource= DataHandler.LoadPizzaDataGird();
            friesGridView.DataSource = DataHandler.LoadFriesDataGird();
            drinksGridView.DataSource = DataHandler.LoadDrinksDataGird();
            //Closing connection
            DataHandler.close();
            //Placing in place of imagePath column
            ImagePlacer();
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

            //Changing label fonts to customized font
            label1.Font = new Font(privateFontCollection.Families[0], label1.Font.Size);
            label2.Font = new Font(privateFontCollection.Families[0], label2.Font.Size);
            label3.Font = new Font(privateFontCollection.Families[0], label3.Font.Size);
            label4.Font = new Font(privateFontCollection.Families[0], label4.Font.Size);
            label5.Font = new Font(privateFontCollection.Families[0], label5.Font.Size);
            label6.Font = new Font(privateFontCollection.Families[0], label6.Font.Size);
        }

        private void namePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ImagePlacer()
        {
            // Used to unbind the grid from data source for traversing purposes
            CurrencyManager cm = (CurrencyManager)BindingContext[pizzaGridView.DataSource];
            foreach (DataGridViewRow row in pizzaGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    cm.SuspendBinding();
                    //Resizing image according to the picture box size
                    //Intializing image variable with the image present in the imagePath cell
                    Image image = ResizeImage(Image.FromFile(row.Cells[1].Value.ToString()), row.Cells[0].Size);
                    row.Cells[0].Value= image;
                    
                }

            }
            pizzaGridView.Columns.RemoveAt(1);//Removing the imagePath column
            foreach (DataGridViewRow row in friesGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    cm.SuspendBinding();
                    //Resizing image according to the picture box size
                    //Intializing image variable with the image present in the imagePath cell
                    Image image = ResizeImage(Image.FromFile(row.Cells[1].Value.ToString()), row.Cells[0].Size);
                    row.Cells[0].Value = image;

                }

            }
            friesGridView.Columns.RemoveAt(1);//Removing the imagePath column
            foreach (DataGridViewRow row in drinksGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    cm.SuspendBinding();
                    //Resizing image according to the picture box size
                    //Intializing image variable with the image present in the imagePath cell
                    Image image = ResizeImage(Image.FromFile(row.Cells[1].Value.ToString()), row.Cells[0].Size);
                    row.Cells[0].Value = image;

                }

            }
            drinksGridView.Columns.RemoveAt(1);//Removing the imagePath column

        }
        private static Image ResizeImage(Image image, Size newSize)
        {
            // Initializing an image with the size of picture box
            Image resized = new Bitmap(newSize.Width, newSize.Height);
            //Drawing the captured image according to picture box size
            using (Graphics graphics = Graphics.FromImage((Bitmap)resized))
            {
                graphics.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }
            return resized;
        }

        private void pizzaGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Item selecteditem = new Item();
            bool flag =false;
            int index = e.RowIndex;
            string value = pizzaGridView.Rows[index].Cells[1].Value.ToString();
            foreach (Item item in SelectedPizza)
            {
                if(item.RowIndex!=index)
                {
                    flag = false;
                }
                else // If the item is already selected decrement total items
                {
                    flag = true;
                    selecteditem = item;
                    int counter = int.Parse(label5.Text)-1;
                    label5.Text = counter.ToString();
                    break;
                }
            }
            // If the item is not already selected increment total items
            if(!flag)
            {
                selecteditem.RowIndex = index;
                selecteditem.ItemName = value;
                SelectedPizza.Add(selecteditem);
                int counter = int.Parse(label5.Text)+1;
                label5.Text=counter.ToString();
            }
            else
            {
                SelectedPizza.Remove(selecteditem);

            }
        }

        private void friesGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Item selecteditem = new Item();
            bool flag = false;
            int index = e.RowIndex;
            string value = friesGridView.Rows[index].Cells[1].Value.ToString();
            foreach (Item item in SelectedFries)
            {
                if (item.RowIndex != index)
                {
                    flag = false;
                }
                else // If the item is already selected decrement total items
                {
                    flag = true;
                    selecteditem = item;
                    int counter = int.Parse(label5.Text) - 1;
                    label5.Text = counter.ToString();
                    break;
                }
            }
            // If the item is not already selected increment total items
            if (!flag)
            {
                selecteditem.RowIndex = index;
                selecteditem.ItemName = value;
                SelectedFries.Add(selecteditem);
                int counter = int.Parse(label5.Text) + 1;
                label5.Text = counter.ToString();
            }
            else
            {
                SelectedFries.Remove(selecteditem);

            }
        }

        private void drinksGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Item selecteditem = new Item();
            bool flag = false;
            int index = e.RowIndex;
            string value = drinksGridView.Rows[index].Cells[1].Value.ToString();
            foreach (Item item in SelectedDrinks)
            {
                if (item.RowIndex != index)
                {
                    flag = false;
                }
                else // If the item is already selected decrement total items
                {
                    flag = true;
                    selecteditem = item;
                    int counter = int.Parse(label5.Text) - 1;
                    label5.Text = counter.ToString();
                    break;
                }
            }
            // If the item is not already selected increment total items
            if (!flag)
            {
                selecteditem.RowIndex = index;
                selecteditem.ItemName = value;
                SelectedDrinks.Add(selecteditem);
                int counter = int.Parse(label5.Text) + 1;
                label5.Text = counter.ToString();
            }
            else
            {
                SelectedDrinks.Remove(selecteditem);

            }
        }

        private void placeOrder_Click(object sender, EventArgs e)
        {
            FinalizeOrder finalizeOrder = new FinalizeOrder(this);
            finalizeOrder.Show();
            this.Hide();
        }
    }
}
