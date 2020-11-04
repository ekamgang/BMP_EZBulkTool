using System;
using System.Windows.Forms;

namespace BMP_EZBulkTool
{
    public partial class Popup : Form
    {

        private Action<string, string, string> insertIntoList;


        public Popup(Action<string, string, string> insertIntoList, string Default)
        {
            InitializeComponent();
            this.insertIntoList = insertIntoList;
            this.ComboBox_DropDownSelect.SelectedItem = (object)Default;
            
        }

        private void Popup_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_Done_Click(object sender, EventArgs e)
        {
            insertIntoList(TextBox_FirstName.Text, TextBox_Email.Text, (string)ComboBox_DropDownSelect.SelectedItem);
            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
            //message box
        }
    }
}
