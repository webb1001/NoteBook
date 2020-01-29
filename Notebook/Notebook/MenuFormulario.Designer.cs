namespace Notebook
{
    partial class MenuFormulario
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
            this.FondoPanel = new System.Windows.Forms.Panel();
            this.CentralPanel = new System.Windows.Forms.Panel();
            this.IzquierdaPanel = new System.Windows.Forms.Panel();
            this.BarraSuperiorPanel = new System.Windows.Forms.Panel();
            this.MaximizarPictureBox = new System.Windows.Forms.PictureBox();
            this.RestaurarPictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizarPictureBox = new System.Windows.Forms.PictureBox();
            this.CerrarPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuadernoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FondoPanel.SuspendLayout();
            this.BarraSuperiorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FondoPanel
            // 
            this.FondoPanel.Controls.Add(this.CentralPanel);
            this.FondoPanel.Controls.Add(this.IzquierdaPanel);
            this.FondoPanel.Controls.Add(this.BarraSuperiorPanel);
            this.FondoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FondoPanel.Location = new System.Drawing.Point(0, 0);
            this.FondoPanel.Name = "FondoPanel";
            this.FondoPanel.Size = new System.Drawing.Size(800, 450);
            this.FondoPanel.TabIndex = 0;
            // 
            // CentralPanel
            // 
            this.CentralPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CentralPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.Location = new System.Drawing.Point(200, 40);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(600, 410);
            this.CentralPanel.TabIndex = 0;
            // 
            // IzquierdaPanel
            // 
            this.IzquierdaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(119)))));
            this.IzquierdaPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.IzquierdaPanel.Location = new System.Drawing.Point(0, 40);
            this.IzquierdaPanel.Name = "IzquierdaPanel";
            this.IzquierdaPanel.Size = new System.Drawing.Size(200, 410);
            this.IzquierdaPanel.TabIndex = 2;
            // 
            // BarraSuperiorPanel
            // 
            this.BarraSuperiorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.BarraSuperiorPanel.Controls.Add(this.MaximizarPictureBox);
            this.BarraSuperiorPanel.Controls.Add(this.RestaurarPictureBox);
            this.BarraSuperiorPanel.Controls.Add(this.MinimizarPictureBox);
            this.BarraSuperiorPanel.Controls.Add(this.CerrarPictureBox);
            this.BarraSuperiorPanel.Controls.Add(this.menuStrip1);
            this.BarraSuperiorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperiorPanel.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperiorPanel.Name = "BarraSuperiorPanel";
            this.BarraSuperiorPanel.Size = new System.Drawing.Size(800, 40);
            this.BarraSuperiorPanel.TabIndex = 1;
            this.BarraSuperiorPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperiorPanel_MouseMove);
            // 
            // MaximizarPictureBox
            // 
            this.MaximizarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizarPictureBox.BackgroundImage = global::Notebook.Properties.Resources.maximizar2;
            this.MaximizarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaximizarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizarPictureBox.Location = new System.Drawing.Point(750, 12);
            this.MaximizarPictureBox.Name = "MaximizarPictureBox";
            this.MaximizarPictureBox.Size = new System.Drawing.Size(16, 16);
            this.MaximizarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizarPictureBox.TabIndex = 2;
            this.MaximizarPictureBox.TabStop = false;
            this.MaximizarPictureBox.Click += new System.EventHandler(this.MaximizarPictureBox_Click);
            // 
            // RestaurarPictureBox
            // 
            this.RestaurarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestaurarPictureBox.BackgroundImage = global::Notebook.Properties.Resources.restaurar2;
            this.RestaurarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RestaurarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestaurarPictureBox.Location = new System.Drawing.Point(750, 12);
            this.RestaurarPictureBox.Name = "RestaurarPictureBox";
            this.RestaurarPictureBox.Size = new System.Drawing.Size(16, 16);
            this.RestaurarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RestaurarPictureBox.TabIndex = 3;
            this.RestaurarPictureBox.TabStop = false;
            this.RestaurarPictureBox.Visible = false;
            this.RestaurarPictureBox.Click += new System.EventHandler(this.RestaurarPictureBox_Click);
            // 
            // MinimizarPictureBox
            // 
            this.MinimizarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarPictureBox.BackgroundImage = global::Notebook.Properties.Resources.minimizar3;
            this.MinimizarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizarPictureBox.Location = new System.Drawing.Point(728, 12);
            this.MinimizarPictureBox.Name = "MinimizarPictureBox";
            this.MinimizarPictureBox.Size = new System.Drawing.Size(16, 16);
            this.MinimizarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizarPictureBox.TabIndex = 1;
            this.MinimizarPictureBox.TabStop = false;
            this.MinimizarPictureBox.Click += new System.EventHandler(this.MinimizarPictureBox_Click);
            // 
            // CerrarPictureBox
            // 
            this.CerrarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarPictureBox.BackgroundImage = global::Notebook.Properties.Resources.cerrar3;
            this.CerrarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CerrarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarPictureBox.Location = new System.Drawing.Point(772, 12);
            this.CerrarPictureBox.Name = "CerrarPictureBox";
            this.CerrarPictureBox.Size = new System.Drawing.Size(16, 16);
            this.CerrarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarPictureBox.TabIndex = 0;
            this.CerrarPictureBox.TabStop = false;
            this.CerrarPictureBox.Click += new System.EventHandler(this.CerrarPictureBox_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuadernoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuadernoToolStripMenuItem
            // 
            this.cuadernoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(119)))));
            this.cuadernoToolStripMenuItem.BackgroundImage = global::Notebook.Properties.Resources.fondoMorado;
            this.cuadernoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cuadernoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.cuadernoToolStripMenuItem.Name = "cuadernoToolStripMenuItem";
            this.cuadernoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cuadernoToolStripMenuItem.Text = "Cuaderno";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // MenuFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FondoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "MenuFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuFormulario";
            this.FondoPanel.ResumeLayout(false);
            this.BarraSuperiorPanel.ResumeLayout(false);
            this.BarraSuperiorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FondoPanel;
        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.Panel IzquierdaPanel;
        private System.Windows.Forms.Panel BarraSuperiorPanel;
        private System.Windows.Forms.PictureBox CerrarPictureBox;
        private System.Windows.Forms.PictureBox MinimizarPictureBox;
        private System.Windows.Forms.PictureBox RestaurarPictureBox;
        private System.Windows.Forms.PictureBox MaximizarPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuadernoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}