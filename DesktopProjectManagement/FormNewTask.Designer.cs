
namespace DesktopProjectManagement
{
    partial class FormNewTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_TASK_NAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_CREATE_TASK = new System.Windows.Forms.Button();
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_TASK_NAME
            // 
            this.textBox_TASK_NAME.Location = new System.Drawing.Point(83, 13);
            this.textBox_TASK_NAME.Name = "textBox_TASK_NAME";
            this.textBox_TASK_NAME.Size = new System.Drawing.Size(164, 20);
            this.textBox_TASK_NAME.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task Description:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(232, 234);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button_CREATE_TASK
            // 
            this.button_CREATE_TASK.Location = new System.Drawing.Point(169, 323);
            this.button_CREATE_TASK.Name = "button_CREATE_TASK";
            this.button_CREATE_TASK.Size = new System.Drawing.Size(75, 23);
            this.button_CREATE_TASK.TabIndex = 4;
            this.button_CREATE_TASK.Text = "New Task";
            this.button_CREATE_TASK.UseVisualStyleBackColor = true;
            this.button_CREATE_TASK.Click += new System.EventHandler(this.button_CREATE_TASK_Click);
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.Location = new System.Drawing.Point(12, 323);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.button_CANCEL.TabIndex = 5;
            this.button_CANCEL.Text = "Cancel";
            this.button_CANCEL.UseVisualStyleBackColor = true;
            this.button_CANCEL.Click += new System.EventHandler(this.button_CANCEL_Click);
            // 
            // FormNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 360);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.button_CREATE_TASK);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_TASK_NAME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormNewTask";
            this.Text = "FormNewTask";
            this.Load += new System.EventHandler(this.FormNewTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_TASK_NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_CREATE_TASK;
        private System.Windows.Forms.Button button_CANCEL;
    }
}