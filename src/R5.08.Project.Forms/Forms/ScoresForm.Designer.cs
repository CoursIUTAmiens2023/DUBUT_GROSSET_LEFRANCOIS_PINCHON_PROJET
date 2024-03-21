﻿namespace ProjetForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoresForm));
            m_LblHomeTitle = new Label();
            m_BtnGameModeBack = new Button();
            m_ScoresGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)m_ScoresGridView).BeginInit();
            SuspendLayout();
            // 
            // m_LblHomeTitle
            // 
            m_LblHomeTitle.AutoSize = true;
            m_LblHomeTitle.Font = new Font("Verdana", 30F, FontStyle.Regular, GraphicsUnit.Point);
            m_LblHomeTitle.ForeColor = Color.White;
            m_LblHomeTitle.Location = new Point(380, 58);
            m_LblHomeTitle.Margin = new Padding(4, 0, 4, 0);
            m_LblHomeTitle.Name = "m_LblHomeTitle";
            m_LblHomeTitle.Size = new Size(154, 48);
            m_LblHomeTitle.TabIndex = 1;
            m_LblHomeTitle.Text = "Scores";
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
            m_BtnGameModeBack.Margin = new Padding(4, 3, 4, 3);
            m_BtnGameModeBack.Name = "m_BtnGameModeBack";
            m_BtnGameModeBack.Padding = new Padding(35, 0, 35, 0);
            m_BtnGameModeBack.Size = new Size(148, 31);
            m_BtnGameModeBack.TabIndex = 6;
            m_BtnGameModeBack.Text = "Retour";
            m_BtnGameModeBack.UseVisualStyleBackColor = false;
            m_BtnGameModeBack.Click += BtnGameModeBack_Click;
            // 
            // m_ScoresGridView
            // 
            m_ScoresGridView.AllowUserToAddRows = false;
            m_ScoresGridView.AllowUserToDeleteRows = false;
            m_ScoresGridView.AllowUserToResizeColumns = false;
            m_ScoresGridView.AllowUserToResizeRows = false;
            m_ScoresGridView.BackgroundColor = Color.FromArgb(16, 27, 39);
            m_ScoresGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(39, 56, 73);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            m_ScoresGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            m_ScoresGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(39, 56, 73);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            m_ScoresGridView.DefaultCellStyle = dataGridViewCellStyle2;
            m_ScoresGridView.EnableHeadersVisualStyles = false;
            m_ScoresGridView.GridColor = Color.FromArgb(39, 56, 73);
            m_ScoresGridView.Location = new Point(37, 138);
            m_ScoresGridView.Margin = new Padding(4, 3, 4, 3);
            m_ScoresGridView.Name = "m_ScoresGridView";
            m_ScoresGridView.ReadOnly = true;
            m_ScoresGridView.Size = new Size(840, 354);
            m_ScoresGridView.TabIndex = 7;
            // 
            // ScoresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 27, 39);
            ClientSize = new Size(915, 532);
            Controls.Add(m_ScoresGridView);
            Controls.Add(m_BtnGameModeBack);
            Controls.Add(m_LblHomeTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "ScoresForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Puissance 4";
            Load += ScoresForm_Load;
            ((System.ComponentModel.ISupportInitialize)m_ScoresGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label m_LblHomeTitle;
        public Button m_BtnGameModeBack;
        public DataGridView m_ScoresGridView;
    }
}