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
            Button m_BtnGameModeBack;
            m_LblGameModeTitle = new Label();
            m_RadioButtonPlayerVSPlayer = new RadioButton();
            m_RadioButtonPlayerVSAi = new RadioButton();
            m_LblJoueurInput1 = new Label();
            m_LblJoueurInput2 = new Label();
            m_InputPseudoPlayer1 = new TextBox();
            m_InputPseudoPlayer2 = new TextBox();
            m_GroupBoxGameModePlayerVSPlayerInput1 = new GroupBox();
            m_LblJoueurInput = new Label();
            m_LblNiveauIA = new Label();
            m_InputPseudoPlayer = new TextBox();
            m_GroupBoxGameModePlayerVSPlayerInput2 = new GroupBox();
            m_CheckBoxIaStart = new CheckBox();
            m_RadioButtonModeHard = new RadioButton();
            m_RadioButtonModeNormal = new RadioButton();
            m_RadioButtonModeEasy = new RadioButton();
            m_BtnGameModePlay = new Button();
            m_ErrorProviderInputPseudoPlayer1 = new ErrorProvider(components);
            m_ErrorProviderInputPseudoPlayer2 = new ErrorProvider(components);
            m_ErrorProviderInputPseudoPlayer = new ErrorProvider(components);
            m_BtnGameModeBack = new Button();
            m_GroupBoxGameModePlayerVSPlayerInput1.SuspendLayout();
            m_GroupBoxGameModePlayerVSPlayerInput2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)m_ErrorProviderInputPseudoPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)m_ErrorProviderInputPseudoPlayer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)m_ErrorProviderInputPseudoPlayer).BeginInit();
            SuspendLayout();
            // 
            // m_BtnGameModeBack
            // 
            m_BtnGameModeBack.AutoSize = true;
            m_BtnGameModeBack.BackColor = Color.Transparent;
            m_BtnGameModeBack.Cursor = Cursors.Hand;
            m_BtnGameModeBack.FlatAppearance.BorderColor = Color.FromArgb(203, 44, 69);
            m_BtnGameModeBack.FlatStyle = FlatStyle.Flat;
            m_BtnGameModeBack.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            m_BtnGameModeBack.ForeColor = Color.FromArgb(203, 44, 69);
            m_BtnGameModeBack.ImageAlign = ContentAlignment.MiddleRight;
            m_BtnGameModeBack.Location = new Point(752, 14);
            m_BtnGameModeBack.Margin = new Padding(4);
            m_BtnGameModeBack.Name = "m_BtnGameModeBack";
            m_BtnGameModeBack.Padding = new Padding(35, 0, 35, 0);
            m_BtnGameModeBack.Size = new Size(148, 31);
            m_BtnGameModeBack.TabIndex = 5;
            m_BtnGameModeBack.Text = "Retour";
            m_BtnGameModeBack.UseVisualStyleBackColor = false;
            m_BtnGameModeBack.Click += btnGameModeBack_Click;
            // 
            // m_LblGameModeTitle
            // 
            m_LblGameModeTitle.AutoSize = true;
            m_LblGameModeTitle.Font = new Font("Verdana", 30F, FontStyle.Regular, GraphicsUnit.Point);
            m_LblGameModeTitle.ForeColor = Color.White;
            m_LblGameModeTitle.Location = new Point(324, 57);
            m_LblGameModeTitle.Margin = new Padding(4, 0, 4, 0);
            m_LblGameModeTitle.Name = "m_LblGameModeTitle";
            m_LblGameModeTitle.Size = new Size(267, 48);
            m_LblGameModeTitle.TabIndex = 1;
            m_LblGameModeTitle.Text = "Mode de jeu";
            // 
            // m_RadioButtonPlayerVSPlayer
            // 
            m_RadioButtonPlayerVSPlayer.AutoSize = true;
            m_RadioButtonPlayerVSPlayer.Checked = true;
            m_RadioButtonPlayerVSPlayer.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            m_RadioButtonPlayerVSPlayer.ForeColor = Color.White;
            m_RadioButtonPlayerVSPlayer.Location = new Point(51, 203);
            m_RadioButtonPlayerVSPlayer.Margin = new Padding(4);
            m_RadioButtonPlayerVSPlayer.Name = "m_RadioButtonPlayerVSPlayer";
            m_RadioButtonPlayerVSPlayer.Size = new Size(239, 33);
            m_RadioButtonPlayerVSPlayer.TabIndex = 2;
            m_RadioButtonPlayerVSPlayer.TabStop = true;
            m_RadioButtonPlayerVSPlayer.Text = "Joueur VS Joueur";
            m_RadioButtonPlayerVSPlayer.UseVisualStyleBackColor = true;
            m_RadioButtonPlayerVSPlayer.CheckedChanged += radioButtonPlayerVsPlayer_CheckedChanged;
            // 
            // m_RadioButtonPlayerVSAi
            // 
            m_RadioButtonPlayerVSAi.AutoSize = true;
            m_RadioButtonPlayerVSAi.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            m_RadioButtonPlayerVSAi.ForeColor = Color.White;
            m_RadioButtonPlayerVSAi.Location = new Point(51, 293);
            m_RadioButtonPlayerVSAi.Margin = new Padding(4);
            m_RadioButtonPlayerVSAi.Name = "m_RadioButtonPlayerVSAi";
            m_RadioButtonPlayerVSAi.Size = new Size(185, 33);
            m_RadioButtonPlayerVSAi.TabIndex = 3;
            m_RadioButtonPlayerVSAi.Text = "Joueur VS IA";
            m_RadioButtonPlayerVSAi.UseVisualStyleBackColor = true;
            m_RadioButtonPlayerVSAi.CheckedChanged += radioButtonPlayerVsIA_CheckedChanged;
            // 
            // m_LblJoueurInput1
            // 
            m_LblJoueurInput1.AutoSize = true;
            m_LblJoueurInput1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            m_LblJoueurInput1.Location = new Point(22, 76);
            m_LblJoueurInput1.Margin = new Padding(4, 0, 4, 0);
            m_LblJoueurInput1.Name = "m_LblJoueurInput1";
            m_LblJoueurInput1.Size = new Size(154, 18);
            m_LblJoueurInput1.TabIndex = 0;
            m_LblJoueurInput1.Text = "Pseudo joueur 1 :";
            // 
            // m_LblJoueurInput2
            // 
            m_LblJoueurInput2.AutoSize = true;
            m_LblJoueurInput2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            m_LblJoueurInput2.Location = new Point(22, 157);
            m_LblJoueurInput2.Margin = new Padding(4, 0, 4, 0);
            m_LblJoueurInput2.Name = "m_LblJoueurInput2";
            m_LblJoueurInput2.Size = new Size(154, 18);
            m_LblJoueurInput2.TabIndex = 1;
            m_LblJoueurInput2.Text = "Pseudo joueur 2 :";
            // 
            // m_InputPseudoPlayer1
            // 
            m_InputPseudoPlayer1.BackColor = Color.FromArgb(27, 40, 55);
            m_InputPseudoPlayer1.BorderStyle = BorderStyle.FixedSingle;
            m_InputPseudoPlayer1.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            m_InputPseudoPlayer1.ForeColor = Color.White;
            m_InputPseudoPlayer1.Location = new Point(209, 71);
            m_InputPseudoPlayer1.Margin = new Padding(4);
            m_InputPseudoPlayer1.Name = "m_InputPseudoPlayer1";
            m_InputPseudoPlayer1.Size = new Size(205, 29);
            m_InputPseudoPlayer1.TabIndex = 2;
            m_InputPseudoPlayer1.Text = "Joueur 1";
            m_InputPseudoPlayer1.Enter += inputPseudoPlayer1_Enter;
            // 
            // m_InputPseudoPlayer2
            // 
            m_InputPseudoPlayer2.BackColor = Color.FromArgb(27, 40, 55);
            m_InputPseudoPlayer2.BorderStyle = BorderStyle.FixedSingle;
            m_InputPseudoPlayer2.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            m_InputPseudoPlayer2.ForeColor = Color.White;
            m_InputPseudoPlayer2.Location = new Point(209, 152);
            m_InputPseudoPlayer2.Margin = new Padding(4);
            m_InputPseudoPlayer2.Name = "m_InputPseudoPlayer2";
            m_InputPseudoPlayer2.Size = new Size(205, 29);
            m_InputPseudoPlayer2.TabIndex = 3;
            m_InputPseudoPlayer2.Text = "Joueur 2";
            m_InputPseudoPlayer2.Enter += inputPseudoPlayer2_Enter;
            // 
            // m_GroupBoxGameModePlayerVSPlayerInput1
            // 
            m_GroupBoxGameModePlayerVSPlayerInput1.Controls.Add(m_InputPseudoPlayer2);
            m_GroupBoxGameModePlayerVSPlayerInput1.Controls.Add(m_InputPseudoPlayer1);
            m_GroupBoxGameModePlayerVSPlayerInput1.Controls.Add(m_LblJoueurInput2);
            m_GroupBoxGameModePlayerVSPlayerInput1.Controls.Add(m_LblJoueurInput1);
            m_GroupBoxGameModePlayerVSPlayerInput1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            m_GroupBoxGameModePlayerVSPlayerInput1.ForeColor = Color.White;
            m_GroupBoxGameModePlayerVSPlayerInput1.Location = new Point(433, 156);
            m_GroupBoxGameModePlayerVSPlayerInput1.Margin = new Padding(4);
            m_GroupBoxGameModePlayerVSPlayerInput1.Name = "m_GroupBoxGameModePlayerVSPlayerInput1";
            m_GroupBoxGameModePlayerVSPlayerInput1.Padding = new Padding(4);
            m_GroupBoxGameModePlayerVSPlayerInput1.Size = new Size(437, 247);
            m_GroupBoxGameModePlayerVSPlayerInput1.TabIndex = 4;
            m_GroupBoxGameModePlayerVSPlayerInput1.TabStop = false;
            m_GroupBoxGameModePlayerVSPlayerInput1.Text = "Saisir les informations";
            // 
            // m_LblJoueurInput
            // 
            m_LblJoueurInput.AutoSize = true;
            m_LblJoueurInput.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            m_LblJoueurInput.Location = new Point(22, 64);
            m_LblJoueurInput.Margin = new Padding(4, 0, 4, 0);
            m_LblJoueurInput.Name = "m_LblJoueurInput";
            m_LblJoueurInput.Size = new Size(138, 18);
            m_LblJoueurInput.TabIndex = 0;
            m_LblJoueurInput.Text = "Pseudo joueur :";
            // 
            // m_LblNiveauIA
            // 
            m_LblNiveauIA.AutoSize = true;
            m_LblNiveauIA.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            m_LblNiveauIA.Location = new Point(22, 126);
            m_LblNiveauIA.Margin = new Padding(4, 0, 4, 0);
            m_LblNiveauIA.Name = "m_LblNiveauIA";
            m_LblNiveauIA.Size = new Size(136, 18);
            m_LblNiveauIA.TabIndex = 1;
            m_LblNiveauIA.Text = "Niveau de l'IA :";
            // 
            // m_InputPseudoPlayer
            // 
            m_InputPseudoPlayer.BackColor = Color.FromArgb(27, 40, 55);
            m_InputPseudoPlayer.BorderStyle = BorderStyle.FixedSingle;
            m_InputPseudoPlayer.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            m_InputPseudoPlayer.ForeColor = Color.White;
            m_InputPseudoPlayer.Location = new Point(209, 59);
            m_InputPseudoPlayer.Margin = new Padding(4);
            m_InputPseudoPlayer.Name = "m_InputPseudoPlayer";
            m_InputPseudoPlayer.Size = new Size(205, 29);
            m_InputPseudoPlayer.TabIndex = 2;
            m_InputPseudoPlayer.Text = "Pseudo";
            m_InputPseudoPlayer.Enter += inputPseudoPlayer_Enter;
            // 
            // m_GroupBoxGameModePlayerVSPlayerInput2
            // 
            m_GroupBoxGameModePlayerVSPlayerInput2.Controls.Add(m_CheckBoxIaStart);
            m_GroupBoxGameModePlayerVSPlayerInput2.Controls.Add(m_RadioButtonModeHard);
            m_GroupBoxGameModePlayerVSPlayerInput2.Controls.Add(m_RadioButtonModeNormal);
            m_GroupBoxGameModePlayerVSPlayerInput2.Controls.Add(m_RadioButtonModeEasy);
            m_GroupBoxGameModePlayerVSPlayerInput2.Controls.Add(m_InputPseudoPlayer);
            m_GroupBoxGameModePlayerVSPlayerInput2.Controls.Add(m_LblNiveauIA);
            m_GroupBoxGameModePlayerVSPlayerInput2.Controls.Add(m_LblJoueurInput);
            m_GroupBoxGameModePlayerVSPlayerInput2.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            m_GroupBoxGameModePlayerVSPlayerInput2.ForeColor = Color.White;
            m_GroupBoxGameModePlayerVSPlayerInput2.Location = new Point(433, 156);
            m_GroupBoxGameModePlayerVSPlayerInput2.Margin = new Padding(4);
            m_GroupBoxGameModePlayerVSPlayerInput2.Name = "m_GroupBoxGameModePlayerVSPlayerInput2";
            m_GroupBoxGameModePlayerVSPlayerInput2.Padding = new Padding(4);
            m_GroupBoxGameModePlayerVSPlayerInput2.Size = new Size(437, 247);
            m_GroupBoxGameModePlayerVSPlayerInput2.TabIndex = 5;
            m_GroupBoxGameModePlayerVSPlayerInput2.TabStop = false;
            m_GroupBoxGameModePlayerVSPlayerInput2.Text = "Saisir les informations";
            m_GroupBoxGameModePlayerVSPlayerInput2.Visible = false;
            // 
            // m_CheckBoxIaStart
            // 
            m_CheckBoxIaStart.AutoSize = true;
            m_CheckBoxIaStart.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            m_CheckBoxIaStart.Location = new Point(25, 208);
            m_CheckBoxIaStart.Name = "m_CheckBoxIaStart";
            m_CheckBoxIaStart.Size = new Size(171, 21);
            m_CheckBoxIaStart.TabIndex = 7;
            m_CheckBoxIaStart.Text = "Faire commencer l'IA";
            m_CheckBoxIaStart.UseVisualStyleBackColor = true;
            // 
            // m_RadioButtonModeHard
            // 
            m_RadioButtonModeHard.AutoSize = true;
            m_RadioButtonModeHard.Cursor = Cursors.Hand;
            m_RadioButtonModeHard.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            m_RadioButtonModeHard.Location = new Point(332, 164);
            m_RadioButtonModeHard.Margin = new Padding(4);
            m_RadioButtonModeHard.Name = "m_RadioButtonModeHard";
            m_RadioButtonModeHard.Size = new Size(74, 21);
            m_RadioButtonModeHard.TabIndex = 5;
            m_RadioButtonModeHard.Text = "Difficile";
            m_RadioButtonModeHard.UseVisualStyleBackColor = true;
            // 
            // m_RadioButtonModeNormal
            // 
            m_RadioButtonModeNormal.AutoSize = true;
            m_RadioButtonModeNormal.Checked = true;
            m_RadioButtonModeNormal.Cursor = Cursors.Hand;
            m_RadioButtonModeNormal.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            m_RadioButtonModeNormal.Location = new Point(178, 164);
            m_RadioButtonModeNormal.Margin = new Padding(4);
            m_RadioButtonModeNormal.Name = "m_RadioButtonModeNormal";
            m_RadioButtonModeNormal.Size = new Size(75, 21);
            m_RadioButtonModeNormal.TabIndex = 4;
            m_RadioButtonModeNormal.TabStop = true;
            m_RadioButtonModeNormal.Text = "Normal";
            m_RadioButtonModeNormal.UseVisualStyleBackColor = true;
            // 
            // m_RadioButtonModeEasy
            // 
            m_RadioButtonModeEasy.AutoSize = true;
            m_RadioButtonModeEasy.Cursor = Cursors.Hand;
            m_RadioButtonModeEasy.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            m_RadioButtonModeEasy.Location = new Point(25, 164);
            m_RadioButtonModeEasy.Margin = new Padding(4);
            m_RadioButtonModeEasy.Name = "m_RadioButtonModeEasy";
            m_RadioButtonModeEasy.Size = new Size(62, 21);
            m_RadioButtonModeEasy.TabIndex = 3;
            m_RadioButtonModeEasy.Text = "Facile";
            m_RadioButtonModeEasy.UseVisualStyleBackColor = true;
            // 
            // m_BtnGameModePlay
            // 
            m_BtnGameModePlay.AutoSize = true;
            m_BtnGameModePlay.BackColor = Color.FromArgb(24, 188, 156);
            m_BtnGameModePlay.Cursor = Cursors.Hand;
            m_BtnGameModePlay.FlatAppearance.BorderSize = 0;
            m_BtnGameModePlay.FlatStyle = FlatStyle.Flat;
            m_BtnGameModePlay.Font = new Font("Verdana", 20F, FontStyle.Regular, GraphicsUnit.Point);
            m_BtnGameModePlay.ForeColor = Color.White;
            m_BtnGameModePlay.ImageAlign = ContentAlignment.MiddleRight;
            m_BtnGameModePlay.Location = new Point(214, 451);
            m_BtnGameModePlay.Margin = new Padding(4);
            m_BtnGameModePlay.Name = "m_BtnGameModePlay";
            m_BtnGameModePlay.Padding = new Padding(94, 0, 94, 0);
            m_BtnGameModePlay.Size = new Size(486, 49);
            m_BtnGameModePlay.TabIndex = 6;
            m_BtnGameModePlay.Text = "Lancer la partie !";
            m_BtnGameModePlay.UseVisualStyleBackColor = false;
            m_BtnGameModePlay.Click += btnGameModePlay_Click;
            // 
            // m_ErrorProviderInputPseudoPlayer1
            // 
            m_ErrorProviderInputPseudoPlayer1.ContainerControl = this;
            // 
            // m_ErrorProviderInputPseudoPlayer2
            // 
            m_ErrorProviderInputPseudoPlayer2.ContainerControl = this;
            // 
            // m_ErrorProviderInputPseudoPlayer
            // 
            m_ErrorProviderInputPseudoPlayer.ContainerControl = this;
            // 
            // GameModeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 27, 39);
            ClientSize = new Size(914, 532);
            Controls.Add(m_BtnGameModePlay);
            Controls.Add(m_GroupBoxGameModePlayerVSPlayerInput1);
            Controls.Add(m_BtnGameModeBack);
            Controls.Add(m_RadioButtonPlayerVSAi);
            Controls.Add(m_GroupBoxGameModePlayerVSPlayerInput2);
            Controls.Add(m_RadioButtonPlayerVSPlayer);
            Controls.Add(m_LblGameModeTitle);
            Margin = new Padding(4);
            Name = "GameModeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Puissance 4";
            m_GroupBoxGameModePlayerVSPlayerInput1.ResumeLayout(false);
            m_GroupBoxGameModePlayerVSPlayerInput1.PerformLayout();
            m_GroupBoxGameModePlayerVSPlayerInput2.ResumeLayout(false);
            m_GroupBoxGameModePlayerVSPlayerInput2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)m_ErrorProviderInputPseudoPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)m_ErrorProviderInputPseudoPlayer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)m_ErrorProviderInputPseudoPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label m_LblGameModeTitle;
        private RadioButton m_RadioButtonPlayerVSPlayer;
        private RadioButton m_RadioButtonPlayerVSAi;
        private Button m_BtnGameModeBack;
        private Label m_LblJoueurInput1;
        private Label m_LblJoueurInput2;
        private TextBox m_InputPseudoPlayer1;
        private TextBox m_InputPseudoPlayer2;
        private GroupBox m_GroupBoxGameModePlayerVSPlayerInput1;
        private Label m_LblJoueurInput;
        private Label m_LblNiveauIA;
        private TextBox m_InputPseudoPlayer;
        private GroupBox m_GroupBoxGameModePlayerVSPlayerInput2;
        private RadioButton m_RadioButtonModeHard;
        private RadioButton m_RadioButtonModeNormal;
        private RadioButton m_RadioButtonModeEasy;
        private Button m_BtnGameModePlay;
        private ErrorProvider m_ErrorProviderInputPseudoPlayer1;
        private ErrorProvider m_ErrorProviderInputPseudoPlayer2;
        private ErrorProvider m_ErrorProviderInputPseudoPlayer;
        private RadioButton m_RadioButtonBotStart;
        private CheckBox m_CheckBox1;
        private CheckBox m_CheckBoxIaStart;
    }
}