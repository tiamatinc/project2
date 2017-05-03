namespace RecipeMadness1
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstStyles = new System.Windows.Forms.ListView();
            this.lstCategories = new System.Windows.Forms.ListView();
            this.lstIngredients = new System.Windows.Forms.ListView();
            this.cmbSeason = new System.Windows.Forms.ComboBox();
            this.txbRecipeName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 20);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Styles:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Categories:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ingredients:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Season:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Recipe Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(30, 186);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstStyles
            // 
            this.lstStyles.CheckBoxes = true;
            this.lstStyles.Location = new System.Drawing.Point(427, 52);
            this.lstStyles.Name = "lstStyles";
            this.lstStyles.Size = new System.Drawing.Size(137, 258);
            this.lstStyles.TabIndex = 27;
            this.lstStyles.UseCompatibleStateImageBehavior = false;
            // 
            // lstCategories
            // 
            this.lstCategories.CheckBoxes = true;
            this.lstCategories.Location = new System.Drawing.Point(284, 52);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(137, 258);
            this.lstCategories.TabIndex = 26;
            this.lstCategories.UseCompatibleStateImageBehavior = false;
            // 
            // lstIngredients
            // 
            this.lstIngredients.CheckBoxes = true;
            this.lstIngredients.FullRowSelect = true;
            this.lstIngredients.GridLines = true;
            this.lstIngredients.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstIngredients.HideSelection = false;
            this.lstIngredients.Location = new System.Drawing.Point(141, 52);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(137, 258);
            this.lstIngredients.TabIndex = 25;
            this.lstIngredients.UseCompatibleStateImageBehavior = false;
            // 
            // cmbSeason
            // 
            this.cmbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeason.FormattingEnabled = true;
            this.cmbSeason.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall",
            "Winter",
            "Any"});
            this.cmbSeason.Location = new System.Drawing.Point(18, 102);
            this.cmbSeason.Name = "cmbSeason";
            this.cmbSeason.Size = new System.Drawing.Size(102, 21);
            this.cmbSeason.TabIndex = 24;
            // 
            // txbRecipeName
            // 
            this.txbRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRecipeName.Location = new System.Drawing.Point(15, 52);
            this.txbRecipeName.Name = "txbRecipeName";
            this.txbRecipeName.Size = new System.Drawing.Size(105, 20);
            this.txbRecipeName.TabIndex = 22;
            this.txbRecipeName.TextChanged += new System.EventHandler(this.txbRecipeName_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(281, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(73, 13);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Find a Recipe";
            // 
            // frmAdHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 325);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstStyles);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.cmbSeason);
            this.Controls.Add(this.txbRecipeName);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAdHoc";
            this.Text = "Search Recipes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdHoc_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lstStyles;
        private System.Windows.Forms.ListView lstCategories;
        private System.Windows.Forms.ListView lstIngredients;
        private System.Windows.Forms.ComboBox cmbSeason;
        private System.Windows.Forms.TextBox txbRecipeName;
        private System.Windows.Forms.Label lblTitle;
    }
}