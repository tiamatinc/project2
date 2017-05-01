namespace WindowsFormsApplication1
{
    partial class frmResultDisplay
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listView4 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 117);
            this.button1.TabIndex = 13;
            this.button1.Text = "Remove Recipe";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 117);
            this.button2.TabIndex = 14;
            this.button2.Text = "Update Recipe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(108, 622);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(255, 117);
            this.button4.TabIndex = 15;
            this.button4.Text = "Go to View Recipe";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(108, 781);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(255, 117);
            this.button5.TabIndex = 16;
            this.button5.Text = "(No Results) Add Recipe";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            this.listView4.Location = new System.Drawing.Point(442, 122);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(884, 776);
            this.listView4.TabIndex = 17;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1230, 901);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tiamat Inc.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(836, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Recipe";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 117);
            this.button3.TabIndex = 12;
            this.button3.Text = "View Search Results";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmResultDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 935);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "frmResultDisplay";
            this.Text = "frmResultDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}