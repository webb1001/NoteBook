namespace Notebook
{
    partial class CrearForm
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
            this.ColoresGroupBox = new System.Windows.Forms.GroupBox();
            this.CafeRadioButton = new System.Windows.Forms.RadioButton();
            this.AmarilloRadioButton = new System.Windows.Forms.RadioButton();
            this.AzulRadioButton = new System.Windows.Forms.RadioButton();
            this.VerdeRadioButton = new System.Windows.Forms.RadioButton();
            this.RojoRadioButton = new System.Windows.Forms.RadioButton();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.CategoriaTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardadoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GuardadoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CerrarPictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizarPictureBox = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ColoresGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuardadoErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ColoresGroupBox
            // 
            this.ColoresGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ColoresGroupBox.Controls.Add(this.CafeRadioButton);
            this.ColoresGroupBox.Controls.Add(this.AmarilloRadioButton);
            this.ColoresGroupBox.Controls.Add(this.AzulRadioButton);
            this.ColoresGroupBox.Controls.Add(this.VerdeRadioButton);
            this.ColoresGroupBox.Controls.Add(this.RojoRadioButton);
            this.ColoresGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColoresGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColoresGroupBox.ForeColor = System.Drawing.Color.DarkGray;
            this.ColoresGroupBox.Location = new System.Drawing.Point(38, 160);
            this.ColoresGroupBox.Name = "ColoresGroupBox";
            this.ColoresGroupBox.Size = new System.Drawing.Size(176, 193);
            this.ColoresGroupBox.TabIndex = 2;
            this.ColoresGroupBox.TabStop = false;
            this.ColoresGroupBox.Text = "Color de cuaderno:";
            // 
            // CafeRadioButton
            // 
            this.CafeRadioButton.AutoSize = true;
            this.CafeRadioButton.Location = new System.Drawing.Point(30, 155);
            this.CafeRadioButton.Name = "CafeRadioButton";
            this.CafeRadioButton.Size = new System.Drawing.Size(61, 24);
            this.CafeRadioButton.TabIndex = 4;
            this.CafeRadioButton.TabStop = true;
            this.CafeRadioButton.Text = "Café";
            this.CafeRadioButton.UseVisualStyleBackColor = true;
            // 
            // AmarilloRadioButton
            // 
            this.AmarilloRadioButton.AutoSize = true;
            this.AmarilloRadioButton.Location = new System.Drawing.Point(30, 125);
            this.AmarilloRadioButton.Name = "AmarilloRadioButton";
            this.AmarilloRadioButton.Size = new System.Drawing.Size(83, 24);
            this.AmarilloRadioButton.TabIndex = 3;
            this.AmarilloRadioButton.TabStop = true;
            this.AmarilloRadioButton.Text = "Amarillo";
            this.AmarilloRadioButton.UseVisualStyleBackColor = true;
            // 
            // AzulRadioButton
            // 
            this.AzulRadioButton.AutoSize = true;
            this.AzulRadioButton.Location = new System.Drawing.Point(30, 95);
            this.AzulRadioButton.Name = "AzulRadioButton";
            this.AzulRadioButton.Size = new System.Drawing.Size(58, 24);
            this.AzulRadioButton.TabIndex = 2;
            this.AzulRadioButton.TabStop = true;
            this.AzulRadioButton.Text = "Azul";
            this.AzulRadioButton.UseVisualStyleBackColor = true;
            // 
            // VerdeRadioButton
            // 
            this.VerdeRadioButton.AutoSize = true;
            this.VerdeRadioButton.Location = new System.Drawing.Point(28, 65);
            this.VerdeRadioButton.Name = "VerdeRadioButton";
            this.VerdeRadioButton.Size = new System.Drawing.Size(70, 24);
            this.VerdeRadioButton.TabIndex = 1;
            this.VerdeRadioButton.TabStop = true;
            this.VerdeRadioButton.Text = "Verde";
            this.VerdeRadioButton.UseVisualStyleBackColor = true;
            // 
            // RojoRadioButton
            // 
            this.RojoRadioButton.AutoSize = true;
            this.RojoRadioButton.Checked = true;
            this.RojoRadioButton.Location = new System.Drawing.Point(28, 35);
            this.RojoRadioButton.Name = "RojoRadioButton";
            this.RojoRadioButton.Size = new System.Drawing.Size(60, 24);
            this.RojoRadioButton.TabIndex = 0;
            this.RojoRadioButton.TabStop = true;
            this.RojoRadioButton.Text = "Rojo";
            this.RojoRadioButton.UseVisualStyleBackColor = true;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.NombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.NombreTextBox.Location = new System.Drawing.Point(50, 61);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(151, 19);
            this.NombreTextBox.TabIndex = 0;
            this.NombreTextBox.Text = "Nombre";
            this.NombreTextBox.Enter += new System.EventHandler(this.NombreTextBox_Enter);
            this.NombreTextBox.Leave += new System.EventHandler(this.NombreTextBox_Leave);
            // 
            // CategoriaTextBox
            // 
            this.CategoriaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.CategoriaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoriaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.CategoriaTextBox.Location = new System.Drawing.Point(50, 111);
            this.CategoriaTextBox.Name = "CategoriaTextBox";
            this.CategoriaTextBox.Size = new System.Drawing.Size(164, 19);
            this.CategoriaTextBox.TabIndex = 1;
            this.CategoriaTextBox.Text = "Categoría";
            this.CategoriaTextBox.Enter += new System.EventHandler(this.CategoriaTextBox_Enter);
            this.CategoriaTextBox.Leave += new System.EventHandler(this.CategoriaTextBox_Leave);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.Color.DarkGray;
            this.GuardarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.GuardarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GuardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GuardarButton.Location = new System.Drawing.Point(170, 399);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 34);
            this.GuardarButton.TabIndex = 4;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.Color.DarkGray;
            this.CancelarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CancelarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CancelarButton.Location = new System.Drawing.Point(12, 399);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(100, 34);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GuardadoErrorProvider
            // 
            this.GuardadoErrorProvider.ContainerControl = this;
            // 
            // CerrarPictureBox
            // 
            this.CerrarPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CerrarPictureBox.BackgroundImage = global::Notebook.Properties.Resources.equisCerrar;
            this.CerrarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CerrarPictureBox.Location = new System.Drawing.Point(416, 2);
            this.CerrarPictureBox.Name = "CerrarPictureBox";
            this.CerrarPictureBox.Size = new System.Drawing.Size(16, 16);
            this.CerrarPictureBox.TabIndex = 5;
            this.CerrarPictureBox.TabStop = false;
            this.CerrarPictureBox.Click += new System.EventHandler(this.CerrarPictureBox_Click);
            // 
            // MinimizarPictureBox
            // 
            this.MinimizarPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.MinimizarPictureBox.BackgroundImage = global::Notebook.Properties.Resources.minimizar1;
            this.MinimizarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizarPictureBox.Location = new System.Drawing.Point(394, 2);
            this.MinimizarPictureBox.Name = "MinimizarPictureBox";
            this.MinimizarPictureBox.Size = new System.Drawing.Size(16, 16);
            this.MinimizarPictureBox.TabIndex = 6;
            this.MinimizarPictureBox.TabStop = false;
            this.MinimizarPictureBox.Click += new System.EventHandler(this.MinimizarPictureBox_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(435, 461);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.MistyRose;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 50;
            this.lineShape2.X2 = 200;
            this.lineShape2.Y1 = 130;
            this.lineShape2.Y2 = 130;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.MistyRose;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 50;
            this.lineShape1.X2 = 200;
            this.lineShape1.Y1 = 80;
            this.lineShape1.Y2 = 80;
            // 
            // CrearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Notebook.Properties.Resources.FondoLibrosMorado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 461);
            this.Controls.Add(this.MinimizarPictureBox);
            this.Controls.Add(this.CerrarPictureBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CategoriaTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.ColoresGroupBox);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creacion de cuadernos";
            this.Load += new System.EventHandler(this.GuardadoForm_Load);
            this.ColoresGroupBox.ResumeLayout(false);
            this.ColoresGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuardadoErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox ColoresGroupBox;
        private System.Windows.Forms.RadioButton CafeRadioButton;
        private System.Windows.Forms.RadioButton AmarilloRadioButton;
        private System.Windows.Forms.RadioButton AzulRadioButton;
        private System.Windows.Forms.RadioButton VerdeRadioButton;
        private System.Windows.Forms.RadioButton RojoRadioButton;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox CategoriaTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ToolTip GuardadoToolTip;
        private System.Windows.Forms.ErrorProvider GuardadoErrorProvider;
        private System.Windows.Forms.PictureBox CerrarPictureBox;
        private System.Windows.Forms.PictureBox MinimizarPictureBox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}