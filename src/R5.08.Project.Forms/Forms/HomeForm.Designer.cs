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
            m_LblHomeTitle = new Label();
            m_BtnHomePlay = new Button();
            m_BtnHomeScores = new Button();
            m_BtnHomeQuit = new Button();
            SuspendLayout();
            // 
            // m_LblHomeTitle
            // 
            m_LblHomeTitle.AutoSize = true;
            m_LblHomeTitle.Font = new Font("Verdana", 60F, FontStyle.Regular, GraphicsUnit.Point);
            m_LblHomeTitle.ForeColor = Color.White;
            m_LblHomeTitle.Location = new Point(200, 96);
            m_LblHomeTitle.Margin = new Padding(4, 0, 4, 0);
            m_LblHomeTitle.Name = "m_LblHomeTitle";
            m_LblHomeTitle.Size = new Size(514, 97);
            m_LblHomeTitle.TabIndex = 0;
            m_LblHomeTitle.Text = "Puissance 4";
            // 
            // m_BtnHomePlay
            // 
            m_BtnHomePlay.AutoSize = true;
            m_BtnHomePlay.BackColor = Color.FromArgb(24, 188, 156);
            m_BtnHomePlay.Cursor = Cursors.Hand;
            m_BtnHomePlay.FlatAppearance.BorderSize = 0;
            m_BtnHomePlay.FlatStyle = FlatStyle.Flat;
            m_BtnHomePlay.Font = new Font("Verdana", 20F, FontStyle.Regular, GraphicsUnit.Point);
            m_BtnHomePlay.ForeColor = Color.White;
            m_BtnHomePlay.ImageAlign = ContentAlignment.MiddleRight;
            m_BtnHomePlay.Location = new Point(307, 247);
            m_BtnHomePlay.Margin = new Padding(4, 3, 4, 3);
            m_BtnHomePlay.Name = "m_BtnHomePlay";
            m_BtnHomePlay.Padding = new Padding(93, 0, 93, 0);
            m_BtnHomePlay.Size = new Size(300, 48);
            m_BtnHomePlay.TabIndex = 1;
            m_BtnHomePlay.Text = "Jouer";
            m_BtnHomePlay.UseVisualStyleBackColor = false;
            m_BtnHomePlay.Click += btnHomePlay_Click;
            // 
            // m_BtnHomeScores
            // 
            m_BtnHomeScores.AutoSize = true;
            m_BtnHomeScores.BackColor = Color.Transparent;
            m_BtnHomeScores.Cursor = Cursors.Hand;
            m_BtnHomeScores.FlatAppearance.BorderColor = Color.White;
            m_BtnHomeScores.FlatStyle = FlatStyle.Flat;
            m_BtnHomeScores.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            m_BtnHomeScores.ForeColor = Color.White;
            m_BtnHomeScores.ImageAlign = ContentAlignment.MiddleRight;
            m_BtnHomeScores.Location = new Point(332, 302);
            m_BtnHomeScores.Margin = new Padding(4, 3, 4, 3);
            m_BtnHomeScores.Name = "m_BtnHomeScores";
            m_BtnHomeScores.Padding = new Padding(58, 0, 58, 0);
            m_BtnHomeScores.Size = new Size(250, 48);
            m_BtnHomeScores.TabIndex = 2;
            m_BtnHomeScores.Text = "Scores";
            m_BtnHomeScores.UseVisualStyleBackColor = false;
            m_BtnHomeScores.Click += btnHomeScores_Click;
            // 
            // m_BtnHomeQuit
            // 
            m_BtnHomeQuit.AutoSize = true;
            m_BtnHomeQuit.BackColor = Color.Transparent;
            m_BtnHomeQuit.Cursor = Cursors.Hand;
            m_BtnHomeQuit.FlatAppearance.BorderColor = Color.FromArgb(203, 44, 69);
            m_BtnHomeQuit.FlatStyle = FlatStyle.Flat;
            m_BtnHomeQuit.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            m_BtnHomeQuit.ForeColor = Color.FromArgb(203, 44, 69);
            m_BtnHomeQuit.ImageAlign = ContentAlignment.MiddleRight;
            m_BtnHomeQuit.Location = new Point(14, 487);
            m_BtnHomeQuit.Margin = new Padding(4, 3, 4, 3);
            m_BtnHomeQuit.Name = "m_BtnHomeQuit";
            m_BtnHomeQuit.Padding = new Padding(35, 0, 35, 0);
            m_BtnHomeQuit.Size = new Size(148, 31);
            m_BtnHomeQuit.TabIndex = 3;
            m_BtnHomeQuit.Text = "Quitter";
            m_BtnHomeQuit.UseVisualStyleBackColor = false;
            m_BtnHomeQuit.Click += btnHomeQuit_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 27, 39);
            ClientSize = new Size(915, 532);
            Controls.Add(m_BtnHomeQuit);
            Controls.Add(m_BtnHomeScores);
            Controls.Add(m_BtnHomePlay);
            Controls.Add(m_LblHomeTitle);
            Margin = new Padding(4, 3, 4, 3);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Puissance 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label m_LblHomeTitle;
        public Button m_BtnHomePlay;
        public Button m_BtnHomeScores;
        public Button m_BtnHomeQuit;
    }
}

