﻿namespace DaGameEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxTilesets = new System.Windows.Forms.ComboBox();
            this.tilesetPreviewer = new DaGameEditor.Controls.TilesetPreviewer();
            this.monoGameEditor1 = new DaGameEditor.MonoGameEditor();
            this.buttonEditTileset = new System.Windows.Forms.Button();
            this.listBoxLayers = new System.Windows.Forms.ListBox();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // comboBoxTilesets
            // 
            this.comboBoxTilesets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTilesets.FormattingEnabled = true;
            this.comboBoxTilesets.Location = new System.Drawing.Point(12, 52);
            this.comboBoxTilesets.Name = "comboBoxTilesets";
            this.comboBoxTilesets.Size = new System.Drawing.Size(207, 21);
            this.comboBoxTilesets.TabIndex = 5;
            this.comboBoxTilesets.SelectedIndexChanged += new System.EventHandler(this.comboBoxTilesets_SelectedIndexChanged);
            // 
            // tilesetPreviewer
            // 
            this.tilesetPreviewer.AutoScroll = true;
            this.tilesetPreviewer.Location = new System.Drawing.Point(12, 115);
            this.tilesetPreviewer.Name = "tilesetPreviewer";
            this.tilesetPreviewer.Size = new System.Drawing.Size(207, 147);
            this.tilesetPreviewer.TabIndex = 4;
            this.tilesetPreviewer.Tileset = null;
            this.tilesetPreviewer.TileSelect += new DaGameEditor.Controls.TilesetPreviewer.OnTileSelectHandler(this.tilesetPreviewer_TileSelect);
            // 
            // monoGameEditor1
            // 
            this.monoGameEditor1.ActiveLayer = 0;
            this.monoGameEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monoGameEditor1.Bootstrap = null;
            this.monoGameEditor1.BrushTile = null;
            this.monoGameEditor1.Location = new System.Drawing.Point(244, 52);
            this.monoGameEditor1.MouseHoverUpdatesOnly = false;
            this.monoGameEditor1.Name = "monoGameEditor1";
            this.monoGameEditor1.Size = new System.Drawing.Size(544, 386);
            this.monoGameEditor1.TabIndex = 0;
            this.monoGameEditor1.Text = "monoGameEditor1";
            this.monoGameEditor1.NewMap += new DaGameEditor.MonoGameEditor.OnNewMapHandler(this.monoGameEditor1_NewMap);
            // 
            // buttonEditTileset
            // 
            this.buttonEditTileset.Enabled = false;
            this.buttonEditTileset.Location = new System.Drawing.Point(12, 79);
            this.buttonEditTileset.Name = "buttonEditTileset";
            this.buttonEditTileset.Size = new System.Drawing.Size(207, 30);
            this.buttonEditTileset.TabIndex = 6;
            this.buttonEditTileset.Text = "Edit Tileset";
            this.buttonEditTileset.UseVisualStyleBackColor = true;
            this.buttonEditTileset.Click += new System.EventHandler(this.buttonEditTileset_Click);
            // 
            // listBoxLayers
            // 
            this.listBoxLayers.FormattingEnabled = true;
            this.listBoxLayers.Location = new System.Drawing.Point(12, 268);
            this.listBoxLayers.Name = "listBoxLayers";
            this.listBoxLayers.Size = new System.Drawing.Size(207, 82);
            this.listBoxLayers.TabIndex = 7;
            this.listBoxLayers.SelectedIndexChanged += new System.EventHandler(this.listBoxLayers_SelectedIndexChanged);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxLayers);
            this.Controls.Add(this.buttonEditTileset);
            this.Controls.Add(this.comboBoxTilesets);
            this.Controls.Add(this.tilesetPreviewer);
            this.Controls.Add(this.monoGameEditor1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonoGameEditor monoGameEditor1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private Controls.TilesetPreviewer tilesetPreviewer;
        private System.Windows.Forms.ComboBox comboBoxTilesets;
        private System.Windows.Forms.Button buttonEditTileset;
        private System.Windows.Forms.ListBox listBoxLayers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}

