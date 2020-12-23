using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace File2ByteConverter {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			byte[] bytes = File.ReadAllBytes(textBox1.Text);
			string res1 = string.Join("", bytes.Select(b => b.ToString()));
			string res2 = Convert.ToString(bytes);
			string res3 = Encoding.ASCII.GetString(bytes);
			richTextBox1.Text = res1;
		}
	}
}