﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace kentapad
{
    public partial class berak_kapur : Form
    {
        public berak_kapur()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("we gonna check ur mom", "sup daddy");
            this.Hide();
            calming calm = new calming();
            calm.ShowDialog();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/akukebedberag/");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/txGvYkr8eW");
        }

        private async void label4_Click(object sender, EventArgs e)
        {
            Label label = new Label { Text = "Click me" };
            label.Click += delegate { label.Text = "Clicked"; };
            await Task.Delay(1500);
            Process.Start("https://saweria.co/fazanich");
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("wanna close this loader ?", "hold up", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
