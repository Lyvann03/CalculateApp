using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateApp
{
    public partial class Form1 : Form
    {
        //Declear variable

        string Input = "";
        double Results = 0;
        string Operatoin = "";
        bool OperationChoose = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Number and Digit button
        private void btnNum1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Input += btn.Text;
            txtInput.Text = Input;
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Input += btn.Text;
            txtInput.Text = Input;
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Input += btn.Text;
            txtInput.Text = Input;
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Input += btn.Text;
            txtInput.Text = Input;
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Input += btn.Text;
            txtInput.Text = Input;
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Input += btn.Text;
            txtInput.Text = Input;
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Input += btn.Text;
            txtInput.Text = Input;
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Input += btn.Text;
            txtInput.Text = Input;
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Input += btn.Text;
            txtInput.Text = Input;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Input += btn.Text;
            txtInput.Text = Input;
        }

        //Make a method for operation in every button
        private void Evaluate()
        {
           if(OperationChoose)
            {
                double SecondNum = double.Parse(Input);

                switch (Operatoin)
                {
                    case "+":
                        Results += SecondNum;
                        break;
                    case "-":
                        Results -= SecondNum;
                        break;
                    case "*":
                        Results *= SecondNum;
                        break;
                    case "/":
                        if (SecondNum != 0)
                        {
                            Results /= SecondNum;
                        }
                        else
                        {
                            txtInput.Text = "Error!";
                        }
                        break;
                }
                txtInput.Text = Results.ToString();
                Input = "";
                OperationChoose = false;
           }

        }

        //Button to calculate the number in the calculate
        private void btnClear_Click(object sender, EventArgs e)
        {
            Input = "";
            Operatoin = "";
            Results = 0;
            OperationChoose = false;
            txtInput.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (OperationChoose)
            {
                Evaluate();
            }
            Button btn = (Button)sender;
            Operatoin = btn.Text; //This is mean Operation = what we are click the button for
            Results = double.Parse(Input); //We declear the result as double so we need to convert the result as string 
            Input = "";
            OperationChoose = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (OperationChoose)
            {
                Evaluate();
            }
            Button btn = (Button)sender;
            Operatoin = btn.Text; //This is mean Operation = what we are click the button for
            Results = double.Parse(Input); //We declear the result as double so we need to convert the result as string 
            Input = "";
            OperationChoose = true;
        }

        private void btnMutiply_Click(object sender, EventArgs e)
        {
            if (OperationChoose)
            {
                Evaluate();
            }
            Button btn = (Button)sender;
            Operatoin = btn.Text; //This is mean Operation = what we are click the button for
            Results = double.Parse(Input); //We declear the result as double so we need to convert the result as string 
            Input = "";
            OperationChoose = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (OperationChoose)
            {
                Evaluate();
            }
            Button btn = (Button)sender;
            Operatoin = btn.Text; //This is mean Operation = what we are click the button for
            Results = double.Parse(Input); //We declear the result as double so we need to convert the result as string 
            Input = "";
            OperationChoose = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Evaluate();
        }
    }
}
