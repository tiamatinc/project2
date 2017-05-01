namespace WindowsFormsApplication1
{
    partial class frmViewRecipe
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
            this.labelIngredients = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listViewInstructions = new System.Windows.Forms.ListView();
            this.btnNewSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.listViewIngredients = new System.Windows.Forms.ListView();
            this.listViewRecipeName = new System.Windows.Forms.ListView();
            this.labelRecipe = new System.Windows.Forms.Label();
            this.listBoxStyle = new System.Windows.Forms.ListBox();
            this.listBoxSeason = new System.Windows.Forms.ListBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Location = new System.Drawing.Point(422, 147);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(156, 32);
            this.labelIngredients.TabIndex = 6;
            this.labelIngredients.Text = "Ingredients";
            this.labelIngredients.Click += new System.EventHandler(this.label2_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(0, 0);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listViewInstructions
            // 
            this.listViewInstructions.Location = new System.Drawing.Point(715, 193);
            this.listViewInstructions.Name = "listViewInstructions";
            this.listViewInstructions.Size = new System.Drawing.Size(640, 567);
            this.listViewInstructions.TabIndex = 12;
            this.listViewInstructions.UseCompatibleStateImageBehavior = false;
            // 
            // btnNewSearch
            // 
            this.btnNewSearch.Location = new System.Drawing.Point(539, 806);
            this.btnNewSearch.Name = "btnNewSearch";
            this.btnNewSearch.Size = new System.Drawing.Size(255, 117);
            this.btnNewSearch.TabIndex = 13;
            this.btnNewSearch.Text = "New Search";
            this.btnNewSearch.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1230, 901);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tiamat Inc.";
            // 
            // btnFavorite
            // 
            this.btnFavorite.Location = new System.Drawing.Point(839, 806);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(255, 117);
            this.btnFavorite.TabIndex = 15;
            this.btnFavorite.Text = "Favorite";
            this.btnFavorite.UseVisualStyleBackColor = true;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(970, 147);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(146, 32);
            this.labelInstructions.TabIndex = 16;
            this.labelInstructions.Text = "Intructions";
            // 
            // listViewIngredients
            // 
            this.listViewIngredients.Location = new System.Drawing.Point(347, 193);
            this.listViewIngredients.Name = "listViewIngredients";
            this.listViewIngredients.Size = new System.Drawing.Size(310, 567);
            this.listViewIngredients.TabIndex = 17;
            this.listViewIngredients.UseCompatibleStateImageBehavior = false;
            // 
            // listViewRecipeName
            // 
            this.listViewRecipeName.Location = new System.Drawing.Point(197, 53);
            this.listViewRecipeName.Name = "listViewRecipeName";
            this.listViewRecipeName.Size = new System.Drawing.Size(1005, 52);
            this.listViewRecipeName.TabIndex = 20;
            this.listViewRecipeName.UseCompatibleStateImageBehavior = false;
            // 
            // labelRecipe
            // 
            this.labelRecipe.AutoSize = true;
            this.labelRecipe.Location = new System.Drawing.Point(642, 9);
            this.labelRecipe.Name = "labelRecipe";
            this.labelRecipe.Size = new System.Drawing.Size(104, 32);
            this.labelRecipe.TabIndex = 21;
            this.labelRecipe.Text = "Recipe";
            // 
            // listBoxStyle
            // 
            this.listBoxStyle.FormattingEnabled = true;
            this.listBoxStyle.ItemHeight = 31;
            this.listBoxStyle.Location = new System.Drawing.Point(35, 463);
            this.listBoxStyle.Name = "listBoxStyle";
            this.listBoxStyle.Size = new System.Drawing.Size(236, 190);
            this.listBoxStyle.TabIndex = 27;
            // 
            // listBoxSeason
            // 
            this.listBoxSeason.FormattingEnabled = true;
            this.listBoxSeason.ItemHeight = 31;
            this.listBoxSeason.Location = new System.Drawing.Point(41, 732);
            this.listBoxSeason.Name = "listBoxSeason";
            this.listBoxSeason.Size = new System.Drawing.Size(236, 190);
            this.listBoxSeason.TabIndex = 26;
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 31;
            this.listBoxCategory.Location = new System.Drawing.Point(35, 190);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(236, 190);
            this.listBoxCategory.TabIndex = 25;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(75, 136);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(130, 32);
            this.labelCategory.TabIndex = 24;
            this.labelCategory.Text = "Category";
            this.labelCategory.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Style";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 678);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Season";
            // 
            // frmViewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 935);
            this.Controls.Add(this.listBoxStyle);
            this.Controls.Add(this.listBoxSeason);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRecipe);
            this.Controls.Add(this.listViewRecipeName);
            this.Controls.Add(this.listViewIngredients);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNewSearch);
            this.Controls.Add(this.listViewInstructions);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelIngredients);
            this.Name = "frmViewRecipe";
            this.Text = "frmViewRecipe";
            this.Load += new System.EventHandler(this.frmViewRecipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listViewInstructions;
        private System.Windows.Forms.Button btnNewSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.ListView listViewIngredients;
        private System.Windows.Forms.ListView listViewRecipeName;
        private System.Windows.Forms.Label labelRecipe;
        private System.Windows.Forms.ListBox listBoxStyle;
        private System.Windows.Forms.ListBox listBoxSeason;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}