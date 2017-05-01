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
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.txbRecipeName.Text = "Recipe Name";
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
            this.cmbSeason.Text = "Season";
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
            this.lstIngredients.Location = new System.Drawing.Point(257, 48);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(137, 199);
            this.lstIngredients.TabIndex = 9;
            this.lstIngredients.UseCompatibleStateImageBehavior = false;
            this.lstIngredients.SelectedIndexChanged += new System.EventHandler(this.lstIngredients_SelectedIndexChanged);
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
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add New Style";
            this.button2.UseVisualStyleBackColor = true;
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
            // frmAddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 328);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
    }
}