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


namespace test
{
    public partial class Form1 : Form
    {
        
        private string _openFile;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog Sdialog = new SaveFileDialog();
            Sdialog.Filter = "all (*.*)|*.*";
            if (Sdialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(Sdialog.FileName, richTextBox1.Text);
                _openFile = Sdialog.FileName;
            }
            toolStripStatusLabel1.Text = "Saving";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           OpenFileDialog Fdialog = new OpenFileDialog();
            Fdialog.Filter = "all (*.*)|*.*";
            if (Fdialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(Fdialog.FileName);
                _openFile = Fdialog.FileName;
            }
            toolStripStatusLabel1.Text = "Opening";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fdialog = new OpenFileDialog();
            Fdialog.Filter = "all (*.*)|*.*";
            if (Fdialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(Fdialog.FileName);
                _openFile = Fdialog.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(_openFile, richTextBox1.Text);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("save error");
                
            }
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("вот бы оап сдать");
        }

        private void toolStripButton2_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ready";
        }

        private void toolStripButton2_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
          toolStripStatusLabel1.Text = "";
            

        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            toolStripStatusLabel2.Text = "modified";
        }
    }
    }

