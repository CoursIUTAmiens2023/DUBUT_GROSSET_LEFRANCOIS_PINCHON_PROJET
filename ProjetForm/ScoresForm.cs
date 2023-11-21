using System;
using System.Windows.Forms;

namespace ProjetForm
{
    public partial class ScoresForm : Form
    {
        public ScoresForm()
        {
            InitializeComponent();
        }

        private void btnGameModeBack_Click(object p_Sender, EventArgs p_EventArgs)
        {
            
            Hide();

            // Ouverture de la page Home
            HomeForm v_HomeForm = new HomeForm();
            v_HomeForm.ShowDialog();
        }
    }
}