namespace FlappyBirdGame
{
    partial class FormFlappyBird
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFlappyBird));
            PicBxPipeUp = new PictureBox();
            PicBxPipeDown = new PictureBox();
            PicBxBird = new PictureBox();
            PicBxGround = new PictureBox();
            LbScore = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            PicBxRestart = new PictureBox();
            BtnStartGame = new Button();
            LbInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)PicBxPipeUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBxPipeDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBxBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBxGround).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBxRestart).BeginInit();
            SuspendLayout();
            // 
            // PicBxPipeUp
            // 
            PicBxPipeUp.Image = Properties.Resources.PipeUp;
            PicBxPipeUp.Location = new Point(688, 0);
            PicBxPipeUp.Margin = new Padding(4);
            PicBxPipeUp.Name = "PicBxPipeUp";
            PicBxPipeUp.Size = new Size(100, 262);
            PicBxPipeUp.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBxPipeUp.TabIndex = 0;
            PicBxPipeUp.TabStop = false;
            // 
            // PicBxPipeDown
            // 
            PicBxPipeDown.Image = Properties.Resources.PipeDown;
            PicBxPipeDown.Location = new Point(500, 486);
            PicBxPipeDown.Margin = new Padding(4);
            PicBxPipeDown.Name = "PicBxPipeDown";
            PicBxPipeDown.Size = new Size(100, 262);
            PicBxPipeDown.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBxPipeDown.TabIndex = 1;
            PicBxPipeDown.TabStop = false;
            // 
            // PicBxBird
            // 
            PicBxBird.Image = Properties.Resources.Bird;
            PicBxBird.Location = new Point(62, 312);
            PicBxBird.Margin = new Padding(4);
            PicBxBird.Name = "PicBxBird";
            PicBxBird.Size = new Size(88, 88);
            PicBxBird.SizeMode = PictureBoxSizeMode.Zoom;
            PicBxBird.TabIndex = 2;
            PicBxBird.TabStop = false;
            // 
            // PicBxGround
            // 
            PicBxGround.Anchor = AnchorStyles.Bottom;
            PicBxGround.BackColor = Color.Transparent;
            PicBxGround.BackgroundImage = Properties.Resources.Ground;
            PicBxGround.Location = new Point(1, 736);
            PicBxGround.Margin = new Padding(4);
            PicBxGround.Name = "PicBxGround";
            PicBxGround.Size = new Size(852, 78);
            PicBxGround.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBxGround.TabIndex = 3;
            PicBxGround.TabStop = false;
            // 
            // LbScore
            // 
            LbScore.AutoSize = true;
            LbScore.BackColor = Color.Transparent;
            LbScore.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbScore.Location = new Point(14, 768);
            LbScore.Margin = new Padding(4, 0, 4, 0);
            LbScore.Name = "LbScore";
            LbScore.Size = new Size(121, 38);
            LbScore.TabIndex = 4;
            LbScore.Text = "Score: 0";
            LbScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // PicBxRestart
            // 
            PicBxRestart.Cursor = Cursors.Hand;
            PicBxRestart.Image = Properties.Resources.RestartLollipop;
            PicBxRestart.Location = new Point(364, 290);
            PicBxRestart.Margin = new Padding(4);
            PicBxRestart.Name = "PicBxRestart";
            PicBxRestart.Size = new Size(125, 125);
            PicBxRestart.SizeMode = PictureBoxSizeMode.Zoom;
            PicBxRestart.TabIndex = 5;
            PicBxRestart.TabStop = false;
            PicBxRestart.Visible = false;
            PicBxRestart.Click += PicBxBtnStart_Click;
            // 
            // BtnStartGame
            // 
            BtnStartGame.BackColor = Color.Plum;
            BtnStartGame.Cursor = Cursors.Hand;
            BtnStartGame.FlatStyle = FlatStyle.Popup;
            BtnStartGame.Font = new Font("Chicle", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnStartGame.ForeColor = Color.Firebrick;
            BtnStartGame.Location = new Point(331, 12);
            BtnStartGame.Name = "BtnStartGame";
            BtnStartGame.Size = new Size(190, 50);
            BtnStartGame.TabIndex = 1;
            BtnStartGame.Text = "Start Game";
            BtnStartGame.UseVisualStyleBackColor = false;
            BtnStartGame.Click += PicBxBtnStart_Click;
            // 
            // LbInfo
            // 
            LbInfo.AutoSize = true;
            LbInfo.BackColor = Color.Peru;
            LbInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LbInfo.Location = new Point(620, 781);
            LbInfo.Name = "LbInfo";
            LbInfo.Size = new Size(229, 25);
            LbInfo.TabIndex = 0;
            LbInfo.Text = "Use Spacebar Key To Play";
            // 
            // FormFlappyBird
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(852, 816);
            Controls.Add(LbInfo);
            Controls.Add(BtnStartGame);
            Controls.Add(PicBxRestart);
            Controls.Add(LbScore);
            Controls.Add(PicBxGround);
            Controls.Add(PicBxBird);
            Controls.Add(PicBxPipeDown);
            Controls.Add(PicBxPipeUp);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormFlappyBird";
            Text = " Flappy Bird Game";
            Load += FormFlappyBird_Load;
            KeyDown += FormFlappyBird_KeyDown;
            KeyUp += FormFlappyBird_KeyUp;
            ((System.ComponentModel.ISupportInitialize)PicBxPipeUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBxPipeDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBxBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBxGround).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBxRestart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PicBxPipeUp;
        private PictureBox PicBxPipeDown;
        private PictureBox PicBxBird;
        private PictureBox PicBxGround;
        private Label LbScore;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox PicBxRestart;
        private Button BtnStartGame;
        private Label LbInfo;
    }
}
