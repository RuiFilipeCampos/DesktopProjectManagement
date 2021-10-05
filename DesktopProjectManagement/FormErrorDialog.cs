using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProjectManagement
{
    public partial class FormErrorDialog : Form
    {
        public FormErrorDialog(string error_description)
        {
            InitializeComponent();
            richTextBox_ERROR_DESCRIPTION.Text = error_description; 
        }

        private void button_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
