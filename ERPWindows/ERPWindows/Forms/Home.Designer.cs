﻿namespace OrtakProje
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStokTanim = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRenkTanim = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBirimTanim = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFirmaTanim = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDepoTanim = new System.Windows.Forms.ToolStripMenuItem();
            this.stokHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlarToolStripMenuItem,
            this.stokHareketleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlarToolStripMenuItem
            // 
            this.tanımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnStokTanim,
            this.mnRenkTanim,
            this.mnBirimTanim,
            this.mnFirmaTanim,
            this.mnDepoTanim});
            this.tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            this.tanımlarToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.tanımlarToolStripMenuItem.Text = "Tanımlar";
            // 
            // mnStokTanim
            // 
            this.mnStokTanim.Name = "mnStokTanim";
            this.mnStokTanim.Size = new System.Drawing.Size(189, 26);
            this.mnStokTanim.Text = "Stok Tanımlar";
            this.mnStokTanim.Click += new System.EventHandler(this.mnStokTanim_Click);
            // 
            // mnRenkTanim
            // 
            this.mnRenkTanim.Name = "mnRenkTanim";
            this.mnRenkTanim.Size = new System.Drawing.Size(189, 26);
            this.mnRenkTanim.Text = "Renk Tanımlar";
            this.mnRenkTanim.Click += new System.EventHandler(this.mnRenkTanim_Click);
            // 
            // mnBirimTanim
            // 
            this.mnBirimTanim.Name = "mnBirimTanim";
            this.mnBirimTanim.Size = new System.Drawing.Size(189, 26);
            this.mnBirimTanim.Text = "Birim Tanımlar";
            this.mnBirimTanim.Click += new System.EventHandler(this.mnBirimTanim_Click);
            // 
            // mnFirmaTanim
            // 
            this.mnFirmaTanim.Name = "mnFirmaTanim";
            this.mnFirmaTanim.Size = new System.Drawing.Size(189, 26);
            this.mnFirmaTanim.Text = "Firma Tanımlar";
            this.mnFirmaTanim.Click += new System.EventHandler(this.mnFirmaTanim_Click);
            // 
            // mnDepoTanim
            // 
            this.mnDepoTanim.Name = "mnDepoTanim";
            this.mnDepoTanim.Size = new System.Drawing.Size(189, 26);
            this.mnDepoTanim.Text = "Depo Tanımlar";
            this.mnDepoTanim.Click += new System.EventHandler(this.mnDepoTanim_Click);
            // 
            // stokHareketleriToolStripMenuItem
            // 
            this.stokHareketleriToolStripMenuItem.Name = "stokHareketleriToolStripMenuItem";
            this.stokHareketleriToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.stokHareketleriToolStripMenuItem.Text = "Stok Hareketleri";
            this.stokHareketleriToolStripMenuItem.Click += new System.EventHandler(this.stokHareketleriToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnFirmaTanim;
        private System.Windows.Forms.ToolStripMenuItem mnStokTanim;
        private System.Windows.Forms.ToolStripMenuItem mnRenkTanim;
        private System.Windows.Forms.ToolStripMenuItem mnBirimTanim;
        private System.Windows.Forms.ToolStripMenuItem mnDepoTanim;
        private System.Windows.Forms.ToolStripMenuItem stokHareketleriToolStripMenuItem;
    }
}

