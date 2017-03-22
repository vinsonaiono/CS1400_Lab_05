// Project Prolog
// Name: Vinson Aiono
// CS 1400 Section 001
// Project: Lab_05
// Date: 1/27/2017 
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_04
{
    public partial class Form1 : Form
    {
        private int _firstValue = 0;
        const int MULT = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tang\nCS1400\nLab #5");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(TxtInput.Text, out _firstValue))
            {
                TxtOutput.Text = $"{_firstValue * MULT:D}";
                TxtOutput.Focus();
            }
            else
            {
                TxtInput.Text = $"{TxtInput.Text} -> Invalid int";
                TxtInput.Focus();
            }
        }
    }
}

/*
Question 1
TxtOutput.Text = $"{cash:c}"; 
Question 2
TxtOutput.Text = $"{_firstValue / MULT:D}";
*/
