/*************************************** 
 * Naveen Reddy 
 * C0838989
 * TEST - 01
 * 2022-02-11
****************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace areaAndPerimeter
{
    public partial class AreaAndPerimeter : Form
    {
        public AreaAndPerimeter()
        {
            InitializeComponent();
        }
      
        private void AreaAndPerimeter_Load(object sender, EventArgs e)
        {
            /*************************************** 
            * this method loads the area and perimeter windows 
            * after clinking on start button on visual studio compiler
            ****************************************/
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            /*************************************** 
             * this method closes the area and perimeter windows 
             * after clinking on exit button
             * this is achieved by using click event 
             ****************************************/

            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            /*************************************** 
             * this method calculates the area and perimeter  
             * for a diameter is giving in the txtDiameter
             * area that's based on the pi and radius of the circle  
             ****************************************/


            // get the diameter from the diameter text box.
            decimal diameter = Convert.ToDecimal(txtDiameter.Text);
            // these three varibales is used to store the calculated area , perimeter, and radius
            decimal area ;
            decimal perimeter ;
            decimal radius ;
            // the pi value id constant from mathematics concept.
            decimal pi = 3.14m;

            // calculting radius ofthe  diameter.
            radius = 0.5m * diameter;

            // calculting area of the diameter.
            area = pi * (radius * radius);

            // calculting perimeter of the diameter.
            perimeter = 2 * pi * radius;

            // displays the calculated area and perimeter in area text box and perimeter text box respctively.
            txtArea.Text = String.Format("{0:00.000000}",area);
            txtPerimeter.Text = perimeter.ToString();


            // moves the focus to the diameter text box 
            txtDiameter.Focus();

        }

       
    }
}
