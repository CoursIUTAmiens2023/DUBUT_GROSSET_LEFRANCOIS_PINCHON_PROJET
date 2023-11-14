namespace ProjetForm
{
    partial class HomeForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="p_Disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool p_Disposing)
        {
            if (p_Disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(p_Disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHomeTitle = new System.Windows.Forms.Label();
            this.btnHomePlay = new System.Windows.Forms.Button();
            this.btnHomeScores = new System.Windows.Forms.Button();
            this.btnHomeQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.AutoSize = true;
            this.lblHomeTitle.Font = new System.Drawing.Font("Verdana", 30F);
            this.lblHomeTitle.Location = new System.Drawing.Point(264, 84);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(256, 48);
            this.lblHomeTitle.TabIndex = 0;
            this.lblHomeTitle.Text = "Puissance 4";
            // 
            // btnHomePlay
            // 
            this.btnHomePlay.AutoSize = true;
            this.btnHomePlay.BackColor = System.Drawing.Color.LightGreen;
            this.btnHomePlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomePlay.FlatAppearance.BorderSize = 0;
            this.btnHomePlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePlay.Font = new System.Drawing.Font("Verdana", 20F);
            this.btnHomePlay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHomePlay.Location = new System.Drawing.Point(264, 214);
            this.btnHomePlay.Name = "btnHomePlay";
            this.btnHomePlay.Padding = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.btnHomePlay.Size = new System.Drawing.Size(257, 42);
            this.btnHomePlay.TabIndex = 1;
            this.btnHomePlay.Text = "Jouer";
            this.btnHomePlay.UseVisualStyleBackColor = false;
            this.btnHomePlay.Click += new System.EventHandler(this.btnHomePlay_Click);
            // 
            // btnHomeScores
            // 
            this.btnHomeScores.AutoSize = true;
            this.btnHomeScores.BackColor = System.Drawing.Color.LightGray;
            this.btnHomeScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomeScores.FlatAppearance.BorderSize = 0;
            this.btnHomeScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeScores.Font = new System.Drawing.Font("Verdana", 15F);
            this.btnHomeScores.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHomeScores.Location = new System.Drawing.Point(285, 262);
            this.btnHomeScores.Name = "btnHomeScores";
            this.btnHomeScores.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.btnHomeScores.Size = new System.Drawing.Size(214, 42);
            this.btnHomeScores.TabIndex = 2;
            this.btnHomeScores.Text = "Scores";
            this.btnHomeScores.UseVisualStyleBackColor = false;
            this.btnHomeScores.Click += new System.EventHandler(this.btnHomeScores_Click);
            // 
            // btnHomeQuit
            // 
            this.btnHomeQuit.AutoSize = true;
            this.btnHomeQuit.BackColor = System.Drawing.Color.LightCoral;
            this.btnHomeQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomeQuit.FlatAppearance.BorderSize = 0;
            this.btnHomeQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeQuit.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnHomeQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHomeQuit.Location = new System.Drawing.Point(12, 422);
            this.btnHomeQuit.Name = "btnHomeQuit";
            this.btnHomeQuit.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnHomeQuit.Size = new System.Drawing.Size(127, 27);
            this.btnHomeQuit.TabIndex = 3;
            this.btnHomeQuit.Text = "Quitter";
            this.btnHomeQuit.UseVisualStyleBackColor = false;
            this.btnHomeQuit.Click += new System.EventHandler(this.btnHomeQuit_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnHomeQuit);
            this.Controls.Add(this.btnHomeScores);
            this.Controls.Add(this.btnHomePlay);
            this.Controls.Add(this.lblHomeTitle);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puissance 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.Button btnHomePlay;
        private System.Windows.Forms.Button btnHomeScores;
        private System.Windows.Forms.Button btnHomeQuit;
    }
}

