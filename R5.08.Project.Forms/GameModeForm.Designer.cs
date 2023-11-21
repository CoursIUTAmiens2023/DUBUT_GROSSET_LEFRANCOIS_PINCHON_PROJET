namespace ProjetForm
{
    partial class GameModeForm
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
            this.components = new System.ComponentModel.Container();
            this.lblGameModeTitle = new System.Windows.Forms.Label();
            this.radioButtonPlayerVSPlayer = new System.Windows.Forms.RadioButton();
            this.radioButtonPlayerVSAi = new System.Windows.Forms.RadioButton();
            this.btnGameModeBack = new System.Windows.Forms.Button();
            this.lblJoueurInput1 = new System.Windows.Forms.Label();
            this.lblJoueurInput2 = new System.Windows.Forms.Label();
            this.inputPseudoPlayer1 = new System.Windows.Forms.TextBox();
            this.inputPseudoPlayer2 = new System.Windows.Forms.TextBox();
            this.groupBoxGameModePlayerVSPlayerInput1 = new System.Windows.Forms.GroupBox();
            this.lblJoueurInput = new System.Windows.Forms.Label();
            this.lblNiveauIA = new System.Windows.Forms.Label();
            this.inputPseudoPlayer = new System.Windows.Forms.TextBox();
            this.groupBoxGameModePlayerVSPlayerInput2 = new System.Windows.Forms.GroupBox();
            this.radioButtonModeHard = new System.Windows.Forms.RadioButton();
            this.radioButtonModeNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonModeEasy = new System.Windows.Forms.RadioButton();
            this.btnGameModePlay = new System.Windows.Forms.Button();
            this.errorProviderInputPseudoPlayer1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderInputPseudoPlayer2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderInputPseudoPlayer = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxGameModePlayerVSPlayerInput1.SuspendLayout();
            this.groupBoxGameModePlayerVSPlayerInput2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInputPseudoPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInputPseudoPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInputPseudoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameModeTitle
            // 
            this.lblGameModeTitle.AutoSize = true;
            this.lblGameModeTitle.Font = new System.Drawing.Font("Verdana", 30F);
            this.lblGameModeTitle.Location = new System.Drawing.Point(345, 62);
            this.lblGameModeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameModeTitle.Name = "lblGameModeTitle";
            this.lblGameModeTitle.Size = new System.Drawing.Size(334, 60);
            this.lblGameModeTitle.TabIndex = 1;
            this.lblGameModeTitle.Text = "Mode de jeu";
            // 
            // radioButtonPlayerVSPlayer
            // 
            this.radioButtonPlayerVSPlayer.AutoSize = true;
            this.radioButtonPlayerVSPlayer.Checked = true;
            this.radioButtonPlayerVSPlayer.Font = new System.Drawing.Font("Verdana", 18F);
            this.radioButtonPlayerVSPlayer.Location = new System.Drawing.Point(55, 222);
            this.radioButtonPlayerVSPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPlayerVSPlayer.Name = "radioButtonPlayerVSPlayer";
            this.radioButtonPlayerVSPlayer.Size = new System.Drawing.Size(302, 40);
            this.radioButtonPlayerVSPlayer.TabIndex = 2;
            this.radioButtonPlayerVSPlayer.TabStop = true;
            this.radioButtonPlayerVSPlayer.Text = "Joueur VS Joueur";
            this.radioButtonPlayerVSPlayer.UseVisualStyleBackColor = true;
            this.radioButtonPlayerVSPlayer.CheckedChanged += new System.EventHandler(this.radioButtonPlayerVsPlayer_CheckedChanged);
            // 
            // radioButtonPlayerVSAi
            // 
            this.radioButtonPlayerVSAi.AutoSize = true;
            this.radioButtonPlayerVSAi.Font = new System.Drawing.Font("Verdana", 18F);
            this.radioButtonPlayerVSAi.Location = new System.Drawing.Point(55, 318);
            this.radioButtonPlayerVSAi.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPlayerVSAi.Name = "radioButtonPlayerVSAi";
            this.radioButtonPlayerVSAi.Size = new System.Drawing.Size(235, 40);
            this.radioButtonPlayerVSAi.TabIndex = 3;
            this.radioButtonPlayerVSAi.Text = "Joueur VS IA";
            this.radioButtonPlayerVSAi.UseVisualStyleBackColor = true;
            this.radioButtonPlayerVSAi.CheckedChanged += new System.EventHandler(this.radioButtonPlayerVsIA_CheckedChanged);
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
            this.btnGameModeBack.Location = new System.Drawing.Point(860, 15);
            this.btnGameModeBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnGameModeBack.Name = "btnGameModeBack";
            this.btnGameModeBack.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.btnGameModeBack.Size = new System.Drawing.Size(169, 33);
            this.btnGameModeBack.TabIndex = 5;
            this.btnGameModeBack.Text = "Retour";
            this.btnGameModeBack.UseVisualStyleBackColor = false;
            this.btnGameModeBack.Click += new System.EventHandler(this.btnGameModeBack_Click);
            // 
            // lblJoueurInput1
            // 
            this.lblJoueurInput1.AutoSize = true;
            this.lblJoueurInput1.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblJoueurInput1.Location = new System.Drawing.Point(25, 68);
            this.lblJoueurInput1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJoueurInput1.Name = "lblJoueurInput1";
            this.lblJoueurInput1.Size = new System.Drawing.Size(192, 25);
            this.lblJoueurInput1.TabIndex = 0;
            this.lblJoueurInput1.Text = "Pseudo joueur 1 :";
            // 
            // lblJoueurInput2
            // 
            this.lblJoueurInput2.AutoSize = true;
            this.lblJoueurInput2.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblJoueurInput2.Location = new System.Drawing.Point(25, 134);
            this.lblJoueurInput2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJoueurInput2.Name = "lblJoueurInput2";
            this.lblJoueurInput2.Size = new System.Drawing.Size(192, 25);
            this.lblJoueurInput2.TabIndex = 1;
            this.lblJoueurInput2.Text = "Pseudo joueur 2 :";
            // 
            // inputPseudoPlayer1
            // 
            this.inputPseudoPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPseudoPlayer1.Font = new System.Drawing.Font("Verdana", 13F);
            this.inputPseudoPlayer1.Location = new System.Drawing.Point(239, 63);
            this.inputPseudoPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.inputPseudoPlayer1.Name = "inputPseudoPlayer1";
            this.inputPseudoPlayer1.Size = new System.Drawing.Size(234, 34);
            this.inputPseudoPlayer1.TabIndex = 2;
            this.inputPseudoPlayer1.Text = "Joueur 1";
            this.inputPseudoPlayer1.Enter += new System.EventHandler(this.inputPseudoPlayer1_Enter);
            // 
            // inputPseudoPlayer2
            // 
            this.inputPseudoPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPseudoPlayer2.Font = new System.Drawing.Font("Verdana", 13F);
            this.inputPseudoPlayer2.Location = new System.Drawing.Point(239, 129);
            this.inputPseudoPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.inputPseudoPlayer2.Name = "inputPseudoPlayer2";
            this.inputPseudoPlayer2.Size = new System.Drawing.Size(234, 34);
            this.inputPseudoPlayer2.TabIndex = 3;
            this.inputPseudoPlayer2.Text = "Joueur 2";
            this.inputPseudoPlayer2.Enter += new System.EventHandler(this.inputPseudoPlayer2_Enter);
            // 
            // groupBoxGameModePlayerVSPlayerInput1
            // 
            this.groupBoxGameModePlayerVSPlayerInput1.Controls.Add(this.inputPseudoPlayer2);
            this.groupBoxGameModePlayerVSPlayerInput1.Controls.Add(this.inputPseudoPlayer1);
            this.groupBoxGameModePlayerVSPlayerInput1.Controls.Add(this.lblJoueurInput2);
            this.groupBoxGameModePlayerVSPlayerInput1.Controls.Add(this.lblJoueurInput1);
            this.groupBoxGameModePlayerVSPlayerInput1.Font = new System.Drawing.Font("Verdana", 15F);
            this.groupBoxGameModePlayerVSPlayerInput1.Location = new System.Drawing.Point(495, 186);
            this.groupBoxGameModePlayerVSPlayerInput1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxGameModePlayerVSPlayerInput1.Name = "groupBoxGameModePlayerVSPlayerInput1";
            this.groupBoxGameModePlayerVSPlayerInput1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxGameModePlayerVSPlayerInput1.Size = new System.Drawing.Size(499, 206);
            this.groupBoxGameModePlayerVSPlayerInput1.TabIndex = 4;
            this.groupBoxGameModePlayerVSPlayerInput1.TabStop = false;
            this.groupBoxGameModePlayerVSPlayerInput1.Text = "Saisir les informations";
            // 
            // lblJoueurInput
            // 
            this.lblJoueurInput.AutoSize = true;
            this.lblJoueurInput.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblJoueurInput.Location = new System.Drawing.Point(25, 68);
            this.lblJoueurInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJoueurInput.Name = "lblJoueurInput";
            this.lblJoueurInput.Size = new System.Drawing.Size(172, 25);
            this.lblJoueurInput.TabIndex = 0;
            this.lblJoueurInput.Text = "Pseudo joueur :";
            // 
            // lblNiveauIA
            // 
            this.lblNiveauIA.AutoSize = true;
            this.lblNiveauIA.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblNiveauIA.Location = new System.Drawing.Point(25, 134);
            this.lblNiveauIA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNiveauIA.Name = "lblNiveauIA";
            this.lblNiveauIA.Size = new System.Drawing.Size(169, 25);
            this.lblNiveauIA.TabIndex = 1;
            this.lblNiveauIA.Text = "Niveau de l\'IA :";
            // 
            // inputPseudoPlayer
            // 
            this.inputPseudoPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPseudoPlayer.Font = new System.Drawing.Font("Verdana", 13F);
            this.inputPseudoPlayer.Location = new System.Drawing.Point(239, 63);
            this.inputPseudoPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.inputPseudoPlayer.Name = "inputPseudoPlayer";
            this.inputPseudoPlayer.Size = new System.Drawing.Size(234, 34);
            this.inputPseudoPlayer.TabIndex = 2;
            this.inputPseudoPlayer.Text = "Pseudo";
            this.inputPseudoPlayer.Enter += new System.EventHandler(this.inputPseudoPlayer_Enter);
            // 
            // groupBoxGameModePlayerVSPlayerInput2
            // 
            this.groupBoxGameModePlayerVSPlayerInput2.Controls.Add(this.radioButtonModeHard);
            this.groupBoxGameModePlayerVSPlayerInput2.Controls.Add(this.radioButtonModeNormal);
            this.groupBoxGameModePlayerVSPlayerInput2.Controls.Add(this.radioButtonModeEasy);
            this.groupBoxGameModePlayerVSPlayerInput2.Controls.Add(this.inputPseudoPlayer);
            this.groupBoxGameModePlayerVSPlayerInput2.Controls.Add(this.lblNiveauIA);
            this.groupBoxGameModePlayerVSPlayerInput2.Controls.Add(this.lblJoueurInput);
            this.groupBoxGameModePlayerVSPlayerInput2.Font = new System.Drawing.Font("Verdana", 15F);
            this.groupBoxGameModePlayerVSPlayerInput2.Location = new System.Drawing.Point(495, 186);
            this.groupBoxGameModePlayerVSPlayerInput2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxGameModePlayerVSPlayerInput2.Name = "groupBoxGameModePlayerVSPlayerInput2";
            this.groupBoxGameModePlayerVSPlayerInput2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxGameModePlayerVSPlayerInput2.Size = new System.Drawing.Size(499, 234);
            this.groupBoxGameModePlayerVSPlayerInput2.TabIndex = 5;
            this.groupBoxGameModePlayerVSPlayerInput2.TabStop = false;
            this.groupBoxGameModePlayerVSPlayerInput2.Text = "Saisir les informations";
            this.groupBoxGameModePlayerVSPlayerInput2.Visible = false;
            // 
            // radioButtonModeHard
            // 
            this.radioButtonModeHard.AutoSize = true;
            this.radioButtonModeHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonModeHard.Font = new System.Drawing.Font("Verdana", 10F);
            this.radioButtonModeHard.Location = new System.Drawing.Point(379, 175);
            this.radioButtonModeHard.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonModeHard.Name = "radioButtonModeHard";
            this.radioButtonModeHard.Size = new System.Drawing.Size(94, 24);
            this.radioButtonModeHard.TabIndex = 5;
            this.radioButtonModeHard.Text = "Difficile";
            this.radioButtonModeHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonModeNormal
            // 
            this.radioButtonModeNormal.AutoSize = true;
            this.radioButtonModeNormal.Checked = true;
            this.radioButtonModeNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonModeNormal.Font = new System.Drawing.Font("Verdana", 10F);
            this.radioButtonModeNormal.Location = new System.Drawing.Point(203, 175);
            this.radioButtonModeNormal.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonModeNormal.Name = "radioButtonModeNormal";
            this.radioButtonModeNormal.Size = new System.Drawing.Size(92, 24);
            this.radioButtonModeNormal.TabIndex = 4;
            this.radioButtonModeNormal.TabStop = true;
            this.radioButtonModeNormal.Text = "Normal";
            this.radioButtonModeNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonModeEasy
            // 
            this.radioButtonModeEasy.AutoSize = true;
            this.radioButtonModeEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonModeEasy.Font = new System.Drawing.Font("Verdana", 10F);
            this.radioButtonModeEasy.Location = new System.Drawing.Point(29, 175);
            this.radioButtonModeEasy.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonModeEasy.Name = "radioButtonModeEasy";
            this.radioButtonModeEasy.Size = new System.Drawing.Size(78, 24);
            this.radioButtonModeEasy.TabIndex = 3;
            this.radioButtonModeEasy.Text = "Facile";
            this.radioButtonModeEasy.UseVisualStyleBackColor = true;
            // 
            // btnGameModePlay
            // 
            this.btnGameModePlay.AutoSize = true;
            this.btnGameModePlay.BackColor = System.Drawing.Color.LightGreen;
            this.btnGameModePlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGameModePlay.FlatAppearance.BorderSize = 0;
            this.btnGameModePlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameModePlay.Font = new System.Drawing.Font("Verdana", 20F);
            this.btnGameModePlay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGameModePlay.Location = new System.Drawing.Point(245, 481);
            this.btnGameModePlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnGameModePlay.Name = "btnGameModePlay";
            this.btnGameModePlay.Padding = new System.Windows.Forms.Padding(107, 0, 107, 0);
            this.btnGameModePlay.Size = new System.Drawing.Size(556, 52);
            this.btnGameModePlay.TabIndex = 6;
            this.btnGameModePlay.Text = "Lancer la partie !";
            this.btnGameModePlay.UseVisualStyleBackColor = false;
            this.btnGameModePlay.Click += new System.EventHandler(this.btnGameModePlay_Click);
            // 
            // errorProviderInputPseudoPlayer1
            // 
            this.errorProviderInputPseudoPlayer1.ContainerControl = this;
            // 
            // errorProviderInputPseudoPlayer2
            // 
            this.errorProviderInputPseudoPlayer2.ContainerControl = this;
            // 
            // errorProviderInputPseudoPlayer
            // 
            this.errorProviderInputPseudoPlayer.ContainerControl = this;
            // 
            // GameModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.btnGameModePlay);
            this.Controls.Add(this.btnGameModeBack);
            this.Controls.Add(this.groupBoxGameModePlayerVSPlayerInput1);
            this.Controls.Add(this.radioButtonPlayerVSAi);
            this.Controls.Add(this.groupBoxGameModePlayerVSPlayerInput2);
            this.Controls.Add(this.radioButtonPlayerVSPlayer);
            this.Controls.Add(this.lblGameModeTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameModeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puissance 4";
            this.groupBoxGameModePlayerVSPlayerInput1.ResumeLayout(false);
            this.groupBoxGameModePlayerVSPlayerInput1.PerformLayout();
            this.groupBoxGameModePlayerVSPlayerInput2.ResumeLayout(false);
            this.groupBoxGameModePlayerVSPlayerInput2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInputPseudoPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInputPseudoPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInputPseudoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameModeTitle;
        private System.Windows.Forms.RadioButton radioButtonPlayerVSPlayer;
        private System.Windows.Forms.RadioButton radioButtonPlayerVSAi;
        private System.Windows.Forms.Button btnGameModeBack;
        private System.Windows.Forms.Label lblJoueurInput1;
        private System.Windows.Forms.Label lblJoueurInput2;
        private System.Windows.Forms.TextBox inputPseudoPlayer1;
        private System.Windows.Forms.TextBox inputPseudoPlayer2;
        private System.Windows.Forms.GroupBox groupBoxGameModePlayerVSPlayerInput1;
        private System.Windows.Forms.Label lblJoueurInput;
        private System.Windows.Forms.Label lblNiveauIA;
        private System.Windows.Forms.TextBox inputPseudoPlayer;
        private System.Windows.Forms.GroupBox groupBoxGameModePlayerVSPlayerInput2;
        private System.Windows.Forms.RadioButton radioButtonModeHard;
        private System.Windows.Forms.RadioButton radioButtonModeNormal;
        private System.Windows.Forms.RadioButton radioButtonModeEasy;
        private System.Windows.Forms.Button btnGameModePlay;
        private System.Windows.Forms.ErrorProvider errorProviderInputPseudoPlayer1;
        private System.Windows.Forms.ErrorProvider errorProviderInputPseudoPlayer2;
        private System.Windows.Forms.ErrorProvider errorProviderInputPseudoPlayer;
    }
}