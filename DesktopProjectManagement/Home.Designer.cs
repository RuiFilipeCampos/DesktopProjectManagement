
namespace DesktopProjectManagement
{
    partial class Home
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
            this.button_ADD_TASK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ADD_TASK
            // 
            this.button_ADD_TASK.Location = new System.Drawing.Point(12, 12);
            this.button_ADD_TASK.Name = "button_ADD_TASK";
            this.button_ADD_TASK.Size = new System.Drawing.Size(75, 23);
            this.button_ADD_TASK.TabIndex = 0;
            this.button_ADD_TASK.Text = "Add a Task";
            this.button_ADD_TASK.UseVisualStyleBackColor = true;
            this.button_ADD_TASK.Click += new System.EventHandler(this.button_ADD_TASK_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ADD_TASK);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ADD_TASK;
    }
}

