using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace venetoalberghi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"veneto_verona.csv");
            string line = sr.ReadLine();         
            string citta = textBox1.Text;

            while (!sr.EndOfStream)
            {
                line=sr.ReadLine();
                string[] comune=line.Split(';');
                
                if (citta == comune[0])
                {
                    MessageBox.Show(comune[7]);

                    return;
                }
                else if (sr.EndOfStream)
                {
                    MessageBox.Show("Comune non esistente o errato, riprova");
                    return;
                }
                
            }
        }
    }
}

