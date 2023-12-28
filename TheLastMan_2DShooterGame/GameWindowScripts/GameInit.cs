using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastMan_2DShooterGame
{
    public class GameInit
    {
        private GameInit() { }
        private static GameInit instance;
        private static readonly object _lock = new object();
        public GameWindow gW = new GameWindow();
        public static GameInit Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new GameInit();
                            instance.SetUp();
                        }
                    }
                }    
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public void SetUp()
        {
            if(!WelcomeScreen.Instance.isSetUp)
                WelcomeScreen.Instance.SetUp();
        }
     
    }
}
