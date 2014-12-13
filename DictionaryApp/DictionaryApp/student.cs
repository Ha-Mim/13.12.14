using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        Dictionary<double,string> studentInfo = new Dictionary<double,string>() ; 

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (studentInfo.ContainsKey(Convert.ToDouble(IDSaveTextBox.Text)))
            {
                MessageBox.Show("ID has already been saved ");
            }
            else
            {
                studentInfo.Add(Convert.ToDouble(IDSaveTextBox.Text),detailsTextBox.Text);
                MessageBox.Show("Information has been saved");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (studentInfo.ContainsKey(Convert.ToDouble(IDSearchTextBox.Text)))
            {
                string studentName = Convert.ToString(studentInfo[Convert.ToDouble(IDSearchTextBox.Text)]);
                MessageBox.Show(studentName);
            }
            else
            {
                MessageBox.Show("There is no entry with this ID");
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string allInfo = " ";
            foreach (KeyValuePair<double,string> pair in studentInfo )
            {
                allInfo = pair.Key + " : " + pair.Value + "\n";
            }
            MessageBox.Show(allInfo);
        }
    }
}
