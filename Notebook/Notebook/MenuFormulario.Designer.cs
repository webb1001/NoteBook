﻿namespace Notebook
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
            this.DerechaPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.CerrarSesiónButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.MisCuadernosLabel = new System.Windows.Forms.Label();
            this.UsuarioPictureBox = new System.Windows.Forms.PictureBox();
            this.MaximizarPictureBox = new System.Windows.Forms.PictureBox();
            this.RestaurarPictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizarPictureBox = new System.Windows.Forms.PictureBox();
            this.CerrarPictureBox = new System.Windows.Forms.PictureBox();
            this.FondoPanel.SuspendLayout();
            this.CentralPanel.SuspendLayout();
            this.IzquierdaPanel.SuspendLayout();
            this.BarraSuperiorPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FondoPanel
            // 
            this.FondoPanel.Controls.Add(this.IzquierdaPanel);
            this.FondoPanel.Controls.Add(this.panel2);
            this.FondoPanel.Controls.Add(this.DerechaPanel);
            this.FondoPanel.Controls.Add(this.CentralPanel);
            this.FondoPanel.Controls.Add(this.BarraSuperiorPanel);
            this.FondoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FondoPanel.Location = new System.Drawing.Point(0, 0);
            this.FondoPanel.Name = "FondoPanel";
            this.FondoPanel.Size = new System.Drawing.Size(900, 600);
            this.FondoPanel.TabIndex = 0;
            // 
            // CentralPanel
            // 
            this.CentralPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CentralPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CentralPanel.Controls.Add(this.label4);
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.Location = new System.Drawing.Point(0, 23);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(900, 577);
            this.CentralPanel.TabIndex = 0;
            // 
            // IzquierdaPanel
            // 
            this.IzquierdaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(119)))));
            this.IzquierdaPanel.Controls.Add(this.MisCuadernosLabel);
            this.IzquierdaPanel.Controls.Add(this.UsuarioLabel);
            this.IzquierdaPanel.Controls.Add(this.UsuarioPictureBox);
            this.IzquierdaPanel.Controls.Add(this.shapeContainer1);
            this.IzquierdaPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.IzquierdaPanel.Location = new System.Drawing.Point(0, 23);
            this.IzquierdaPanel.Name = "IzquierdaPanel";
            this.IzquierdaPanel.Size = new System.Drawing.Size(200, 531);
            this.IzquierdaPanel.TabIndex = 2;
            // 
            // BarraSuperiorPanel
            // 
            this.BarraSuperiorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.BarraSuperiorPanel.Controls.Add(this.CerrarSesiónButton);
            this.BarraSuperiorPanel.Controls.Add(this.CodigoLabel);
            this.BarraSuperiorPanel.Controls.Add(this.MenuLabel);
            this.BarraSuperiorPanel.Controls.Add(this.label2);
            this.BarraSuperiorPanel.Controls.Add(this.MaximizarPictureBox);
            this.BarraSuperiorPanel.Controls.Add(this.RestaurarPictureBox);
            this.BarraSuperiorPanel.Controls.Add(this.MinimizarPictureBox);
            this.BarraSuperiorPanel.Controls.Add(this.CerrarPictureBox);
            this.BarraSuperiorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperiorPanel.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperiorPanel.Name = "BarraSuperiorPanel";
            this.BarraSuperiorPanel.Size = new System.Drawing.Size(900, 23);
            this.BarraSuperiorPanel.TabIndex = 1;
            this.BarraSuperiorPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperiorPanel_MouseMove);
            // 
            // DerechaPanel
            // 
            this.DerechaPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DerechaPanel.Location = new System.Drawing.Point(700, 23);
            this.DerechaPanel.Name = "DerechaPanel";
            this.DerechaPanel.Size = new System.Drawing.Size(200, 577);
            this.DerechaPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EliminarButton);
            this.panel2.Controls.Add(this.ModificarButton);
            this.panel2.Controls.Add(this.AgregarButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 554);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 46);
            this.panel2.TabIndex = 0;
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLabel.Location = new System.Drawing.Point(12, 2);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(43, 17);
            this.MenuLabel.TabIndex = 1;
            this.MenuLabel.Text = "Menú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // CodigoLabel
            // 
            this.CodigoLabel.AutoSize = true;
            this.CodigoLabel.Location = new System.Drawing.Point(206, 4);
            this.CodigoLabel.Name = "CodigoLabel";
            this.CodigoLabel.Size = new System.Drawing.Size(36, 13);
            this.CodigoLabel.TabIndex = 4;
            this.CodigoLabel.Text = "f3pw2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.ForeColor = System.Drawing.Color.White;
            this.UsuarioLabel.Location = new System.Drawing.Point(77, 16);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(57, 17);
            this.UsuarioLabel.TabIndex = 6;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // CerrarSesiónButton
            // 
            this.CerrarSesiónButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(119)))));
            this.CerrarSesiónButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CerrarSesiónButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarSesiónButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarSesiónButton.Location = new System.Drawing.Point(111, -1);
            this.CerrarSesiónButton.Name = "CerrarSesiónButton";
            this.CerrarSesiónButton.Size = new System.Drawing.Size(89, 24);
            this.CerrarSesiónButton.TabIndex = 5;
            this.CerrarSesiónButton.Text = "Cerrar sesión";
            this.CerrarSesiónButton.UseVisualStyleBackColor = false;
            this.CerrarSesiónButton.Click += new System.EventHandler(this.CerrarSesiónButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.AgregarButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AgregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarButton.Location = new System.Drawing.Point(0, 0);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(242, 46);
            this.AgregarButton.TabIndex = 0;
            this.AgregarButton.Text = "Agregar cuaderno";
            this.AgregarButton.UseVisualStyleBackColor = false;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.ModificarButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ModificarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarButton.Location = new System.Drawing.Point(472, 0);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(228, 46);
            this.ModificarButton.TabIndex = 1;
            this.ModificarButton.Text = "Modificar cuaderno";
            this.ModificarButton.UseVisualStyleBackColor = false;
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.EliminarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarButton.Location = new System.Drawing.Point(242, 0);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(230, 46);
            this.EliminarButton.TabIndex = 2;
            this.EliminarButton.Text = "Eliminar cuaderno";
            this.EliminarButton.UseVisualStyleBackColor = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(200, 531);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 7;
            this.lineShape1.X2 = 191;
            this.lineShape1.Y1 = 70;
            this.lineShape1.Y2 = 70;
            // 
            // MisCuadernosLabel
            // 
            this.MisCuadernosLabel.AutoSize = true;
            this.MisCuadernosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MisCuadernosLabel.ForeColor = System.Drawing.Color.White;
            this.MisCuadernosLabel.Location = new System.Drawing.Point(9, 84);
            this.MisCuadernosLabel.Name = "MisCuadernosLabel";
            this.MisCuadernosLabel.Size = new System.Drawing.Size(104, 17);
            this.MisCuadernosLabel.TabIndex = 8;
            this.MisCuadernosLabel.Text = "Mis cuadernos:";
            // 
            // UsuarioPictureBox
            // 
            this.UsuarioPictureBox.BackgroundImage = global::Notebook.Properties.Resources.ImagenUsuarioMenuB;
            this.UsuarioPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UsuarioPictureBox.Location = new System.Drawing.Point(12, 6);
            this.UsuarioPictureBox.Name = "UsuarioPictureBox";
            this.UsuarioPictureBox.Size = new System.Drawing.Size(59, 52);
            this.UsuarioPictureBox.TabIndex = 5;
            this.UsuarioPictureBox.TabStop = false;
            // 
            // MaximizarPictureBox
            // 
            this.MaximizarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizarPictureBox.BackgroundImage = global::Notebook.Properties.Resources.maximizar2;
            this.MaximizarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaximizarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizarPictureBox.Location = new System.Drawing.Point(859, 3);
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
            this.RestaurarPictureBox.Location = new System.Drawing.Point(859, 3);
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
            this.MinimizarPictureBox.Location = new System.Drawing.Point(837, 3);
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
            this.CerrarPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.CerrarPictureBox.BackgroundImage = global::Notebook.Properties.Resources.cerrar3;
            this.CerrarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CerrarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarPictureBox.Location = new System.Drawing.Point(881, 3);
            this.CerrarPictureBox.Name = "CerrarPictureBox";
            this.CerrarPictureBox.Size = new System.Drawing.Size(16, 16);
            this.CerrarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarPictureBox.TabIndex = 0;
            this.CerrarPictureBox.TabStop = false;
            this.CerrarPictureBox.Click += new System.EventHandler(this.CerrarPictureBox_Click);
            // 
            // MenuFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.FondoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "MenuFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuFormulario";
            this.Load += new System.EventHandler(this.MenuFormulario_Load);
            this.FondoPanel.ResumeLayout(false);
            this.CentralPanel.ResumeLayout(false);
            this.CentralPanel.PerformLayout();
            this.IzquierdaPanel.ResumeLayout(false);
            this.IzquierdaPanel.PerformLayout();
            this.BarraSuperiorPanel.ResumeLayout(false);
            this.BarraSuperiorPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel DerechaPanel;
        private System.Windows.Forms.Label CodigoLabel;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox UsuarioPictureBox;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CerrarSesiónButton;
        private System.Windows.Forms.Label MisCuadernosLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button AgregarButton;
    }
}