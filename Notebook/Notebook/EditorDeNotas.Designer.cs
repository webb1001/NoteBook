namespace Notebook
{
    partial class EditorDeNotas
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
            this.EditorMenuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaginaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.GuardarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CopiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PegarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BotonesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EditorMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorMenuStrip
            // 
            this.EditorMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.edicionToolStripMenuItem});
            this.EditorMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.EditorMenuStrip.Name = "EditorMenuStrip";
            this.EditorMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.EditorMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.EditorMenuStrip.TabIndex = 0;
            this.EditorMenuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.exportarImagenToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::Notebook.Properties.Resources.IGuardar;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // exportarImagenToolStripMenuItem
            // 
            this.exportarImagenToolStripMenuItem.Image = global::Notebook.Properties.Resources.IExportar;
            this.exportarImagenToolStripMenuItem.Name = "exportarImagenToolStripMenuItem";
            this.exportarImagenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.exportarImagenToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.exportarImagenToolStripMenuItem.Text = "Exportar imagen ";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Image = global::Notebook.Properties.Resources.ICerrar;
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            this.formatoToolStripMenuItem.Click += new System.EventHandler(this.formatoToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrásToolStripMenuItem,
            this.adelanteToolStripMenuItem,
            this.toolStripSeparator1,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.toolStripSeparator2,
            this.seleccionarTodoToolStripMenuItem,
            this.eliminarTodoToolStripMenuItem});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.edicionToolStripMenuItem.Text = "Edición";
            // 
            // atrásToolStripMenuItem
            // 
            this.atrásToolStripMenuItem.Image = global::Notebook.Properties.Resources.imagesAtras;
            this.atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            this.atrásToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.atrásToolStripMenuItem.Text = "Atrás";
            this.atrásToolStripMenuItem.Click += new System.EventHandler(this.atrásToolStripMenuItem_Click);
            // 
            // adelanteToolStripMenuItem
            // 
            this.adelanteToolStripMenuItem.Image = global::Notebook.Properties.Resources.imagesAdelante;
            this.adelanteToolStripMenuItem.Name = "adelanteToolStripMenuItem";
            this.adelanteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.adelanteToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.adelanteToolStripMenuItem.Text = "Adelante";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = global::Notebook.Properties.Resources.imagenCopiar;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Image = global::Notebook.Properties.Resources.IPegar;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Image = global::Notebook.Properties.Resources.ICortar;
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Image = global::Notebook.Properties.Resources.ISelecionarTodo;
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.seleccionarTodoToolStripMenuItem.Text = "Seleccionar Todo";
            this.seleccionarTodoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarTodoToolStripMenuItem_Click);
            // 
            // eliminarTodoToolStripMenuItem
            // 
            this.eliminarTodoToolStripMenuItem.Image = global::Notebook.Properties.Resources.IEliminarTodo;
            this.eliminarTodoToolStripMenuItem.Name = "eliminarTodoToolStripMenuItem";
            this.eliminarTodoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.eliminarTodoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.eliminarTodoToolStripMenuItem.Text = "Eliminar Todo";
            this.eliminarTodoToolStripMenuItem.Click += new System.EventHandler(this.eliminarTodoToolStripMenuItem_Click);
            // 
            // PaginaRichTextBox
            // 
            this.PaginaRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaginaRichTextBox.Location = new System.Drawing.Point(0, 54);
            this.PaginaRichTextBox.Name = "PaginaRichTextBox";
            this.PaginaRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.PaginaRichTextBox.Size = new System.Drawing.Size(800, 396);
            this.PaginaRichTextBox.TabIndex = 1;
            this.PaginaRichTextBox.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GuardarToolStripButton,
            this.CopiarToolStripButton,
            this.PegarToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // GuardarToolStripButton
            // 
            this.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuardarToolStripButton.Image = global::Notebook.Properties.Resources.IGuardar;
            this.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarToolStripButton.Name = "GuardarToolStripButton";
            this.GuardarToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.GuardarToolStripButton.Text = "toolStripButton1";
            this.GuardarToolStripButton.ToolTipText = "Guardar";
            this.GuardarToolStripButton.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // CopiarToolStripButton
            // 
            this.CopiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopiarToolStripButton.Image = global::Notebook.Properties.Resources.imagenCopiar;
            this.CopiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopiarToolStripButton.Name = "CopiarToolStripButton";
            this.CopiarToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.CopiarToolStripButton.Text = "toolStripButton2";
            this.CopiarToolStripButton.ToolTipText = "Copiar";
            this.CopiarToolStripButton.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // PegarToolStripButton
            // 
            this.PegarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PegarToolStripButton.Image = global::Notebook.Properties.Resources.IPegar;
            this.PegarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PegarToolStripButton.Name = "PegarToolStripButton";
            this.PegarToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.PegarToolStripButton.Text = "toolStripButton3";
            this.PegarToolStripButton.ToolTipText = "Pegar";
            this.PegarToolStripButton.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // EditorDeNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PaginaRichTextBox);
            this.Controls.Add(this.EditorMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.EditorMenuStrip;
            this.Name = "EditorDeNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditorDeTexto";
            this.Load += new System.EventHandler(this.EditorDeNotas_Load);
            this.EditorMenuStrip.ResumeLayout(false);
            this.EditorMenuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip EditorMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.RichTextBox PaginaRichTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton GuardarToolStripButton;
        private System.Windows.Forms.ToolStripButton CopiarToolStripButton;
        private System.Windows.Forms.ToolStripButton PegarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adelanteToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolTip BotonesToolTip;
    }
}