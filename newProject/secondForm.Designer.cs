namespace newProject
{
    partial class secondForm
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
            this.preForm = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // preForm
            // 
            this.preForm.Location = new System.Drawing.Point(219, 229);
            this.preForm.Name = "preForm";
            this.preForm.Size = new System.Drawing.Size(75, 23);
            this.preForm.TabIndex = 0;
            this.preForm.Text = "Previous Form";
            this.preForm.UseVisualStyleBackColor = true;
            this.preForm.Click += new System.EventHandler(this.preForm_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.AutoSize = true;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.ForeColor = System.Drawing.Color.White;
            this.nameTxt.Location = new System.Drawing.Point(215, 79);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(51, 20);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.Text = "label1";
            // 
            // secondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(464, 298);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.preForm);
            this.Name = "secondForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "secondForm";
            this.Load += new System.EventHandler(this.secondForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button preForm;
        private System.Windows.Forms.Label nameTxt;
    }
}