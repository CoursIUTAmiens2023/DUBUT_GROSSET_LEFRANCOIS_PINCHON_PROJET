namespace ProjetForm
{
    partial class PlateauForm
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
            m_PlateauJeu = new TableLayoutPanel();
            m_LblPlateauTimer = new Label();
            m_BtnPlateauAbandon = new Button();
            m_LblPlateauTour = new Label();
            m_LblPlayerToPlay = new Label();
            m_BtnCol1 = new Button();
            m_BtnCol2 = new Button();
            m_BtnCol3 = new Button();
            m_BtnCol6 = new Button();
            m_BtnCol5 = new Button();
            m_BtnCol4 = new Button();
            m_BtnCol7 = new Button();
            m_GroupBoxWinner = new GroupBox();
            m_BtnWinnerHome = new Button();
            m_BtnWinnerQuitter = new Button();
            m_BtnWinnerPlay = new Button();
            m_LblWinner = new Label();
            m_LblCongrats = new Label();
            m_GroupBoxWinner.SuspendLayout();
            SuspendLayout();
            // 
            // m_PlateauJeu
            // 
            m_PlateauJeu.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            m_PlateauJeu.ColumnCount = 7;
            m_PlateauJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            m_PlateauJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28572F));
            m_PlateauJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28572F));
            m_PlateauJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28572F));
            m_PlateauJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.83812F));
            m_PlateauJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.3603134F));
            m_PlateauJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.02439F));
            m_PlateauJeu.Location = new Point(490, 129);
            m_PlateauJeu.Margin = new Padding(4);
            m_PlateauJeu.Name = "m_PlateauJeu";
            m_PlateauJeu.RowCount = 6;
            m_PlateauJeu.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            m_PlateauJeu.RowStyles.Add(new RowStyle(SizeType.Percent, 16.3690472F));
            m_PlateauJeu.RowStyles.Add(new RowStyle(SizeType.Percent, 16.3690472F));
            m_PlateauJeu.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            m_PlateauJeu.RowStyles.Add(new RowStyle(SizeType.Percent, 16.9642849F));
            m_PlateauJeu.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            m_PlateauJeu.Size = new Size(385, 338);
            m_PlateauJeu.TabIndex = 3;
            // 
            // m_LblPlateauTimer
            // 
            m_LblPlateauTimer.AutoSize = true;
            m_LblPlateauTimer.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            m_LblPlateauTimer.ForeColor = Color.White;
            m_LblPlateauTimer.Location = new Point(8, 10);
            m_LblPlateauTimer.Margin = new Padding(4, 0, 4, 0);
            m_LblPlateauTimer.Name = "m_LblPlateauTimer";
            m_LblPlateauTimer.Size = new Size(281, 25);
            m_LblPlateauTimer.TabIndex = 4;
            m_LblPlateauTimer.Text = "Temps écoulé : 0 secondes";
            // 
            // m_BtnPlateauAbandon
            // 
            m_BtnPlateauAbandon.AutoSize = true;
            m_BtnPlateauAbandon.BackColor = Color.Transparent;
            m_BtnPlateauAbandon.Cursor = Cursors.Hand;
            m_BtnPlateauAbandon.FlatAppearance.BorderColor = Color.FromArgb(203, 44, 69);
            m_BtnPlateauAbandon.FlatStyle = FlatStyle.Flat;
            m_BtnPlateauAbandon.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            m_BtnPlateauAbandon.ForeColor = Color.FromArgb(203, 44, 69);
            m_BtnPlateauAbandon.ImageAlign = ContentAlignment.MiddleRight;
            m_BtnPlateauAbandon.Location = new Point(14, 487);
            m_BtnPlateauAbandon.Margin = new Padding(4);
            m_BtnPlateauAbandon.Name = "m_BtnPlateauAbandon";
            m_BtnPlateauAbandon.Padding = new Padding(18, 0, 18, 0);
            m_BtnPlateauAbandon.Size = new Size(124, 31);
            m_BtnPlateauAbandon.TabIndex = 6;
            m_BtnPlateauAbandon.Text = "Abandonner";
            m_BtnPlateauAbandon.UseVisualStyleBackColor = false;
            m_BtnPlateauAbandon.Click += btnPlateauAbandon_Click;
            // 
            // m_LblPlateauTour
            // 
            m_LblPlateauTour.AutoSize = true;
            m_LblPlateauTour.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            m_LblPlateauTour.ForeColor = Color.White;
            m_LblPlateauTour.Location = new Point(106, 226);
            m_LblPlateauTour.Margin = new Padding(4, 0, 4, 0);
            m_LblPlateauTour.Name = "m_LblPlateauTour";
            m_LblPlateauTour.Size = new Size(267, 25);
            m_LblPlateauTour.TabIndex = 7;
            m_LblPlateauTour.Text = "C'est à ton tour de jouer ";
            // 
            // m_LblPlayerToPlay
            // 
            m_LblPlayerToPlay.AutoSize = true;
            m_LblPlayerToPlay.Font = new Font("Verdana", 25F, FontStyle.Regular, GraphicsUnit.Point);
            m_LblPlayerToPlay.ForeColor = Color.White;
            m_LblPlayerToPlay.Location = new Point(141, 266);
            m_LblPlayerToPlay.Margin = new Padding(4, 0, 4, 0);
            m_LblPlayerToPlay.Name = "m_LblPlayerToPlay";
            m_LblPlayerToPlay.Size = new Size(190, 41);
            m_LblPlayerToPlay.TabIndex = 9;
            m_LblPlayerToPlay.Text = "JOUEUR 1";
            // 
            // m_BtnCol1
            // 
            m_BtnCol1.BackColor = Color.FromArgb(24, 188, 156);
            m_BtnCol1.FlatAppearance.BorderColor = Color.FromArgb(24, 188, 156);
            m_BtnCol1.FlatAppearance.BorderSize = 0;
            m_BtnCol1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            m_BtnCol1.ForeColor = Color.White;
            m_BtnCol1.Location = new Point(493, 75);
            m_BtnCol1.Margin = new Padding(4);
            m_BtnCol1.Name = "m_BtnCol1";
            m_BtnCol1.Size = new Size(53, 47);
            m_BtnCol1.TabIndex = 10;
            m_BtnCol1.Text = "v";
            m_BtnCol1.UseVisualStyleBackColor = false;
            m_BtnCol1.Click += buttonColonne_Click;
            // 
            // m_BtnCol2
            // 
            m_BtnCol2.BackColor = Color.FromArgb(24, 188, 156);
            m_BtnCol2.FlatAppearance.BorderColor = Color.FromArgb(24, 188, 156);
            m_BtnCol2.FlatAppearance.BorderSize = 0;
            m_BtnCol2.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            m_BtnCol2.ForeColor = Color.White;
            m_BtnCol2.Location = new Point(547, 75);
            m_BtnCol2.Margin = new Padding(4);
            m_BtnCol2.Name = "m_BtnCol2";
            m_BtnCol2.Size = new Size(53, 47);
            m_BtnCol2.TabIndex = 11;
            m_BtnCol2.Text = "v";
            m_BtnCol2.UseVisualStyleBackColor = false;
            m_BtnCol2.Click += buttonColonne_Click;
            // 
            // m_BtnCol3
            // 
            m_BtnCol3.BackColor = Color.FromArgb(24, 188, 156);
            m_BtnCol3.FlatAppearance.BorderColor = Color.FromArgb(24, 188, 156);
            m_BtnCol3.FlatAppearance.BorderSize = 0;
            m_BtnCol3.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            m_BtnCol3.ForeColor = Color.White;
            m_BtnCol3.Location = new Point(602, 75);
            m_BtnCol3.Margin = new Padding(4);
            m_BtnCol3.Name = "m_BtnCol3";
            m_BtnCol3.Size = new Size(53, 47);
            m_BtnCol3.TabIndex = 12;
            m_BtnCol3.Text = "v";
            m_BtnCol3.UseVisualStyleBackColor = false;
            m_BtnCol3.Click += buttonColonne_Click;
            // 
            // m_BtnCol6
            // 
            m_BtnCol6.BackColor = Color.FromArgb(24, 188, 156);
            m_BtnCol6.FlatAppearance.BorderColor = Color.FromArgb(24, 188, 156);
            m_BtnCol6.FlatAppearance.BorderSize = 0;
            m_BtnCol6.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            m_BtnCol6.ForeColor = Color.White;
            m_BtnCol6.Location = new Point(764, 75);
            m_BtnCol6.Margin = new Padding(4);
            m_BtnCol6.Name = "m_BtnCol6";
            m_BtnCol6.Size = new Size(53, 47);
            m_BtnCol6.TabIndex = 15;
            m_BtnCol6.Text = "v";
            m_BtnCol6.UseVisualStyleBackColor = false;
            m_BtnCol6.Click += buttonColonne_Click;
            // 
            // m_BtnCol5
            // 
            m_BtnCol5.BackColor = Color.FromArgb(24, 188, 156);
            m_BtnCol5.FlatAppearance.BorderColor = Color.FromArgb(24, 188, 156);
            m_BtnCol5.FlatAppearance.BorderSize = 0;
            m_BtnCol5.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            m_BtnCol5.ForeColor = Color.White;
            m_BtnCol5.Location = new Point(710, 75);
            m_BtnCol5.Margin = new Padding(4);
            m_BtnCol5.Name = "m_BtnCol5";
            m_BtnCol5.Size = new Size(53, 47);
            m_BtnCol5.TabIndex = 14;
            m_BtnCol5.Text = "v";
            m_BtnCol5.UseVisualStyleBackColor = false;
            m_BtnCol5.Click += buttonColonne_Click;
            // 
            // m_BtnCol4
            // 
            m_BtnCol4.BackColor = Color.FromArgb(24, 188, 156);
            m_BtnCol4.FlatAppearance.BorderColor = Color.FromArgb(24, 188, 156);
            m_BtnCol4.FlatAppearance.BorderSize = 0;
            m_BtnCol4.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            m_BtnCol4.ForeColor = Color.White;
            m_BtnCol4.Location = new Point(655, 75);
            m_BtnCol4.Margin = new Padding(4);
            m_BtnCol4.Name = "m_BtnCol4";
            m_BtnCol4.Size = new Size(53, 47);
            m_BtnCol4.TabIndex = 13;
            m_BtnCol4.Text = "v";
            m_BtnCol4.UseVisualStyleBackColor = false;
            m_BtnCol4.Click += buttonColonne_Click;
            // 
            // m_BtnCol7
            // 
            m_BtnCol7.BackColor = Color.FromArgb(24, 188, 156);
            m_BtnCol7.FlatAppearance.BorderColor = Color.FromArgb(24, 188, 156);
            m_BtnCol7.FlatAppearance.BorderSize = 0;
            m_BtnCol7.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            m_BtnCol7.ForeColor = Color.White;
            m_BtnCol7.Location = new Point(820, 75);
            m_BtnCol7.Margin = new Padding(4);
            m_BtnCol7.Name = "m_BtnCol7";
            m_BtnCol7.Size = new Size(53, 47);
            m_BtnCol7.TabIndex = 16;
            m_BtnCol7.Text = "v";
            m_BtnCol7.UseVisualStyleBackColor = false;
            m_BtnCol7.Click += buttonColonne_Click;
            // 
            // m_GroupBoxWinner
            // 
            m_GroupBoxWinner.BackColor = Color.Transparent;
            m_GroupBoxWinner.Controls.Add(m_BtnWinnerHome);
            m_GroupBoxWinner.Controls.Add(m_BtnWinnerQuitter);
            m_GroupBoxWinner.Controls.Add(m_BtnWinnerPlay);
            m_GroupBoxWinner.Controls.Add(m_LblWinner);
            m_GroupBoxWinner.Controls.Add(m_LblCongrats);
            m_GroupBoxWinner.Font = new Font("Verdana", 1F, FontStyle.Regular, GraphicsUnit.Point);
            m_GroupBoxWinner.Location = new Point(33, 182);
            m_GroupBoxWinner.Margin = new Padding(4);
            m_GroupBoxWinner.Name = "m_GroupBoxWinner";
            m_GroupBoxWinner.Padding = new Padding(4);
            m_GroupBoxWinner.Size = new Size(421, 205);
            m_GroupBoxWinner.TabIndex = 17;
            m_GroupBoxWinner.TabStop = false;
            m_GroupBoxWinner.Visible = false;
            // 
            // m_BtnWinnerHome
            // 
            m_BtnWinnerHome.AutoSize = true;
            m_BtnWinnerHome.BackColor = Color.Transparent;
            m_BtnWinnerHome.Cursor = Cursors.Hand;
            m_BtnWinnerHome.FlatAppearance.BorderColor = Color.White;
            m_BtnWinnerHome.FlatStyle = FlatStyle.Flat;
            m_BtnWinnerHome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            m_BtnWinnerHome.ForeColor = Color.White;
            m_BtnWinnerHome.ImageAlign = ContentAlignment.MiddleRight;
            m_BtnWinnerHome.Location = new Point(221, 109);
            m_BtnWinnerHome.Margin = new Padding(4);
            m_BtnWinnerHome.Name = "m_BtnWinnerHome";
            m_BtnWinnerHome.Padding = new Padding(18, 0, 18, 0);
            m_BtnWinnerHome.Size = new Size(174, 31);
            m_BtnWinnerHome.TabIndex = 19;
            m_BtnWinnerHome.Text = "Menu Principal";
            m_BtnWinnerHome.UseVisualStyleBackColor = false;
            m_BtnWinnerHome.Click += btnWinnerHome_Click;
            // 
            // m_BtnWinnerQuitter
            // 
            m_BtnWinnerQuitter.AutoSize = true;
            m_BtnWinnerQuitter.BackColor = Color.Transparent;
            m_BtnWinnerQuitter.Cursor = Cursors.Hand;
            m_BtnWinnerQuitter.FlatAppearance.BorderColor = Color.FromArgb(203, 44, 69);
            m_BtnWinnerQuitter.FlatStyle = FlatStyle.Flat;
            m_BtnWinnerQuitter.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            m_BtnWinnerQuitter.ForeColor = Color.FromArgb(203, 44, 69);
            m_BtnWinnerQuitter.ImageAlign = ContentAlignment.MiddleRight;
            m_BtnWinnerQuitter.Location = new Point(157, 157);
            m_BtnWinnerQuitter.Margin = new Padding(4);
            m_BtnWinnerQuitter.Name = "m_BtnWinnerQuitter";
            m_BtnWinnerQuitter.Padding = new Padding(18, 0, 18, 0);
            m_BtnWinnerQuitter.Size = new Size(95, 31);
            m_BtnWinnerQuitter.TabIndex = 18;
            m_BtnWinnerQuitter.Text = "Quitter";
            m_BtnWinnerQuitter.UseVisualStyleBackColor = false;
            m_BtnWinnerQuitter.Click += btnWinnerQuitter_Click;
            // 
            // m_BtnWinnerPlay
            // 
            m_BtnWinnerPlay.AutoSize = true;
            m_BtnWinnerPlay.BackColor = Color.FromArgb(24, 188, 156);
            m_BtnWinnerPlay.Cursor = Cursors.Hand;
            m_BtnWinnerPlay.FlatAppearance.BorderSize = 0;
            m_BtnWinnerPlay.FlatStyle = FlatStyle.Flat;
            m_BtnWinnerPlay.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            m_BtnWinnerPlay.ForeColor = Color.White;
            m_BtnWinnerPlay.ImageAlign = ContentAlignment.MiddleRight;
            m_BtnWinnerPlay.Location = new Point(29, 109);
            m_BtnWinnerPlay.Margin = new Padding(4);
            m_BtnWinnerPlay.Name = "m_BtnWinnerPlay";
            m_BtnWinnerPlay.Padding = new Padding(18, 0, 18, 0);
            m_BtnWinnerPlay.Size = new Size(160, 31);
            m_BtnWinnerPlay.TabIndex = 7;
            m_BtnWinnerPlay.Text = "Rejouer";
            m_BtnWinnerPlay.UseVisualStyleBackColor = false;
            m_BtnWinnerPlay.Click += btnWinnerPlay_Click;
            // 
            // m_LblWinner
            // 
            m_LblWinner.Font = new Font("Verdana", 20F, FontStyle.Regular, GraphicsUnit.Point);
            m_LblWinner.ForeColor = Color.White;
            m_LblWinner.Location = new Point(2, 8);
            m_LblWinner.Margin = new Padding(4, 0, 4, 0);
            m_LblWinner.Name = "m_LblWinner";
            m_LblWinner.Size = new Size(416, 38);
            m_LblWinner.TabIndex = 1;
            m_LblWinner.Text = "Le JOUEUR 1 a gagné !";
            m_LblWinner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // m_LblCongrats
            // 
            m_LblCongrats.AutoSize = true;
            m_LblCongrats.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            m_LblCongrats.ForeColor = Color.White;
            m_LblCongrats.Location = new Point(122, 51);
            m_LblCongrats.Margin = new Padding(4, 0, 4, 0);
            m_LblCongrats.Name = "m_LblCongrats";
            m_LblCongrats.Size = new Size(181, 17);
            m_LblCongrats.TabIndex = 0;
            m_LblCongrats.Text = "Bien jouer aux joueurs !";
            // 
            // PlateauForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 27, 39);
            ClientSize = new Size(914, 532);
            Controls.Add(m_GroupBoxWinner);
            Controls.Add(m_BtnCol7);
            Controls.Add(m_BtnCol6);
            Controls.Add(m_BtnCol5);
            Controls.Add(m_BtnCol4);
            Controls.Add(m_BtnCol3);
            Controls.Add(m_BtnCol2);
            Controls.Add(m_BtnCol1);
            Controls.Add(m_LblPlayerToPlay);
            Controls.Add(m_LblPlateauTour);
            Controls.Add(m_BtnPlateauAbandon);
            Controls.Add(m_LblPlateauTimer);
            Controls.Add(m_PlateauJeu);
            Margin = new Padding(4);
            Name = "PlateauForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Puissance 4";
            Load += PlateauForm_Load;
            m_GroupBoxWinner.ResumeLayout(false);
            m_GroupBoxWinner.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel m_PlateauJeu;
        private Label m_LblPlateauTimer;
        private Button m_BtnPlateauAbandon;
        private Label m_LblPlateauTour;
        private Label m_LblPlayerToPlay;
        private Button m_BtnCol1;
        private Button m_BtnCol2;
        private Button m_BtnCol3;
        private Button m_BtnCol6;
        private Button m_BtnCol5;
        private Button m_BtnCol4;
        private Button m_BtnCol7;
        private GroupBox m_GroupBoxWinner;
        private Label m_LblWinner;
        private Label m_LblCongrats;
        private Button m_BtnWinnerPlay;
        private Button m_BtnWinnerQuitter;
        private Button m_BtnWinnerHome;
    }
}