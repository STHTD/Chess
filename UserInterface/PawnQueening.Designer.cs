﻿
namespace UserInterface
{
    partial class PawnQueening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PawnQueening));
            this.label1 = new System.Windows.Forms.Label();
            this.Knightbox = new System.Windows.Forms.PictureBox();
            this.Rookbox = new System.Windows.Forms.PictureBox();
            this.Bishopbox = new System.Windows.Forms.PictureBox();
            this.Queenbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Knightbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rookbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bishopbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Queenbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("04b03", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHOOSE PIECE";
            // 
            // Knightbox
            // 
            this.Knightbox.BackColor = System.Drawing.Color.DimGray;
            this.Knightbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Knightbox.BackgroundImage")));
            this.Knightbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Knightbox.ErrorImage = null;
            this.Knightbox.InitialImage = ((System.Drawing.Image)(resources.GetObject("Knightbox.InitialImage")));
            this.Knightbox.Location = new System.Drawing.Point(540, 34);
            this.Knightbox.Margin = new System.Windows.Forms.Padding(4);
            this.Knightbox.Name = "Knightbox";
            this.Knightbox.Size = new System.Drawing.Size(140, 118);
            this.Knightbox.TabIndex = 1;
            this.Knightbox.TabStop = false;
            this.Knightbox.Click += new System.EventHandler(this.Knightbox_Click);
            this.Knightbox.MouseEnter += new System.EventHandler(this.Knightbox_MouseEnter);
            this.Knightbox.MouseLeave += new System.EventHandler(this.Knightbox_MouseLeave);
            // 
            // Rookbox
            // 
            this.Rookbox.BackColor = System.Drawing.Color.DimGray;
            this.Rookbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rookbox.BackgroundImage")));
            this.Rookbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Rookbox.ErrorImage = null;
            this.Rookbox.InitialImage = ((System.Drawing.Image)(resources.GetObject("Rookbox.InitialImage")));
            this.Rookbox.Location = new System.Drawing.Point(205, 34);
            this.Rookbox.Margin = new System.Windows.Forms.Padding(4);
            this.Rookbox.Name = "Rookbox";
            this.Rookbox.Size = new System.Drawing.Size(140, 118);
            this.Rookbox.TabIndex = 1;
            this.Rookbox.TabStop = false;
            this.Rookbox.Click += new System.EventHandler(this.Rookbox_Click);
            this.Rookbox.MouseEnter += new System.EventHandler(this.Rookbox_MouseEnter);
            this.Rookbox.MouseLeave += new System.EventHandler(this.Rookbox_MouseLeave);
            // 
            // Bishopbox
            // 
            this.Bishopbox.BackColor = System.Drawing.Color.DimGray;
            this.Bishopbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bishopbox.BackgroundImage")));
            this.Bishopbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Bishopbox.ErrorImage = null;
            this.Bishopbox.InitialImage = ((System.Drawing.Image)(resources.GetObject("Bishopbox.InitialImage")));
            this.Bishopbox.Location = new System.Drawing.Point(371, 34);
            this.Bishopbox.Margin = new System.Windows.Forms.Padding(4);
            this.Bishopbox.Name = "Bishopbox";
            this.Bishopbox.Size = new System.Drawing.Size(140, 118);
            this.Bishopbox.TabIndex = 1;
            this.Bishopbox.TabStop = false;
            this.Bishopbox.Click += new System.EventHandler(this.Bishop_Click);
            this.Bishopbox.MouseEnter += new System.EventHandler(this.Bishop_MouseEnter);
            this.Bishopbox.MouseLeave += new System.EventHandler(this.Bishop_MouseLeave);
            // 
            // Queenbox
            // 
            this.Queenbox.BackColor = System.Drawing.Color.DimGray;
            this.Queenbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Queenbox.BackgroundImage")));
            this.Queenbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Queenbox.ErrorImage = null;
            this.Queenbox.InitialImage = ((System.Drawing.Image)(resources.GetObject("Queenbox.InitialImage")));
            this.Queenbox.Location = new System.Drawing.Point(35, 34);
            this.Queenbox.Margin = new System.Windows.Forms.Padding(4);
            this.Queenbox.Name = "Queenbox";
            this.Queenbox.Size = new System.Drawing.Size(140, 118);
            this.Queenbox.TabIndex = 1;
            this.Queenbox.TabStop = false;
            this.Queenbox.Click += new System.EventHandler(this.Queenbox_Click);
            this.Queenbox.MouseEnter += new System.EventHandler(this.Queenbox_MouseEnter);
            this.Queenbox.MouseLeave += new System.EventHandler(this.Queenbox_MouseLeave);
            // 
            // PawnQueening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(713, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Knightbox);
            this.Controls.Add(this.Rookbox);
            this.Controls.Add(this.Bishopbox);
            this.Controls.Add(this.Queenbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PawnQueening";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PawnQueening";
            ((System.ComponentModel.ISupportInitialize)(this.Knightbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rookbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bishopbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Queenbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Queenbox;
        private System.Windows.Forms.PictureBox Bishopbox;
        private System.Windows.Forms.PictureBox Rookbox;
        private System.Windows.Forms.PictureBox Knightbox;
        private System.Windows.Forms.Label label1;
    }
}