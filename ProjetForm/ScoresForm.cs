using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetForm
{
    public partial class ScoresForm : Form
    {
        public ScoresForm()
        {
            InitializeComponent();
        }

        private void btnGameModeBack_Click(object sender, EventArgs e)
        {
            // Fermeture de la page
            Close();

            // Ouverture de la page Home
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
    }
}
