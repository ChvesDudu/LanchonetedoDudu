﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LanchonetedoDudu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            string mensagem = " Nome Completo: " + txtName.Text + "\n" + " CPF: " + txtCPF.Text;
            MessageBox.Show(mensagem, "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}