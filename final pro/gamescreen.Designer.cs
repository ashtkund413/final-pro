namespace final_pro
{
    partial class gamescreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.health = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.BackColor = System.Drawing.Color.Transparent;
            this.health.ForeColor = System.Drawing.Color.Lime;
            this.health.Location = new System.Drawing.Point(50, 15);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(13, 13);
            this.health.TabIndex = 0;
            this.health.Text = "3";
 
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "health";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.ForeColor = System.Drawing.Color.Transparent;
            this.score.Location = new System.Drawing.Point(435, 15);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(35, 13);
            this.score.TabIndex = 2;
            this.score.Text = "label2";
            // 
            // gamescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::final_pro.Properties.Resources.game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.health);
            this.DoubleBuffered = true;
            this.Name = "gamescreen";
            this.Size = new System.Drawing.Size(492, 365);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gamescreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamescreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gamescreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
    }
}
