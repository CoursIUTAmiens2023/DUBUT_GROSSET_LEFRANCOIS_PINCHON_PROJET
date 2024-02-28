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
            components = new System.ComponentModel.Container();
            lblGameModeTitle = new Label();
            radioButtonPlayerVSPlayer = new RadioButton();
            radioButtonPlayerVSAi = new RadioButton();
            btnGameModeBack = new Button();
            lblJoueurInput1 = new Label();
            lblJoueurInput2 = new Label();
            inputPseudoPlayer1 = new TextBox();
            inputPseudoPlayer2 = new TextBox();
            groupBoxGameModePlayerVSPlayerInput1 = new GroupBox();
            lblJoueurInput = new Label();
            lblNiveauIA = new Label();
            inputPseudoPlayer = new TextBox();
            groupBoxGameModePlayerVSPlayerInput2 = new GroupBox();
            checkBoxIaStart = new CheckBox();
            radioButtonModeHard = new RadioButton();
            radioButtonModeNormal = new RadioButton();
            radioButtonModeEasy = new RadioButton();
            btnGameModePlay = new Button();
            errorProviderInputPseudoPlayer1 = new ErrorProvider(components);
            errorProviderInputPseudoPlayer2 = new ErrorProvider(components);
            errorProviderInputPseudoPlayer = new ErrorProvider(components);
            groupBoxGameModePlayerVSPlayerInput1.SuspendLayout();
            groupBoxGameModePlayerVSPlayerInput2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderInputPseudoPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInputPseudoPlayer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInputPseudoPlayer).BeginInit();
            SuspendLayout();
            // 
            // lblGameModeTitle
            // 
            lblGameModeTitle.AutoSize = true;
            lblGameModeTitle.Font = new Font("Verdana", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblGameModeTitle.Location = new Point(345, 78);
            lblGameModeTitle.Margin = new Padding(4, 0, 4, 0);
            lblGameModeTitle.Name = "lblGameModeTitle";
            lblGameModeTitle.Size = new Size(334, 60);
            lblGameModeTitle.TabIndex = 1;
            lblGameModeTitle.Text = "Mode de jeu";
            // 
            // radioButtonPlayerVSPlayer
            // 
            radioButtonPlayerVSPlayer.AutoSize = true;
            radioButtonPlayerVSPlayer.Checked = true;
            radioButtonPlayerVSPlayer.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonPlayerVSPlayer.Location = new Point(55, 278);
            radioButtonPlayerVSPlayer.Margin = new Padding(4, 5, 4, 5);
            radioButtonPlayerVSPlayer.Name = "radioButtonPlayerVSPlayer";
            radioButtonPlayerVSPlayer.Size = new Size(302, 40);
            radioButtonPlayerVSPlayer.TabIndex = 2;
            radioButtonPlayerVSPlayer.TabStop = true;
            radioButtonPlayerVSPlayer.Text = "Joueur VS Joueur";
            radioButtonPlayerVSPlayer.UseVisualStyleBackColor = true;
            radioButtonPlayerVSPlayer.CheckedChanged += radioButtonPlayerVsPlayer_CheckedChanged;
            // 
            // radioButtonPlayerVSAi
            // 
            radioButtonPlayerVSAi.AutoSize = true;
            radioButtonPlayerVSAi.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonPlayerVSAi.Location = new Point(55, 398);
            radioButtonPlayerVSAi.Margin = new Padding(4, 5, 4, 5);
            radioButtonPlayerVSAi.Name = "radioButtonPlayerVSAi";
            radioButtonPlayerVSAi.Size = new Size(235, 40);
            radioButtonPlayerVSAi.TabIndex = 3;
            radioButtonPlayerVSAi.Text = "Joueur VS IA";
            radioButtonPlayerVSAi.UseVisualStyleBackColor = true;
            radioButtonPlayerVSAi.CheckedChanged += radioButtonPlayerVsIA_CheckedChanged;
            // 
            // btnGameModeBack
            // 
            btnGameModeBack.AutoSize = true;
            btnGameModeBack.BackColor = Color.LightCoral;
            btnGameModeBack.Cursor = Cursors.Hand;
            btnGameModeBack.FlatAppearance.BorderSize = 0;
            btnGameModeBack.FlatStyle = FlatStyle.Flat;
            btnGameModeBack.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGameModeBack.ImageAlign = ContentAlignment.MiddleRight;
            btnGameModeBack.Location = new Point(860, 19);
            btnGameModeBack.Margin = new Padding(4, 5, 4, 5);
            btnGameModeBack.Name = "btnGameModeBack";
            btnGameModeBack.Padding = new Padding(40, 0, 40, 0);
            btnGameModeBack.Size = new Size(169, 41);
            btnGameModeBack.TabIndex = 5;
            btnGameModeBack.Text = "Retour";
            btnGameModeBack.UseVisualStyleBackColor = false;
            btnGameModeBack.Click += btnGameModeBack_Click;
            // 
            // lblJoueurInput1
            // 
            lblJoueurInput1.AutoSize = true;
            lblJoueurInput1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblJoueurInput1.Location = new Point(25, 85);
            lblJoueurInput1.Margin = new Padding(4, 0, 4, 0);
            lblJoueurInput1.Name = "lblJoueurInput1";
            lblJoueurInput1.Size = new Size(192, 25);
            lblJoueurInput1.TabIndex = 0;
            lblJoueurInput1.Text = "Pseudo joueur 1 :";
            // 
            // lblJoueurInput2
            // 
            lblJoueurInput2.AutoSize = true;
            lblJoueurInput2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblJoueurInput2.Location = new Point(25, 168);
            lblJoueurInput2.Margin = new Padding(4, 0, 4, 0);
            lblJoueurInput2.Name = "lblJoueurInput2";
            lblJoueurInput2.Size = new Size(192, 25);
            lblJoueurInput2.TabIndex = 1;
            lblJoueurInput2.Text = "Pseudo joueur 2 :";
            // 
            // inputPseudoPlayer1
            // 
            inputPseudoPlayer1.BorderStyle = BorderStyle.FixedSingle;
            inputPseudoPlayer1.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            inputPseudoPlayer1.Location = new Point(239, 79);
            inputPseudoPlayer1.Margin = new Padding(4, 5, 4, 5);
            inputPseudoPlayer1.Name = "inputPseudoPlayer1";
            inputPseudoPlayer1.Size = new Size(234, 34);
            inputPseudoPlayer1.TabIndex = 2;
            inputPseudoPlayer1.Text = "Joueur 1";
            inputPseudoPlayer1.Enter += inputPseudoPlayer1_Enter;
            // 
            // inputPseudoPlayer2
            // 
            inputPseudoPlayer2.BorderStyle = BorderStyle.FixedSingle;
            inputPseudoPlayer2.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            inputPseudoPlayer2.Location = new Point(239, 161);
            inputPseudoPlayer2.Margin = new Padding(4, 5, 4, 5);
            inputPseudoPlayer2.Name = "inputPseudoPlayer2";
            inputPseudoPlayer2.Size = new Size(234, 34);
            inputPseudoPlayer2.TabIndex = 3;
            inputPseudoPlayer2.Text = "Joueur 2";
            inputPseudoPlayer2.Enter += inputPseudoPlayer2_Enter;
            // 
            // groupBoxGameModePlayerVSPlayerInput1
            // 
            groupBoxGameModePlayerVSPlayerInput1.Controls.Add(inputPseudoPlayer2);
            groupBoxGameModePlayerVSPlayerInput1.Controls.Add(inputPseudoPlayer1);
            groupBoxGameModePlayerVSPlayerInput1.Controls.Add(lblJoueurInput2);
            groupBoxGameModePlayerVSPlayerInput1.Controls.Add(lblJoueurInput1);
            groupBoxGameModePlayerVSPlayerInput1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxGameModePlayerVSPlayerInput1.Location = new Point(0, 0);
            groupBoxGameModePlayerVSPlayerInput1.Margin = new Padding(4, 5, 4, 5);
            groupBoxGameModePlayerVSPlayerInput1.Name = "groupBoxGameModePlayerVSPlayerInput1";
            groupBoxGameModePlayerVSPlayerInput1.Padding = new Padding(4, 5, 4, 5);
            groupBoxGameModePlayerVSPlayerInput1.Size = new Size(499, 329);
            groupBoxGameModePlayerVSPlayerInput1.TabIndex = 4;
            groupBoxGameModePlayerVSPlayerInput1.TabStop = false;
            groupBoxGameModePlayerVSPlayerInput1.Text = "Saisir les informations";
            // 
            // lblJoueurInput
            // 
            lblJoueurInput.AutoSize = true;
            lblJoueurInput.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblJoueurInput.Location = new Point(25, 85);
            lblJoueurInput.Margin = new Padding(4, 0, 4, 0);
            lblJoueurInput.Name = "lblJoueurInput";
            lblJoueurInput.Size = new Size(172, 25);
            lblJoueurInput.TabIndex = 0;
            lblJoueurInput.Text = "Pseudo joueur :";
            // 
            // lblNiveauIA
            // 
            lblNiveauIA.AutoSize = true;
            lblNiveauIA.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNiveauIA.Location = new Point(25, 168);
            lblNiveauIA.Margin = new Padding(4, 0, 4, 0);
            lblNiveauIA.Name = "lblNiveauIA";
            lblNiveauIA.Size = new Size(169, 25);
            lblNiveauIA.TabIndex = 1;
            lblNiveauIA.Text = "Niveau de l'IA :";
            // 
            // inputPseudoPlayer
            // 
            inputPseudoPlayer.BorderStyle = BorderStyle.FixedSingle;
            inputPseudoPlayer.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            inputPseudoPlayer.Location = new Point(239, 79);
            inputPseudoPlayer.Margin = new Padding(4, 5, 4, 5);
            inputPseudoPlayer.Name = "inputPseudoPlayer";
            inputPseudoPlayer.Size = new Size(234, 34);
            inputPseudoPlayer.TabIndex = 2;
            inputPseudoPlayer.Text = "Pseudo";
            inputPseudoPlayer.Enter += inputPseudoPlayer_Enter;
            // 
            // groupBoxGameModePlayerVSPlayerInput2
            // 
            groupBoxGameModePlayerVSPlayerInput2.Controls.Add(radioButtonModeHard);
            groupBoxGameModePlayerVSPlayerInput2.Controls.Add(groupBoxGameModePlayerVSPlayerInput1);
            groupBoxGameModePlayerVSPlayerInput2.Controls.Add(radioButtonModeNormal);
            groupBoxGameModePlayerVSPlayerInput2.Controls.Add(radioButtonModeEasy);
            groupBoxGameModePlayerVSPlayerInput2.Controls.Add(inputPseudoPlayer);
            groupBoxGameModePlayerVSPlayerInput2.Controls.Add(lblNiveauIA);
            groupBoxGameModePlayerVSPlayerInput2.Controls.Add(lblJoueurInput);
            groupBoxGameModePlayerVSPlayerInput2.Controls.Add(checkBoxIaStart);
            groupBoxGameModePlayerVSPlayerInput2.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxGameModePlayerVSPlayerInput2.Location = new Point(495, 232);
            groupBoxGameModePlayerVSPlayerInput2.Margin = new Padding(4, 5, 4, 5);
            groupBoxGameModePlayerVSPlayerInput2.Name = "groupBoxGameModePlayerVSPlayerInput2";
            groupBoxGameModePlayerVSPlayerInput2.Padding = new Padding(4, 5, 4, 5);
            groupBoxGameModePlayerVSPlayerInput2.Size = new Size(499, 329);
            groupBoxGameModePlayerVSPlayerInput2.TabIndex = 5;
            groupBoxGameModePlayerVSPlayerInput2.TabStop = false;
            groupBoxGameModePlayerVSPlayerInput2.Text = "Saisir les informations";
            groupBoxGameModePlayerVSPlayerInput2.Visible = false;
            // 
            // checkBoxIaStart
            // 
            checkBoxIaStart.Appearance = Appearance.Button;
            checkBoxIaStart.AutoSize = true;
            checkBoxIaStart.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIaStart.Location = new Point(25, 290);
            checkBoxIaStart.Name = "checkBoxIaStart";
            checkBoxIaStart.Size = new Size(202, 30);
            checkBoxIaStart.TabIndex = 6;
            checkBoxIaStart.Text = "Faire commencer l'IA";
            checkBoxIaStart.UseVisualStyleBackColor = true;
            // 
            // radioButtonModeHard
            // 
            radioButtonModeHard.AutoSize = true;
            radioButtonModeHard.Cursor = Cursors.Hand;
            radioButtonModeHard.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonModeHard.Location = new Point(379, 219);
            radioButtonModeHard.Margin = new Padding(4, 5, 4, 5);
            radioButtonModeHard.Name = "radioButtonModeHard";
            radioButtonModeHard.Size = new Size(94, 24);
            radioButtonModeHard.TabIndex = 5;
            radioButtonModeHard.Text = "Difficile";
            radioButtonModeHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonModeNormal
            // 
            radioButtonModeNormal.AutoSize = true;
            radioButtonModeNormal.Checked = true;
            radioButtonModeNormal.Cursor = Cursors.Hand;
            radioButtonModeNormal.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonModeNormal.Location = new Point(203, 219);
            radioButtonModeNormal.Margin = new Padding(4, 5, 4, 5);
            radioButtonModeNormal.Name = "radioButtonModeNormal";
            radioButtonModeNormal.Size = new Size(92, 24);
            radioButtonModeNormal.TabIndex = 4;
            radioButtonModeNormal.TabStop = true;
            radioButtonModeNormal.Text = "Normal";
            radioButtonModeNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonModeEasy
            // 
            radioButtonModeEasy.AutoSize = true;
            radioButtonModeEasy.Cursor = Cursors.Hand;
            radioButtonModeEasy.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonModeEasy.Location = new Point(29, 219);
            radioButtonModeEasy.Margin = new Padding(4, 5, 4, 5);
            radioButtonModeEasy.Name = "radioButtonModeEasy";
            radioButtonModeEasy.Size = new Size(78, 24);
            radioButtonModeEasy.TabIndex = 3;
            radioButtonModeEasy.Text = "Facile";
            radioButtonModeEasy.UseVisualStyleBackColor = true;
            // 
            // btnGameModePlay
            // 
            btnGameModePlay.AutoSize = true;
            btnGameModePlay.BackColor = Color.LightGreen;
            btnGameModePlay.Cursor = Cursors.Hand;
            btnGameModePlay.FlatAppearance.BorderSize = 0;
            btnGameModePlay.FlatStyle = FlatStyle.Flat;
            btnGameModePlay.Font = new Font("Verdana", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnGameModePlay.ImageAlign = ContentAlignment.MiddleRight;
            btnGameModePlay.Location = new Point(245, 601);
            btnGameModePlay.Margin = new Padding(4, 5, 4, 5);
            btnGameModePlay.Name = "btnGameModePlay";
            btnGameModePlay.Padding = new Padding(107, 0, 107, 0);
            btnGameModePlay.Size = new Size(556, 65);
            btnGameModePlay.TabIndex = 6;
            btnGameModePlay.Text = "Lancer la partie !";
            btnGameModePlay.UseVisualStyleBackColor = false;
            btnGameModePlay.Click += btnGameModePlay_Click;
            // 
            // errorProviderInputPseudoPlayer1
            // 
            errorProviderInputPseudoPlayer1.ContainerControl = this;
            // 
            // errorProviderInputPseudoPlayer2
            // 
            errorProviderInputPseudoPlayer2.ContainerControl = this;
            // 
            // errorProviderInputPseudoPlayer
            // 
            errorProviderInputPseudoPlayer.ContainerControl = this;
            // 
            // GameModeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 709);
            Controls.Add(btnGameModePlay);
            Controls.Add(btnGameModeBack);
            Controls.Add(radioButtonPlayerVSAi);
            Controls.Add(groupBoxGameModePlayerVSPlayerInput2);
            Controls.Add(radioButtonPlayerVSPlayer);
            Controls.Add(lblGameModeTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GameModeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Puissance 4";
            groupBoxGameModePlayerVSPlayerInput1.ResumeLayout(false);
            groupBoxGameModePlayerVSPlayerInput1.PerformLayout();
            groupBoxGameModePlayerVSPlayerInput2.ResumeLayout(false);
            groupBoxGameModePlayerVSPlayerInput2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderInputPseudoPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInputPseudoPlayer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInputPseudoPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGameModeTitle;
        private RadioButton radioButtonPlayerVSPlayer;
        private RadioButton radioButtonPlayerVSAi;
        private Button btnGameModeBack;
        private Label lblJoueurInput1;
        private Label lblJoueurInput2;
        private TextBox inputPseudoPlayer1;
        private TextBox inputPseudoPlayer2;
        private GroupBox groupBoxGameModePlayerVSPlayerInput1;
        private Label lblJoueurInput;
        private Label lblNiveauIA;
        private TextBox inputPseudoPlayer;
        private GroupBox groupBoxGameModePlayerVSPlayerInput2;
        private RadioButton radioButtonModeHard;
        private RadioButton radioButtonModeNormal;
        private RadioButton radioButtonModeEasy;
        private Button btnGameModePlay;
        private ErrorProvider errorProviderInputPseudoPlayer1;
        private ErrorProvider errorProviderInputPseudoPlayer2;
        private ErrorProvider errorProviderInputPseudoPlayer;
        private RadioButton radioButtonBotStart;
        private CheckBox checkBox1;
        private CheckBox checkBoxIaStart;
    }
}