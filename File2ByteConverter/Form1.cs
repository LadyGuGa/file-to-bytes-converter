using System;
using System.IO;
using System.Windows.Forms;

namespace File2ByteConverter {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				textBox1.Text = openFileDialog1.FileName;

				byte[] bytes = File.ReadAllBytes(textBox1.Text);
				string result = Convert.ToBase64String(bytes);
				richTextBox1.Text = result;
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			Clipboard.SetText(richTextBox1.Text);
		}
	}
}