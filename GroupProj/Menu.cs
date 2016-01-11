using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//To import namespace of "Xml.Linq"
using System.Xml.Linq;

namespace GroupProj
{

    public partial class Menu : Form
    {
        OrderConfirmation frm;
        public Menu(OrderConfirmation fr)
        {
            InitializeComponent();
            frm = fr;
        }

        //Creating list titled as itemList that contains OrderData
        //List<OrderData> itemList;
        //create MenuDataArray array which is to store instances of itemList 
        MenuData[] menuDataArray = new MenuData[8];
        public Menu()
        {
            InitializeComponent();
            //Application.DoEvents();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            /* XDocument Menu = XDocument.Load("Menu.xml");
            MenuData[] menuDataArray = new MenuData[7];
            int count = 0;

            var menuNames = Menu.Descendants("menu-name");

            foreach (var menuName in menuNames)
            {
                Console.WriteLine(menuName.Value);
                //MessageBox.Show(menuName.Value);
            }*/

            //Load XML document
            XDocument Menu = XDocument.Load("Menu.xml");
            //MenuData[] menuDataArray = new MenuData[7];
            int count = 0;
            //create instance of MenuData class and pass through into each element of array menuDataArray
            while (count < 8)
            {
                menuDataArray[count] = new MenuData();
                count++;
            }
            //matches menuNames with proper name of item from xml in desceding order and stores in menuNames
            var menuNames = Menu.Descendants("menu-name");
            count = 0;
            foreach (var menuName in menuNames)
            {

                if (menuDataArray[count] == null)
                {
                    //throw a meaningful exception or give some useful feedback to the user!
                    return;
                }

                menuDataArray[count].itemName = menuName.Value;

                count++;
            }

            count = 0;
            var menuPrices = Menu.Descendants("menu-price");
            foreach (var price in menuPrices)
            {
                menuDataArray[count].itemPrice = Double.Parse(price.Value);

                count++;
            }

            count = 0;
            var menuTaxables = Menu.Descendants("menu-taxable");
            foreach (var menuTaxable in menuTaxables)
            {
                menuDataArray[count].itemTax = Double.Parse(menuTaxable.Value);

                count++;

            }
            //hard coded labels for price, name and tax
            lItem1DName.Text = menuDataArray[0].itemName;
            lItem2DName.Text = menuDataArray[1].itemName;
            lItem3DName.Text = menuDataArray[2].itemName;
            lItem4DName.Text = menuDataArray[3].itemName;
            lItem5SName.Text = menuDataArray[4].itemName;
            lItem6SName.Text = menuDataArray[5].itemName;
            lItem7SName.Text = menuDataArray[6].itemName;
            lItem8SName.Text = menuDataArray[7].itemName;

            lItem1UnitPrice.Text = menuDataArray[0].itemPrice.ToString("c");
            lItem2UnitPrice.Text = menuDataArray[1].itemPrice.ToString("c");
            lItem3UnitPrice.Text = menuDataArray[2].itemPrice.ToString("c");
            lItem4UnitPrice.Text = menuDataArray[3].itemPrice.ToString("c");
            lItem5UnitPrice.Text = menuDataArray[4].itemPrice.ToString("c");
            lItem6UnitPrice.Text = menuDataArray[5].itemPrice.ToString("c");
            lItem7UnitPrice.Text = menuDataArray[6].itemPrice.ToString("c");
            lItem8UnitPrice.Text = menuDataArray[7].itemPrice.ToString("c");

            lItem1DName.Text = menuDataArray[0].itemName;
        }

        private void tBItem1Price_TextChanged(object sender, EventArgs e)
        {

        }

        //shows the real time subtotal of each item
        public void nUDItem1Qty_ValueChanged(object sender, EventArgs e)
        {
            double price0 = menuDataArray[0].itemPrice;
            double qty0 = double.Parse(nUDItem1Qty.Value.ToString());
            if (nUDItem1Qty.Value >= 0)
            {
                tBItem1Price.Text = (price0 * qty0).ToString();
            }
        }

