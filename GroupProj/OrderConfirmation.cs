using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GroupProj
{
    public partial class OrderConfirmation : Form
    {
        Menu frm;
        public OrderConfirmation()
        {
            InitializeComponent();
            frm = new Menu();
            Instance = this;
        }
   
        private List<OrderData> orderListGlobal;
        public static OrderConfirmation Instance;

        double grandTotalGlobal;

        public OrderConfirmation(List<OrderData> orderlist, double grandTotal)
        {
            grandTotalGlobal = grandTotal;
            orderListGlobal = orderlist;
            InitializeComponent();
        }

        private void MakeVisibletBItem()
        {
            lItemQty1.Visible = true;
            lItemQty2.Visible = true;
            lItemQty3.Visible = true;
            lItemQty4.Visible = true;
            lItemQty5.Visible = true;
            lItemQty6.Visible = true;
            lItemQty7.Visible = true;
            lItemQty8.Visible = true;
        }

        private void MakeInVisibletBItem()
        {
            lItemQty1.Visible = false;
            lItemQty2.Visible = false;
            lItemQty3.Visible = false;
            lItemQty4.Visible = false;
            lItemQty5.Visible = false;
            lItemQty6.Visible = false;
            lItemQty7.Visible = false;
            lItemQty8.Visible = false;
        }

        private void MakeVisibletBPrice()
        {
            lItemPrice1.Visible = true;
            lItemPrice2.Visible = true;
            lItemPrice3.Visible = true;
            lItemPrice4.Visible = true;
            lItemPrice5.Visible = true;
            lItemPrice6.Visible = true;
            lItemPrice7.Visible = true;
            lItemPrice8.Visible = true;
        }

        private void MakeInvisibletBPrice()
        {
            lItemPrice1.Visible = false;
            lItemPrice2.Visible = false;
            lItemPrice3.Visible = false;
            lItemPrice4.Visible = false;
            lItemPrice5.Visible = false;
            lItemPrice6.Visible = false;
            lItemPrice7.Visible = false;
            lItemPrice8.Visible = false;
        }
        private void MakeInvisibleQuantity()
        {
            lItemQty1.Visible = false;
            lItemQty2.Visible = false;
            lItemQty3.Visible = false;
            lItemQty4.Visible = false;
            lItemQty5.Visible = false;
            lItemQty6.Visible = false;
            lItemQty7.Visible = false;
            lItemQty8.Visible = false;
        }

        private void OrderConfirmation_Load(object sender, EventArgs e)
        {

            tBGrandTotal.Text = "$"+Convert.ToString(grandTotalGlobal);


            lDateTimeFuncton.Text = DateTime.Now.ToString();

            int count = 0;

            OrderData[] orderDataArray = new OrderData[orderListGlobal.Count];

            foreach (OrderData data in orderListGlobal) // Loop through List with foreach
            {
                //Console.WriteLine(prime);
                orderDataArray[count] = data;
                    count++;
            }

            if (orderDataArray[0].itemName != null)
            {
                lItemOrder1.Text = orderDataArray[0].itemName.ToString();
                lItemQty1.Text = orderDataArray[0].quantity.ToString();
                lItemPrice1.Text = orderDataArray[0].itemPrice.ToString("c");
            }
            if (count >= 2)
            {
                lItemOrder2.Text = orderDataArray[1].itemName;
                lItemQty2.Text = orderDataArray[1].quantity.ToString();
                lItemPrice2.Text = orderDataArray[1].itemPrice.ToString("c");
            }
            if (count >= 3)
            {
                lItemOrder3.Text = orderDataArray[2].itemName;
                lItemQty3.Text = orderDataArray[2].quantity.ToString();
                lItemPrice3.Text = orderDataArray[2].itemPrice.ToString("c");
            }
            if (count >= 4)
            {
                lItemOrder4.Text = orderDataArray[3].itemName;
                lItemQty4.Text = orderDataArray[3].quantity.ToString();
                lItemPrice4.Text = orderDataArray[3].itemPrice.ToString("c");
            }
            if (count >= 5)
            {
                lItemOrder5.Text = orderDataArray[4].itemName;
                lItemQty5.Text = orderDataArray[4].quantity.ToString();
                lItemPrice5.Text = orderDataArray[4].itemPrice.ToString("c");
            }
            if (count >= 6)
            {
                lItemOrder6.Text = orderDataArray[5].itemName;
                lItemQty6.Text = orderDataArray[5].quantity.ToString();
                lItemPrice6.Text = orderDataArray[5].itemPrice.ToString("c");
            }
            if (count >= 7)
            {
                lItemOrder7.Text = orderDataArray[6].itemName;
                lItemQty7.Text = orderDataArray[6].quantity.ToString();
                lItemPrice7.Text = orderDataArray[6].itemPrice.ToString("c");
            }
            if (count >= 8)
            {
                lItemOrder8.Text = orderDataArray[7].itemName;
                lItemQty8.Text = orderDataArray[7].quantity.ToString();
                lItemPrice8.Text = orderDataArray[7].itemPrice.ToString("c");
            }
            
            if (lItemQty1.Text == "label1")
            {
                lItemQty1.Visible = false;
                lItemPrice1.Visible = false;
                lItemOrder1.Visible = false;
            }

            if (lItemQty2.Text == "label2")
            {
                lItemQty2.Visible = false;
                lItemPrice2.Visible = false;
                lItemOrder2.Visible = false;
            }

            if (lItemQty3.Text == "label3")
            {
                lItemQty3.Visible = false;
                lItemPrice3.Visible = false;
                lItemOrder3.Visible = false;
            }

            if (lItemQty4.Text == "label4")
            {
                lItemQty4.Visible = false;
                lItemPrice4.Visible = false;
                lItemOrder4.Visible = false;
            }

            if (lItemQty5.Text == "label5")
            {
                lItemQty5.Visible = false;
                lItemPrice5.Visible = false;
                lItemOrder5.Visible = false;
            }

            if (lItemQty6.Text == "label6")
            {
                lItemQty6.Visible = false;
                lItemPrice6.Visible = false;
                lItemOrder6.Visible = false;
            }

            if (lItemQty7.Text == "label7")
            {
                lItemQty7.Visible = false;
                lItemPrice7.Visible = false;
                lItemOrder7.Visible = false;
            }

            if (lItemQty8.Text == "label8")
            {
                lItemQty8.Visible = false;
                lItemPrice8.Visible = false;
                lItemOrder8.Visible = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void tBltem1Qty_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tBItem1Qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void lItemOrder1_Click(object sender, EventArgs e)
        {

        }

        private void lItemQty2_Click(object sender, EventArgs e)
        {
            lItemQty2.Text = " ";

            if (lItemQty2.Text == "")
            {
                MakeInvisibleQuantity();
            }
        }

        private void lItemOrder2_Click(object sender, EventArgs e)
        {

        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show(); 
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            XDocument xd = XDocument.Load("orders.xml");

            xd.Element("orders").Add(
                new XElement("order",
                    new XElement("accountNum", tBAccountNum.Text),
                    new XElement("dateTime", lDateTimeFuncton.Text),
                    new XElement("grandTotal", tBGrandTotal.Text)
                    )
                );
            xd.Save("orders.xml");

            MessageBox.Show("Your order has been confirmed!");
        }
    }
}
