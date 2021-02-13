using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;
using System.IO;

namespace Diagnoser
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        private double [,] data;

        public Form1()
        {
            nn = new NeuralNet(20, 30, 1);
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form2());
            int i;
            for (i = 0; i < symptoms.Items.Count; i++)
            {
                if (symptoms.GetItemChecked(i)) nn.setInputs(i, 1.0);
                else nn.setInputs(i, 0.0);
            }
            
            for (int k = 0; k < external.Items.Count; k++,i++)
            {
                if (external.GetItemChecked(k)) nn.setInputs(i, 1.0);
                else nn.setInputs(i, 0.0);
            }
            
            nn.run();
            index0.Text = "" + nn.getOuputData(0);
            if (nn.getOuputData(0) < 0.5)
            {
                output.Text = "NO COVID - 19";
            }
            else
            {
                output.Text = "COVID - 19";
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            readRecord();
            int l;

            for(int i = 0; i < 5; i++)
            {
                for (int k = 0; k < data.GetLength(0); k++)
                {
                    for (l = 0; l < data.GetLength(1)-1; l++)
                    {
                        nn.setInputs(l, data[k, l]);
                    }
                    nn.setDesiredOutput(0, data[k, l]);
                    nn.learn();
                }
            }
        }
        private void readRecord()
        {
            var lines = File.ReadAllLines("covid1k.csv");
            int i = 0, j = 0;
            data = new double[lines.Length - 1, 20];
            foreach (var line in lines)
            {
                /*Console.WriteLine(line);*/
                if (i != 0)
                {
                    var values = line.Split(',');
                    foreach (var value in values)
                    {
                        if (j != 0)
                        {
                            data[i - 1, j - 1] = Convert.ToDouble(value);
                        }
                        j++;
                    }
                }
                i++;
                j = 0;
            }

            /*for(int k=0; k < data.GetLength(0); k++)
          {
              for(int l = 0; l < data.GetLength(1)-1; l++)
              {
                  richTextBox1.Text += "" + data[k, l] + " ";
              }
              richTextBox1.Text += "\n";
          }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            nn.saveWeights(saveFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            nn.loadWeights(openFileDialog1.FileName);
        }
    }
}
