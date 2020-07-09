﻿namespace Chinook.EF.Practices
{
    partial class PracBindAlbumListForm
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
            this.lsbTitle = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.bdsAlbum = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdsAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbTitle
            // 
            this.lsbTitle.DataSource = this.bdsAlbum;
            this.lsbTitle.DisplayMember = "Title";
            this.lsbTitle.FormattingEnabled = true;
            this.lsbTitle.ItemHeight = 15;
            this.lsbTitle.Location = new System.Drawing.Point(53, 45);
            this.lsbTitle.Name = "lsbTitle";
            this.lsbTitle.Size = new System.Drawing.Size(452, 319);
            this.lsbTitle.TabIndex = 0;
            this.lsbTitle.ValueMember = "AlbumId";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(555, 45);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load(&L)";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // bdsAlbum
            // 
            this.bdsAlbum.DataSource = typeof(Chinook.Data.Album);
            // 
            // PracBindAlbumListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lsbTitle);
            this.Name = "PracBindAlbumListForm";
            this.Text = "PracAlbumListForm";
            ((System.ComponentModel.ISupportInitialize)(this.bdsAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbTitle;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.BindingSource bdsAlbum;
    }
}