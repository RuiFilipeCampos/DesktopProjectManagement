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
    public partial class FormNewTask : Form
    {
        public FormNewTask()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_CREATE_TASK_Click(object sender, EventArgs e)
        {
            // just getting the data into a trackable format 
            string task_name = textBox_TASK_NAME.Text;

            if (task_name == "") {

                var errorDialog = new FormErrorDialog("Task name must be specified.");
                errorDialog.ShowDialog(); 
                return;
            };
            string task_description = richTextBox1.Text;


            this.Close();
        }

        private void FormNewTask_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false; 
        }
    }
}
