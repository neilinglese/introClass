namespace newProject
{
    partial class Form1
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
            this.nxtForm = new System.Windows.Forms.Button();
            this.form1Txt = new System.Windows.Forms.Label();
            this.changeTxt = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proBar = new System.Windows.Forms.ProgressBar();
            this.barChange = new System.Windows.Forms.Button();
            this.myPanel = new System.Windows.Forms.Panel();
            this.showEverything = new System.Windows.Forms.Button();
            this.hideEverything = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nxtForm
            // 
            this.nxtForm.Location = new System.Drawing.Point(12, 265);
            this.nxtForm.Name = "nxtForm";
            this.nxtForm.Size = new System.Drawing.Size(75, 23);
            this.nxtForm.TabIndex = 0;
            this.nxtForm.Text = "next form";
            this.nxtForm.UseVisualStyleBackColor = true;
            this.nxtForm.Click += new System.EventHandler(this.nxtForm_Click);
            // 
            // form1Txt
            // 
            this.form1Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1Txt.ForeColor = System.Drawing.Color.Black;
            this.form1Txt.Location = new System.Drawing.Point(23, 9);
            this.form1Txt.Name = "form1Txt";
            this.form1Txt.Size = new System.Drawing.Size(462, 172);
            this.form1Txt.TabIndex = 1;
            this.form1Txt.Text = "label1";
            // 
            // changeTxt
            // 
            this.changeTxt.Location = new System.Drawing.Point(147, 265);
            this.changeTxt.Name = "changeTxt";
            this.changeTxt.Size = new System.Drawing.Size(99, 23);
            this.changeTxt.TabIndex = 2;
            this.changeTxt.Text = "Change Text";
            this.changeTxt.UseVisualStyleBackColor = true;
            this.changeTxt.Click += new System.EventHandler(this.changeTxt_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(147, 160);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your Name";
            // 
            // proBar
            // 
            this.proBar.BackColor = System.Drawing.Color.Blue;
            this.proBar.ForeColor = System.Drawing.Color.Aqua;
            this.proBar.Location = new System.Drawing.Point(28, 53);
            this.proBar.Name = "proBar";
            this.proBar.Size = new System.Drawing.Size(149, 23);
            this.proBar.TabIndex = 5;
            // 
            // barChange
            // 
            this.barChange.Location = new System.Drawing.Point(28, 86);
            this.barChange.Name = "barChange";
            this.barChange.Size = new System.Drawing.Size(75, 23);
            this.barChange.TabIndex = 6;
            this.barChange.Text = "Change Bar";
            this.barChange.UseVisualStyleBackColor = true;
            this.barChange.Click += new System.EventHandler(this.barChange_Click);
            // 
            // myPanel
            // 
            this.myPanel.BackColor = System.Drawing.Color.Red;
            this.myPanel.Location = new System.Drawing.Point(214, 9);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(200, 100);
            this.myPanel.TabIndex = 7;
            // 
            // showEverything
            // 
            this.showEverything.Location = new System.Drawing.Point(287, 265);
            this.showEverything.Name = "showEverything";
            this.showEverything.Size = new System.Drawing.Size(75, 23);
            this.showEverything.TabIndex = 8;
            this.showEverything.Text = "Show";
            this.showEverything.UseVisualStyleBackColor = true;
            this.showEverything.Click += new System.EventHandler(this.showEverything_Click);
            // 
            // hideEverything
            // 
            this.hideEverything.Location = new System.Drawing.Point(287, 265);
            this.hideEverything.Name = "hideEverything";
            this.hideEverything.Size = new System.Drawing.Size(75, 23);
            this.hideEverything.TabIndex = 9;
            this.hideEverything.Text = "Hide";
            this.hideEverything.UseVisualStyleBackColor = true;
            this.hideEverything.Click += new System.EventHandler(this.hideEverything_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "New Label For Git";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(582, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hideEverything);
            this.Controls.Add(this.showEverything);
            this.Controls.Add(this.myPanel);
            this.Controls.Add(this.barChange);
            this.Controls.Add(this.proBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.changeTxt);
            this.Controls.Add(this.form1Txt);
            this.Controls.Add(this.nxtForm);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nxtForm;
        private System.Windows.Forms.Label form1Txt;
        private System.Windows.Forms.Button changeTxt;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar proBar;
        private System.Windows.Forms.Button barChange;
        private System.Windows.Forms.Panel myPanel;
        private System.Windows.Forms.Button showEverything;
        private System.Windows.Forms.Button hideEverything;
        private System.Windows.Forms.Label label2;
    }
}

