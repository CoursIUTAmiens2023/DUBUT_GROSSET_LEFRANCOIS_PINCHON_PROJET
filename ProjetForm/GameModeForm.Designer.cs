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
            this.lblGameModeTitle = new System.Windows.Forms.Label();
            this.radioButtonGameMode1 = new System.Windows.Forms.RadioButton();
            this.radioButtonGameMode2 = new System.Windows.Forms.RadioButton();
            this.btnGameModeBack = new System.Windows.Forms.Button();
            this.lblJoueurInput1 = new System.Windows.Forms.Label();
            this.lblJoueurInput2 = new System.Windows.Forms.Label();
            this.inputJoueur1 = new System.Windows.Forms.TextBox();
            this.inputJoueur2 = new System.Windows.Forms.TextBox();
            this.groupBoxGameModeInput1 = new System.Windows.Forms.GroupBox();
            this.lblJoueurInput = new System.Windows.Forms.Label();
            this.lblNiveauIA = new System.Windows.Forms.Label();
            this.inputJoueur = new System.Windows.Forms.TextBox();
            this.groupBoxGameModeInput2 = new System.Windows.Forms.GroupBox();
            this.radioButtonModeHard = new System.Windows.Forms.RadioButton();
            this.radioButtonModeNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonModeEasy = new System.Windows.Forms.RadioButton();
            this.btnGameModePlay = new System.Windows.Forms.Button();
            this.groupBoxGameModeInput1.SuspendLayout();
            this.groupBoxGameModeInput2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGameModeTitle
            // 
            this.lblGameModeTitle.AutoSize = true;
            this.lblGameModeTitle.Font = new System.Drawing.Font("Verdana", 30F);
            this.lblGameModeTitle.Location = new System.Drawing.Point(259, 50);
            this.lblGameModeTitle.Name = "lblGameModeTitle";
            this.lblGameModeTitle.Size = new System.Drawing.Size(267, 48);
            this.lblGameModeTitle.TabIndex = 1;
            this.lblGameModeTitle.Text = "Mode de jeu";
            // 
            // radioButtonGameMode1
            // 
            this.radioButtonGameMode1.AutoSize = true;
            this.radioButtonGameMode1.Checked = true;
            this.radioButtonGameMode1.Font = new System.Drawing.Font("Verdana", 18F);
            this.radioButtonGameMode1.Location = new System.Drawing.Point(41, 180);
            this.radioButtonGameMode1.Name = "radioButtonGameMode1";
            this.radioButtonGameMode1.Size = new System.Drawing.Size(239, 33);
            this.radioButtonGameMode1.TabIndex = 2;
            this.radioButtonGameMode1.TabStop = true;
            this.radioButtonGameMode1.Text = "Joueur VS Joueur";
            this.radioButtonGameMode1.UseVisualStyleBackColor = true;
            this.radioButtonGameMode1.CheckedChanged += new System.EventHandler(this.radioButtonGameMode1_CheckedChanged);
            // 
            // radioButtonGameMode2
            // 
            this.radioButtonGameMode2.AutoSize = true;
            this.radioButtonGameMode2.Font = new System.Drawing.Font("Verdana", 18F);
            this.radioButtonGameMode2.Location = new System.Drawing.Point(41, 258);
            this.radioButtonGameMode2.Name = "radioButtonGameMode2";
            this.radioButtonGameMode2.Size = new System.Drawing.Size(185, 33);
            this.radioButtonGameMode2.TabIndex = 3;
            this.radioButtonGameMode2.Text = "Joueur VS IA";
            this.radioButtonGameMode2.UseVisualStyleBackColor = true;
            this.radioButtonGameMode2.CheckedChanged += new System.EventHandler(this.radioButtonGameMode2_CheckedChanged);
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
            this.btnGameModeBack.TabIndex = 5;
            this.btnGameModeBack.Text = "Retour";
            this.btnGameModeBack.UseVisualStyleBackColor = false;
            this.btnGameModeBack.Click += new System.EventHandler(this.btnGameModeBack_Click);
            // 
            // lblJoueurInput1
            // 
            this.lblJoueurInput1.AutoSize = true;
            this.lblJoueurInput1.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblJoueurInput1.Location = new System.Drawing.Point(19, 55);
            this.lblJoueurInput1.Name = "lblJoueurInput1";
            this.lblJoueurInput1.Size = new System.Drawing.Size(154, 18);
            this.lblJoueurInput1.TabIndex = 0;
            this.lblJoueurInput1.Text = "Pseudo joueur 1 :";
            // 
            // lblJoueurInput2
            // 
            this.lblJoueurInput2.AutoSize = true;
            this.lblJoueurInput2.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblJoueurInput2.Location = new System.Drawing.Point(19, 109);
            this.lblJoueurInput2.Name = "lblJoueurInput2";
            this.lblJoueurInput2.Size = new System.Drawing.Size(154, 18);
            this.lblJoueurInput2.TabIndex = 1;
            this.lblJoueurInput2.Text = "Pseudo joueur 2 :";
            // 
            // inputJoueur1
            // 
            this.inputJoueur1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputJoueur1.Font = new System.Drawing.Font("Verdana", 13F);
            this.inputJoueur1.Location = new System.Drawing.Point(179, 51);
            this.inputJoueur1.Name = "inputJoueur1";
            this.inputJoueur1.Size = new System.Drawing.Size(176, 29);
            this.inputJoueur1.TabIndex = 2;
            this.inputJoueur1.Text = "Joueur 1";
            this.inputJoueur1.Enter += new System.EventHandler(this.inputJoueur1_Enter);
            // 
            // inputJoueur2
            // 
            this.inputJoueur2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputJoueur2.Font = new System.Drawing.Font("Verdana", 13F);
            this.inputJoueur2.Location = new System.Drawing.Point(179, 105);
            this.inputJoueur2.Name = "inputJoueur2";
            this.inputJoueur2.Size = new System.Drawing.Size(176, 29);
            this.inputJoueur2.TabIndex = 3;
            this.inputJoueur2.Text = "Joueur 2";
            this.inputJoueur2.Enter += new System.EventHandler(this.inputJoueur2_Enter);
            // 
            // groupBoxGameModeInput1
            // 
            this.groupBoxGameModeInput1.Controls.Add(this.inputJoueur2);
            this.groupBoxGameModeInput1.Controls.Add(this.inputJoueur1);
            this.groupBoxGameModeInput1.Controls.Add(this.lblJoueurInput2);
            this.groupBoxGameModeInput1.Controls.Add(this.lblJoueurInput1);
            this.groupBoxGameModeInput1.Font = new System.Drawing.Font("Verdana", 15F);
            this.groupBoxGameModeInput1.Location = new System.Drawing.Point(371, 151);
            this.groupBoxGameModeInput1.Name = "groupBoxGameModeInput1";
            this.groupBoxGameModeInput1.Size = new System.Drawing.Size(374, 167);
            this.groupBoxGameModeInput1.TabIndex = 4;
            this.groupBoxGameModeInput1.TabStop = false;
            this.groupBoxGameModeInput1.Text = "Saisir les informations";
            // 
            // lblJoueurInput
            // 
            this.lblJoueurInput.AutoSize = true;
            this.lblJoueurInput.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblJoueurInput.Location = new System.Drawing.Point(19, 55);
            this.lblJoueurInput.Name = "lblJoueurInput";
            this.lblJoueurInput.Size = new System.Drawing.Size(138, 18);
            this.lblJoueurInput.TabIndex = 0;
            this.lblJoueurInput.Text = "Pseudo joueur :";
            // 
            // lblNiveauIA
            // 
            this.lblNiveauIA.AutoSize = true;
            this.lblNiveauIA.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblNiveauIA.Location = new System.Drawing.Point(19, 109);
            this.lblNiveauIA.Name = "lblNiveauIA";
            this.lblNiveauIA.Size = new System.Drawing.Size(136, 18);
            this.lblNiveauIA.TabIndex = 1;
            this.lblNiveauIA.Text = "Niveau de l\'IA :";
            // 
            // inputJoueur
            // 
            this.inputJoueur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputJoueur.Font = new System.Drawing.Font("Verdana", 13F);
            this.inputJoueur.Location = new System.Drawing.Point(179, 51);
            this.inputJoueur.Name = "inputJoueur";
            this.inputJoueur.Size = new System.Drawing.Size(176, 29);
            this.inputJoueur.TabIndex = 2;
            this.inputJoueur.Text = "Pseudo";
            this.inputJoueur.Enter += new System.EventHandler(this.btnJoueurInput_Enter);
            // 
            // groupBoxGameModeInput2
            // 
            this.groupBoxGameModeInput2.Controls.Add(this.radioButtonModeHard);
            this.groupBoxGameModeInput2.Controls.Add(this.radioButtonModeNormal);
            this.groupBoxGameModeInput2.Controls.Add(this.radioButtonModeEasy);
            this.groupBoxGameModeInput2.Controls.Add(this.inputJoueur);
            this.groupBoxGameModeInput2.Controls.Add(this.lblNiveauIA);
            this.groupBoxGameModeInput2.Controls.Add(this.lblJoueurInput);
            this.groupBoxGameModeInput2.Font = new System.Drawing.Font("Verdana", 15F);
            this.groupBoxGameModeInput2.Location = new System.Drawing.Point(371, 151);
            this.groupBoxGameModeInput2.Name = "groupBoxGameModeInput2";
            this.groupBoxGameModeInput2.Size = new System.Drawing.Size(374, 190);
            this.groupBoxGameModeInput2.TabIndex = 5;
            this.groupBoxGameModeInput2.TabStop = false;
            this.groupBoxGameModeInput2.Text = "Saisir les informations";
            this.groupBoxGameModeInput2.Visible = false;
            // 
            // radioButtonModeHard
            // 
            this.radioButtonModeHard.AutoSize = true;
            this.radioButtonModeHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonModeHard.Font = new System.Drawing.Font("Verdana", 10F);
            this.radioButtonModeHard.Location = new System.Drawing.Point(284, 142);
            this.radioButtonModeHard.Name = "radioButtonModeHard";
            this.radioButtonModeHard.Size = new System.Drawing.Size(74, 21);
            this.radioButtonModeHard.TabIndex = 5;
            this.radioButtonModeHard.Text = "Difficile";
            this.radioButtonModeHard.UseVisualStyleBackColor = true;
            this.radioButtonModeHard.CheckedChanged += new System.EventHandler(this.radioButtonModeHard_CheckedChanged);
            // 
            // radioButtonModeNormal
            // 
            this.radioButtonModeNormal.AutoSize = true;
            this.radioButtonModeNormal.Checked = true;
            this.radioButtonModeNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonModeNormal.Font = new System.Drawing.Font("Verdana", 10F);
            this.radioButtonModeNormal.Location = new System.Drawing.Point(152, 142);
            this.radioButtonModeNormal.Name = "radioButtonModeNormal";
            this.radioButtonModeNormal.Size = new System.Drawing.Size(75, 21);
            this.radioButtonModeNormal.TabIndex = 4;
            this.radioButtonModeNormal.TabStop = true;
            this.radioButtonModeNormal.Text = "Normal";
            this.radioButtonModeNormal.UseVisualStyleBackColor = true;
            this.radioButtonModeNormal.CheckedChanged += new System.EventHandler(this.radioButtonModeNormal_CheckedChanged);
            // 
            // radioButtonModeEasy
            // 
            this.radioButtonModeEasy.AutoSize = true;
            this.radioButtonModeEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonModeEasy.Font = new System.Drawing.Font("Verdana", 10F);
            this.radioButtonModeEasy.Location = new System.Drawing.Point(22, 142);
            this.radioButtonModeEasy.Name = "radioButtonModeEasy";
            this.radioButtonModeEasy.Size = new System.Drawing.Size(62, 21);
            this.radioButtonModeEasy.TabIndex = 3;
            this.radioButtonModeEasy.Text = "Facile";
            this.radioButtonModeEasy.UseVisualStyleBackColor = true;
            this.radioButtonModeEasy.CheckedChanged += new System.EventHandler(this.radioButtonModeEasy_CheckedChanged);
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
            this.btnGameModePlay.Location = new System.Drawing.Point(184, 391);
            this.btnGameModePlay.Name = "btnGameModePlay";
            this.btnGameModePlay.Padding = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.btnGameModePlay.Size = new System.Drawing.Size(417, 42);
            this.btnGameModePlay.TabIndex = 6;
            this.btnGameModePlay.Text = "Lancer la partie !";
            this.btnGameModePlay.UseVisualStyleBackColor = false;
            this.btnGameModePlay.Click += new System.EventHandler(this.btnGameModePlay_Click);
            // 
            // GameModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnGameModePlay);
            this.Controls.Add(this.btnGameModeBack);
            this.Controls.Add(this.groupBoxGameModeInput1);
            this.Controls.Add(this.radioButtonGameMode2);
            this.Controls.Add(this.groupBoxGameModeInput2);
            this.Controls.Add(this.radioButtonGameMode1);
            this.Controls.Add(this.lblGameModeTitle);
            this.Name = "GameModeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puissance 4";
            this.groupBoxGameModeInput1.ResumeLayout(false);
            this.groupBoxGameModeInput1.PerformLayout();
            this.groupBoxGameModeInput2.ResumeLayout(false);
            this.groupBoxGameModeInput2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameModeTitle;
        private System.Windows.Forms.RadioButton radioButtonGameMode1;
        private System.Windows.Forms.RadioButton radioButtonGameMode2;
        private System.Windows.Forms.Button btnGameModeBack;
        private System.Windows.Forms.Label lblJoueurInput1;
        private System.Windows.Forms.Label lblJoueurInput2;
        private System.Windows.Forms.TextBox inputJoueur1;
        private System.Windows.Forms.TextBox inputJoueur2;
        private System.Windows.Forms.GroupBox groupBoxGameModeInput1;
        private System.Windows.Forms.Label lblJoueurInput;
        private System.Windows.Forms.Label lblNiveauIA;
        private System.Windows.Forms.TextBox inputJoueur;
        private System.Windows.Forms.GroupBox groupBoxGameModeInput2;
        private System.Windows.Forms.RadioButton radioButtonModeHard;
        private System.Windows.Forms.RadioButton radioButtonModeNormal;
        private System.Windows.Forms.RadioButton radioButtonModeEasy;
        private System.Windows.Forms.Button btnGameModePlay;
    }
}