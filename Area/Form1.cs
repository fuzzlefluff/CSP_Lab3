using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_MatthewPrindleSummer2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            AreaTxtB.Visible = true;
            if (CircleRadBtn.Checked == true)
            {
                double radius = Convert.ToDouble (RadiusTxtB.Text);
                double result = CalcCircle(radius);
                AreaTxtB.Text = Convert.ToString(result);
            }
            if (SquareRadBtn.Checked == true)
            {
                double side = Convert.ToDouble(RadiusTxtB.Text);
                double result = CalcSquare(side);
                AreaTxtB.Text = Convert.ToString(result);
            }
            if (RectRadBtn.Checked == true)
            {
                double length = Convert.ToDouble(RadiusTxtB.Text);
                double width = Convert.ToDouble(WidthTextB.Text);
                double result = CalcRect(length,width);
                AreaTxtB.Text = Convert.ToString(result);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CircleRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CircleRadBtn.Checked == true) ;
            {
                RadiusLbl.Text = "Radius";
                RadiusTxtB.Visible = true;
                WidthTextB.Visible = false;
                AreaTxtB.Visible = false;
            }
        }

        private void SquareRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadiusTxtB.Visible = true;
            WidthTextB.Visible = false;
            AreaTxtB.Visible = false;
            RadiusLbl.Text = "Side";
        }

        private void RectRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadiusLbl.Text = "Height";
            RadiusTxtB.Visible = true;
            WidthTextB.Visible = true;
            AreaTxtB.Visible = false;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CircleRadBtn.Checked = true;
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SquareRadBtn.Checked = true;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RectRadBtn.Checked = true;
        }

        private void shapeLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shapeLstBox.SelectedIndex == 0) { CircleRadBtn.Checked = true; }
            if (shapeLstBox.SelectedIndex == 1) { SquareRadBtn.Checked = true; }
            if (shapeLstBox.SelectedIndex == 2) { RectRadBtn.Checked = true; }
        }

        private void shapeCombBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shapeCombBox.SelectedIndex == 0) { CircleRadBtn.Checked = true; }
            if (shapeCombBox.SelectedIndex == 1) { SquareRadBtn.Checked = true; }
            if (shapeCombBox.SelectedIndex == 2) { RectRadBtn.Checked = true; }
        }

        private void Clear()
        {
            RadiusTxtB.Text = "";
            WidthTextB.Text = "";
            AreaTxtB.Text = "";
        }

        private void Exit()
        {
            DialogResult result = MessageBox.Show("Really Close the Program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private double CalcCircle(double radius)
        {
            double result = 0;
            result = radius * radius;
            result = result * Math.PI;
            return result;
        }
        private double CalcSquare(double side)
        {
            double result = 0;
            result = side * side;
            return result;
        }
        private double CalcRect(double length, double width)
        {
            double result = 0;
            result = length * width;
            return result;
        }
    }
}
