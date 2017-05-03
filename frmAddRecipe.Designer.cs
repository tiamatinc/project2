namespace RecipeMadness1
{
    partial class frmAddRecipe
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txbRecipeName = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.RichTextBox();
            this.cmbSeason = new System.Windows.Forms.ComboBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.lstIngredients = new System.Windows.Forms.ListView();
            this.lstCategories = new System.Windows.Forms.ListView();
            this.lstStyles = new System.Windows.Forms.ListView();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnAddNewStyle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(311, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add a Recipe";
            // 
            // txbRecipeName
            // 
            this.txbRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRecipeName.Location = new System.Drawing.Point(12, 48);
            this.txbRecipeName.Name = "txbRecipeName";
            this.txbRecipeName.Size = new System.Drawing.Size(105, 20);
            this.txbRecipeName.TabIndex = 1;
            this.txbRecipeName.TextChanged += new System.EventHandler(this.txbRecipeName_TextChanged);
            // 
            // txbDescription
            // 
            this.txbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescription.Location = new System.Drawing.Point(12, 74);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(239, 232);
            this.txbDescription.TabIndex = 2;
            this.txbDescription.Text = "Recipe Directions or Link";
            this.txbDescription.TextChanged += new System.EventHandler(this.txbDescription_TextChanged);
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
            this.cmbSeason.Location = new System.Drawing.Point(130, 47);
            this.cmbSeason.Name = "cmbSeason";
            this.cmbSeason.Size = new System.Drawing.Size(121, 21);
            this.cmbSeason.TabIndex = 3;
            this.cmbSeason.SelectedIndexChanged += new System.EventHandler(this.cmbSeason_SelectedIndexChanged);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(257, 257);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(137, 23);
            this.btnAddIngredient.TabIndex = 5;
            this.btnAddIngredient.Text = "Add New Ingredient";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // lstIngredients
            // 
            this.lstIngredients.CheckBoxes = true;
            this.lstIngredients.FullRowSelect = true;
            this.lstIngredients.GridLines = true;
            this.lstIngredients.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstIngredients.HideSelection = false;
            this.lstIngredients.Location = new System.Drawing.Point(257, 48);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(137, 199);
            this.lstIngredients.TabIndex = 9;
            this.lstIngredients.UseCompatibleStateImageBehavior = false;
            // 
            // lstCategories
            // 
            this.lstCategories.CheckBoxes = true;
            this.lstCategories.Location = new System.Drawing.Point(400, 48);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(137, 199);
            this.lstCategories.TabIndex = 10;
            this.lstCategories.UseCompatibleStateImageBehavior = false;
            // 
            // lstStyles
            // 
            this.lstStyles.CheckBoxes = true;
            this.lstStyles.Location = new System.Drawing.Point(543, 48);
            this.lstStyles.Name = "lstStyles";
            this.lstStyles.Size = new System.Drawing.Size(137, 199);
            this.lstStyles.TabIndex = 11;
            this.lstStyles.UseCompatibleStateImageBehavior = false;
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(400, 257);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(137, 23);
            this.btnNewCategory.TabIndex = 12;
            this.btnNewCategory.Text = "Add New Category";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // btnAddNewStyle
            // 
            this.btnAddNewStyle.Location = new System.Drawing.Point(543, 257);
            this.btnAddNewStyle.Name = "btnAddNewStyle";
            this.btnAddNewStyle.Size = new System.Drawing.Size(137, 23);
            this.btnAddNewStyle.TabIndex = 13;
            this.btnAddNewStyle.Text = "Add New Style";
            this.btnAddNewStyle.UseVisualStyleBackColor = true;
            this.btnAddNewStyle.Click += new System.EventHandler(this.btnAddNewStyle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(605, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Recipe Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Season:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ingredients:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Categories:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Styles:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 20);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 328);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNewStyle);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.lstStyles);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.cmbSeason);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbRecipeName);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddRecipe";
            this.Text = "Add Recipe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddRecipe_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txbRecipeName;
        private System.Windows.Forms.RichTextBox txbDescription;
        private System.Windows.Forms.ComboBox cmbSeason;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.ListView lstIngredients;
        private System.Windows.Forms.ListView lstCategories;
        private System.Windows.Forms.ListView lstStyles;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Button btnAddNewStyle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
    }
}