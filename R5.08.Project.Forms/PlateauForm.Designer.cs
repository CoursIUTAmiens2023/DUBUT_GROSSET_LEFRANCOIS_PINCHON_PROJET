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
            plateauJeu = new TableLayoutPanel();
            lblPlateauTimer = new Label();
            btnPlateauAbandon = new Button();
            lblPlateauTour = new Label();
            lblToPlay = new Label();
            lblPlayerToPlay = new Label();
            btnCol1 = new Button();
            btnCol2 = new Button();
            btnCol3 = new Button();
            btnCol6 = new Button();
            btnCol5 = new Button();
            btnCol4 = new Button();
            btnCol7 = new Button();
            groupBoxWinner = new GroupBox();
            btnWinnerHome = new Button();
            btnWinnerQuitter = new Button();
            btnWinnerPlay = new Button();
            lblWinner = new Label();
            lblCongrats = new Label();
            groupBoxWinner.SuspendLayout();
            SuspendLayout();
            // 
            // plateauJeu
            // 
            plateauJeu.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            plateauJeu.ColumnCount = 7;
            plateauJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            plateauJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28572F));
            plateauJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28572F));
            plateauJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28572F));
            plateauJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.71951F));
            plateauJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.63415F));
            plateauJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.02439F));
            plateauJeu.Location = new Point(507, 172);
            plateauJeu.Margin = new Padding(5, 5, 5, 5);
            plateauJeu.Name = "plateauJeu";
            plateauJeu.RowCount = 6;
            plateauJeu.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            plateauJeu.RowStyles.Add(new RowStyle(SizeType.Percent, 15.46392F));
            plateauJeu.RowStyles.Add(new RowStyle(SizeType.Percent, 17.18213F));
            plateauJeu.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            plateauJeu.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            plateauJeu.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            plateauJeu.Size = new Size(440, 451);
            plateauJeu.TabIndex = 3;
            // 
            // lblPlateauTimer
            // 
            lblPlateauTimer.AutoSize = true;
            lblPlateauTimer.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlateauTimer.Location = new Point(9, 13);
            lblPlateauTimer.Margin = new Padding(5, 0, 5, 0);
            lblPlateauTimer.Name = "lblPlateauTimer";
            lblPlateauTimer.Size = new Size(353, 31);
            lblPlateauTimer.TabIndex = 4;
            lblPlateauTimer.Text = "Temps écoulé : 0 secondes";
            // 
            // btnPlateauAbandon
            // 
            btnPlateauAbandon.AutoSize = true;
            btnPlateauAbandon.BackColor = Color.LightCoral;
            btnPlateauAbandon.Cursor = Cursors.Hand;
            btnPlateauAbandon.FlatAppearance.BorderSize = 0;
            btnPlateauAbandon.FlatStyle = FlatStyle.Flat;
            btnPlateauAbandon.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlateauAbandon.ImageAlign = ContentAlignment.MiddleRight;
            btnPlateauAbandon.Location = new Point(16, 649);
            btnPlateauAbandon.Margin = new Padding(5, 5, 5, 5);
            btnPlateauAbandon.Name = "btnPlateauAbandon";
            btnPlateauAbandon.Padding = new Padding(21, 0, 21, 0);
            btnPlateauAbandon.Size = new Size(155, 41);
            btnPlateauAbandon.TabIndex = 6;
            btnPlateauAbandon.Text = "Abandonner";
            btnPlateauAbandon.UseVisualStyleBackColor = false;
            btnPlateauAbandon.Click += btnPlateauAbandon_Click;
            // 
            // lblPlateauTour
            // 
            lblPlateauTour.AutoSize = true;
            lblPlateauTour.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlateauTour.Location = new Point(77, 228);
            lblPlateauTour.Margin = new Padding(5, 0, 5, 0);
            lblPlateauTour.Name = "lblPlateauTour";
            lblPlateauTour.Size = new Size(157, 31);
            lblPlateauTour.TabIndex = 7;
            lblPlateauTour.Text = "Au tour de ";
            // 
            // lblToPlay
            // 
            lblToPlay.AutoSize = true;
            lblToPlay.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblToPlay.Location = new Point(77, 372);
            lblToPlay.Margin = new Padding(5, 0, 5, 0);
            lblToPlay.Name = "lblToPlay";
            lblToPlay.Size = new Size(120, 31);
            lblToPlay.TabIndex = 8;
            lblToPlay.Text = "de jouer";
            // 
            // lblPlayerToPlay
            // 
            lblPlayerToPlay.AutoSize = true;
            lblPlayerToPlay.Font = new Font("Verdana", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayerToPlay.Location = new Point(128, 293);
            lblPlayerToPlay.Margin = new Padding(5, 0, 5, 0);
            lblPlayerToPlay.Name = "lblPlayerToPlay";
            lblPlayerToPlay.Size = new Size(190, 41);
            lblPlayerToPlay.TabIndex = 9;
            lblPlayerToPlay.Text = "JOUEUR 1";
            // 
            // btnCol1
            // 
            btnCol1.Location = new Point(511, 100);
            btnCol1.Margin = new Padding(5, 5, 5, 5);
            btnCol1.Name = "btnCol1";
            btnCol1.Size = new Size(61, 63);
            btnCol1.TabIndex = 10;
            btnCol1.Text = "v";
            btnCol1.UseVisualStyleBackColor = true;
            btnCol1.Click += buttonColonne_Click;
            // 
            // btnCol2
            // 
            btnCol2.Location = new Point(573, 100);
            btnCol2.Margin = new Padding(5, 5, 5, 5);
            btnCol2.Name = "btnCol2";
            btnCol2.Size = new Size(61, 63);
            btnCol2.TabIndex = 11;
            btnCol2.Text = "v";
            btnCol2.UseVisualStyleBackColor = true;
            btnCol2.Click += buttonColonne_Click;
            // 
            // btnCol3
            // 
            btnCol3.Location = new Point(635, 100);
            btnCol3.Margin = new Padding(5, 5, 5, 5);
            btnCol3.Name = "btnCol3";
            btnCol3.Size = new Size(61, 63);
            btnCol3.TabIndex = 12;
            btnCol3.Text = "v";
            btnCol3.UseVisualStyleBackColor = true;
            btnCol3.Click += buttonColonne_Click;
            // 
            // btnCol6
            // 
            btnCol6.Location = new Point(821, 100);
            btnCol6.Margin = new Padding(5, 5, 5, 5);
            btnCol6.Name = "btnCol6";
            btnCol6.Size = new Size(61, 63);
            btnCol6.TabIndex = 15;
            btnCol6.Text = "v";
            btnCol6.UseVisualStyleBackColor = true;
            btnCol6.Click += buttonColonne_Click;
            // 
            // btnCol5
            // 
            btnCol5.Location = new Point(759, 100);
            btnCol5.Margin = new Padding(5, 5, 5, 5);
            btnCol5.Name = "btnCol5";
            btnCol5.Size = new Size(61, 63);
            btnCol5.TabIndex = 14;
            btnCol5.Text = "v";
            btnCol5.UseVisualStyleBackColor = true;
            btnCol5.Click += buttonColonne_Click;
            // 
            // btnCol4
            // 
            btnCol4.Location = new Point(696, 100);
            btnCol4.Margin = new Padding(5, 5, 5, 5);
            btnCol4.Name = "btnCol4";
            btnCol4.Size = new Size(61, 63);
            btnCol4.TabIndex = 13;
            btnCol4.Text = "v";
            btnCol4.UseVisualStyleBackColor = true;
            btnCol4.Click += buttonColonne_Click;
            // 
            // btnCol7
            // 
            btnCol7.Location = new Point(885, 100);
            btnCol7.Margin = new Padding(5, 5, 5, 5);
            btnCol7.Name = "btnCol7";
            btnCol7.Size = new Size(61, 63);
            btnCol7.TabIndex = 16;
            btnCol7.Text = "v";
            btnCol7.UseVisualStyleBackColor = true;
            btnCol7.Click += buttonColonne_Click;
            // 
            // groupBoxWinner
            // 
            groupBoxWinner.BackColor = Color.Transparent;
            groupBoxWinner.Controls.Add(btnWinnerHome);
            groupBoxWinner.Controls.Add(btnWinnerQuitter);
            groupBoxWinner.Controls.Add(btnWinnerPlay);
            groupBoxWinner.Controls.Add(lblWinner);
            groupBoxWinner.Controls.Add(lblCongrats);
            groupBoxWinner.Font = new Font("Verdana", 1F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxWinner.Location = new Point(16, 205);
            groupBoxWinner.Margin = new Padding(5, 5, 5, 5);
            groupBoxWinner.Name = "groupBoxWinner";
            groupBoxWinner.Padding = new Padding(5, 5, 5, 5);
            groupBoxWinner.Size = new Size(481, 299);
            groupBoxWinner.TabIndex = 17;
            groupBoxWinner.TabStop = false;
            groupBoxWinner.Visible = false;
            // 
            // btnWinnerHome
            // 
            btnWinnerHome.AutoSize = true;
            btnWinnerHome.BackColor = Color.LightGray;
            btnWinnerHome.Cursor = Cursors.Hand;
            btnWinnerHome.FlatAppearance.BorderSize = 0;
            btnWinnerHome.FlatStyle = FlatStyle.Flat;
            btnWinnerHome.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnWinnerHome.ImageAlign = ContentAlignment.MiddleRight;
            btnWinnerHome.Location = new Point(143, 145);
            btnWinnerHome.Margin = new Padding(5, 5, 5, 5);
            btnWinnerHome.Name = "btnWinnerHome";
            btnWinnerHome.Padding = new Padding(21, 0, 21, 0);
            btnWinnerHome.Size = new Size(158, 41);
            btnWinnerHome.TabIndex = 19;
            btnWinnerHome.Text = "Menu Principal";
            btnWinnerHome.UseVisualStyleBackColor = false;
            btnWinnerHome.Click += btnWinnerHome_Click;
            // 
            // btnWinnerQuitter
            // 
            btnWinnerQuitter.AutoSize = true;
            btnWinnerQuitter.BackColor = Color.LightCoral;
            btnWinnerQuitter.Cursor = Cursors.Hand;
            btnWinnerQuitter.FlatAppearance.BorderSize = 0;
            btnWinnerQuitter.FlatStyle = FlatStyle.Flat;
            btnWinnerQuitter.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnWinnerQuitter.ImageAlign = ContentAlignment.MiddleRight;
            btnWinnerQuitter.Location = new Point(311, 145);
            btnWinnerQuitter.Margin = new Padding(5, 5, 5, 5);
            btnWinnerQuitter.Name = "btnWinnerQuitter";
            btnWinnerQuitter.Padding = new Padding(21, 0, 21, 0);
            btnWinnerQuitter.Size = new Size(155, 41);
            btnWinnerQuitter.TabIndex = 18;
            btnWinnerQuitter.Text = "Quitter";
            btnWinnerQuitter.UseVisualStyleBackColor = false;
            btnWinnerQuitter.Click += btnWinnerQuitter_Click;
            // 
            // btnWinnerPlay
            // 
            btnWinnerPlay.AutoSize = true;
            btnWinnerPlay.BackColor = Color.LightGreen;
            btnWinnerPlay.Cursor = Cursors.Hand;
            btnWinnerPlay.FlatAppearance.BorderSize = 0;
            btnWinnerPlay.FlatStyle = FlatStyle.Flat;
            btnWinnerPlay.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnWinnerPlay.ImageAlign = ContentAlignment.MiddleRight;
            btnWinnerPlay.Location = new Point(10, 145);
            btnWinnerPlay.Margin = new Padding(5, 5, 5, 5);
            btnWinnerPlay.Name = "btnWinnerPlay";
            btnWinnerPlay.Padding = new Padding(21, 0, 21, 0);
            btnWinnerPlay.Size = new Size(124, 41);
            btnWinnerPlay.TabIndex = 7;
            btnWinnerPlay.Text = "Rejouer";
            btnWinnerPlay.UseVisualStyleBackColor = false;
            btnWinnerPlay.Click += btnWinnerPlay_Click;
            // 
            // lblWinner
            // 
            lblWinner.Font = new Font("Verdana", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblWinner.Location = new Point(2, 11);
            lblWinner.Margin = new Padding(5, 0, 5, 0);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(476, 51);
            lblWinner.TabIndex = 1;
            lblWinner.Text = "Le JOUEUR 1 a gagné !";
            lblWinner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCongrats
            // 
            lblCongrats.AutoSize = true;
            lblCongrats.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCongrats.Location = new Point(140, 68);
            lblCongrats.Margin = new Padding(5, 0, 5, 0);
            lblCongrats.Name = "lblCongrats";
            lblCongrats.Size = new Size(217, 20);
            lblCongrats.TabIndex = 0;
            lblCongrats.Text = "Bien jouer aux joueurs !";
            // 
            // PlateauForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 709);
            Controls.Add(groupBoxWinner);
            Controls.Add(btnCol7);
            Controls.Add(btnCol6);
            Controls.Add(btnCol5);
            Controls.Add(btnCol4);
            Controls.Add(btnCol3);
            Controls.Add(btnCol2);
            Controls.Add(btnCol1);
            Controls.Add(lblPlayerToPlay);
            Controls.Add(lblToPlay);
            Controls.Add(lblPlateauTour);
            Controls.Add(btnPlateauAbandon);
            Controls.Add(lblPlateauTimer);
            Controls.Add(plateauJeu);
            Margin = new Padding(5, 5, 5, 5);
            Name = "PlateauForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Puissance 4";
            Load += PlateauForm_Load;
            groupBoxWinner.ResumeLayout(false);
            groupBoxWinner.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel plateauJeu;
        private Label lblPlateauTimer;
        private Button btnPlateauAbandon;
        private Label lblPlateauTour;
        private Label lblToPlay;
        private Label lblPlayerToPlay;
        private Button btnCol1;
        private Button btnCol2;
        private Button btnCol3;
        private Button btnCol6;
        private Button btnCol5;
        private Button btnCol4;
        private Button btnCol7;
        private GroupBox groupBoxWinner;
        private Label lblWinner;
        private Label lblCongrats;
        private Button btnWinnerPlay;
        private Button btnWinnerQuitter;
        private Button btnWinnerHome;
    }
}