        private void tBItem2Price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tBItem3Price_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tBItem4Price_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tBItem5Price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tBItem6Price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tBItem7Price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tBItem8Price_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void nUDItem2Qty_ValueChanged(object sender, EventArgs e)
        {
            double price1 = menuDataArray[1].itemPrice;
            double qty1 = double.Parse(nUDItem2Qty.Value.ToString());
            if (nUDItem2Qty.Value >= 0)
            {
                tBItem2Price.Text = (price1 * qty1).ToString();
            }
        }

        private void nUDItem3Qty_ValueChanged(object sender, EventArgs e)
        {
            double price2 = menuDataArray[2].itemPrice;
            double qty2 = double.Parse(nUDItem3Qty.Value.ToString());
            if (nUDItem3Qty.Value >= 0)
            {
                tBItem3Price.Text = (price2 * qty2).ToString();
            }
        }

        private void nUDItem4Qty_ValueChanged(object sender, EventArgs e)
        {
            double price3 = menuDataArray[3].itemPrice;
            double qty3 = double.Parse(nUDItem4Qty.Value.ToString());
            if (nUDItem4Qty.Value >= 0)
            {
                tBItem4Price.Text = (price3 * qty3).ToString();
            }
        }

        private void nUDItem5Qty_ValueChanged(object sender, EventArgs e)
        {
            double price4 = menuDataArray[4].itemPrice;
            double qty4 = double.Parse(nUDItem5Qty.Value.ToString());
            if (nUDItem5Qty.Value >= 0)
            {
                tBItem5Price.Text = (price4 * qty4).ToString();
            }
        }

        private void nUDItem6Qty_ValueChanged(object sender, EventArgs e)
        {
            double price5 = menuDataArray[5].itemPrice;
            double qty5 = double.Parse(nUDItem6Qty.Value.ToString());
            if (nUDItem6Qty.Value >= 0)
            {
                tBItem6Price.Text = (price5 * qty5).ToString();
            }
        }

        private void nUDItem7Qty_ValueChanged(object sender, EventArgs e)
        {
            double price6 = menuDataArray[6].itemPrice;
            double qty6 = double.Parse(nUDItem7Qty.Value.ToString());
            if (nUDItem7Qty.Value >= 0)
            {
                tBItem7Price.Text = (price6 * qty6).ToString();
            }
        }

        private void nUDItem8Qty_ValueChanged(object sender, EventArgs e)
        {
            double price7 = menuDataArray[7].itemPrice;
            double qty7 = double.Parse(nUDItem8Qty.Value.ToString());
            if (nUDItem8Qty.Value >= 0)
            {
                tBItem8Price.Text = (price7 * qty7).ToString();
            }

            
        }

        //event click bReset hardcodes nUDItems 1-8 to zero
        private void bReset_Click(object sender, EventArgs e)
        {
            nUDItem1Qty.Value = 0;
            nUDItem2Qty.Value = 0;
            nUDItem3Qty.Value = 0;
            nUDItem4Qty.Value = 0;
            nUDItem5Qty.Value = 0;
            nUDItem6Qty.Value = 0;
            nUDItem7Qty.Value = 0;
            nUDItem8Qty.Value = 0;
        }

