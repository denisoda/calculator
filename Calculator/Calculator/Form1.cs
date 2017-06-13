using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace WindowsFormsApp1
{
 

public partial class Form1 : Form
    {
        bool click;

        private int zero = 0;
        private double one = 1;
        private double two = 2;
        private double summ;
        private int three = 3;
        private int four = 4;
        private int five= 5;
        private int six = 6;
        private int seven =7;
        private int eight = 8;
        private int nine = 9;
        private float sum = 0;
        private float buff = 0;
        private int press_buff=0;
        private bool count=false;
        string sumString;



        private int eq = 0;





        public Form1()
        {
            InitializeComponent();
        }

        #region Buttons

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.press_buff++;
            this.click = true;

            
            if (press_buff<=10||click==true)
            {


                if (press_buff <= 1 )
                {
                    MainLB.Text = "";
                   


                }
                if (count)
                {
                    MainLB.Text = "";
                    count = false;
                }
                if (press_buff<=10&&press_buff>=0);
            {
            MainLB.Text +="1";
                
            }
                one = int.Parse(MainLB.Text);
            
            }

            else
            {
                MessageBox.Show("You riched a num limit");
            }
            
            
                
            

            

                

                 
               

        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.press_buff++;


            if (press_buff <= 10 || click == true)
            {


                if (press_buff <= 1)
                {
                    MainLB.Text = "";


                }
                if (count)
                {
                    MainLB.Text = "";
                    count = false;
                }

                if (press_buff <= 10 && press_buff >= 0) ;
                {
                    MainLB.Text += "2";

                }
                two = int.Parse(MainLB.Text);

            }

            else
            {
                MessageBox.Show("You riched a num limit");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.press_buff++;


            if (press_buff <= 10 || click == true)
            {


                if (press_buff <= 1)
                {
                    MainLB.Text = "";


                }
                if (count)
                {
                    MainLB.Text = "";
                    count = false;
                }

                if (press_buff <= 10 && press_buff >= 0) ;
                {
                    MainLB.Text += "3";

                }
                three = int.Parse(MainLB.Text);

            }

            else
            {
                MessageBox.Show("You riched a num limit");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.press_buff++;


            if (press_buff <= 10 || click == true)
            {


                if (press_buff <= 1)
                {
                    MainLB.Text = "";


                }

                if (count)
                {
                    MainLB.Text = "";
                    count = false;
                }
                if (press_buff <= 10 && press_buff >= 0) ;
                {
                    MainLB.Text += "4";

                }
                four = int.Parse(MainLB.Text);

            }

            else
            {
                MessageBox.Show("You riched a num limit");
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.press_buff++;


            if (press_buff <= 10 || click == true)
            {


                if (press_buff <= 1)
                {
                    MainLB.Text = "";


                }
                if (count)
                {
                    MainLB.Text = "";
                    count = false;
                }

                if (press_buff <= 10 && press_buff >= 0) ;
                {
                    MainLB.Text += "5";

                }
                five = int.Parse(MainLB.Text);

            }

            else
            {
                MessageBox.Show("You riched a num limit");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.press_buff++;


            if (press_buff <= 10 || click == true)
            {


                if (press_buff <= 1)
                {
                    MainLB.Text = "";


                }
                if (count)
                {
                    MainLB.Text = "";
                    count = false;
                }

                if (press_buff <= 10 && press_buff >= 0) ;
                {
                    MainLB.Text += "6";

                }
                six = int.Parse(MainLB.Text);

            }

            else
            {
                MessageBox.Show("You riched a num limit");
            }



        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.press_buff++;


            if (press_buff <= 10 || click == true)
            {


                if (press_buff <= 1)
                {
                    MainLB.Text = "";


                }
                if (count)
                {
                    MainLB.Text = "";
                    count = false;
                }

                if (press_buff <= 10 && press_buff >= 0) ;
                {
                    MainLB.Text += "7";

                }
                seven = int.Parse(MainLB.Text);

            }

            else
            {
                MessageBox.Show("You riched a num limit");
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.press_buff++;


            if (press_buff <= 10 || click == true)
            {


                if (press_buff <= 1)
                {
                    MainLB.Text = "";


                }
                if (count)
                {
                    MainLB.Text = "";
                    count = false;
                }
                if (press_buff <= 10 && press_buff >= 0) ;
                {
                    MainLB.Text += "8";

                }
                eight = int.Parse(MainLB.Text);

            }

            else
            {
                MessageBox.Show("You riched a num limit");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {

            this.press_buff++;


            if (press_buff <= 10 || click == true)
            {


                if (press_buff <= 1)
                {
                    MainLB.Text = "";


                }
                if (count)
                {
                    MainLB.Text = "";
                    count = false;
                }
                if (press_buff <= 10 && press_buff >= 0) ;
                {
                    MainLB.Text += "9";

                }
                nine = int.Parse(MainLB.Text);

            }

            else
            {
                MessageBox.Show("You riched a num limit");
            }

        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            this.press_buff++;


            if (press_buff <= 10 || click == true)
            {


                if (press_buff <= 1)
                {
                    MainLB.Text = "";


                }
                if (count)
                {
                    MainLB.Text = "";
                    count = false;
                }

                if (press_buff <= 10 && press_buff >= 0) ;
                {
                    MainLB.Text += "0";

                }
                zero = int.Parse(MainLB.Text);

            }

            else
            {
                MessageBox.Show("You riched a num limit");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            MainLB.Text = sumString;
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo pagelink = new ProcessStartInfo("https://vk.com/denisoda");
            Process.Start(pagelink);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
          click=true;


            

            if (MainLB.Text != "")
            {
                
            switch (eq)
            {

                  

                case 0:
                
                    one = double.Parse(MainLB.Text);
                    summ = one;

                    eq++;
                    
                    MainLB.Text = "";

                    break;

                case 1:
                    two = double.Parse(MainLB.Text);
                    summ += two;
                  
                    sumString = Convert.ToString(summ);

                    MainLB.Text = "";
                    count=true;
                    MainLB.Text = sumString;
                  
                    eq++;
                    break;

                case 2:
                    MainLB.Text = "";


                    eq = 0;
                    break;
                        


            }
            }
            else
            {
                MainLB.Text = "";
            }




            





        }

        private void button10_Click(object sender, EventArgs e)
        {
            MainLB.Text = "";
            summ = 0;
            eq=0;





        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            click = true;




            if (MainLB.Text != "")
            {

                switch (eq)
                {



                    case 0:

                        one = double.Parse(MainLB.Text);
                        summ = one;

                        eq++;

                        MainLB.Text = "";

                        break;

                    case 1:
                        two = double.Parse(MainLB.Text);
                        summ = two*summ;

                        sumString = Convert.ToString(summ);

                        MainLB.Text = "";
                        count = true;
                        MainLB.Text = sumString;

                        eq++;
                        break;

                    case 2:
                        MainLB.Text = "";


                        eq = 0;
                        break;



                }
            }
            else
            {
                MainLB.Text = "";
            }



        }

        private void minus_Click(object sender, EventArgs e)
        {
            click = true;




            if (MainLB.Text != "")
            {

                switch (eq)
                {



                    case 0:

                        one = double.Parse(MainLB.Text);
                        summ = one;

                        eq++;

                        MainLB.Text = "";

                        break;

                    case 1:
                        two = double.Parse(MainLB.Text);
                        summ -= two;

                        sumString = Convert.ToString(summ);

                        MainLB.Text = "";
                        count = true;
                        MainLB.Text = sumString;

                        eq++;
                        break;

                    case 2:
                        MainLB.Text = "";


                        eq = 0;
                        break;



                }
            }
            else
            {
                MainLB.Text = "";
            }


        }
    }
}
