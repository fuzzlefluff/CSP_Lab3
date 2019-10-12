using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator_Matthew_Prindle_Summer_2017
{
    public partial class MainFrm : Form
    {
        double MemoryVar;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Value1TxtB.Text = "";
            Value2TxtB.Text = "";
            ResultTxtB.Text = "";
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double result = 0;
                double num1 = Convert.ToDouble(Value1TxtB.Text);
                double num2 = Convert.ToDouble(Value2TxtB.Text);
                if (AdditionRadBtn.Checked == true)
                {
                    result = num1 + num2;
                }
                if (SubRadBtn.Checked == true)
                {
                    result = num1 - num2;
                }
                if (MultiRadBtn.Checked == true)
                {
                    result = num1 * num2;
                }
                if (DivRadBtn.Checked == true)
                {
                    result = num1 / num2;
                }
                ResultTxtB.Text = Convert.ToString(result);
            }
            catch (Exception E) { MessageBox.Show("Please Enter 2 Numbers!"); }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdditionRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (AdditionRadBtn.Checked == true) { OperatorLbl.Text = "+"; }
        }
        private void SubRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (SubRadBtn.Checked == true) { OperatorLbl.Text = "-"; }
        }

        private void MultiRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (MultiRadBtn.Checked == true) { OperatorLbl.Text = "*"; }
        }

        private void DivRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (DivRadBtn.Checked == true) { OperatorLbl.Text = "/"; }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Value1TxtB.Text = "";
            Value2TxtB.Text = "";
            ResultTxtB.Text = "";
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple calculator, simply type in 2 numbers into the boxes under Value 1 and Value 2, then select the operation radio button and click on the calculate button, your result will be show in the result box.");
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainFrm.ActiveForm.BackColor = Color.LightSteelBlue;
            AdditionRadBtn.ForeColor = Color.DarkViolet;
            AdditionRadBtn.BackColor = Color.LightSteelBlue;
            SubRadBtn.ForeColor = Color.DarkViolet;
            SubRadBtn.BackColor = Color.LightSteelBlue;
            MultiRadBtn.ForeColor = Color.DarkViolet;
            MultiRadBtn.BackColor = Color.LightSteelBlue;
            DivRadBtn.ForeColor = Color.DarkViolet;
            DivRadBtn.BackColor = Color.LightSteelBlue;
            CalcBtn.ForeColor = Color.GhostWhite;
            CalcBtn.BackColor = Color.DarkSlateGray;
            ClearBtn.ForeColor = Color.GhostWhite;
            ClearBtn.BackColor = Color.DarkSlateGray;
            ExitBtn.ForeColor = Color.GhostWhite;
            ExitBtn.BackColor = Color.DarkSlateGray;
            Value1TxtB.ForeColor = Color.Black;
            Value1TxtB.BackColor = Color.White;
            Value2TxtB.ForeColor = Color.Black;
            Value2TxtB.BackColor = Color.White;
            OperatorLbl.ForeColor = Color.Black;
            OperatorLbl.BackColor = Color.White;
            Value1Lbl.ForeColor = Color.Maroon;
            Value1Lbl.BackColor = Color.AliceBlue;
            Value2Lbl.ForeColor = Color.Maroon;
            Value2Lbl.BackColor = Color.AliceBlue;
            ResultLbl.ForeColor = Color.DarkGreen;
            ResultLbl.BackColor = Color.AliceBlue;
            ResultTxtB.ForeColor = Color.Black;
            ResultTxtB.BackColor = Color.White;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainFrm.ActiveForm.BackColor = Color.Red;
            AdditionRadBtn.ForeColor = Color.DarkViolet;
            AdditionRadBtn.BackColor = Color.LightSteelBlue;
            SubRadBtn.ForeColor = Color.DarkViolet;
            SubRadBtn.BackColor = Color.LightSteelBlue;
            MultiRadBtn.ForeColor = Color.DarkViolet;
            MultiRadBtn.BackColor = Color.LightSteelBlue;
            DivRadBtn.ForeColor = Color.DarkViolet;
            DivRadBtn.BackColor = Color.LightSteelBlue;
            CalcBtn.ForeColor = Color.GhostWhite;
            CalcBtn.BackColor = Color.DarkSlateGray;
            ClearBtn.ForeColor = Color.GhostWhite;
            ClearBtn.BackColor = Color.DarkSlateGray;
            ExitBtn.ForeColor = Color.GhostWhite;
            ExitBtn.BackColor = Color.DarkSlateGray;
            Value1TxtB.ForeColor = Color.Black;
            Value1TxtB.BackColor = Color.White;
            Value2TxtB.ForeColor = Color.Black;
            Value2TxtB.BackColor = Color.White;
            OperatorLbl.ForeColor = Color.Black;
            OperatorLbl.BackColor = Color.White;
            Value1Lbl.ForeColor = Color.Maroon;
            Value1Lbl.BackColor = Color.AliceBlue;
            Value2Lbl.ForeColor = Color.Maroon;
            Value2Lbl.BackColor = Color.AliceBlue;
            ResultLbl.ForeColor = Color.DarkGreen;
            ResultLbl.BackColor = Color.AliceBlue;
            ResultTxtB.ForeColor = Color.Black;
            ResultTxtB.BackColor = Color.White;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainFrm.ActiveForm.BackColor = Color.Blue;
            AdditionRadBtn.ForeColor = Color.DarkViolet;
            AdditionRadBtn.BackColor = Color.LightSteelBlue;
            SubRadBtn.ForeColor = Color.DarkViolet;
            SubRadBtn.BackColor = Color.LightSteelBlue;
            MultiRadBtn.ForeColor = Color.DarkViolet;
            MultiRadBtn.BackColor = Color.LightSteelBlue;
            DivRadBtn.ForeColor = Color.DarkViolet;
            DivRadBtn.BackColor = Color.LightSteelBlue;
            CalcBtn.ForeColor = Color.GhostWhite;
            CalcBtn.BackColor = Color.DarkSlateGray;
            ClearBtn.ForeColor = Color.GhostWhite;
            ClearBtn.BackColor = Color.DarkSlateGray;
            ExitBtn.ForeColor = Color.GhostWhite;
            ExitBtn.BackColor = Color.DarkSlateGray;
            Value1TxtB.ForeColor = Color.Black;
            Value1TxtB.BackColor = Color.White;
            Value2TxtB.ForeColor = Color.Black;
            Value2TxtB.BackColor = Color.White;
            OperatorLbl.ForeColor = Color.Black;
            OperatorLbl.BackColor = Color.White;
            Value1Lbl.ForeColor = Color.Maroon;
            Value1Lbl.BackColor = Color.AliceBlue;
            Value2Lbl.ForeColor = Color.Maroon;
            Value2Lbl.BackColor = Color.AliceBlue;
            ResultLbl.ForeColor = Color.DarkGreen;
            ResultLbl.BackColor = Color.AliceBlue;
            ResultTxtB.ForeColor = Color.Black;
            ResultTxtB.BackColor = Color.White;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainFrm.ActiveForm.BackColor = Color.Green;
            AdditionRadBtn.ForeColor = Color.DarkViolet;
            AdditionRadBtn.BackColor = Color.LightSteelBlue;
            SubRadBtn.ForeColor = Color.DarkViolet;
            SubRadBtn.BackColor = Color.LightSteelBlue;
            MultiRadBtn.ForeColor = Color.DarkViolet;
            MultiRadBtn.BackColor = Color.LightSteelBlue;
            DivRadBtn.ForeColor = Color.DarkViolet;
            DivRadBtn.BackColor = Color.LightSteelBlue;
            CalcBtn.ForeColor = Color.GhostWhite;
            CalcBtn.BackColor = Color.DarkSlateGray;
            ClearBtn.ForeColor = Color.GhostWhite;
            ClearBtn.BackColor = Color.DarkSlateGray;
            ExitBtn.ForeColor = Color.GhostWhite;
            ExitBtn.BackColor = Color.DarkSlateGray;
            Value1TxtB.ForeColor = Color.Black;
            Value1TxtB.BackColor = Color.White;
            Value2TxtB.ForeColor = Color.Black;
            Value2TxtB.BackColor = Color.White;
            OperatorLbl.ForeColor = Color.Black;
            OperatorLbl.BackColor = Color.White;
            Value1Lbl.ForeColor = Color.Maroon;
            Value1Lbl.BackColor = Color.AliceBlue;
            Value2Lbl.ForeColor = Color.Maroon;
            Value2Lbl.BackColor = Color.AliceBlue;
            ResultLbl.ForeColor = Color.DarkGreen;
            ResultLbl.BackColor = Color.AliceBlue;
            ResultTxtB.ForeColor = Color.Black;
            ResultTxtB.BackColor = Color.White;
        }

        private void ForLoopBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) { Console.WriteLine("Go Falcons!"); } 
        }

        private void WhileLoopBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 10) { Console.WriteLine("Go Falcons!"); i++; }
        }

        private void memoryBtn_Click(object sender, EventArgs e)
        {
            try { MemoryVar = Convert.ToDouble(ResultTxtB.Text); }
            catch (Exception E) { MessageBox.Show("There is no result to store!"); }
        }

        private void memoryplusBtn_Click(object sender, EventArgs e)
        {
            try { MemoryVar += Convert.ToDouble(ResultTxtB.Text); }
            catch (Exception E) { MessageBox.Show("There is no result to add!"); }
        }
        private void memoryLbl_Enter(Object sender, EventArgs e)
        {
            memoryLbl.Text = Convert.ToString(MemoryVar);
        }
        private void memoryLbl_Exit(Object sender, EventArgs e)
        {
            memoryLbl.Text = " ";
        }
    }
}
