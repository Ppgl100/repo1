using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckMyGames
{
    public partial class Form2 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public string myGamePlatform = "";
        public string myGameTitle = "";
        public bool cancel = false;

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
        public Form2(string platformString)
        {
            InitializeComponent();
            this.platform.Text = platformString;

            this.MouseDown += new MouseEventHandler(Form2_MouseDown);
            this.MouseMove += new MouseEventHandler(Form2_MouseMove);
            this.MouseUp += new MouseEventHandler(Form2_MouseUp);
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void addGame_Click(object sender, EventArgs e)
        {
            myGamePlatform = this.platform.Text;
            myGameTitle = this.gameTitle.Text;

            cancel= false;
            this.Close();
        }
        public void setGamePlatform(string setPlatform)
        {
            this.platform.Text = setPlatform;
        }

        public string getGamePlatform()
        {
            return myGamePlatform;
        }

        public void setGameTitle(string setTitle)
        {
            this.gameTitle.Text = setTitle;
        }

        public string getGameTitle()
        {
            return myGameTitle;
        }

        public bool cancelled()
        {
            return cancel;
        }

        private void cancelWindow_Click(object sender, EventArgs e)
        {
            cancel=true;
            this.Close();
        }
    }
}
