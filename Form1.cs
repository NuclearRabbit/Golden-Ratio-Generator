////////////////////////////////////////////////////////////////////
//                                                                //
//                     Golden Ratio Generator                     //
//                    ------------------------                    //
//                                                                //
//    Author: Brandon Wall                                        //
//    Date: 5/1/2016                                              //
//    Desc: An application to determine the proper dimensions     //
//          to create a golden proportioned shape.                //
//                                                                //
////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenRatioProject
{
    public partial class Form1 : Form
    {
        // equation variables
        double a, b, total_width, pSlant, pHeight;

        // contansts for golden ratio
        const double PHI = 1.61803;
        const double PYRAMID_PHI = 1.61804;

        //============================================================================================================
        public Form1()
        {
            InitializeComponent();
        }

        //============================================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            a = b = total_width = pSlant = pHeight = 0;

            widthInput.Text = "";

            widthInput.Visible = true;
            calcButton.Visible = true;
            exitButton.Visible = true;
            resultPanel.Visible = true;
            instructionsLabel.Visible = true;

            aLabel.Visible = false;
            bLabel.Visible = false;
            rectImage.Visible = false;
            pyramidImage.Visible = false;
            triangleImage.Visible = false;
            invalidLabel.Visible = false;
            dimensionsLabel.Visible = false;
        }

        //============================================================================================================
        private void widthInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                calc_Click(this, new EventArgs());
        }

        //============================================================================================================
        private void rectButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                calc_Click(this, new EventArgs());
        }

        //============================================================================================================
        private void pyramidButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                calc_Click(this, new EventArgs());
        }

        //============================================================================================================
        private void triangleButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                calc_Click(this, new EventArgs());
        }

        //============================================================================================================
        private void rectButton_Click(object sender, EventArgs e)
        {
            if (widthInput.Text.ToString() != "") 
                calc_Click(this, e);
        }

        //============================================================================================================
        private void pyramidButton_Click(object sender, EventArgs e)
        {
            if(widthInput.Text.ToString() != "")
                calc_Click(this, e);
        }

        //============================================================================================================
        private void triangleButton_Click(object sender, EventArgs e)
        {
            if(widthInput.Text.ToString() != "")
                calc_Click(this, e);
        }

        //============================================================================================================
        private void calc_Click(object sender, EventArgs e)
        {
            double temp = 0;

            aLabel.Visible = false;
            bLabel.Visible = false;
            resultPanel.Visible = true;
            rectImage.Visible = false;
            invalidLabel.Visible = false;
            triangleImage.Visible = false;
            pyramidImage.Visible = false;
            dimensionsLabel.Visible = false;

            bool valid = double.TryParse(widthInput.Text, out temp);

            // if user enters 0 width length
            if (temp < 0)
            {
                valid = false;
                invalidLabel.Text = "Error: Invalid Input";
                invalidLabel.Visible = true;
            }

            // user selects rectangles
            if (rectButton.Checked)
            {
                if (valid)
                {
                    total_width = temp;
                    a = total_width / PHI;
                    b = total_width - a;

                    if (total_width == 0)
                    {
                        invalidLabel.Text = "Error: No Number Entered";
                        invalidLabel.Visible = true;
                    }
                    else
                    {
                        aLabel.Text = String.Format("a = {0:0.000}", a);
                        bLabel.Text = String.Format("b = {0:0.000}", b);

                        aLabel.Visible = true;
                        bLabel.Visible = true;
                        rectImage.Visible = true;
                        resultPanel.Visible = true;
                        dimensionsLabel.Visible = true;
                    }
                }
                else
                {
                    invalidLabel.Text = "Error: Invalid Input";
                    invalidLabel.Visible = true;
                }
            }
            // user selects pyramid
            else if (pyramidButton.Checked)
            {
                if (valid)
                {
                    total_width = temp;
                    pSlant = (total_width / 2) * PYRAMID_PHI;
                    pHeight = Math.Sqrt(Math.Pow(pSlant, 2) - Math.Pow((total_width / 2), 2));

                    if (total_width == 0)
                    {
                        invalidLabel.Text = "Error: No Number Entered";

                        aLabel.Visible = false;
                        bLabel.Visible = false;
                        invalidLabel.Visible = true;
                    }
                    else
                    {
                        aLabel.Text = String.Format("Slant Height (s) = {0:0.0000}", pSlant);
                        bLabel.Text = String.Format("Pyramid Height (h) = {0:0.0000}", pHeight);

                        aLabel.Visible = true;
                        bLabel.Visible = true;
                        resultPanel.Visible = true;
                        pyramidImage.Visible = true;
                        dimensionsLabel.Visible = true;
                    }
                }
                else
                {
                    invalidLabel.Text = "Error: Invalid Input";

                    invalidLabel.Visible = true;
                }
            }
            // user selects triangle
            else if (triangleButton.Checked == true)
            {
                if (valid)
                {
                    b = temp;
                    a = b * PHI;

                    if (b == 0)
                    {
                        invalidLabel.Text = "Error: No Number Entered";

                        invalidLabel.Visible = true;
                    }
                    else
                    {
                        aLabel.Text = String.Format("Side Lengths (a): {0:0.0000}", a);

                        aLabel.Visible = true;
                        dimensionsLabel.Visible = true;
                        resultPanel.Visible = true;
                        triangleImage.Visible = true;
                    }
                }
                else
                {
                    invalidLabel.Text = "Error: Invalid Input";

                    invalidLabel.Visible = true;
                }
            }
            // no shape clicked
            else if (rectButton.Checked == false && pyramidButton.Checked == false && triangleButton.Checked == false || valid == false)
            {
                invalidLabel.Text = "Error: No Shape Selected";

                invalidLabel.Visible = true;
            }
        }

        //============================================================================================================
        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
