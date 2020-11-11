namespace US_Codestitution
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.YesVote = new System.Windows.Forms.Button();
            this.NoVote = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InputPicture = new System.Windows.Forms.PictureBox();
            this.ScoreCount1 = new System.Windows.Forms.Label();
            this.ScoreCount2 = new System.Windows.Forms.Label();
            this.Vote = new System.Windows.Forms.GroupBox();
            this.SSIDBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SSIDNumberLable = new System.Windows.Forms.Label();
            this.SSIDFirstNameLable = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.GroupBox();
            this.DLIDNumberLable = new System.Windows.Forms.Label();
            this.DLGenderLable = new System.Windows.Forms.Label();
            this.DLStateLable = new System.Windows.Forms.Label();
            this.DLZipLable = new System.Windows.Forms.Label();
            this.DLCityLable = new System.Windows.Forms.Label();
            this.DLLastNameLable = new System.Windows.Forms.Label();
            this.DLFirstNameLable = new System.Windows.Forms.Label();
            this.DriversLicensePicture = new System.Windows.Forms.PictureBox();
            this.BallotBox = new System.Windows.Forms.GroupBox();
            this.Address2Lable = new System.Windows.Forms.Label();
            this.AddressLable1 = new System.Windows.Forms.Label();
            this.SSNLable = new System.Windows.Forms.Label();
            this.StateLable = new System.Windows.Forms.Label();
            this.ZipLable = new System.Windows.Forms.Label();
            this.LastNameLable = new System.Windows.Forms.Label();
            this.CityLable = new System.Windows.Forms.Label();
            this.FirstNameLable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timerBar = new System.Windows.Forms.ProgressBar();
            this.lblQuota = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputPicture)).BeginInit();
            this.Vote.SuspendLayout();
            this.SSIDBox.SuspendLayout();
            this.IDBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriversLicensePicture)).BeginInit();
            this.BallotBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // YesVote
            // 
            this.YesVote.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YesVote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YesVote.BackgroundImage")));
            this.YesVote.Location = new System.Drawing.Point(62, 28);
            this.YesVote.Name = "YesVote";
            this.YesVote.Size = new System.Drawing.Size(75, 50);
            this.YesVote.TabIndex = 0;
            this.YesVote.UseVisualStyleBackColor = false;
            this.YesVote.Click += new System.EventHandler(this.YesVote_Click);
            this.YesVote.MouseLeave += new System.EventHandler(this.YesVoteLeave);
            this.YesVote.MouseHover += new System.EventHandler(this.YesVoteHover);
            // 
            // NoVote
            // 
            this.NoVote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NoVote.BackgroundImage")));
            this.NoVote.Location = new System.Drawing.Point(207, 28);
            this.NoVote.Name = "NoVote";
            this.NoVote.Size = new System.Drawing.Size(75, 50);
            this.NoVote.TabIndex = 1;
            this.NoVote.UseVisualStyleBackColor = true;
            this.NoVote.Click += new System.EventHandler(this.NoVote_Click);
            this.NoVote.MouseLeave += new System.EventHandler(this.NoVoteLeave);
            this.NoVote.MouseHover += new System.EventHandler(this.NoVoteHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // InputPicture
            // 
            this.InputPicture.BackColor = System.Drawing.Color.Silver;
            this.InputPicture.Image = ((System.Drawing.Image)(resources.GetObject("InputPicture.Image")));
            this.InputPicture.Location = new System.Drawing.Point(117, 24);
            this.InputPicture.Name = "InputPicture";
            this.InputPicture.Size = new System.Drawing.Size(225, 225);
            this.InputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.InputPicture.TabIndex = 3;
            this.InputPicture.TabStop = false;
            // 
            // ScoreCount1
            // 
            this.ScoreCount1.AutoSize = true;
            this.ScoreCount1.Location = new System.Drawing.Point(84, 14);
            this.ScoreCount1.Name = "ScoreCount1";
            this.ScoreCount1.Size = new System.Drawing.Size(13, 13);
            this.ScoreCount1.TabIndex = 5;
            this.ScoreCount1.Text = "0";
            // 
            // ScoreCount2
            // 
            this.ScoreCount2.AutoSize = true;
            this.ScoreCount2.Location = new System.Drawing.Point(84, 42);
            this.ScoreCount2.Name = "ScoreCount2";
            this.ScoreCount2.Size = new System.Drawing.Size(13, 13);
            this.ScoreCount2.TabIndex = 6;
            this.ScoreCount2.Text = "0";
            // 
            // Vote
            // 
            this.Vote.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Vote.Controls.Add(this.YesVote);
            this.Vote.Controls.Add(this.NoVote);
            this.Vote.Location = new System.Drawing.Point(448, 37);
            this.Vote.Name = "Vote";
            this.Vote.Size = new System.Drawing.Size(343, 100);
            this.Vote.TabIndex = 7;
            this.Vote.TabStop = false;
            this.Vote.Text = "Accent/Decent";
            // 
            // SSIDBox
            // 
            this.SSIDBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SSIDBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SSIDBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SSIDBox.BackgroundImage")));
            this.SSIDBox.Controls.Add(this.label1);
            this.SSIDBox.Controls.Add(this.SSIDNumberLable);
            this.SSIDBox.Controls.Add(this.SSIDFirstNameLable);
            this.SSIDBox.Location = new System.Drawing.Point(646, 322);
            this.SSIDBox.Name = "SSIDBox";
            this.SSIDBox.Size = new System.Drawing.Size(567, 310);
            this.SSIDBox.TabIndex = 10;
            this.SSIDBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alexander Hamilton";
            // 
            // SSIDNumberLable
            // 
            this.SSIDNumberLable.AutoSize = true;
            this.SSIDNumberLable.Location = new System.Drawing.Point(261, 173);
            this.SSIDNumberLable.Name = "SSIDNumberLable";
            this.SSIDNumberLable.Size = new System.Drawing.Size(58, 13);
            this.SSIDNumberLable.TabIndex = 1;
            this.SSIDNumberLable.Text = "ID Number";
            // 
            // SSIDFirstNameLable
            // 
            this.SSIDFirstNameLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SSIDFirstNameLable.AutoSize = true;
            this.SSIDFirstNameLable.Location = new System.Drawing.Point(262, 121);
            this.SSIDFirstNameLable.Name = "SSIDFirstNameLable";
            this.SSIDFirstNameLable.Size = new System.Drawing.Size(54, 13);
            this.SSIDFirstNameLable.TabIndex = 0;
            this.SSIDFirstNameLable.Text = "Full Name";
            this.SSIDFirstNameLable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // IDBox
            // 
            this.IDBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.IDBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IDBox.BackgroundImage")));
            this.IDBox.Controls.Add(this.DLIDNumberLable);
            this.IDBox.Controls.Add(this.DLGenderLable);
            this.IDBox.Controls.Add(this.DLStateLable);
            this.IDBox.Controls.Add(this.DLZipLable);
            this.IDBox.Controls.Add(this.DLCityLable);
            this.IDBox.Controls.Add(this.DLLastNameLable);
            this.IDBox.Controls.Add(this.DLFirstNameLable);
            this.IDBox.Controls.Add(this.DriversLicensePicture);
            this.IDBox.Location = new System.Drawing.Point(12, 322);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(619, 318);
            this.IDBox.TabIndex = 8;
            this.IDBox.TabStop = false;
            this.IDBox.Text = "ID";
            // 
            // DLIDNumberLable
            // 
            this.DLIDNumberLable.AutoSize = true;
            this.DLIDNumberLable.Location = new System.Drawing.Point(392, 219);
            this.DLIDNumberLable.Name = "DLIDNumberLable";
            this.DLIDNumberLable.Size = new System.Drawing.Size(58, 13);
            this.DLIDNumberLable.TabIndex = 7;
            this.DLIDNumberLable.Text = "ID Number";
            // 
            // DLGenderLable
            // 
            this.DLGenderLable.AutoSize = true;
            this.DLGenderLable.Location = new System.Drawing.Point(362, 219);
            this.DLGenderLable.Name = "DLGenderLable";
            this.DLGenderLable.Size = new System.Drawing.Size(15, 13);
            this.DLGenderLable.TabIndex = 6;
            this.DLGenderLable.Text = "G";
            // 
            // DLStateLable
            // 
            this.DLStateLable.AutoSize = true;
            this.DLStateLable.Location = new System.Drawing.Point(300, 221);
            this.DLStateLable.Name = "DLStateLable";
            this.DLStateLable.Size = new System.Drawing.Size(17, 13);
            this.DLStateLable.TabIndex = 5;
            this.DLStateLable.Text = "St";
            // 
            // DLZipLable
            // 
            this.DLZipLable.AutoSize = true;
            this.DLZipLable.Location = new System.Drawing.Point(230, 219);
            this.DLZipLable.Name = "DLZipLable";
            this.DLZipLable.Size = new System.Drawing.Size(22, 13);
            this.DLZipLable.TabIndex = 4;
            this.DLZipLable.Text = "Zip";
            // 
            // DLCityLable
            // 
            this.DLCityLable.AutoSize = true;
            this.DLCityLable.Location = new System.Drawing.Point(236, 183);
            this.DLCityLable.Name = "DLCityLable";
            this.DLCityLable.Size = new System.Drawing.Size(35, 13);
            this.DLCityLable.TabIndex = 3;
            this.DLCityLable.Text = "label1";
            // 
            // DLLastNameLable
            // 
            this.DLLastNameLable.AutoSize = true;
            this.DLLastNameLable.Location = new System.Drawing.Point(273, 144);
            this.DLLastNameLable.Name = "DLLastNameLable";
            this.DLLastNameLable.Size = new System.Drawing.Size(58, 13);
            this.DLLastNameLable.TabIndex = 2;
            this.DLLastNameLable.Text = "Last Name";
            // 
            // DLFirstNameLable
            // 
            this.DLFirstNameLable.AutoSize = true;
            this.DLFirstNameLable.Location = new System.Drawing.Point(272, 109);
            this.DLFirstNameLable.Name = "DLFirstNameLable";
            this.DLFirstNameLable.Size = new System.Drawing.Size(57, 13);
            this.DLFirstNameLable.TabIndex = 1;
            this.DLFirstNameLable.Text = "First Name";
            // 
            // DriversLicensePicture
            // 
            this.DriversLicensePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DriversLicensePicture.Image = ((System.Drawing.Image)(resources.GetObject("DriversLicensePicture.Image")));
            this.DriversLicensePicture.Location = new System.Drawing.Point(6, 91);
            this.DriversLicensePicture.Name = "DriversLicensePicture";
            this.DriversLicensePicture.Size = new System.Drawing.Size(178, 209);
            this.DriversLicensePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DriversLicensePicture.TabIndex = 0;
            this.DriversLicensePicture.TabStop = false;
            // 
            // BallotBox
            // 
            this.BallotBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BallotBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BallotBox.BackgroundImage")));
            this.BallotBox.Controls.Add(this.Address2Lable);
            this.BallotBox.Controls.Add(this.AddressLable1);
            this.BallotBox.Controls.Add(this.SSNLable);
            this.BallotBox.Controls.Add(this.StateLable);
            this.BallotBox.Controls.Add(this.ZipLable);
            this.BallotBox.Controls.Add(this.LastNameLable);
            this.BallotBox.Controls.Add(this.CityLable);
            this.BallotBox.Controls.Add(this.FirstNameLable);
            this.BallotBox.Location = new System.Drawing.Point(448, 170);
            this.BallotBox.Name = "BallotBox";
            this.BallotBox.Size = new System.Drawing.Size(442, 132);
            this.BallotBox.TabIndex = 11;
            this.BallotBox.TabStop = false;
            // 
            // Address2Lable
            // 
            this.Address2Lable.AutoSize = true;
            this.Address2Lable.Location = new System.Drawing.Point(102, 99);
            this.Address2Lable.Name = "Address2Lable";
            this.Address2Lable.Size = new System.Drawing.Size(77, 13);
            this.Address2Lable.TabIndex = 7;
            this.Address2Lable.Text = "Address Line 2";
            // 
            // AddressLable1
            // 
            this.AddressLable1.AutoSize = true;
            this.AddressLable1.Location = new System.Drawing.Point(101, 83);
            this.AddressLable1.Name = "AddressLable1";
            this.AddressLable1.Size = new System.Drawing.Size(77, 13);
            this.AddressLable1.TabIndex = 6;
            this.AddressLable1.Text = "Address Line 1";
            // 
            // SSNLable
            // 
            this.SSNLable.AutoSize = true;
            this.SSNLable.Location = new System.Drawing.Point(163, 67);
            this.SSNLable.Name = "SSNLable";
            this.SSNLable.Size = new System.Drawing.Size(29, 13);
            this.SSNLable.TabIndex = 5;
            this.SSNLable.Text = "SSN";
            // 
            // StateLable
            // 
            this.StateLable.AutoSize = true;
            this.StateLable.Location = new System.Drawing.Point(401, 51);
            this.StateLable.Name = "StateLable";
            this.StateLable.Size = new System.Drawing.Size(32, 13);
            this.StateLable.TabIndex = 4;
            this.StateLable.Text = "State";
            // 
            // ZipLable
            // 
            this.ZipLable.AutoSize = true;
            this.ZipLable.Location = new System.Drawing.Point(233, 51);
            this.ZipLable.Name = "ZipLable";
            this.ZipLable.Size = new System.Drawing.Size(22, 13);
            this.ZipLable.TabIndex = 3;
            this.ZipLable.Text = "Zip";
            // 
            // LastNameLable
            // 
            this.LastNameLable.AutoSize = true;
            this.LastNameLable.Location = new System.Drawing.Point(49, 51);
            this.LastNameLable.Name = "LastNameLable";
            this.LastNameLable.Size = new System.Drawing.Size(58, 13);
            this.LastNameLable.TabIndex = 2;
            this.LastNameLable.Text = "Last Name";
            // 
            // CityLable
            // 
            this.CityLable.AutoSize = true;
            this.CityLable.Location = new System.Drawing.Point(243, 34);
            this.CityLable.Name = "CityLable";
            this.CityLable.Size = new System.Drawing.Size(24, 13);
            this.CityLable.TabIndex = 1;
            this.CityLable.Text = "City";
            // 
            // FirstNameLable
            // 
            this.FirstNameLable.AutoSize = true;
            this.FirstNameLable.Location = new System.Drawing.Point(48, 34);
            this.FirstNameLable.Name = "FirstNameLable";
            this.FirstNameLable.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLable.TabIndex = 0;
            this.FirstNameLable.Text = "First Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add( this.lblQuota );
            this.groupBox1.Controls.Add( this.label4 );
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ScoreCount2);
            this.groupBox1.Controls.Add( this.ScoreCount1 );
            this.groupBox1.Location = new System.Drawing.Point( 808, 37 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 157, 100 );
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 31, 70 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 39, 13 );
            this.label4.TabIndex = 9;
            this.label4.Text = "Quota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Incorrect:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Correct:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(910, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 96);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(121, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseLeave += new System.EventHandler(this.Mute_Leave);
            this.button2.MouseHover += new System.EventHandler(this.Mute_Hover);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(24, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.reset_click);
            this.button1.MouseLeave += new System.EventHandler(this.Reset_Leave);
            this.button1.MouseHover += new System.EventHandler(this.Reset_Hover);
            // 
            // timerBar
            // 
            this.timerBar.Location = new System.Drawing.Point( 0, 299 );
            this.timerBar.Name = "timerBar";
            this.timerBar.Size = new System.Drawing.Size( 421, 23 );
            this.timerBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.timerBar.TabIndex = 14;
            // 
            // lblQuota
            // 
            this.lblQuota.AutoSize = true;
            this.lblQuota.Location = new System.Drawing.Point( 84, 70 );
            this.lblQuota.Name = "lblQuota";
            this.lblQuota.Size = new System.Drawing.Size( 19, 13 );
            this.lblQuota.TabIndex = 10;
            this.lblQuota.Text = "30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 652);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BallotBox);
            this.Controls.Add(this.InputPicture);
            this.Controls.Add(this.SSIDBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.Vote);
            this.Controls.Add( this.timerBar );
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputPicture)).EndInit();
            this.Vote.ResumeLayout(false);
            this.SSIDBox.ResumeLayout(false);
            this.SSIDBox.PerformLayout();
            this.IDBox.ResumeLayout(false);
            this.IDBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriversLicensePicture)).EndInit();
            this.BallotBox.ResumeLayout(false);
            this.BallotBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YesVote;
        private System.Windows.Forms.Button NoVote;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox InputPicture;
        private System.Windows.Forms.Label ScoreCount1;
        private System.Windows.Forms.Label ScoreCount2;
        private System.Windows.Forms.GroupBox Vote;
        private System.Windows.Forms.GroupBox IDBox;
        private System.Windows.Forms.GroupBox BallotBox;
        private System.Windows.Forms.Label ZipLable;
        private System.Windows.Forms.Label LastNameLable;
        private System.Windows.Forms.Label CityLable;
        private System.Windows.Forms.Label FirstNameLable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label AddressLable1;
        private System.Windows.Forms.Label SSNLable;
        private System.Windows.Forms.Label StateLable;
        private System.Windows.Forms.Label Address2Lable;
        private System.Windows.Forms.Label DLGenderLable;
        private System.Windows.Forms.Label DLStateLable;
        private System.Windows.Forms.Label DLZipLable;
        private System.Windows.Forms.Label DLCityLable;
        private System.Windows.Forms.Label DLLastNameLable;
        private System.Windows.Forms.Label DLFirstNameLable;
        private System.Windows.Forms.PictureBox DriversLicensePicture;
        private System.Windows.Forms.Label DLIDNumberLable;
        private System.Windows.Forms.GroupBox SSIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SSIDNumberLable;
        private System.Windows.Forms.Label SSIDFirstNameLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar timerBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuota;
    }
}

