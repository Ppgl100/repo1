using CheckMyGames.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckMyGames
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public int panelYPosition = 5;
        public Form2 addGame;
        public bool programmStart = true;
        public Panel myEditPanel;
        public string myEditPlatform;
        public string myEditTitle;

        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        public Form1()
        {
            InitializeComponent();
            this.closeBtn.MouseEnter += OnMouseEnter;
            this.maximizeBtn.MouseEnter += OnMouseEnter;
            this.minimizeBtn.MouseEnter += OnMouseEnter;
            this.addGames.MouseEnter += OnMouseEnter;
            this.myList.MouseEnter += OnMouseEnter;

            this.closeBtn.MouseLeave += OnMouseLeave;
            this.maximizeBtn.MouseLeave += OnMouseLeave;
            this.minimizeBtn.MouseLeave += OnMouseLeave;
            this.addGames.MouseLeave += OnMouseLeave;
            this.myList.MouseLeave += OnMouseLeave;

            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);

            this.myListTab.HorizontalScroll.Visible = false;
            this.myListTab.VerticalScroll.Visible = false;

            readMyDataFile();

        }

        private void readMyDataFile()
        {
            /*using (StreamReader sr = File.OpenText(("myDataFile_DO_NOT_DELETE.txt")))
            {
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    string readMeText = s;
                    string gamePlatform = readMeText.Substring(0, readMeText.IndexOf(";"));
                    string gameTitle = readMeText.Substring(readMeText.IndexOf(";") + 1, readMeText.Length - (readMeText.IndexOf(";") + 1));
                    addMyData(gamePlatform, gameTitle);
                }
            }*/

            string[] lines = File.ReadAllLines("myDataFile_DO_NOT_DELETE.txt");
            foreach (string line in lines)
            {
                string readMeText = line;
                string gamePlatform = readMeText.Substring(0, readMeText.IndexOf(";"));
                string gameTitle = readMeText.Substring(readMeText.IndexOf(";") + 1, readMeText.Length - (readMeText.IndexOf(";") + 1));
                addMyData(gamePlatform, gameTitle);
            }
            programmStart = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if(b.Name =="closeBtn")
            {
                b.BackgroundImage = global::CheckMyGames.Properties.Resources.closeHover;
            }
            else if (b.Name == "maximizeBtn")
            {
                b.BackgroundImage = global::CheckMyGames.Properties.Resources.maximizeHover;
            }
            else if(b.Name == "minimizeBtn")
            {
                b.BackgroundImage = global::CheckMyGames.Properties.Resources.minimizeHover;
            }
            else if (b.Name == "addGames")
            {
                b.BackColor = Color.AliceBlue;
            }
            else if (b.Name == "myList")
            {
                b.BackColor = Color.AliceBlue;
            }

        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Name == "closeBtn")
            {
                b.BackgroundImage = global::CheckMyGames.Properties.Resources.close;
            }
            else if (b.Name == "maximizeBtn")
            {
                b.BackgroundImage = global::CheckMyGames.Properties.Resources.maximize;
            }
            else if (b.Name == "minimizeBtn")
            {
                b.BackgroundImage = global::CheckMyGames.Properties.Resources.minimize;
            }
            else if (b.Name == "addGames")
            {
                b.BackColor = Color.White;
            }
            else if (b.Name == "myList")
            {
                b.BackColor = Color.White;
            }

        }

        private void OnPanelEnter(object sender, EventArgs e)
        {
            Panel p = (Panel) sender;
            p.BackColor = Color.White;
        }

        private void OnPanelLeave(object sender, EventArgs e)
        {
            Panel p = (Panel) sender;
            p.BackColor = Color.AliceBlue;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void addGames_Click(object sender, EventArgs e)
        {
            this.myTab.SelectedIndex = 0;
        }

        private void myList_Click(object sender, EventArgs e)
        {
            this.myTab.SelectedIndex = 1;
        }

        private void addMyGame(string gamePlatform)
        {
            scrollToTop();

            addGame = new Form2(gamePlatform);
            addGame.Location = new Point(this.Location.X, this.Location.Y);
            addGame.TopMost = true;
            addGame.StartPosition = FormStartPosition.Manual;
            addGame.Location = this.Location;
            addGame.Show();
            addGame.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
        }

        private void editMyGame(string gamePlatform, string gameTitle)
        {
            scrollToTop();

            addGame = new Form2(gamePlatform);
            addGame.setGameTitle(gameTitle);
            addGame.Location = new Point(this.Location.X, this.Location.Y);
            addGame.TopMost = true;
            addGame.StartPosition = FormStartPosition.Manual;
            addGame.Location = this.Location;
            addGame.Show();
            addGame.FormClosed += new FormClosedEventHandler(Form2_FormClosedEdit);
        }

        void Form2_FormClosedEdit(object sender, FormClosedEventArgs e)
        {
            if (!addGame.cancelled())
            {
                foreach (Control c in myEditPanel.Controls)
                {
                    if (c is Label)
                    {
                        c.Text = addGame.getGameTitle();
                    }
                }

                createDataFile();
            }
        }

        private void addPs4_Click(object sender, EventArgs e)
        {
            addMyGame("PS4");        
        }
        private void addXOne_Click(object sender, EventArgs e)
        {
            addMyGame("XBOX ONE");
        }

        private void addSwitch_Click(object sender, EventArgs e)
        {
            addMyGame("SWITCH");
        }

        private void addPs1_Click(object sender, EventArgs e)
        {
            addMyGame("PS1");
        }

        private void addPs2_Click(object sender, EventArgs e)
        {
            addMyGame("PS2");
        }

        private void addPs3_Click(object sender, EventArgs e)
        {
            addMyGame("PS3");
        }

        private void addX1_Click(object sender, EventArgs e)
        {
            addMyGame("XBOX");
        }

        private void addX360_Click(object sender, EventArgs e)
        {
            addMyGame("XBOX 360");
        }

        private void addNes_Click(object sender, EventArgs e)
        {
            addMyGame("NES");
        }

        private void addSnes_Click(object sender, EventArgs e)
        {
            addMyGame("SNES");
        }

        private void addN64_Click(object sender, EventArgs e)
        {
            addMyGame("N64");
        }

        private void addGC_Click(object sender, EventArgs e)
        {
            addMyGame("GAMECUBE");
        }

        private void addWii_Click(object sender, EventArgs e)
        {
            addMyGame("Wii");
        }

        private void addWiiU_Click(object sender, EventArgs e)
        {
            addMyGame("WiiU");
        }

        private void addSteam_Click(object sender, EventArgs e)
        {
            addMyGame("STEAM");
        }

        private void addEpicGames_Click(object sender, EventArgs e)
        {
            addMyGame("EPIC GAMES");
        }

        public void createDataFile()
        {
            string myGamePlatform = "";
            string myGameTitle = "";
            using (StreamWriter writetext = new StreamWriter("myDataFile_DO_NOT_DELETE.txt"))
            {
                foreach(Panel p in this.myListTab.Controls)
                {
                    foreach(Control c in p.Controls)
                    {
                        if(c is TextBox)
                        {                    
                            myGamePlatform = c.Text;
                        }
                        else if (c is Label)
                        {
                            myGameTitle = c.Text;
                        }
                    }
                    writetext.WriteLine(myGamePlatform +";"+myGameTitle);
                }            
            }
        }

        private void myPanelClick(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            myEditPanel = p;
            string myGamePlatform = "";
            string myGameTitle = "";

            foreach(Control c in p.Controls)
            {
                if(c is Label)
                {
                    myGameTitle = c.Text;
                }
                else if(c is Button && c.Name =="myPictureBox")
                {
                    if (c.Tag.Equals("PS4"))
                    {
                        myGamePlatform = "PS4";
                    }
                    else if (c.Tag.Equals("XBOX ONE"))
                    {
                        myGamePlatform = "XBOX ONE";
                    }
                    else if (c.Tag.Equals("SWITCH"))
                    {
                        myGamePlatform = "SWITCH";
                    }
                    else if (c.Tag.Equals("NES"))
                    {
                        myGamePlatform = "NES";
                    }
                    else if (c.Tag.Equals("SNES"))
                    {
                        myGamePlatform = "SNES";
                    }
                    else if (c.Tag.Equals("N64"))
                    {
                        myGamePlatform = "N64";
                    }
                    else if (c.Tag.Equals("GAMECUBE"))
                    {
                        myGamePlatform = "GAMECUBE";
                    }
                    else if (c.Tag.Equals("Wii"))
                    {
                        myGamePlatform = "Wii";
                    }
                    else if (c.Tag.Equals("WiiU"))
                    {
                        myGamePlatform = "WiiU";
                    }
                    else if (c.Tag.Equals("PS1"))
                    {
                        myGamePlatform = "PS1";
                    }
                    else if (c.Tag.Equals("PS2"))
                    {
                        myGamePlatform = "PS2";
                    }
                    else if (c.Tag.Equals("PS3"))
                    {
                        myGamePlatform = "PS3";
                    }
                    else if (c.Tag.Equals("XBOX"))
                    {
                        myGamePlatform = "XBOX";
                    }
                    else if (c.Tag.Equals("XBOX 360"))
                    {
                        myGamePlatform = "XBOX 360";
                    }
                    else if (c.Tag.Equals("STEAM"))
                    {
                        myGamePlatform = "STEAM";
                    }
                    else if (c.Tag.Equals("EPIC GAMES"))
                    {
                        myGamePlatform = "EPIC GAMES";
                    }
                }
            }

            editMyGame(myGamePlatform,myGameTitle);
        }

        private void addMyData(string platf, string gamet)
        {
            
            panelYPosition = 5;
            foreach (Panel p in this.myListTab.Controls)
            {
                p.Location = new Point(5, panelYPosition);
                panelYPosition = panelYPosition + 106;
                p.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            }

            if (gamet != "")
            {
                Panel myPanel = new Panel();
                myPanel.Click += myPanelClick;
                myPanel.MouseEnter += OnPanelEnter;
                myPanel.MouseLeave += OnPanelLeave;
                myPanel.Size = new Size(980, 100);
                myPanel.Location = new Point(5, panelYPosition);
                myPanel.BorderStyle = BorderStyle.FixedSingle;
                myPanel.BackColor = Color.AliceBlue;
                myPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);


                TextBox myTextBox = new TextBox();
                myTextBox.Text = platf;
                myTextBox.Visible = false;
                myPanel.Controls.Add(myTextBox);

                Button myPictureBox = new Button();
                myPictureBox.Name = "myPictureBox";
                myPictureBox.FlatStyle = FlatStyle.Flat;
                myPictureBox.Enabled = false;
                myPictureBox.Size = new Size(96, 88);
                myPictureBox.Location = new Point(6, 5);
                myPictureBox.BackColor = Color.White;
                myPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                myPictureBox.Anchor = AnchorStyles.Left;

                if (platf == "PS4")
                {
                    myPictureBox.Text = "PS4";
                    myPictureBox.Tag = "PS4";
                }
                else if (platf == "XBOX ONE")
                {
                    myPictureBox.Text = "XBOX ONE";
                    myPictureBox.Tag = "XBOX ONE";
                }
                else if (platf == "SWITCH")
                {
                    myPictureBox.Text = "SWITCH";
                    myPictureBox.Tag = "SWITCH";
                }
                else if (platf == "NES")
                {
                    myPictureBox.Text = "NES";
                    myPictureBox.Tag = "NES";
                }
                else if (platf == "SNES")
                {
                    myPictureBox.Text = "SNES";
                    myPictureBox.Tag = "SNES";
                }
                else if (platf == "N64")
                {
                    myPictureBox.Text = "N64";
                    myPictureBox.Tag = "N64";
                }
                else if (platf == "GAMECUBE")
                {
                    myPictureBox.Text = "GAMECUBE";
                    myPictureBox.Tag = "GAMECUBE";
                }
                else if (platf == "Wii")
                {
                    myPictureBox.Text = "Wii";
                    myPictureBox.Tag = "Wii";
                }
                else if (platf == "WiiU")
                {
                    myPictureBox.Text = "WiiU";
                    myPictureBox.Tag = "WiiU";
                }
                else if (platf == "PS1")
                {
                    myPictureBox.Text = "PS1";
                    myPictureBox.Tag = "PS1";
                }
                else if (platf == "PS2")
                {
                    myPictureBox.Text = "PS2";
                    myPictureBox.Tag = "PS2";
                }
                else if (platf == "PS3")
                {
                    myPictureBox.Text = "PS3";
                    myPictureBox.Tag = "PS3";
                }
                else if (platf == "XBOX")
                {
                    myPictureBox.Text = "XBOX";
                    myPictureBox.Tag = "XBOX";
                }
                else if (platf == "XBOX 360")
                {
                    myPictureBox.Text = "XBOX 360";
                    myPictureBox.Tag = "XBOX 360";
                }
                else if (platf == "STEAM")
                {
                    myPictureBox.Text = "STEAM";
                    myPictureBox.Tag = "STEAM";
                }
                else if (platf == "EPIC GAMES")
                {
                    myPictureBox.Text = "EPIC GAMES";
                    myPictureBox.Tag = "EPIC GAMES";
                }
                myPanel.Controls.Add(myPictureBox);

                Label myLabel = new Label();
                myLabel.Text = gamet;
                myLabel.Font = new Font("Yu Gothic", 16);
                myLabel.Size = new Size(439, 27);
                myLabel.AutoSize = false;
                myLabel.Location = new Point(171, 37);         
                myLabel.Anchor = AnchorStyles.Left;
                myPanel.Controls.Add(myLabel);
               

                Button myRemoveButton = new Button();
                myRemoveButton.Font = new Font("Yu Gothic", 16);
                myRemoveButton.BackColor = Color.White;
                myRemoveButton.Text = "REMOVE";
                myRemoveButton.FlatStyle = FlatStyle.Flat;
                myRemoveButton.Size = new Size(119, 39);
                myRemoveButton.Location = new Point(834, 31);
                myRemoveButton.Click += new EventHandler(removeEntry);
                myRemoveButton.Anchor = AnchorStyles.Right;
                myPanel.Controls.Add(myRemoveButton);

                this.myListTab.Controls.Add(myPanel);

                //panelYPosition = panelYPosition + 106;
            }
            if (!programmStart)
            {
                createDataFile();
            }
        }

        void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            addMyData(addGame.getGamePlatform(),addGame.getGameTitle());
        }

        private void scrollToTop()
        {
            this.myListTab.VerticalScroll.Value = 0;
            /*foreach (Panel p in this.myListTab.Controls)
            {
                this.myListTab.ScrollControlIntoView(p);
                break;
            }*/
        }

        private void removeEntry(object sender, EventArgs e)
        {
            scrollToTop();
            Button myButton = (Button)sender;
            Panel removedPanel = new Panel();

            foreach(Panel p in this.myListTab.Controls)
            {
                if(myButton.Parent == p)
                {
                    removedPanel = p;
                    break;
                }
            }

            this.myListTab.Controls.Remove(removedPanel);

            int panelYLocation = 5;
            foreach (Panel p in this.myListTab.Controls)
            {
                
                p.Location = new Point(5, panelYLocation);
                panelYLocation = panelYLocation + 106;
                p.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            }
            createDataFile();
        }

        private void sortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Panel p in this.myListTab.Controls)
            {
                p.Tag = null;
            }
            scrollToTop();
            List<string> myPlatforms = new List<string>();
            foreach (Panel p in this.myListTab.Controls)
            {
                foreach (Control c in p.Controls)
                {
                    if (c is Button && c.Name == "myPictureBox")
                    {
                        myPlatforms.Add(""+c.Tag);
                    }
                }
            }

            List<string> myTitles = new List<string>();
            foreach (Panel p in this.myListTab.Controls)
            {
                foreach (Control c in p.Controls)
                { 
                    if(c is Label)
                    {
                        myTitles.Add(c.Text);
                    }
                }
            }

            panelYPosition = 5;
            bool loopBreaker = false;

            if (sortBox.SelectedItem == "Name (A-Z)")
            {
                myTitles.Sort();

                for (int i = 0; i < myTitles.Count; i++)
                {

                    foreach (Panel p in this.myListTab.Controls)
                    {
                        foreach(Control c in p.Controls)
                        {
                            if(c is Label && c.Text == myTitles[i] && p.Tag == null)
                            {
                                p.Location = new Point(5, panelYPosition);
                                panelYPosition = panelYPosition + 106;
                                loopBreaker = true;
                                p.Tag = "1";
                                break;

                            }
                        }
                        if(loopBreaker)
                        {
                            loopBreaker = false;
                            break;
                        }
                    }
                }

            }
            else if (sortBox.SelectedItem == "Name (Z-A)")
            {
                myTitles.Sort();

                for (int i = myTitles.Count-1; i >=0; i--)
                {

                    foreach (Panel p in this.myListTab.Controls)
                    {
                        foreach (Control c in p.Controls)
                        {
                            if (c is Label && c.Text == myTitles[i] && p.Tag == null)
                            {
                                p.Location = new Point(5, panelYPosition);
                                panelYPosition = panelYPosition + 106;
                                loopBreaker = true;
                                p.Tag = "1";
                                break;

                            }
                        }
                        if (loopBreaker)
                        {
                            loopBreaker = false;
                            break;
                        }
                    }
                }
            }
            else if (sortBox.SelectedItem == "Platform (A-Z)")
            {
                myPlatforms.Sort();

                for (int i = 0; i < myPlatforms.Count; i++)
                {

                    foreach (Panel p in this.myListTab.Controls)
                    {
                        foreach (Control c in p.Controls)
                        {
                            if (c is Button && c.Name == "myPictureBox" && c.Tag == myPlatforms[i] && p.Tag == null)
                            {
                                p.Location = new Point(5, panelYPosition);
                                panelYPosition = panelYPosition + 106;
                                loopBreaker = true;
                                p.Tag = "1";
                                break;

                            }
                        }
                        if (loopBreaker)
                        {
                            loopBreaker = false;
                            break;
                        }
                    }
                }
            }
            else if (sortBox.SelectedItem == "Platform (Z-A)")
            {
                myPlatforms.Sort();

                for (int i = myPlatforms.Count - 1; i >= 0; i--)
                {

                    foreach (Panel p in this.myListTab.Controls)
                    {
                        foreach (Control c in p.Controls)
                        {
                            if (c is Button && c.Name == "myPictureBox" && c.Tag == myPlatforms[i] && p.Tag == null)
                            {
                                p.Location = new Point(5, panelYPosition);
                                panelYPosition = panelYPosition + 106;
                                loopBreaker = true;
                                p.Tag = "1";
                                break;

                            }
                        }
                        if (loopBreaker)
                        {
                            loopBreaker = false;
                            break;
                        }
                    }
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string mySearchString = this.searchBox.Text.ToUpper();

            foreach (Panel p in this.myListTab.Controls)
            {
                p.BackColor = Color.AliceBlue;
            }

                foreach (Panel p in this.myListTab.Controls)
            {
                foreach (Control l in p.Controls)
                {
                    if (l is Label)
                    {
                        if (l.Text.ToUpper().Contains(mySearchString) || l.Text.ToUpper().Equals(mySearchString))
                        {
                            this.myListTab.ScrollControlIntoView(p);
                            p.BackColor = Color.Aqua;
                            break;
                        }
                    }
                }
            }
        }
    }
}
