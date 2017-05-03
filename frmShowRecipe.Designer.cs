namespace RecipeMadness1
{
    partial class frmShowRecipe
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
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblSeasons = new System.Windows.Forms.Label();
            this.lblStyles = new System.Windows.Forms.Label();
            this.lblIngredientLabel = new System.Windows.Forms.Label();
            this.txbDirections = new System.Windows.Forms.RichTextBox();
            this.lblDirections = new System.Windows.Forms.Label();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Location = new System.Drawing.Point(244, 9);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(79, 13);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "lblRecipeName";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(12, 59);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(67, 13);
            this.lblCategories.TabIndex = 1;
            this.lblCategories.Text = "lblCategories";
            // 
            // lblSeasons
            // 
            this.lblSeasons.AutoSize = true;
            this.lblSeasons.Location = new System.Drawing.Point(12, 84);
            this.lblSeasons.Name = "lblSeasons";
            this.lblSeasons.Size = new System.Drawing.Size(58, 13);
            this.lblSeasons.TabIndex = 2;
            this.lblSeasons.Text = "lblSeasons";
            // 
            // lblStyles
            // 
            this.lblStyles.AutoSize = true;
            this.lblStyles.Location = new System.Drawing.Point(12, 35);
            this.lblStyles.Name = "lblStyles";
            this.lblStyles.Size = new System.Drawing.Size(45, 13);
            this.lblStyles.TabIndex = 3;
            this.lblStyles.Text = "lblStyles";
            // 
            // lblIngredientLabel
            // 
            this.lblIngredientLabel.AutoSize = true;
            this.lblIngredientLabel.Location = new System.Drawing.Point(12, 114);
            this.lblIngredientLabel.Name = "lblIngredientLabel";
            this.lblIngredientLabel.Size = new System.Drawing.Size(62, 13);
            this.lblIngredientLabel.TabIndex = 5;
            this.lblIngredientLabel.Text = "Ingredients:";
            // 
            // txbDirections
            // 
            this.txbDirections.Location = new System.Drawing.Point(199, 130);
            this.txbDirections.Name = "txbDirections";
            this.txbDirections.ReadOnly = true;
            this.txbDirections.Size = new System.Drawing.Size(376, 405);
            this.txbDirections.TabIndex = 6;
            this.txbDirections.Text = "";
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(196, 114);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(57, 13);
            this.lblDirections.TabIndex = 7;
            this.lblDirections.Text = "Directions:";
            // 
            // btnFavorite
            // 
            this.btnFavorite.Location = new System.Drawing.Point(500, 541);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(75, 23);
            this.btnFavorite.TabIndex = 8;
            this.btnFavorite.Text = "Favorite";
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 22);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(15, 541);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMainMenu.TabIndex = 10;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.AllowUserToAddRows = false;
            this.dgvIngredients.AllowUserToDeleteRows = false;
            this.dgvIngredients.AllowUserToOrderColumns = true;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvIngredients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvIngredients.Location = new System.Drawing.Point(12, 130);
            this.dgvIngredients.MultiSelect = false;
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.ReadOnly = true;
            this.dgvIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngredients.Size = new System.Drawing.Size(181, 368);
            this.dgvIngredients.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // frmShowRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 574);
            this.Controls.Add(this.dgvIngredients);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.txbDirections);
            this.Controls.Add(this.lblIngredientLabel);
            this.Controls.Add(this.lblStyles);
            this.Controls.Add(this.lblSeasons);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblRecipeName);
            this.Name = "frmShowRecipe";
            this.Text = "Recipe";
            this.Load += new System.EventHandler(this.frmShowRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblSeasons;
        private System.Windows.Forms.Label lblStyles;
        private System.Windows.Forms.Label lblIngredientLabel;
        private System.Windows.Forms.RichTextBox txbDirections;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}