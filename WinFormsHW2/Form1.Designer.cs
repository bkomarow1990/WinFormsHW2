
namespace WinFormsHW2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.startbtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.leftbtn = new System.Windows.Forms.Button();
            this.rightbtn = new System.Windows.Forms.Button();
            this.upbtn = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.PictureBox();
            this.scorelbl = new System.Windows.Forms.Label();
            this.money_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::WinFormsHW2.Properties.Resources.goat_PNG13151__1_;
            this.player.InitialImage = ((System.Drawing.Image)(resources.GetObject("player.InitialImage")));
            this.player.Location = new System.Drawing.Point(-16, 484);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(221, 146);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(500, 12);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(94, 29);
            this.startbtn.TabIndex = 1;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.Location = new System.Drawing.Point(693, 12);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(94, 29);
            this.stopbtn.TabIndex = 2;
            this.stopbtn.Text = "Stop";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // leftbtn
            // 
            this.leftbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leftbtn.Location = new System.Drawing.Point(538, 556);
            this.leftbtn.Name = "leftbtn";
            this.leftbtn.Size = new System.Drawing.Size(56, 47);
            this.leftbtn.TabIndex = 3;
            this.leftbtn.Text = "<";
            this.leftbtn.UseVisualStyleBackColor = true;
            this.leftbtn.Click += new System.EventHandler(this.leftbtn_Click);
            // 
            // rightbtn
            // 
            this.rightbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rightbtn.Location = new System.Drawing.Point(677, 556);
            this.rightbtn.Name = "rightbtn";
            this.rightbtn.Size = new System.Drawing.Size(56, 47);
            this.rightbtn.TabIndex = 4;
            this.rightbtn.Text = ">";
            this.rightbtn.UseVisualStyleBackColor = true;
            this.rightbtn.Click += new System.EventHandler(this.rightbtn_Click);
            // 
            // upbtn
            // 
            this.upbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.upbtn.Location = new System.Drawing.Point(609, 484);
            this.upbtn.Name = "upbtn";
            this.upbtn.Size = new System.Drawing.Size(56, 47);
            this.upbtn.TabIndex = 5;
            this.upbtn.Text = "^";
            this.upbtn.UseVisualStyleBackColor = true;
            this.upbtn.Click += new System.EventHandler(this.upbtn_Click);
            // 
            // money
            // 
            this.money.BackColor = System.Drawing.Color.Transparent;
            this.money.BackgroundImage = global::WinFormsHW2.Properties.Resources.coin_PNG36879;
            this.money.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.money.InitialImage = ((System.Drawing.Image)(resources.GetObject("money.InitialImage")));
            this.money.Location = new System.Drawing.Point(107, 12);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(88, 85);
            this.money.TabIndex = 6;
            this.money.TabStop = false;
            this.money.LocationChanged += new System.EventHandler(this.money_LocationChanged);
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scorelbl.Location = new System.Drawing.Point(1165, 12);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(99, 31);
            this.scorelbl.TabIndex = 7;
            this.scorelbl.Text = "Score : 0";
            // 
            // money_timer
            // 
            this.money_timer.Interval = 300;
            this.money_timer.Tick += new System.EventHandler(this.money_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 625);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.money);
            this.Controls.Add(this.upbtn);
            this.Controls.Add(this.rightbtn);
            this.Controls.Add(this.leftbtn);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Button leftbtn;
        private System.Windows.Forms.Button rightbtn;
        private System.Windows.Forms.Button upbtn;
        private System.Windows.Forms.PictureBox money;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Timer money_timer;
    }
}