        private void bQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bPlaceOrder_Click(object sender, EventArgs e)
        {
            double grandTotal = 0.00;
            double result1 = 0;
            double subTotal = 0;
            double priceTemp = 0;

            if (double.TryParse(tBItem1Price.Text, out priceTemp))
            {
                subTotal = subTotal + double.Parse(tBItem1Price.Text);
            }

             if (double.TryParse(tBItem2Price.Text, out priceTemp))
            {
                subTotal = subTotal + double.Parse(tBItem2Price.Text);
            }

             if (double.TryParse(tBItem3Price.Text, out priceTemp))
            {
                subTotal = subTotal + double.Parse(tBItem3Price.Text);
            }

             if (double.TryParse(tBItem4Price.Text, out priceTemp))
            {
                subTotal = subTotal + double.Parse(tBItem4Price.Text);
            }

             if (double.TryParse(tBItem5Price.Text, out priceTemp))
            {
                subTotal = subTotal + double.Parse(tBItem5Price.Text);
            }

             if (double.TryParse(tBItem6Price.Text, out priceTemp))
            {
                subTotal = subTotal + double.Parse(tBItem6Price.Text);
            }

             if (double.TryParse(tBItem7Price.Text, out priceTemp))
            {
                subTotal = subTotal + double.Parse(tBItem7Price.Text);
            }

             if (double.TryParse(tBItem8Price.Text, out priceTemp))
            {
                subTotal = subTotal + double.Parse(tBItem8Price.Text);
            }

             int count = 0;
            /*calculate tax on items in menuDataArray with itemTax value being greater than 1, add that 
            value to grandTotal and loop through menuDataArray  */
             while (count < menuDataArray.Length)
             {
                 double totalPrice = 0;

                 if (count == 0)
                 {
                     totalPrice = menuDataArray[count].itemPrice * double.Parse(nUDItem1Qty.Value.ToString());

                     if (menuDataArray[count].itemTax > 1)
                     {
                         result1 = totalPrice * menuDataArray[count].itemTax;
                         grandTotal = result1 + grandTotal;
                     }

                     else
                     {
                         result1 = totalPrice;
                         grandTotal = grandTotal + result1;
                     }
                 }


                 if (count == 1)
                 {
                     totalPrice = menuDataArray[count].itemPrice * double.Parse(nUDItem2Qty.Value.ToString());

                     if (menuDataArray[count].itemTax > 1)
                     {
                         result1 = totalPrice * menuDataArray[count].itemTax;
                         grandTotal = result1 + grandTotal;
                     }

                     else
                     {
                         result1 = totalPrice;
                         grandTotal = grandTotal + result1;
                     }
                 }


                 if (count == 2)
                 {
                     totalPrice = menuDataArray[count].itemPrice * double.Parse(nUDItem3Qty.Value.ToString());

                     if (menuDataArray[count].itemTax > 1)
                     {
                         result1 = totalPrice * menuDataArray[count].itemTax;
                         grandTotal = result1 + grandTotal;
                     }

                     else
                     {
                         result1 = totalPrice;
                         grandTotal = grandTotal + result1;
                     }
                 }


                 if (count == 3)
                 {
                     totalPrice = menuDataArray[count].itemPrice * double.Parse(nUDItem4Qty.Value.ToString());

                     if (menuDataArray[count].itemTax > 1)
                     {
                         result1 = totalPrice * menuDataArray[count].itemTax;
                         grandTotal = result1 + grandTotal;
                     }

                     else
                     {
                         result1 = totalPrice;
                         grandTotal = grandTotal + result1;
                     }
                 }


                 if (count == 4)
                 {
                     totalPrice = menuDataArray[count].itemPrice * double.Parse(nUDItem5Qty.Value.ToString());

                     if (menuDataArray[count].itemTax > 1)
                     {
                         result1 = totalPrice * menuDataArray[count].itemTax;
                         grandTotal = result1 + grandTotal;
                     }

                     else
                     {
                         result1 = totalPrice;
                         grandTotal = grandTotal + result1;
                     }
                 }


                 if (count == 5)
                 {
                     totalPrice = menuDataArray[count].itemPrice * double.Parse(nUDItem6Qty.Value.ToString());

                     if (menuDataArray[count].itemTax > 1)
                     {
                         result1 = totalPrice * menuDataArray[count].itemTax;
                         grandTotal = result1 + grandTotal;
                     }

                     else
                     {
                         result1 = totalPrice;
                         grandTotal = grandTotal + result1;
                     }
                 }


                 if (count == 6)
                 {
                     totalPrice = menuDataArray[count].itemPrice * double.Parse(nUDItem7Qty.Value.ToString());

                     if (menuDataArray[count].itemTax > 1)
                     {
                         result1 = totalPrice * menuDataArray[count].itemTax;
                         grandTotal = result1 + grandTotal;
                     }

                     else
                     {
                         result1 = totalPrice;
                         grandTotal = grandTotal + result1;
                     }
                 }


                 if (count == 7)
                 {
                     totalPrice = menuDataArray[count].itemPrice * double.Parse(nUDItem8Qty.Value.ToString());

                     if (menuDataArray[count].itemTax > 1)
                     {
                         result1 = totalPrice * menuDataArray[count].itemTax;
                         grandTotal = result1 + grandTotal;
                     }

                     else
                     {
                         result1 = totalPrice;
                         grandTotal = grandTotal + result1;
                     }
                 }
                 count++;
             }
             if (grandTotal == 0)
             {
                 MessageBox.Show("Please select an item");
                 return;
             }
            //create instance of global class called TransferData(contains list)
             //TransferData globalClass = new TransferData();

             OrderData[] orderArray = new OrderData[8];
             List<OrderData> orderlist = new List<OrderData>();

            if (nUDItem1Qty.Value > 0)
            {
                //pass data into constructor (in Program.cs) and save to 'record1'
                OrderData record1 = new OrderData(menuDataArray[0].itemName,menuDataArray[0].itemPrice,int.Parse(nUDItem1Qty.Value.ToString()));
                //orderArray[0] = record1;
                
                orderlist.Add(record1);
            }

            if (nUDItem2Qty.Value > 0)
            {
                OrderData record2 = new OrderData(menuDataArray[1].itemName, menuDataArray[1].itemPrice, int.Parse(nUDItem2Qty.Value.ToString()));
                orderlist.Add(record2);
            }

            if (nUDItem3Qty.Value > 0)
            {
                OrderData record3 = new OrderData(menuDataArray[2].itemName, menuDataArray[2].itemPrice, int.Parse(nUDItem3Qty.Value.ToString()));
                orderlist.Add(record3);
            }

            if (nUDItem4Qty.Value > 0)
            {
                OrderData record4 = new OrderData(menuDataArray[3].itemName, menuDataArray[3].itemPrice, int.Parse(nUDItem4Qty.Value.ToString()));
                orderlist.Add(record4);
            }

            if (nUDItem5Qty.Value > 0)
            {
                OrderData record5 = new OrderData(menuDataArray[4].itemName, menuDataArray[4].itemPrice, int.Parse(nUDItem5Qty.Value.ToString()));
                orderlist.Add(record5);
            }

            if (nUDItem6Qty.Value > 0)
            {
                OrderData record6 = new OrderData(menuDataArray[5].itemName, menuDataArray[5].itemPrice, int.Parse(nUDItem6Qty.Value.ToString()));
                orderlist.Add(record6);
            }

            if (nUDItem7Qty.Value > 0)
            {
                OrderData record7 = new OrderData(menuDataArray[6].itemName, menuDataArray[6].itemPrice, int.Parse(nUDItem7Qty.Value.ToString()));
                orderlist.Add(record7);
            }

            if (nUDItem8Qty.Value > 0)
            {
                OrderData record8 = new OrderData(menuDataArray[7].itemName, menuDataArray[7].itemPrice, int.Parse(nUDItem8Qty.Value.ToString()));
                orderlist.Add(record8);
            }

            //pass user input through constructor into element of list
            //MoveToNewForm ian instance of OrderConfirmation and passes info through orderlist
            OrderConfirmation MoveToNewForm = new OrderConfirmation(orderlist, grandTotal);
            MoveToNewForm.Show();

            this.Hide();
	        {
		
	        }
        }
    }
}

