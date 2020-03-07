using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_V2
{
    public partial class Form1 : Form
    {

        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }



        private void button_Click(object sender, EventArgs e)   // numbers click
        {
            if ((result.Text == "0") || (operation_pressed))  // navele spatiale? investigheaza ||  = ori?
                result.Clear();
            operation_pressed = false;
            Button apasa = (Button)sender;
            result.Text = result.Text + apasa.Text;
        }

        private void button_CE_click(object sender, EventArgs e)
        {
            // you must create an IF logic where you check if there is any input in the textbox and if it is clear the content?????
            result.Text = "0";

        }


        private void operator_click(object sender, EventArgs e) // math operators click: _+*/
        {
            Button apasa = (Button)sender;
            operation = apasa.Text;
            value = Double.Parse(result.Text); // double.parse 
            operation_pressed = true;
            //sign_in_use.Text = value + " " + operation;

        }

        private void operator_equal(object sender, EventArgs e)  // equal click - returns the result
        {
            
            sign_in_use.Text = "";
            switch (operation)

            {

                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;

                case "+":
    
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;

            }//end switch
           






        }

    }
}