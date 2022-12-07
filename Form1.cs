using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_Eru
{
    public partial class Eru : MaterialForm
    {
        #region winget commands
        // browsers
        Dictionary<string, string> browsers = new Dictionary<string, string>()
        {
            {"Mozzila Firefox", "/C winget install -e --id Mozilla.Firefox" },
            {"Google Chrome", "/C winget install -e --id Google.Chrome" },
            {"Opera", "/C winget install -e --id Opera.Opera" },
            {"Opera GX", "/C winget install -e --id Opera.OperaGX" },
            {"Brave", "/C winget install -e --id BraveSoftware.BraveBrowser" },
            {"Tor Browser", "/C winget install -e --id TorProject.TorBrowser" }

        };

        // gaming
        Dictionary<string, string> gaming = new Dictionary<string, string>()
        {
            {"Discord", "/C winget install -e --id Discord.Discord"  },
            {"Steam", "/C winget install -e --id Valve.Steam"  },
            {"Epic Games", "/C winget install -e --id EpicGames.EpicGamesLauncher"  },
            {"League of Legends", "/C winget install -e --id RiotGames.LeagueOfLegends.EUNE"  },
            {"EA Desktop Client", "/C winget install -e --id ElectronicArts.EADesktop"  }
        };

        // productivity 
        Dictionary<string, string> productivity = new Dictionary<string, string>()
        {
            {"Adobe Reader PDF", "/C winget install -e --id Adobe.Acrobat.Reader.64-bit"  },
            {"SumatraPDF", "/C winget install -e --id SumatraPDF.SumatraPDF"  },
            {"LibreOffice", "/C winget install -e --id TheDocumentFoundation.LibreOffice"  }
        };

        // development 
        Dictionary<string, string> development = new Dictionary<string, string>()
        {
            {"Python 3.9", "/C winget install -e --id Python.Python.3.9"  },
            {"NodeJS", "/C winget install -e --id OpenJS.NodeJS"  },
            {"Git", "/C winget install -e --id Git.Git"  },
            {"Docker", "/C winget install -e --id Docker.DockerDesktop"  }
        };

        // IDE's & text editors
        Dictionary<string, string> ides = new Dictionary<string, string>()
        {
            {"VS Code", "/C winget install -e --id Microsoft.VisualStudioCode"  },
            {"PyCharm", "/C winget install -e --id JetBrains.PyCharm.Community"  },
            {"Vim", "/C winget install -e --id vim.vim"  },
            {"Notepad++", "/C winget install -e --id Notepad++.Notepad++"  },
            {"NeoVim", "/C winget install -e --id Neovim.Neovim"  },
            {"Atom", "/C winget install -e --id GitHub.Atom"  },
            {"SublimeText", "/C winget install -e --id SublimeHQ.SublimeText.4"  },
            {"Visual Studio", "/C winget install -e --id Microsoft.VisualStudio.2022.Community-Preview" }
        };

        //media 
        Dictionary<string, string> media = new Dictionary<string, string>()
        {
            //{"VLC", "/C winget install -e --id VideoLAN.VLC"  },
            {"Winamp", "/C winget install -e --id Radionomy.Winamp"  },
            {"Spotify", "/C winget install -e --id Spotify.Spotify"  },
            {"HandBrake", "/C winget install -e --id HandBrake.HandBrake"  }
        };

        //utilities
        Dictionary<string, string> utilities = new Dictionary<string, string>()
        {
            {"Greenshot", "/C winget install -e --id VideoLAN.VLC"  },
            {"Lightshot", "/C winget install -e --id VideoLAN.VLC"  },
            {"7-zip", "/C winget install -e --id VideoLAN.VLC"  },
            {"Winrar", "/C winget install -e --id VideoLAN.VLC"  },
            {"PowerISO", "/C winget install -e --id PowerSoftware.PowerISO" },
            {"Bitwarden", "/C winget install -e --id Bitwarden.Bitwarden" }
        };


        #endregion

        public Eru()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        MaterialSkinManager ThemeManger = MaterialSkinManager.Instance;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BrowsersCheckedList(object sender, EventArgs e)
        {
            BrowserList.CheckOnClick= true;
        }

        // function for the gaming check tab
        private void GamingCheckedList(object sender, EventArgs e)
        {
            GamingList.CheckOnClick= true;
        }

        private void ProductivityCheckList(object sender, EventArgs e)
        {
            ProductivityList.CheckOnClick = true;
        }

        private void DevelopmentCheckedList(object sender, EventArgs e)
        {
            DevelopmentList.CheckOnClick = true;
        }


        private void IDESCheckList(object sender, EventArgs e)
        {
            IDESList.CheckOnClick = true;
        }

        private void MediaCheckList(object sender, EventArgs e)
        {
            MediaList.CheckOnClick = true;
        }

        private void UtilitiesCheckList(object sender, EventArgs e)
        {
            UtilitiesList.CheckOnClick = true;
        }

        private void InstallClick(object sender, EventArgs e)
        {
            foreach (string browser in BrowserList.CheckedItems)
            {
                if (browsers.ContainsKey(browser))
                {
                    System.Diagnostics.Process.Start("PowerShell.exe", browsers[browser]);
                }
            }

            foreach (string game in GamingList.CheckedItems)
            {
                if (gaming.ContainsKey(game))
                {
                    System.Diagnostics.Process.Start("PowerShell.exe", gaming[game]);
                }
            }

            foreach (string product in ProductivityList.CheckedItems)
            {
                if (productivity.ContainsKey(product))
                {
                    System.Diagnostics.Process.Start("PowerShell.exe", productivity[product]);
                }
            }

            foreach (string devel in DevelopmentList.CheckedItems)
            {
                if (development.ContainsKey(devel))
                {
                    System.Diagnostics.Process.Start("PowerShell.exe", development[devel]);
                }
            }

            foreach (string ide in IDESList.CheckedItems)
            {
                if (ides.ContainsKey(ide))
                {
                    System.Diagnostics.Process.Start("PowerShell.exe", ides[ide]);
                }
            }

            foreach (string med in MediaList.CheckedItems)
            {
                if (media.ContainsKey(med))
                {
                    System.Diagnostics.Process.Start("PowerShell.exe", media[med]);
                }
            }

            foreach (string util in UtilitiesList.CheckedItems)
            {
                if (utilities.ContainsKey(util))
                {
                    System.Diagnostics.Process.Start("PowerShell.exe", utilities[util]);
                }
            }
        }

        private void UpgradeAllApps(object sender, EventArgs e)
        {
            string upgrade_all = "/C winget upgrade --all";
            System.Diagnostics.Process.Start("PowerShell.exe", upgrade_all);
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (ThemeSwitch.Checked)
            {
                ThemeManger.Theme = MaterialSkinManager.Themes.DARK;
                ThemeSwitch.Text = "Dark";
            }
            else
            {
                ThemeManger.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }
    }
}
