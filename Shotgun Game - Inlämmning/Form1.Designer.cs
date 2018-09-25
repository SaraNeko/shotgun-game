namespace Shotgun_Game___Inlämmning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonShoot = new System.Windows.Forms.Button();
            this.buttonBlock = new System.Windows.Forms.Button();
            this.buttonShootShotgun = new System.Windows.Forms.Button();
            this.textBoxUserBulletsLoaded = new System.Windows.Forms.TextBox();
            this.textBoxComputerBulletsLoaded = new System.Windows.Forms.TextBox();
            this.textBoxUserPreviousMove = new System.Windows.Forms.TextBox();
            this.textBoxComputerPreviousMove = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(235, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opponent";
            // 
            // buttonReload
            // 
            this.buttonReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonReload.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReload.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonReload.Location = new System.Drawing.Point(17, 170);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(81, 31);
            this.buttonReload.TabIndex = 2;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonShoot
            // 
            this.buttonShoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonShoot.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShoot.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonShoot.Location = new System.Drawing.Point(104, 170);
            this.buttonShoot.Name = "buttonShoot";
            this.buttonShoot.Size = new System.Drawing.Size(81, 31);
            this.buttonShoot.TabIndex = 3;
            this.buttonShoot.Text = "Shoot";
            this.buttonShoot.UseVisualStyleBackColor = false;
            this.buttonShoot.Click += new System.EventHandler(this.buttonShoot_Click);
            // 
            // buttonBlock
            // 
            this.buttonBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBlock.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlock.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonBlock.Location = new System.Drawing.Point(191, 170);
            this.buttonBlock.Name = "buttonBlock";
            this.buttonBlock.Size = new System.Drawing.Size(81, 31);
            this.buttonBlock.TabIndex = 4;
            this.buttonBlock.Text = "Block";
            this.buttonBlock.UseVisualStyleBackColor = false;
            this.buttonBlock.Click += new System.EventHandler(this.buttonBlock_Click);
            // 
            // buttonShootShotgun
            // 
            this.buttonShootShotgun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonShootShotgun.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShootShotgun.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonShootShotgun.Location = new System.Drawing.Point(278, 170);
            this.buttonShootShotgun.Name = "buttonShootShotgun";
            this.buttonShootShotgun.Size = new System.Drawing.Size(81, 31);
            this.buttonShootShotgun.TabIndex = 5;
            this.buttonShootShotgun.Text = "Shotgun";
            this.buttonShootShotgun.UseVisualStyleBackColor = false;
            this.buttonShootShotgun.Click += new System.EventHandler(this.buttonShootShotgun_Click);
            // 
            // textBoxUserBulletsLoaded
            // 
            this.textBoxUserBulletsLoaded.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxUserBulletsLoaded.Font = new System.Drawing.Font("Courier New", 10F);
            this.textBoxUserBulletsLoaded.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUserBulletsLoaded.Location = new System.Drawing.Point(17, 116);
            this.textBoxUserBulletsLoaded.Name = "textBoxUserBulletsLoaded";
            this.textBoxUserBulletsLoaded.ReadOnly = true;
            this.textBoxUserBulletsLoaded.Size = new System.Drawing.Size(120, 23);
            this.textBoxUserBulletsLoaded.TabIndex = 6;
            // 
            // textBoxComputerBulletsLoaded
            // 
            this.textBoxComputerBulletsLoaded.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxComputerBulletsLoaded.Font = new System.Drawing.Font("Courier New", 10F);
            this.textBoxComputerBulletsLoaded.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxComputerBulletsLoaded.Location = new System.Drawing.Point(239, 116);
            this.textBoxComputerBulletsLoaded.Name = "textBoxComputerBulletsLoaded";
            this.textBoxComputerBulletsLoaded.ReadOnly = true;
            this.textBoxComputerBulletsLoaded.Size = new System.Drawing.Size(120, 23);
            this.textBoxComputerBulletsLoaded.TabIndex = 7;
            // 
            // textBoxUserPreviousMove
            // 
            this.textBoxUserPreviousMove.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxUserPreviousMove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserPreviousMove.Font = new System.Drawing.Font("Courier New", 11F);
            this.textBoxUserPreviousMove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUserPreviousMove.Location = new System.Drawing.Point(20, 42);
            this.textBoxUserPreviousMove.Multiline = true;
            this.textBoxUserPreviousMove.Name = "textBoxUserPreviousMove";
            this.textBoxUserPreviousMove.ReadOnly = true;
            this.textBoxUserPreviousMove.Size = new System.Drawing.Size(117, 47);
            this.textBoxUserPreviousMove.TabIndex = 8;
            // 
            // textBoxComputerPreviousMove
            // 
            this.textBoxComputerPreviousMove.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxComputerPreviousMove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxComputerPreviousMove.Font = new System.Drawing.Font("Courier New", 11F);
            this.textBoxComputerPreviousMove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxComputerPreviousMove.Location = new System.Drawing.Point(242, 42);
            this.textBoxComputerPreviousMove.Multiline = true;
            this.textBoxComputerPreviousMove.Name = "textBoxComputerPreviousMove";
            this.textBoxComputerPreviousMove.ReadOnly = true;
            this.textBoxComputerPreviousMove.Size = new System.Drawing.Size(117, 47);
            this.textBoxComputerPreviousMove.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Shotgun_Game___Inlämmning.Properties.Resources.TacticalShotgun;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Shotgun_Game___Inlämmning.Properties.Resources.TacticalShotgun;
            this.pictureBox1.Location = new System.Drawing.Point(137, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 87);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(380, 222);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxComputerPreviousMove);
            this.Controls.Add(this.textBoxUserPreviousMove);
            this.Controls.Add(this.textBoxComputerBulletsLoaded);
            this.Controls.Add(this.textBoxUserBulletsLoaded);
            this.Controls.Add(this.buttonShootShotgun);
            this.Controls.Add(this.buttonBlock);
            this.Controls.Add(this.buttonShoot);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Shotgun Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonShoot;
        private System.Windows.Forms.Button buttonBlock;
        private System.Windows.Forms.Button buttonShootShotgun;
        private System.Windows.Forms.TextBox textBoxUserBulletsLoaded;
        private System.Windows.Forms.TextBox textBoxComputerBulletsLoaded;
        private System.Windows.Forms.TextBox textBoxUserPreviousMove;
        private System.Windows.Forms.TextBox textBoxComputerPreviousMove;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

