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

namespace FileRWApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = customerInfoTextBox.Text;
            string path = @"D\info.txt";
            FileStream aFileStream = new FileStream(path,FileMode.Append);
            StreamWriter aStreamWriter= new StreamWriter(aFileStream);
            aStreamWriter.Write(name);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
            aFileStream.Close();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string path = @"D\info.txt";
            FileStream aFileStream  = new FileStream(path, FileMode.Open); 
            StreamReader aStreamReader = new StreamReader(aFileStream);
            showAllListBox.Items.Clear();
            while (aStreamReader.EndOfStream)
            {
                string aName = aStreamReader.ReadLine();
            }
            aStreamReader.Close();
            aFileStream.Close();
        }
    }
}
