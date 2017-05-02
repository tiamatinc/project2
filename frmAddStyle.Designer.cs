namespace RecipeMadness1
{
    partial class frmAddStyle
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
            this.btnAddStyle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbStyle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddStyle
            // 
            this.btnAddStyle.Location = new System.Drawing.Point(64, 97);
            this.btnAddStyle.Name = "btnAddStyle";
            this.btnAddStyle.Size = new System.Drawing.Size(75, 23);
            this.btnAddStyle.TabIndex = 0;
            this.btnAddStyle.Text = "Add";
            this.btnAddStyle.UseVisualStyleBackColor = true;
            this.btnAddStyle.Click += new System.EventHandler(this.btnAddStyle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a New Style";
            // 
            // txbStyle
            // 
            this.txbStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStyle.Location = new System.Drawing.Point(41, 54);
            this.txbStyle.Name = "txbStyle";
            this.txbStyle.Size = new System.Drawing.Size(118, 20);
            this.txbStyle.TabIndex = 2;
            this.txbStyle.Text = "Style";
            this.txbStyle.TextChanged += new System.EventHandler(this.txbStyle_TextChanged);
            // 
            // frmAddStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 159);
            this.Controls.Add(this.txbStyle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddStyle);
            this.Name = "frmAddStyle";
            this.Text = "Add Style";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbStyle;
    }
}