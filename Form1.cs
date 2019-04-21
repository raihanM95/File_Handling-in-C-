using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("write.txt"))
            {
                //writetext.WriteLine("writing in text file");
                string a = textBox1.Text;
                writetext.WriteLine(a);

                string b = textBox2.Text;
                writetext.WriteLine(b);

                MessageBox.Show("Data Saved");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader readtext = new StreamReader("write.txt", true))
                {
                    string readMeText;
                    while ((readMeText = readtext.ReadLine()) != null)
                    {
                        //textBox3.Text = readMeText;
                        textBox3.AppendText(readMeText);
                        textBox3.AppendText(Environment.NewLine);
                    }
                    readtext.Close();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("File not found");
            }
        }
    }
}
