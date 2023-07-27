using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: Ben Peak
 * Date: 7/27/23
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public object UxOutPutCube { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int number;
            int result;
            // INPUT
            if (!int.TryParse(UxInputTextBox.Text, out number))
            {
                
            }
            // PROCESS
            result = Square(number);
            UxOutPutTextBox.Text = "Square: " + result;
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */

            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */
            result = Cube(number);
            UxOutPutcube.Text = "Cube: " + result;
            // OUTPUT
            // set the output to visible
            UxOutPutTextBox.Visible = true;
            UxOutPutcube.Visible = true;
            // turn the Go button off
            UxGoButton.Visible = false;
        }

        public int Square(int num)
        {
            // we will create this code in class
            return num * num;
        }

        public int Cube(int num)
        {
            // we will create this code in class
            return num * num * num;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {

            // the input and output text should be emptied
            UxInputTextBox.Text = "";
            UxOutPutTextBox.Text = "";
            UxOutPutcube.Text = "";
            // turn the output to invisible
            UxOutPutTextBox.Visible = false;
            UxOutPutcube.Visible = false;
            // turn the Go button back on
            UxGoButton.Visible = true;
        }

    }
}
