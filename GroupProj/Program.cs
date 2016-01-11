using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProj
{
    static class Program
    { 
        /// The main entry point for the application.
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }  
    }
    //This is global class which contains an instance of OrderData called 'orderlist'
    public class TransferData
    {
        public List<OrderData> orderlist = new List<OrderData>();
    }

    //created a class to access
    public class MenuData
    {
        public MenuData()
        {
            itemName = "";
            itemPrice = 0.0;
            itemTax = 0.0;
        }

        public string itemName
        {
            get;
            set;
        }

        public double itemPrice
        {
            get;
            set;
        }

        public double itemTax
        {
            get;
            set;
        }
    }
    public class OrderData
    {
        public string itemName
        {
            get;
            set;
        }
        public double itemPrice
        {
            get;
            set;
        }
        public int quantity
        {
            get;
            set;
        }
        public OrderData (string name, double price, int quant)
        {
            itemName = name;
            itemPrice = price;
            quantity = quant;
        }
    }
}
