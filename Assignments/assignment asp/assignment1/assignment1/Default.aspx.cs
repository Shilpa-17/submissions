using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 
namespace assignment1

{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("toy1");
                DropDownList1.Items.Add("toy2");
                DropDownList1.Items.Add("toy3");
                DropDownList1.Items.Add("toy4");
                DropDownList1.Items.Add("toy5");
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = DropDownList1.SelectedItem.ToString();

            if (selectedItem == "toy1")
            {
                Image1.ImageUrl = "toy1.jpg";
                Label1.Text = "cost: 650 rupees";
            }
            else if (selectedItem == "toy2")
            {
                Image1.ImageUrl = "toy2.jpg";
                Label1.Text = "cost: 400 rupees";
            }
            else if (selectedItem == "toy3")
            {
                Image1.ImageUrl = "toy3.jpg";
                Label1.Text = "cost: 500 rupees";
            }
            else if (selectedItem == "toy4")
            {
                Image1.ImageUrl = "toy4.jpg";
                Label1.Text = "cost: 350 rupees";
            }
            else if (selectedItem == "toy5")
            {
                Image1.ImageUrl = "toy5.jpg";
                Label1.Text = "cost: 400 rupees";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = DropDownList1.SelectedItem.ToString();
            Label1.Text = "You have chosen " + selectedItem + " and its cost is " + Label1.Text;
        }
    }
}
