using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TugasPertemuan3
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void ButtonTambahClick(object sender, EventArgs e)
		{
			listBox1.Items.Add(textBoxNama.Text + " - " + textBoxNoHP.Text);
			textBoxNama.Clear();
			textBoxNoHP.Clear();
		}
		
		void ButtonHapusClick(object sender, EventArgs e)
		{
			listBox1.Items.RemoveAt(listBox1.SelectedIndex);
		}
		
		
		void ButtonHapusSemuaClick(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}
	}
}
