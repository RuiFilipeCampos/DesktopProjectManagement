
namespace DesktopProjectManagement
{
    partial class FormErrorDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_ERROR_DESCRIPTION = new System.Windows.Forms.RichTextBox();
            this.button_CLOSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "An error has occured!";
            // 
            // richTextBox_ERROR_DESCRIPTION
            // 
            this.richTextBox_ERROR_DESCRIPTION.Location = new System.Drawing.Point(12, 37);
            this.richTextBox_ERROR_DESCRIPTION.Name = "richTextBox_ERROR_DESCRIPTION";
            this.richTextBox_ERROR_DESCRIPTION.Size = new System.Drawing.Size(425, 76);
            this.richTextBox_ERROR_DESCRIPTION.TabIndex = 1;
            this.richTextBox_ERROR_DESCRIPTION.Text = "";
            // 
            // button_CLOSE
            // 
            this.button_CLOSE.Location = new System.Drawing.Point(12, 119);
            this.button_CLOSE.Name = "button_CLOSE";
            this.button_CLOSE.Size = new System.Drawing.Size(425, 23);
            this.button_CLOSE.TabIndex = 2;
            this.button_CLOSE.Text = "Ok";
            this.button_CLOSE.UseVisualStyleBackColor = true;
            this.button_CLOSE.Click += new System.EventHandler(this.button_CLOSE_Click);
            // 
            // FormErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 146);
            this.Controls.Add(this.button_CLOSE);
            this.Controls.Add(this.richTextBox_ERROR_DESCRIPTION);
            this.Controls.Add(this.label1);
            this.Name = "FormErrorDialog";
            this.Text = "FormErrorDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_ERROR_DESCRIPTION;
        private System.Windows.Forms.Button button_CLOSE;
    }
}