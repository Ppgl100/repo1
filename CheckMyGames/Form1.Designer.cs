namespace CheckMyGames
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.myTab = new System.Windows.Forms.TabControl();
            this.addGamesTab = new System.Windows.Forms.TabPage();
            this.addEpicGames = new System.Windows.Forms.Button();
            this.addSteam = new System.Windows.Forms.Button();
            this.addWiiU = new System.Windows.Forms.Button();
            this.addWii = new System.Windows.Forms.Button();
            this.addGC = new System.Windows.Forms.Button();
            this.addN64 = new System.Windows.Forms.Button();
            this.addSnes = new System.Windows.Forms.Button();
            this.addNes = new System.Windows.Forms.Button();
            this.addX360 = new System.Windows.Forms.Button();
            this.addX1 = new System.Windows.Forms.Button();
            this.addPs1 = new System.Windows.Forms.Button();
            this.addPs2 = new System.Windows.Forms.Button();
            this.addPs3 = new System.Windows.Forms.Button();
            this.addSwitch = new System.Windows.Forms.Button();
            this.addXOne = new System.Windows.Forms.Button();
            this.addPs4 = new System.Windows.Forms.Button();
            this.myListTab = new System.Windows.Forms.TabPage();
            this.addGames = new System.Windows.Forms.Button();
            this.myList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.maximizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.myTab.SuspendLayout();
            this.addGamesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // myTab
            // 
            this.myTab.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.myTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myTab.Controls.Add(this.addGamesTab);
            this.myTab.Controls.Add(this.myListTab);
            this.myTab.Location = new System.Drawing.Point(9, 114);
            this.myTab.Margin = new System.Windows.Forms.Padding(2);
            this.myTab.Name = "myTab";
            this.myTab.SelectedIndex = 0;
            this.myTab.Size = new System.Drawing.Size(1021, 600);
            this.myTab.TabIndex = 0;
            // 
            // addGamesTab
            // 
            this.addGamesTab.AutoScroll = true;
            this.addGamesTab.BackColor = System.Drawing.Color.AliceBlue;
            this.addGamesTab.Controls.Add(this.addEpicGames);
            this.addGamesTab.Controls.Add(this.addSteam);
            this.addGamesTab.Controls.Add(this.addWiiU);
            this.addGamesTab.Controls.Add(this.addWii);
            this.addGamesTab.Controls.Add(this.addGC);
            this.addGamesTab.Controls.Add(this.addN64);
            this.addGamesTab.Controls.Add(this.addSnes);
            this.addGamesTab.Controls.Add(this.addNes);
            this.addGamesTab.Controls.Add(this.addX360);
            this.addGamesTab.Controls.Add(this.addX1);
            this.addGamesTab.Controls.Add(this.addPs1);
            this.addGamesTab.Controls.Add(this.addPs2);
            this.addGamesTab.Controls.Add(this.addPs3);
            this.addGamesTab.Controls.Add(this.addSwitch);
            this.addGamesTab.Controls.Add(this.addXOne);
            this.addGamesTab.Controls.Add(this.addPs4);
            this.addGamesTab.Location = new System.Drawing.Point(4, 4);
            this.addGamesTab.Margin = new System.Windows.Forms.Padding(2);
            this.addGamesTab.Name = "addGamesTab";
            this.addGamesTab.Padding = new System.Windows.Forms.Padding(2);
            this.addGamesTab.Size = new System.Drawing.Size(1013, 574);
            this.addGamesTab.TabIndex = 0;
            this.addGamesTab.Text = "tabPage1";
            // 
            // addEpicGames
            // 
            this.addEpicGames.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addEpicGames.BackColor = System.Drawing.Color.White;
            this.addEpicGames.BackgroundImage = global::CheckMyGames.Properties.Resources.epicGamesLogo;
            this.addEpicGames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addEpicGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEpicGames.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEpicGames.Location = new System.Drawing.Point(313, 529);
            this.addEpicGames.Name = "addEpicGames";
            this.addEpicGames.Size = new System.Drawing.Size(100, 100);
            this.addEpicGames.TabIndex = 25;
            this.addEpicGames.UseVisualStyleBackColor = false;
            this.addEpicGames.Click += new System.EventHandler(this.addEpicGames_Click);
            // 
            // addSteam
            // 
            this.addSteam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addSteam.BackColor = System.Drawing.Color.White;
            this.addSteam.BackgroundImage = global::CheckMyGames.Properties.Resources.steamLogo;
            this.addSteam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addSteam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSteam.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSteam.Location = new System.Drawing.Point(183, 529);
            this.addSteam.Name = "addSteam";
            this.addSteam.Size = new System.Drawing.Size(100, 100);
            this.addSteam.TabIndex = 24;
            this.addSteam.UseVisualStyleBackColor = false;
            this.addSteam.Click += new System.EventHandler(this.addSteam_Click);
            // 
            // addWiiU
            // 
            this.addWiiU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addWiiU.BackColor = System.Drawing.Color.White;
            this.addWiiU.BackgroundImage = global::CheckMyGames.Properties.Resources.wiiULogo;
            this.addWiiU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addWiiU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWiiU.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWiiU.Location = new System.Drawing.Point(183, 398);
            this.addWiiU.Name = "addWiiU";
            this.addWiiU.Size = new System.Drawing.Size(100, 100);
            this.addWiiU.TabIndex = 23;
            this.addWiiU.UseVisualStyleBackColor = false;
            this.addWiiU.Click += new System.EventHandler(this.addWiiU_Click);
            // 
            // addWii
            // 
            this.addWii.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addWii.BackColor = System.Drawing.Color.White;
            this.addWii.BackgroundImage = global::CheckMyGames.Properties.Resources.wiiLogo;
            this.addWii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addWii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWii.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWii.Location = new System.Drawing.Point(704, 268);
            this.addWii.Name = "addWii";
            this.addWii.Size = new System.Drawing.Size(100, 100);
            this.addWii.TabIndex = 22;
            this.addWii.UseVisualStyleBackColor = false;
            this.addWii.Click += new System.EventHandler(this.addWii_Click);
            // 
            // addGC
            // 
            this.addGC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addGC.BackColor = System.Drawing.Color.White;
            this.addGC.BackgroundImage = global::CheckMyGames.Properties.Resources.gameCubeLogo1;
            this.addGC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addGC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGC.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGC.Location = new System.Drawing.Point(574, 268);
            this.addGC.Name = "addGC";
            this.addGC.Size = new System.Drawing.Size(100, 100);
            this.addGC.TabIndex = 21;
            this.addGC.UseVisualStyleBackColor = false;
            this.addGC.Click += new System.EventHandler(this.addGC_Click);
            // 
            // addN64
            // 
            this.addN64.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addN64.BackColor = System.Drawing.Color.White;
            this.addN64.BackgroundImage = global::CheckMyGames.Properties.Resources.n64Logo;
            this.addN64.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addN64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addN64.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addN64.Location = new System.Drawing.Point(444, 268);
            this.addN64.Name = "addN64";
            this.addN64.Size = new System.Drawing.Size(100, 100);
            this.addN64.TabIndex = 20;
            this.addN64.UseVisualStyleBackColor = false;
            this.addN64.Click += new System.EventHandler(this.addN64_Click);
            // 
            // addSnes
            // 
            this.addSnes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addSnes.BackColor = System.Drawing.Color.White;
            this.addSnes.BackgroundImage = global::CheckMyGames.Properties.Resources.snesLogo1;
            this.addSnes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addSnes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSnes.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSnes.Location = new System.Drawing.Point(313, 268);
            this.addSnes.Name = "addSnes";
            this.addSnes.Size = new System.Drawing.Size(100, 100);
            this.addSnes.TabIndex = 19;
            this.addSnes.UseVisualStyleBackColor = false;
            this.addSnes.Click += new System.EventHandler(this.addSnes_Click);
            // 
            // addNes
            // 
            this.addNes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addNes.BackColor = System.Drawing.Color.White;
            this.addNes.BackgroundImage = global::CheckMyGames.Properties.Resources.nesLogo1;
            this.addNes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addNes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNes.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNes.Location = new System.Drawing.Point(183, 268);
            this.addNes.Name = "addNes";
            this.addNes.Size = new System.Drawing.Size(100, 100);
            this.addNes.TabIndex = 18;
            this.addNes.UseVisualStyleBackColor = false;
            this.addNes.Click += new System.EventHandler(this.addNes_Click);
            // 
            // addX360
            // 
            this.addX360.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addX360.BackColor = System.Drawing.Color.White;
            this.addX360.BackgroundImage = global::CheckMyGames.Properties.Resources.xbox360Logo;
            this.addX360.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addX360.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addX360.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addX360.Location = new System.Drawing.Point(313, 141);
            this.addX360.Name = "addX360";
            this.addX360.Size = new System.Drawing.Size(100, 100);
            this.addX360.TabIndex = 17;
            this.addX360.UseVisualStyleBackColor = false;
            this.addX360.Click += new System.EventHandler(this.addX360_Click);
            // 
            // addX1
            // 
            this.addX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addX1.BackColor = System.Drawing.Color.White;
            this.addX1.BackgroundImage = global::CheckMyGames.Properties.Resources.xboxLogo;
            this.addX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addX1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addX1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addX1.Location = new System.Drawing.Point(183, 141);
            this.addX1.Name = "addX1";
            this.addX1.Size = new System.Drawing.Size(100, 100);
            this.addX1.TabIndex = 16;
            this.addX1.UseVisualStyleBackColor = false;
            this.addX1.Click += new System.EventHandler(this.addX1_Click);
            // 
            // addPs1
            // 
            this.addPs1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addPs1.BackColor = System.Drawing.Color.White;
            this.addPs1.BackgroundImage = global::CheckMyGames.Properties.Resources.ps1Logo;
            this.addPs1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addPs1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPs1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPs1.Location = new System.Drawing.Point(183, 14);
            this.addPs1.Name = "addPs1";
            this.addPs1.Size = new System.Drawing.Size(100, 100);
            this.addPs1.TabIndex = 15;
            this.addPs1.UseVisualStyleBackColor = false;
            this.addPs1.Click += new System.EventHandler(this.addPs1_Click);
            // 
            // addPs2
            // 
            this.addPs2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addPs2.BackColor = System.Drawing.Color.White;
            this.addPs2.BackgroundImage = global::CheckMyGames.Properties.Resources.ps2Logo;
            this.addPs2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addPs2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPs2.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPs2.Location = new System.Drawing.Point(313, 14);
            this.addPs2.Name = "addPs2";
            this.addPs2.Size = new System.Drawing.Size(100, 100);
            this.addPs2.TabIndex = 14;
            this.addPs2.UseVisualStyleBackColor = false;
            this.addPs2.Click += new System.EventHandler(this.addPs2_Click);
            // 
            // addPs3
            // 
            this.addPs3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addPs3.BackColor = System.Drawing.Color.White;
            this.addPs3.BackgroundImage = global::CheckMyGames.Properties.Resources.ps3Logo;
            this.addPs3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addPs3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPs3.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPs3.Location = new System.Drawing.Point(444, 14);
            this.addPs3.Name = "addPs3";
            this.addPs3.Size = new System.Drawing.Size(100, 100);
            this.addPs3.TabIndex = 13;
            this.addPs3.UseVisualStyleBackColor = false;
            this.addPs3.Click += new System.EventHandler(this.addPs3_Click);
            // 
            // addSwitch
            // 
            this.addSwitch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addSwitch.BackColor = System.Drawing.Color.White;
            this.addSwitch.BackgroundImage = global::CheckMyGames.Properties.Resources.switchLogo;
            this.addSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSwitch.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSwitch.Location = new System.Drawing.Point(313, 398);
            this.addSwitch.Name = "addSwitch";
            this.addSwitch.Size = new System.Drawing.Size(100, 100);
            this.addSwitch.TabIndex = 12;
            this.addSwitch.UseVisualStyleBackColor = false;
            this.addSwitch.Click += new System.EventHandler(this.addSwitch_Click);
            // 
            // addXOne
            // 
            this.addXOne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addXOne.BackColor = System.Drawing.Color.White;
            this.addXOne.BackgroundImage = global::CheckMyGames.Properties.Resources.xboxOneLogo;
            this.addXOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addXOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addXOne.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addXOne.Location = new System.Drawing.Point(444, 141);
            this.addXOne.Name = "addXOne";
            this.addXOne.Size = new System.Drawing.Size(100, 100);
            this.addXOne.TabIndex = 11;
            this.addXOne.UseVisualStyleBackColor = false;
            this.addXOne.Click += new System.EventHandler(this.addXOne_Click);
            // 
            // addPs4
            // 
            this.addPs4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addPs4.BackColor = System.Drawing.Color.White;
            this.addPs4.BackgroundImage = global::CheckMyGames.Properties.Resources.ps4Logo;
            this.addPs4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addPs4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPs4.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPs4.Location = new System.Drawing.Point(574, 14);
            this.addPs4.Name = "addPs4";
            this.addPs4.Size = new System.Drawing.Size(100, 100);
            this.addPs4.TabIndex = 10;
            this.addPs4.UseVisualStyleBackColor = false;
            this.addPs4.Click += new System.EventHandler(this.addPs4_Click);
            // 
            // myListTab
            // 
            this.myListTab.AutoScroll = true;
            this.myListTab.BackColor = System.Drawing.Color.White;
            this.myListTab.Location = new System.Drawing.Point(4, 4);
            this.myListTab.Margin = new System.Windows.Forms.Padding(2);
            this.myListTab.Name = "myListTab";
            this.myListTab.Padding = new System.Windows.Forms.Padding(2);
            this.myListTab.Size = new System.Drawing.Size(1013, 574);
            this.myListTab.TabIndex = 1;
            this.myListTab.Text = "tabPage2";
            // 
            // addGames
            // 
            this.addGames.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addGames.BackColor = System.Drawing.Color.White;
            this.addGames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGames.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGames.Location = new System.Drawing.Point(243, 702);
            this.addGames.Name = "addGames";
            this.addGames.Size = new System.Drawing.Size(189, 39);
            this.addGames.TabIndex = 5;
            this.addGames.Text = "ADD GAMES";
            this.addGames.UseVisualStyleBackColor = false;
            this.addGames.Click += new System.EventHandler(this.addGames_Click);
            // 
            // myList
            // 
            this.myList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.myList.BackColor = System.Drawing.Color.White;
            this.myList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myList.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myList.Location = new System.Drawing.Point(603, 702);
            this.myList.Name = "myList";
            this.myList.Size = new System.Drawing.Size(189, 39);
            this.myList.TabIndex = 6;
            this.myList.Text = "MY LIST";
            this.myList.UseVisualStyleBackColor = false;
            this.myList.Click += new System.EventHandler(this.myList_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.label1.Location = new System.Drawing.Point(435, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "CheckMyGames";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackgroundImage = global::CheckMyGames.Properties.Resources.minimize;
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Location = new System.Drawing.Point(934, 4);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(30, 30);
            this.minimizeBtn.TabIndex = 4;
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackgroundImage = global::CheckMyGames.Properties.Resources.maximize;
            this.maximizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizeBtn.FlatAppearance.BorderSize = 0;
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.Location = new System.Drawing.Point(970, 4);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(30, 30);
            this.maximizeBtn.TabIndex = 3;
            this.maximizeBtn.UseVisualStyleBackColor = true;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackgroundImage = global::CheckMyGames.Properties.Resources.close;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(1006, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(-11, 693);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1054, 56);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sortBox
            // 
            this.sortBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sortBox.BackColor = System.Drawing.Color.AliceBlue;
            this.sortBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBox.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
            "Name (A-Z)",
            "Name (Z-A)",
            "Platform (A-Z)",
            "Platform (Z-A)"});
            this.sortBox.Location = new System.Drawing.Point(821, 62);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(189, 35);
            this.sortBox.TabIndex = 11;
            this.sortBox.SelectedIndexChanged += new System.EventHandler(this.sortBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.label2.Location = new System.Drawing.Point(730, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Sort by:";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.BackColor = System.Drawing.Color.White;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(295, 59);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(189, 39);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBox.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.searchBox.Location = new System.Drawing.Point(12, 58);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(262, 41);
            this.searchBox.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 748);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myList);
            this.Controls.Add(this.addGames);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.maximizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.myTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.myTab.ResumeLayout(false);
            this.addGamesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl myTab;
        private System.Windows.Forms.TabPage addGamesTab;
        private System.Windows.Forms.TabPage myListTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button maximizeBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button addGames;
        private System.Windows.Forms.Button myList;
        private System.Windows.Forms.Button addSwitch;
        private System.Windows.Forms.Button addXOne;
        private System.Windows.Forms.Button addPs4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPs1;
        private System.Windows.Forms.Button addPs2;
        private System.Windows.Forms.Button addPs3;
        private System.Windows.Forms.Button addWiiU;
        private System.Windows.Forms.Button addWii;
        private System.Windows.Forms.Button addGC;
        private System.Windows.Forms.Button addN64;
        private System.Windows.Forms.Button addSnes;
        private System.Windows.Forms.Button addNes;
        private System.Windows.Forms.Button addX360;
        private System.Windows.Forms.Button addX1;
        private System.Windows.Forms.Button addEpicGames;
        private System.Windows.Forms.Button addSteam;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
    }
}

