﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao
{
    public partial class While : Form
    {
        public While()
        {
            InitializeComponent();

            int i = 15;

            double dinheiro = 1000.0;
            while (i >= 0)
            {
                dinheiro -= i;

                txtresult.Text = Convert.ToString(dinheiro);
                i--;


            }
            MessageBox.Show("O subtraído um "+ dinheiro);
            
        }
    }
}
