using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLastMan_2DShooterGame
{
    public class AssetsLoader
    {
        private AssetsLoader() { }
        private static AssetsLoader instance;
        private static readonly object _lock = new object();
        //UI
        public Dictionary<string,Image> UI_Maps = new Dictionary<string,Image>();
        public Dictionary<string,Image> UI_Icons = new Dictionary<string,Image>();
        public Dictionary<string,Image> UI_Borders = new Dictionary<string,Image>();
        public Dictionary<string,Image> UI_BG = new Dictionary<string,Image>();
        public Dictionary<string,Image> UI_Panels = new Dictionary<string,Image>();
        public Dictionary<string,Image> UI_Icon_Stages = new Dictionary<string,Image>();
        //GameObject
        public Dictionary<string,Image> GO_Player = new Dictionary<string,Image>();
        public Dictionary<string,Image> GO_Projectile = new Dictionary<string,Image>();
        public Dictionary<string,Image> GO_Weapon = new Dictionary<string,Image>();
        public Dictionary<string,Image> GO_Item = new Dictionary<string,Image>();

        public Dictionary<string, string> Audio = new Dictionary<string, string>();

        public PrivateFontCollection Fonts = new PrivateFontCollection();
        public static AssetsLoader Instance
        {
            get
            { 
                if(instance == null)
                {
                    lock(_lock)
                    {
                        if(instance==null)
                        {
                            instance = new AssetsLoader();
                            instance.LoadAssets();

                        }
                    }
                }
                return instance; 
            }
            private set { instance = value; }
        }

        private void LoadAssets()
        {
            Load_Audio();
            Load_Fonts();
            
            Load_UI_BG();
            Load_UI_Borders();
            Load_UI_Icons();
            Load_UI_Maps();
            Load_UI_Panels();
            Load_UI_Icon_Stages();

            Load_GO_Player();
            Load_GO_Weapons();
            Load_GO_Items();
            Load_GO_Projectiles();
        }

        private void Load_Fonts()
        {
            var files = Directory.GetFiles("..\\..\\..\\Assets\\Fonts", "*.ttf");
            foreach (var file in files)
            {
                Fonts.AddFontFile(file);
            }
        }
        //UI
        private void Load_UI_Maps()
        {
            var files = Directory.GetFiles("..\\..\\..\\Assets\\UI\\Maps", "*.png");
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file).Split('.')[0];
                var fileImage = Image.FromFile(file);
                UI_Maps.Add(fileName, fileImage);
            }
        }
        private void Load_UI_Panels()
        {
            var files = Directory.GetFiles("..\\..\\..\\Assets\\UI\\Panels", "*.png");
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file).Split('.')[0];
                var fileImage = Image.FromFile(file);
                UI_Panels.Add(fileName, fileImage);
            }
     
        }
        private void Load_UI_Icons()
        {
            var files = Directory.GetFiles("..\\..\\..\\Assets\\UI\\Icons", "*.png");
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file).Split('.')[0];
                var fileImage = Image.FromFile(file);
                UI_Icons.Add(fileName, fileImage);
            }
        }
        private void Load_UI_BG()
        {
            var files = Directory.GetFiles("..\\..\\..\\Assets\\UI\\BG", "*.png");
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file).Split('.')[0];
                var fileImage = Image.FromFile(file);
                UI_BG.Add(fileName, fileImage);
            }
        }
        private void Load_UI_Borders()
        {
            var files = Directory.GetFiles("..\\..\\..\\Assets\\UI\\Borders", "*.png");
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file).Split('.')[0];
                var fileImage = Image.FromFile(file);
                UI_Borders.Add(fileName, fileImage);
            }
        }

        private void Load_UI_Icon_Stages()
        {
            var files = Directory.GetFiles("..\\..\\..\\Assets\\UI\\Icons\\Stages", "*.png");
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file).Split('.')[0];
                var fileImage = Image.FromFile(file);
                UI_Icon_Stages.Add(fileName, fileImage);
            }
        }
        //GO
        private void Load_GO_Player()
        {
            var files = Directory.GetFiles("..\\..\\..\\Assets\\GameObject\\Player", "*.gif");
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file).Split('.')[0];
                var fileImage = Image.FromFile(file);
                GO_Player.Add(fileName, fileImage);
            }
        }

        private void Load_GO_Projectiles()
        {
            var files = Directory.GetFiles("..\\..\\..\\Assets\\GameObject\\Projectiles", "*.png");
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file).Split('.')[0];
                var fileImage = Image.FromFile(file);
                GO_Projectile.Add(fileName, fileImage);
            }
        }
        private void Load_GO_Weapons()
        {
            var files = Directory.GetFiles("..\\..\\..\\Assets\\GameObject\\Weapons", "*.png");
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file).Split('.')[0];
                var fileImage = Image.FromFile(file);
                GO_Weapon.Add(fileName, fileImage);
            }
        }
        private void Load_GO_Items()
        {
            var files = Directory.GetFiles("..\\..\\..\\Assets\\GameObject\\Items", "*.png");
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file).Split('.')[0];
                var fileImage = Image.FromFile(file);
                GO_Item.Add(fileName, fileImage);
            }
        }

        public Dictionary<string,Image> Load_GO_Mob(string Name)
        {
            var files = Directory.GetFiles("..\\..\\..\\Assets\\GameObject\\Mobs\\"+Name, "*.gif");
            var stores = new Dictionary<string, Image>();
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file).Split('.')[0];
                var fileImage = Image.FromFile(file);
                stores[fileName] = fileImage;
            }
            return stores;
        }


        //
        public void Load_Audio()
        {
            var files = Directory.GetFiles("..\\..\\..\\Assets\\Audio", "*.wav");
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file).Split('.')[0];
                Audio.Add(fileName, Path.GetFullPath(file));
            }
        }
    }
}
