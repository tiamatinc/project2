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
            this.btnViewRecipe = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewRecipeResults = new System.Windows.Forms.DataGridView();
            this.labelQueryResults = new System.Windows.Forms.Label();
            this.btnNewSearch = new System.Windows.Forms.Button();
            this.btnFavorites = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipeResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewRecipe
            // 
            this.btnViewRecipe.Location = new System.Drawing.Point(80, 752);
            this.btnViewRecipe.Name = "btnViewRecipe";
            this.btnViewRecipe.Size = new System.Drawing.Size(255, 117);
            this.btnViewRecipe.TabIndex = 15;
            this.btnViewRecipe.Text = "View Recipe";
            this.btnViewRecipe.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(405, 752);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(255, 117);
            this.button5.TabIndex = 16;
            this.button5.Text = "Add Recipe";
            this.button5.UseVisualStyleBackColor = true;
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
            // dataGridViewRecipeResults
            // 
            this.dataGridViewRecipeResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipeResults.Location = new System.Drawing.Point(80, 80);
            this.dataGridViewRecipeResults.Name = "dataGridViewRecipeResults";
            this.dataGridViewRecipeResults.RowTemplate.Height = 40;
            this.dataGridViewRecipeResults.Size = new System.Drawing.Size(1245, 601);
            this.dataGridViewRecipeResults.TabIndex = 20;
            this.dataGridViewRecipeResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecipeResults_CellContentClick);
            // 
            // labelQueryResults
            // 
            this.labelQueryResults.AutoSize = true;
            this.labelQueryResults.Location = new System.Drawing.Point(600, 31);
            this.labelQueryResults.Name = "labelQueryResults";
            this.labelQueryResults.Size = new System.Drawing.Size(194, 32);
            this.labelQueryResults.TabIndex = 21;
            this.labelQueryResults.Text = "Query Results";
            this.labelQueryResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQueryResults.Click += new System.EventHandler(this.labelWelcome_Click);
            // 
            // btnNewSearch
            // 
            this.btnNewSearch.Location = new System.Drawing.Point(1070, 752);
            this.btnNewSearch.Name = "btnNewSearch";
            this.btnNewSearch.Size = new System.Drawing.Size(255, 117);
            this.btnNewSearch.TabIndex = 22;
            this.btnNewSearch.Text = "New Search";
            this.btnNewSearch.UseVisualStyleBackColor = true;
            // 
            // btnFavorites
            // 
            this.btnFavorites.Location = new System.Drawing.Point(743, 752);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(255, 117);
            this.btnFavorites.TabIndex = 23;
            this.btnFavorites.Text = "Favorites";
            this.btnFavorites.UseVisualStyleBackColor = true;
            // 
            // frmResultDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 935);
            this.Controls.Add(this.btnFavorites);
            this.Controls.Add(this.btnNewSearch);
            this.Controls.Add(this.labelQueryResults);
            this.Controls.Add(this.dataGridViewRecipeResults);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnViewRecipe);
            this.Name = "frmResultDisplay";
            this.Text = "frmResultDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipeResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnViewRecipe;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewRecipeResults;
        private System.Windows.Forms.Label labelQueryResults;
        private System.Windows.Forms.Button btnNewSearch;
        private System.Windows.Forms.Button btnFavorites;
    }
}