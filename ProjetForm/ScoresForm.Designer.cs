namespace ProjetForm
{
    partial class ScoresForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="p_Disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool p_Disposing)
        {
            if (p_Disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(p_Disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHomeTitle = new System.Windows.Forms.Label();
            this.btnGameModeBack = new System.Windows.Forms.Button();
            this.scoresGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.scoresGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.AutoSize = true;
            this.lblHomeTitle.Font = new System.Drawing.Font("Verdana", 30F);
            this.lblHomeTitle.Location = new System.Drawing.Point(315, 50);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(154, 48);
            this.lblHomeTitle.TabIndex = 1;
            this.lblHomeTitle.Text = "Scores";
            // 
            // btnGameModeBack
            // 
            this.btnGameModeBack.AutoSize = true;
            this.btnGameModeBack.BackColor = System.Drawing.Color.LightCoral;
            this.btnGameModeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGameModeBack.FlatAppearance.BorderSize = 0;
            this.btnGameModeBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameModeBack.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnGameModeBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGameModeBack.Location = new System.Drawing.Point(645, 12);
            this.btnGameModeBack.Name = "btnGameModeBack";
            this.btnGameModeBack.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnGameModeBack.Size = new System.Drawing.Size(127, 27);
            this.btnGameModeBack.TabIndex = 6;
            this.btnGameModeBack.Text = "Retour";
            this.btnGameModeBack.UseVisualStyleBackColor = false;
            this.btnGameModeBack.Click += new System.EventHandler(this.btnGameModeBack_Click);
            // 
            // scoresGridView
            // 
            this.scoresGridView.AllowUserToAddRows = false;
            this.scoresGridView.AllowUserToDeleteRows = false;
            this.scoresGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoresGridView.Location = new System.Drawing.Point(32, 120);
            this.scoresGridView.Name = "scoresGridView";
            this.scoresGridView.ReadOnly = true;
            this.scoresGridView.Size = new System.Drawing.Size(720, 307);
            this.scoresGridView.TabIndex = 7;
            // 
            // ScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.scoresGridView);
            this.Controls.Add(this.btnGameModeBack);
            this.Controls.Add(this.lblHomeTitle);
            this.Name = "ScoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puissance 4";
            ((System.ComponentModel.ISupportInitialize)(this.scoresGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.Button btnGameModeBack;
        private System.Windows.Forms.DataGridView scoresGridView;
    }
}