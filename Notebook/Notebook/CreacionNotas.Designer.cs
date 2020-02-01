namespace Notebook
{
    partial class CreacionNotas
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
            this.TituloTextBox = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.CreadorNotasPanel = new System.Windows.Forms.Panel();
            this.CategoriaTextBox = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NotasErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CodigoCreadorNotasLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreadorNotasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotasErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloTextBox
            // 
            this.TituloTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.TituloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TituloTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloTextBox.Location = new System.Drawing.Point(25, 55);
            this.TituloTextBox.Name = "TituloTextBox";
            this.TituloTextBox.Size = new System.Drawing.Size(226, 18);
            this.TituloTextBox.TabIndex = 1;
            this.TituloTextBox.Text = "TÍTULO";
            this.TituloTextBox.Enter += new System.EventHandler(this.TituloTextBox_Enter);
            this.TituloTextBox.Leave += new System.EventHandler(this.TituloTextBox_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(490, 246);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 25;
            this.lineShape2.X2 = 250;
            this.lineShape2.Y1 = 121;
            this.lineShape2.Y2 = 121;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 25;
            this.lineShape1.X2 = 250;
            this.lineShape1.Y1 = 75;
            this.lineShape1.Y2 = 75;
            // 
            // CreadorNotasPanel
            // 
            this.CreadorNotasPanel.BackgroundImage = global::Notebook.Properties.Resources.FondoGuardadoNotas2;
            this.CreadorNotasPanel.Controls.Add(this.pictureBox1);
            this.CreadorNotasPanel.Controls.Add(this.CodigoCreadorNotasLabel);
            this.CreadorNotasPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CreadorNotasPanel.Location = new System.Drawing.Point(290, 0);
            this.CreadorNotasPanel.Name = "CreadorNotasPanel";
            this.CreadorNotasPanel.Size = new System.Drawing.Size(200, 246);
            this.CreadorNotasPanel.TabIndex = 0;
            // 
            // CategoriaTextBox
            // 
            this.CategoriaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.CategoriaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoriaTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaTextBox.Location = new System.Drawing.Point(25, 101);
            this.CategoriaTextBox.Name = "CategoriaTextBox";
            this.CategoriaTextBox.Size = new System.Drawing.Size(226, 18);
            this.CategoriaTextBox.TabIndex = 3;
            this.CategoriaTextBox.Text = "CATEGORÍA";
            this.CategoriaTextBox.Enter += new System.EventHandler(this.CategoriaTextBox_Enter);
            this.CategoriaTextBox.Leave += new System.EventHandler(this.CategoriaTextBox_Leave);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CancelarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CancelarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.CancelarButton.Location = new System.Drawing.Point(25, 186);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(101, 32);
            this.CancelarButton.TabIndex = 4;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GuardarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.GuardarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GuardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.GuardarButton.Location = new System.Drawing.Point(146, 186);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(105, 32);
            this.GuardarButton.TabIndex = 5;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NotasErrorProvider
            // 
            this.NotasErrorProvider.ContainerControl = this;
            // 
            // CodigoCreadorNotasLabel
            // 
            this.CodigoCreadorNotasLabel.AutoSize = true;
            this.CodigoCreadorNotasLabel.Location = new System.Drawing.Point(139, 7);
            this.CodigoCreadorNotasLabel.Name = "CodigoCreadorNotasLabel";
            this.CodigoCreadorNotasLabel.Size = new System.Drawing.Size(36, 13);
            this.CodigoCreadorNotasLabel.TabIndex = 0;
            this.CodigoCreadorNotasLabel.Text = "f5pw2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Notebook.Properties.Resources.equisCerrar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(181, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CreacionNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(490, 246);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.CategoriaTextBox);
            this.Controls.Add(this.TituloTextBox);
            this.Controls.Add(this.CreadorNotasPanel);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreacionNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreacionNotas";
            this.CreadorNotasPanel.ResumeLayout(false);
            this.CreadorNotasPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotasErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CreadorNotasPanel;
        private System.Windows.Forms.TextBox TituloTextBox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox CategoriaTextBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.ErrorProvider NotasErrorProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CodigoCreadorNotasLabel;
    }
}