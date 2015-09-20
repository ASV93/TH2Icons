//============================================================================
//
//    TH2Icons
//    Copyright (C) 2015 Visual Software Corporation
//
//    Author: ASV93
//    File: Form1.cs
//
//    This program is free software; you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation; either version 2 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License along
//    with this program; if not, write to the Free Software Foundation, Inc.,
//    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
//
//============================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VSCORP.TH2Icons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AccentColorizedIconABTest", true);
            if (radioButton1.Checked == true)
            {
                regkey.SetValue("UseAccentColorizedIcons", 1, RegistryValueKind.DWord);
            } else
            {
                regkey.SetValue("UseAccentColorizedIcons", 0, RegistryValueKind.DWord);
            }
            regkey.Close();
            MessageBox.Show("Applied!", "Apply", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)Bitmap.FromFile("Store.png");
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    if (bmp.GetPixel(x, y) == Color.FromArgb(255, 0, 0, 0))
                    {
                        bmp.SetPixel(x, y, Ext.ColorFunctions.GetImmersiveColor(Ext.ImmersiveColors.ImmersiveStartBackground));
                    }
                }
            }
            pictureBox1.Image = bmp;

            RegistryKey regkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AccentColorizedIconABTest", true);
            if (Convert.ToInt32(regkey.GetValue("UseAccentColorizedIcons",0)) == 1)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            regkey.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
