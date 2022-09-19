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

namespace Text05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                int celkovySoucet=0;
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    if (int.TryParse(line, out int cislo))
                    {
                        celkovySoucet += cislo;
                    }
                }
                streamReader.Close();
                StreamWriter streamWriter = File.AppendText(openFileDialog1.FileName);
                streamWriter.WriteLine("Celkový součet je: " +celkovySoucet);
                streamWriter.Close();   
            }
        }
    }
}
