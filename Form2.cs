using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_application
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string pepperoni;
            if (radpepperoni.Checked == true)
                pepperoni = radhawaian.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string veggie;
            if (radveggie.Checked == true)
                veggie = radhawaian.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string mushroom;
            if (chkmushrooms.Checked == true)
                mushroom = radhawaian.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblyourorder.Text = "Your order is: ";
            lblextratoppings.Text = "Crust type: ";
            lblsizee.Text = "Size: ";
            lbltotal.Text = "Total toppings: ";
            lblamount.Text = "Total amount: ";



            string size = "";
            //size
            if (radsmall.Checked == true)
            {
                size += radsmall.Text;
                float smallsize = 0;
                lblsizeprize.Text = smallsize.ToString();
            }

            if (radmedium.Checked == true)
            {
                size += radmedium.Text;
                float mediumsize = 50;
                lblsizeprize.Text = mediumsize.ToString();
            }

            if (radlarge.Checked == true)
            {
                size += radlarge.Text;
                float largesize = 100;
                lblsizeprize.Text = largesize.ToString();
            }

            if (radextralarge.Checked == true)
            {
                size += radextralarge.Text;
                float extralargesize = 200;
                lblsizeprize.Text = extralargesize.ToString();
            }

            string crusttype = "";
            //crust type
            if (radthin.Checked == true)
            {
                crusttype = radthin.Text;
                float thincrust = 20;
                lblcrustprice.Text = thincrust.ToString();
            }

            if (radthick.Checked == true)
            {
                crusttype = radthick.Text;
                float thickcrust = 0;
                lblcrustprice.Text = thickcrust.ToString();
            }

            //extra toppings
            string extra = "", extra2 = "",
                strextracheese = "", stronions = "", strmushrooms = "", strtomatoes = "", strpineapple = "", strpeppers = "";
            string extracheese = "", extramushrooms = "", extraonions = "", extratomatoes = "", extrapineapple = "", extrapeppers = "";

            if (chkextracheese.Checked == true)
            {
                strextracheese += chkextracheese.Text;
                extracheese = "20";
            }
            else
            {
                extracheese = "0";
            }

            if (chkmushrooms.Checked == true)
            {
                strmushrooms += chkmushrooms.Text;
                extramushrooms = "20";
            }
            else
            {
                extramushrooms = "0";
            }

            if (chkonions.Checked == true)
            {
                stronions += chkonions.Text;
                extraonions = "10";
            }
            else
            {
                extraonions = "0";
            }

            if (chktomatoes.Checked == true)
            {
                strtomatoes += chktomatoes.Text;
                extratomatoes = "10";
            }
            else
            {
                extratomatoes = "0";
            }

            if (chkpineapple.Checked == true)
            {
                strpineapple += chkpineapple.Text;
                extrapineapple = "15";
            }
            else
            {
                extrapineapple = "0";
            }

            if (chkpeppers.Checked == true)
            {
                strpeppers += chkpeppers.Text;
                extrapeppers = "10";
            }
            else
            {
                extrapeppers = "0";
            }

            lbltoppings1.Text = $"{strextracheese}  {strmushrooms}  {stronions}";
            lbltoppings2.Text = $"{strtomatoes}  {strpineapple}  {strpeppers}";


            float toppingstotal = float.Parse(extracheese) + float.Parse(extramushrooms) + float.Parse(extraonions) + float.Parse(extratomatoes
                ) + float.Parse(extrapineapple) + float.Parse(extrapeppers);
            lbltoppstotal.Text = toppingstotal.ToString();



            float pizzaprice;
            //pizza
            if (radhawaian.Checked == true)
            {
                lblpizza.Text = radhawaian.Text + " pizza";
                pizzaprice = 100;
                lbltotall.Text = pizzaprice.ToString();

                float summation;
                summation = pizzaprice + float.Parse(lblsizeprize.Text) + float.Parse(lblcrustprice.Text);
                lbltotall.Text = summation.ToString();
            }

            if (radhamandcheese.Checked == true)
            {
                lblpizza.Text = radhamandcheese.Text + " pizza";
                pizzaprice = 200;
                lbltotall.Text = pizzaprice.ToString();

                float summation;
                summation = pizzaprice + float.Parse(lblsizeprize.Text) + float.Parse(lblcrustprice.Text);
                lbltotall.Text = summation.ToString();
            }

            if (radpepperoni.Checked == true)
            {
                lblpizza.Text = radpepperoni.Text + " pizza";
                pizzaprice = 150;
                lbltotall.Text = pizzaprice.ToString();

                float summation;
                summation = pizzaprice + float.Parse(lblsizeprize.Text) + float.Parse(lblcrustprice.Text);
                lbltotall.Text = summation.ToString();
            }

            if (radveggie.Checked == true)
            {
                lblpizza.Text = radveggie.Text + " pizza";
                pizzaprice = 90;
                lbltotall.Text = pizzaprice.ToString();

                float summation;
                summation = pizzaprice + float.Parse(lblsizeprize.Text) + float.Parse(lblcrustprice.Text);
                lbltotall.Text = summation.ToString();

            }

            lblsize.Text = size;
            lblcrustt.Text = crusttype;

            float totalsum;
            totalsum = float.Parse(lbltotall.Text) + float.Parse(lbltoppstotal.Text);
            lbltotalamount.Text = totalsum.ToString();


        }

        private void radhawaian_CheckedChanged(object sender, EventArgs e)
        {
            string hawaian;
            if (radhawaian.Checked == true)
                hawaian = radhawaian.Text;
        }

        private void radhamandcheese_CheckedChanged(object sender, EventArgs e)
        {
            string hamandcheese;
            if (radhamandcheese.Checked == true)
                hamandcheese = radhawaian.Text;
        }

        private void radsmall_CheckedChanged(object sender, EventArgs e)
        {
            string small;
            if (radsmall.Checked == true)
                small = radhawaian.Text;
        }

        private void radmedium_CheckedChanged(object sender, EventArgs e)
        {
            string medium;
            if (radmedium.Checked == true)
                medium = radhawaian.Text;
        }

        private void radlarge_CheckedChanged(object sender, EventArgs e)
        {
            string large;
            if (radlarge.Checked == true)
                large = radhawaian.Text;
        }

        private void radextralarge_CheckedChanged(object sender, EventArgs e)
        {
            string extralarge;
            if (radextralarge.Checked == true)
                extralarge = radhawaian.Text;
        }

        private void radthin_CheckedChanged(object sender, EventArgs e)
        {
            string thin;
            if (radthin.Checked == true)
                thin = radhawaian.Text;
        }

        private void radthick_CheckedChanged(object sender, EventArgs e)
        {
            string thick;
            if (radthick.Checked == true)
                thick = radhawaian.Text;
        }

        private void chkextracheese_CheckedChanged(object sender, EventArgs e)
        {
            string extracheese;
            if (chkextracheese.Checked == true)
                extracheese = radhawaian.Text;
        }

        private void chkonions_CheckedChanged(object sender, EventArgs e)
        {
            string onions;
            if (chkonions.Checked == true)
                onions = radhawaian.Text;
        }

        private void chktomatoes_CheckedChanged(object sender, EventArgs e)
        {
            string tomatoes;
            if (chktomatoes.Checked == true)
                tomatoes = radhawaian.Text;
        }

        private void chkpineapple_CheckedChanged(object sender, EventArgs e)
        {
            string pineapple;
            if (chkpineapple.Checked == true)
                pineapple = radhawaian.Text;
        }

        private void chkpeppers_CheckedChanged(object sender, EventArgs e)
        {
            string peppers;
            if (chkpeppers.Checked == true)
                peppers = radhawaian.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblpizza_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Do you really want to Log Out?", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }

        private void lbltoppstotal_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            radhawaian.Checked = false;
            radhamandcheese.Checked = false;
            radpepperoni.Checked = false;
            radveggie.Checked = false;

            radsmall.Checked = false;
            radmedium.Checked = false;
            radlarge.Checked = false;
            radextralarge.Checked = false;

            radthick.Checked = false;
            radthin.Checked = false;

            chkextracheese.Checked = false;
            chkmushrooms.Checked = false;
            chkonions.Checked = false;
            chktomatoes.Checked = false;
            chkpineapple.Checked = false;
            chkpeppers.Checked = false;

            /*lblyourorder.Text = "";
            lblextratoppings.Text = "";
            lblsizee.Text = "";
            lbltotal.Text = "";
            lblamount.Text = "";*/

            lblpizza.Text = "";
            lblsize.Text = "";
            lblcrustt.Text = "";
            lbltoppings1.Text = "";
            lbltoppings2.Text = "";
            lbltoppstotal.Text = "0";
            lbltotalamount.Text = "0";
            lblsizeprize.Text = "0";
            lblcrustprice.Text = "0";
            lbltotall.Text = "0";
        }

        private void lblsizeprize_Click(object sender, EventArgs e)
        {

        }
    }
}
