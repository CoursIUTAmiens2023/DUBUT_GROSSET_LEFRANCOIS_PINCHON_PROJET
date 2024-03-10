using R5._08.Project.Database.Entities;
using R5._08.Project.Database.Interface;

namespace ProjetForm
{
    public partial class ScoresForm : Form
    {
        private IUnitOfWork m_UnitOfWork;
        public ScoresForm(IUnitOfWork p_UnitOfWork)
        {
            m_UnitOfWork = p_UnitOfWork;
            InitializeComponent();
        }

        public void BtnGameModeBack_Click(object p_Sender, EventArgs p_EventArgs)
        {

            Hide();

            // Ouverture de la page Home
            HomeForm v_HomeForm = new(m_UnitOfWork);
            v_HomeForm.ShowDialog();
        }

        public async void ScoresForm_Load(object p_Sender, EventArgs p_EventArgs)
        {
            /*Upgrade this initialisaiton*/
            m_ScoresGridView.Columns.Add("Nom", "Nom");
            m_ScoresGridView.Columns.Add("Nombre de parties", "Nombre de parties");
            m_ScoresGridView.Columns.Add("Nombre de parties gagnées", "Nombre de parties gagnées");
            m_ScoresGridView.Columns.Add("Temps de jeu moyen", "Temps de jeu moyen");
            try
            {
                IEnumerable<Scoreboard> v_Entities = await m_UnitOfWork.ScoreboardRepository.GetAllScoreboards();
                foreach (Scoreboard v_Entity in v_Entities)
                {
                    m_ScoresGridView.Rows.Add(v_Entity.Name, v_Entity.NumberOfGames, v_Entity.NumberOfWins, v_Entity.AverageTime);
                }
            }
            catch (Exception v_Ex)
            {
                Console.WriteLine(v_Ex.ToString());
            }
        }
    }
}