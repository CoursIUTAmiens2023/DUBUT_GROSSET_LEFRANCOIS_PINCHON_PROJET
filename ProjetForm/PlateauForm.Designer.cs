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
            this.plateauJeu = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlateauTimer = new System.Windows.Forms.Label();
            this.btnPlateauAbandon = new System.Windows.Forms.Button();
            this.lblPlateauTour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCol1 = new System.Windows.Forms.Button();
            this.btnCol2 = new System.Windows.Forms.Button();
            this.btnCol3 = new System.Windows.Forms.Button();
            this.btnCol6 = new System.Windows.Forms.Button();
            this.btnCol5 = new System.Windows.Forms.Button();
            this.btnCol4 = new System.Windows.Forms.Button();
            this.btnCol7 = new System.Windows.Forms.Button();
            this.groupBoxWinner = new System.Windows.Forms.GroupBox();
            this.btnWinnerHome = new System.Windows.Forms.Button();
            this.btnWinnerQuitter = new System.Windows.Forms.Button();
            this.btnWinnerPlay = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.groupBoxWinner.SuspendLayout();
            this.SuspendLayout();
            // 
            // plateauJeu
            // 
            this.plateauJeu.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.plateauJeu.ColumnCount = 7;
            this.plateauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.plateauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.plateauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.plateauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.plateauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.71951F));
            this.plateauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.63415F));
            this.plateauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.02439F));
            this.plateauJeu.Location = new System.Drawing.Point(381, 112);
            this.plateauJeu.Name = "plateauJeu";
            this.plateauJeu.RowCount = 6;
            this.plateauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.plateauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.46392F));
            this.plateauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.18213F));
            this.plateauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.plateauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.plateauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.plateauJeu.Size = new System.Drawing.Size(330, 293);
            this.plateauJeu.TabIndex = 3;
            // 
            // lblPlateauTimer
            // 
            this.lblPlateauTimer.AutoSize = true;
            this.lblPlateauTimer.Font = new System.Drawing.Font("Verdana", 15F);
            this.lblPlateauTimer.Location = new System.Drawing.Point(7, 9);
            this.lblPlateauTimer.Name = "lblPlateauTimer";
            this.lblPlateauTimer.Size = new System.Drawing.Size(142, 25);
            this.lblPlateauTimer.TabIndex = 4;
            this.lblPlateauTimer.Text = "1 min 30 sec";
            // 
            // btnPlateauAbandon
            // 
            this.btnPlateauAbandon.AutoSize = true;
            this.btnPlateauAbandon.BackColor = System.Drawing.Color.LightCoral;
            this.btnPlateauAbandon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlateauAbandon.FlatAppearance.BorderSize = 0;
            this.btnPlateauAbandon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlateauAbandon.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnPlateauAbandon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlateauAbandon.Location = new System.Drawing.Point(12, 422);
            this.btnPlateauAbandon.Name = "btnPlateauAbandon";
            this.btnPlateauAbandon.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnPlateauAbandon.Size = new System.Drawing.Size(116, 27);
            this.btnPlateauAbandon.TabIndex = 6;
            this.btnPlateauAbandon.Text = "Abandonner";
            this.btnPlateauAbandon.UseVisualStyleBackColor = false;
            this.btnPlateauAbandon.Click += new System.EventHandler(this.btnPlateauAbandon_Click);
            // 
            // lblPlateauTour
            // 
            this.lblPlateauTour.AutoSize = true;
            this.lblPlateauTour.Font = new System.Drawing.Font("Verdana", 15F);
            this.lblPlateauTour.Location = new System.Drawing.Point(58, 148);
            this.lblPlateauTour.Name = "lblPlateauTour";
            this.lblPlateauTour.Size = new System.Drawing.Size(126, 25);
            this.lblPlateauTour.TabIndex = 7;
            this.lblPlateauTour.Text = "Au tour de ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15F);
            this.label1.Location = new System.Drawing.Point(58, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "de jouer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20F);
            this.label2.Location = new System.Drawing.Point(96, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "JOUEUR 1";
            // 
            // btnCol1
            // 
            this.btnCol1.Location = new System.Drawing.Point(383, 65);
            this.btnCol1.Name = "btnCol1";
            this.btnCol1.Size = new System.Drawing.Size(46, 41);
            this.btnCol1.TabIndex = 10;
            this.btnCol1.Text = "v";
            this.btnCol1.UseVisualStyleBackColor = true;
            this.btnCol1.Click += new System.EventHandler(this.buttonColonne_Click);
            // 
            // btnCol2
            // 
            this.btnCol2.Location = new System.Drawing.Point(430, 65);
            this.btnCol2.Name = "btnCol2";
            this.btnCol2.Size = new System.Drawing.Size(46, 41);
            this.btnCol2.TabIndex = 11;
            this.btnCol2.Text = "v";
            this.btnCol2.UseVisualStyleBackColor = true;
            this.btnCol2.Click += new System.EventHandler(this.buttonColonne_Click);
            // 
            // btnCol3
            // 
            this.btnCol3.Location = new System.Drawing.Point(476, 65);
            this.btnCol3.Name = "btnCol3";
            this.btnCol3.Size = new System.Drawing.Size(46, 41);
            this.btnCol3.TabIndex = 12;
            this.btnCol3.Text = "v";
            this.btnCol3.UseVisualStyleBackColor = true;
            this.btnCol3.Click += new System.EventHandler(this.buttonColonne_Click);
            // 
            // btnCol6
            // 
            this.btnCol6.Location = new System.Drawing.Point(615, 65);
            this.btnCol6.Name = "btnCol6";
            this.btnCol6.Size = new System.Drawing.Size(46, 41);
            this.btnCol6.TabIndex = 15;
            this.btnCol6.Text = "v";
            this.btnCol6.UseVisualStyleBackColor = true;
            this.btnCol6.Click += new System.EventHandler(this.buttonColonne_Click);
            // 
            // btnCol5
            // 
            this.btnCol5.Location = new System.Drawing.Point(569, 65);
            this.btnCol5.Name = "btnCol5";
            this.btnCol5.Size = new System.Drawing.Size(46, 41);
            this.btnCol5.TabIndex = 14;
            this.btnCol5.Text = "v";
            this.btnCol5.UseVisualStyleBackColor = true;
            this.btnCol5.Click += new System.EventHandler(this.buttonColonne_Click);
            // 
            // btnCol4
            // 
            this.btnCol4.Location = new System.Drawing.Point(522, 65);
            this.btnCol4.Name = "btnCol4";
            this.btnCol4.Size = new System.Drawing.Size(46, 41);
            this.btnCol4.TabIndex = 13;
            this.btnCol4.Text = "v";
            this.btnCol4.UseVisualStyleBackColor = true;
            this.btnCol4.Click += new System.EventHandler(this.buttonColonne_Click);
            // 
            // btnCol7
            // 
            this.btnCol7.Location = new System.Drawing.Point(663, 65);
            this.btnCol7.Name = "btnCol7";
            this.btnCol7.Size = new System.Drawing.Size(46, 41);
            this.btnCol7.TabIndex = 16;
            this.btnCol7.Text = "v";
            this.btnCol7.UseVisualStyleBackColor = true;
            this.btnCol7.Click += new System.EventHandler(this.buttonColonne_Click);
            // 
            // groupBoxWinner
            // 
            this.groupBoxWinner.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxWinner.Controls.Add(this.btnWinnerHome);
            this.groupBoxWinner.Controls.Add(this.btnWinnerQuitter);
            this.groupBoxWinner.Controls.Add(this.btnWinnerPlay);
            this.groupBoxWinner.Controls.Add(this.lblWinner);
            this.groupBoxWinner.Controls.Add(this.lblCongrats);
            this.groupBoxWinner.Font = new System.Drawing.Font("Verdana", 1F);
            this.groupBoxWinner.Location = new System.Drawing.Point(64, 133);
            this.groupBoxWinner.Name = "groupBoxWinner";
            this.groupBoxWinner.Size = new System.Drawing.Size(656, 194);
            this.groupBoxWinner.TabIndex = 17;
            this.groupBoxWinner.TabStop = false;
            this.groupBoxWinner.Visible = false;
            // 
            // btnWinnerHome
            // 
            this.btnWinnerHome.AutoSize = true;
            this.btnWinnerHome.BackColor = System.Drawing.Color.LightGray;
            this.btnWinnerHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWinnerHome.FlatAppearance.BorderSize = 0;
            this.btnWinnerHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinnerHome.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnWinnerHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWinnerHome.Location = new System.Drawing.Point(264, 140);
            this.btnWinnerHome.Name = "btnWinnerHome";
            this.btnWinnerHome.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnWinnerHome.Size = new System.Drawing.Size(129, 27);
            this.btnWinnerHome.TabIndex = 19;
            this.btnWinnerHome.Text = "Menu Principal";
            this.btnWinnerHome.UseVisualStyleBackColor = false;
            this.btnWinnerHome.Click += new System.EventHandler(this.btnWinnerHome_Click);
            // 
            // btnWinnerQuitter
            // 
            this.btnWinnerQuitter.AutoSize = true;
            this.btnWinnerQuitter.BackColor = System.Drawing.Color.LightCoral;
            this.btnWinnerQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWinnerQuitter.FlatAppearance.BorderSize = 0;
            this.btnWinnerQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinnerQuitter.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnWinnerQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWinnerQuitter.Location = new System.Drawing.Point(417, 140);
            this.btnWinnerQuitter.Name = "btnWinnerQuitter";
            this.btnWinnerQuitter.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnWinnerQuitter.Size = new System.Drawing.Size(116, 27);
            this.btnWinnerQuitter.TabIndex = 18;
            this.btnWinnerQuitter.Text = "Quitter";
            this.btnWinnerQuitter.UseVisualStyleBackColor = false;
            this.btnWinnerQuitter.Click += new System.EventHandler(this.btnWinnerQuitter_Click);
            // 
            // btnWinnerPlay
            // 
            this.btnWinnerPlay.AutoSize = true;
            this.btnWinnerPlay.BackColor = System.Drawing.Color.LightGreen;
            this.btnWinnerPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWinnerPlay.FlatAppearance.BorderSize = 0;
            this.btnWinnerPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinnerPlay.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnWinnerPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWinnerPlay.Location = new System.Drawing.Point(123, 140);
            this.btnWinnerPlay.Name = "btnWinnerPlay";
            this.btnWinnerPlay.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnWinnerPlay.Size = new System.Drawing.Size(116, 27);
            this.btnWinnerPlay.TabIndex = 7;
            this.btnWinnerPlay.Text = "Rejouer";
            this.btnWinnerPlay.UseVisualStyleBackColor = false;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Verdana", 20F);
            this.lblWinner.Location = new System.Drawing.Point(152, 45);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(331, 32);
            this.lblWinner.TabIndex = 1;
            this.lblWinner.Text = "Le JOUEUR 1 a gagné !";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblCongrats.Location = new System.Drawing.Point(227, 97);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(181, 17);
            this.lblCongrats.TabIndex = 0;
            this.lblCongrats.Text = "Bien jouer aux joueurs !";
            // 
            // PlateauForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBoxWinner);
            this.Controls.Add(this.btnCol7);
            this.Controls.Add(this.btnCol6);
            this.Controls.Add(this.btnCol5);
            this.Controls.Add(this.btnCol4);
            this.Controls.Add(this.btnCol3);
            this.Controls.Add(this.btnCol2);
            this.Controls.Add(this.btnCol1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlateauTour);
            this.Controls.Add(this.btnPlateauAbandon);
            this.Controls.Add(this.lblPlateauTimer);
            this.Controls.Add(this.plateauJeu);
            this.Name = "PlateauForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puissance 4";
            this.groupBoxWinner.ResumeLayout(false);
            this.groupBoxWinner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel plateauJeu;
        private System.Windows.Forms.Label lblPlateauTimer;
        private System.Windows.Forms.Button btnPlateauAbandon;
        private System.Windows.Forms.Label lblPlateauTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCol1;
        private System.Windows.Forms.Button btnCol2;
        private System.Windows.Forms.Button btnCol3;
        private System.Windows.Forms.Button btnCol6;
        private System.Windows.Forms.Button btnCol5;
        private System.Windows.Forms.Button btnCol4;
        private System.Windows.Forms.Button btnCol7;
        private System.Windows.Forms.GroupBox groupBoxWinner;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Button btnWinnerPlay;
        private System.Windows.Forms.Button btnWinnerQuitter;
        private System.Windows.Forms.Button btnWinnerHome;
    }
}