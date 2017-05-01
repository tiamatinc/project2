namespace WindowsFormsApplication1
{
    partial class frmAdHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdHoc));
            this.labelTiamatInc = new System.Windows.Forms.Label();
            this.btnGoToFavorites = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTiamatInc
            // 
            this.labelTiamatInc.AutoSize = true;
            this.labelTiamatInc.Location = new System.Drawing.Point(1230, 901);
            this.labelTiamatInc.Name = "labelTiamatInc";
            this.labelTiamatInc.Size = new System.Drawing.Size(154, 32);
            this.labelTiamatInc.TabIndex = 13;
            this.labelTiamatInc.Text = "Tiamat Inc.";
            // 
            // btnGoToFavorites
            // 
            this.btnGoToFavorites.Location = new System.Drawing.Point(560, 747);
            this.btnGoToFavorites.Name = "btnGoToFavorites";
            this.btnGoToFavorites.Size = new System.Drawing.Size(255, 117);
            this.btnGoToFavorites.TabIndex = 28;
            this.btnGoToFavorites.Text = "Go to Favorites";
            this.btnGoToFavorites.UseVisualStyleBackColor = true;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 31;
            this.listBox4.Items.AddRange(new object[] {
            "American",
            "Chinese",
            "Cuban",
            "Ecuadorian",
            "Filipino",
            "French",
            "Italian",
            "Japanese",
            "Mediterranean",
            "Mexican",
            "Korean"});
            this.listBox4.Location = new System.Drawing.Point(422, 413);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(236, 190);
            this.listBox4.TabIndex = 27;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 31;
            this.listBox2.Items.AddRange(new object[] {
            "Spring",
            "Winter",
            "Summer",
            "Fall"});
            this.listBox2.Location = new System.Drawing.Point(760, 413);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(236, 190);
            this.listBox2.TabIndex = 26;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Items.AddRange(new object[] {
            "Appetizers",
            "Breakfast",
            "Dessert",
            "Dinner",
            "Drinks",
            "Lunch",
            "Snacks"});
            this.listBox1.Location = new System.Drawing.Point(74, 413);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 190);
            this.listBox1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Style";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(812, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Season";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1110, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ingredients";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1063, 414);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 38);
            this.textBox2.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1021, 747);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(255, 117);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(301, 70);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(890, 192);
            this.labelWelcome.TabIndex = 18;
            this.labelWelcome.Text = resources.GetString("labelWelcome.Text");
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(106, 747);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(255, 117);
            this.btnViewAll.TabIndex = 29;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            // 
            // frmAdHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 935);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnGoToFavorites);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelTiamatInc);
            this.Name = "frmAdHoc";
            this.Text = "frmAdHoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTiamatInc;
        private System.Windows.Forms.Button btnGoToFavorites;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btnViewAll;
    }
}