using System.Media;

namespace TheLastMan_2DShooterGame
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(AssetsLoader.Instance.Audio["BG Audio"]);
            //soundPlayer.PlayLooping();
        }
    }
}