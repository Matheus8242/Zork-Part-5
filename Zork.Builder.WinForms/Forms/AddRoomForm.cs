﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zork.Builder.WinForms.Forms
{
    public partial class AddRoomForm : Form
    {
        public string RoomName
        {
            get => roomTextBox.Text;
            set => roomTextBox.Text = value;
        }
        public AddRoomForm()
        {
            InitializeComponent();
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }
    }
}
