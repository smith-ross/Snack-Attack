namespace Snack_Attack
{
    partial class game
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.FoodSpawn = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.Tooth5 = new System.Windows.Forms.PictureBox();
            this.Tooth4 = new System.Windows.Forms.PictureBox();
            this.Tooth3 = new System.Windows.Forms.PictureBox();
            this.Tooth2 = new System.Windows.Forms.PictureBox();
            this.Tooth1 = new System.Windows.Forms.PictureBox();
            this.objectTemplate = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Character = new System.Windows.Forms.PictureBox();
            this.GameOverBG = new System.Windows.Forms.PictureBox();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.teethAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tooth5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tooth4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tooth3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tooth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tooth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverBG)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 10;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // FoodSpawn
            // 
            this.FoodSpawn.Enabled = true;
            this.FoodSpawn.Interval = 1000;
            this.FoodSpawn.Tick += new System.EventHandler(this.FoodSpawn_Tick);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.DarkGreen;
            this.Score.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.Control;
            this.Score.Location = new System.Drawing.Point(293, 531);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(85, 16);
            this.Score.TabIndex = 3;
            this.Score.Text = "SCORE : 0";
            // 
            // Tooth5
            // 
            this.Tooth5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tooth5.BackgroundImage = global::Snack_Attack.Properties.Resources.Tooth;
            this.Tooth5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tooth5.ImageLocation = "";
            this.Tooth5.Location = new System.Drawing.Point(180, 12);
            this.Tooth5.Name = "Tooth5";
            this.Tooth5.Size = new System.Drawing.Size(36, 34);
            this.Tooth5.TabIndex = 8;
            this.Tooth5.TabStop = false;
            // 
            // Tooth4
            // 
            this.Tooth4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tooth4.BackgroundImage = global::Snack_Attack.Properties.Resources.Tooth;
            this.Tooth4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tooth4.ImageLocation = "";
            this.Tooth4.Location = new System.Drawing.Point(138, 12);
            this.Tooth4.Name = "Tooth4";
            this.Tooth4.Size = new System.Drawing.Size(36, 34);
            this.Tooth4.TabIndex = 7;
            this.Tooth4.TabStop = false;
            // 
            // Tooth3
            // 
            this.Tooth3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tooth3.BackgroundImage = global::Snack_Attack.Properties.Resources.Tooth;
            this.Tooth3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tooth3.ImageLocation = "";
            this.Tooth3.Location = new System.Drawing.Point(96, 12);
            this.Tooth3.Name = "Tooth3";
            this.Tooth3.Size = new System.Drawing.Size(36, 34);
            this.Tooth3.TabIndex = 6;
            this.Tooth3.TabStop = false;
            // 
            // Tooth2
            // 
            this.Tooth2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tooth2.BackgroundImage = global::Snack_Attack.Properties.Resources.Tooth;
            this.Tooth2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tooth2.ImageLocation = "";
            this.Tooth2.Location = new System.Drawing.Point(54, 12);
            this.Tooth2.Name = "Tooth2";
            this.Tooth2.Size = new System.Drawing.Size(36, 34);
            this.Tooth2.TabIndex = 5;
            this.Tooth2.TabStop = false;
            // 
            // Tooth1
            // 
            this.Tooth1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tooth1.BackgroundImage = global::Snack_Attack.Properties.Resources.Tooth;
            this.Tooth1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tooth1.ImageLocation = "";
            this.Tooth1.Location = new System.Drawing.Point(12, 12);
            this.Tooth1.Name = "Tooth1";
            this.Tooth1.Size = new System.Drawing.Size(36, 34);
            this.Tooth1.TabIndex = 4;
            this.Tooth1.TabStop = false;
            // 
            // objectTemplate
            // 
            this.objectTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objectTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.objectTemplate.ImageLocation = "";
            this.objectTemplate.Location = new System.Drawing.Point(694, 49);
            this.objectTemplate.Name = "objectTemplate";
            this.objectTemplate.Size = new System.Drawing.Size(83, 79);
            this.objectTemplate.TabIndex = 2;
            this.objectTemplate.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.DarkGreen;
            this.Ground.Location = new System.Drawing.Point(-3, 516);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(683, 108);
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // Character
            // 
            this.Character.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Character.BackgroundImage = global::Snack_Attack.Properties.Resources.Basket;
            this.Character.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Character.ImageLocation = "";
            this.Character.Location = new System.Drawing.Point(293, 445);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(83, 79);
            this.Character.TabIndex = 1;
            this.Character.TabStop = false;
            // 
            // GameOverBG
            // 
            this.GameOverBG.BackgroundImage = global::Snack_Attack.Properties.Resources.gameOver;
            this.GameOverBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameOverBG.Location = new System.Drawing.Point(107, 141);
            this.GameOverBG.Name = "GameOverBG";
            this.GameOverBG.Size = new System.Drawing.Size(454, 260);
            this.GameOverBG.TabIndex = 10;
            this.GameOverBG.TabStop = false;
            this.GameOverBG.Visible = false;
            // 
            // RestartBtn
            // 
            this.RestartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RestartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartBtn.Location = new System.Drawing.Point(194, 220);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(284, 74);
            this.RestartBtn.TabIndex = 11;
            this.RestartBtn.Text = "RESTART";
            this.RestartBtn.UseVisualStyleBackColor = false;
            this.RestartBtn.Visible = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(233, 300);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(212, 57);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Visible = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // teethAmount
            // 
            this.teethAmount.AutoSize = true;
            this.teethAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.teethAmount.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teethAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.teethAmount.Location = new System.Drawing.Point(93, 49);
            this.teethAmount.Name = "teethAmount";
            this.teethAmount.Size = new System.Drawing.Size(45, 16);
            this.teethAmount.TabIndex = 9;
            this.teethAmount.Text = "5 / 5";
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(683, 593);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.GameOverBG);
            this.Controls.Add(this.teethAmount);
            this.Controls.Add(this.Tooth5);
            this.Controls.Add(this.Tooth4);
            this.Controls.Add(this.Tooth3);
            this.Controls.Add(this.Tooth2);
            this.Controls.Add(this.Tooth1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.objectTemplate);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Character);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "game";
            this.Text = "Snack Attack!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Tooth5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tooth4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tooth3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tooth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tooth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Character;
        private System.Windows.Forms.PictureBox objectTemplate;
        private System.Windows.Forms.Timer FoodSpawn;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox Tooth1;
        private System.Windows.Forms.PictureBox Tooth2;
        private System.Windows.Forms.PictureBox Tooth3;
        private System.Windows.Forms.PictureBox Tooth4;
        private System.Windows.Forms.PictureBox Tooth5;
        private System.Windows.Forms.PictureBox GameOverBG;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label teethAmount;
    }
}

