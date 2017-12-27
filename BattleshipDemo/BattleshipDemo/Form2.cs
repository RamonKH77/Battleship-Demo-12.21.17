using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BattleshipDemo.Coordinates;

namespace BattleshipDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var elem = new Coordinates();

            for (int Y = 0; Y < 10; Y++)
            {
                for (int X = 0; X < 10; X++)
                {
                    Button BtnNew = new Button();
                    BtnNew.Height = 40;
                    BtnNew.Width = 40;
                    BtnNew.Location = new Point(40 * Y, 40 * X); 
                    BtnNew.Tag = X + "" + Y;
                    string tag = BtnNew.Tag.ToString();
                    BtnNew.Click += new EventHandler(this.button_Click);//adds button_click method to click
                    int tagInt = int.Parse(BtnNew.Tag.ToString());

                    

                    CheckCoordinatesCL CC = new CheckCoordinatesCL();
                    if (CC.CheckCoordinates(tagInt) == true)
                    {
                        BtnNew.Text = "Ship";
                        BtnNew.ForeColor = Color.Red;

                    }
                    else
                    {
                        BtnNew.Text = "Sea";
                        BtnNew.ForeColor = Color.Aqua;
                    }


                    this.Controls.Add(BtnNew);



                }

            }

        }

        private void button101_Click(object sender, EventArgs e)
        {

        }


        void button_Click(object sender, System.EventArgs e)
        {
            Button b = sender as Button;
            //string tagDesc = b.Tag.ToString();
            //int ButtonX = int.Parse(tagDesc);
            //CheckCoordinatesCL CC = new CheckCoordinatesCL();
            //if (CC.CheckCoordinates(ButtonX) == false)
            //{
            //    b.Text = "M";
            //}
            //else b.Text = "S";
            MessageBox.Show(b.Tag.ToString());

        }
    }
}