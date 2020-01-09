namespace Notebook
{
    partial class GuardadoForm
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
            this.NombreLabel = new System.Windows.Forms.Label();
            this.CategoriaLabel = new System.Windows.Forms.Label();
            this.ColoresGroupBox = new System.Windows.Forms.GroupBox();
            this.CafeRadioButton = new System.Windows.Forms.RadioButton();
            this.AmarilloRadioButton = new System.Windows.Forms.RadioButton();
            this.AzulRadioButton = new System.Windows.Forms.RadioButton();
            this.VerdeRadioButton = new System.Windows.Forms.RadioButton();
            this.RojoRadioButton = new System.Windows.Forms.RadioButton();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.CategoriaTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GuardadoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GuardadoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ColoresGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuardadoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(106, 21);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(69, 20);
            this.NombreLabel.TabIndex = 0;
            this.NombreLabel.Text = "Nombre:";
            // 
            // CategoriaLabel
            // 
            this.CategoriaLabel.AutoSize = true;
            this.CategoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLabel.Location = new System.Drawing.Point(106, 87);
            this.CategoriaLabel.Name = "CategoriaLabel";
            this.CategoriaLabel.Size = new System.Drawing.Size(82, 20);
            this.CategoriaLabel.TabIndex = 1;
            this.CategoriaLabel.Text = "Categoria:";
            // 
            // ColoresGroupBox
            // 
            this.ColoresGroupBox.Controls.Add(this.CafeRadioButton);
            this.ColoresGroupBox.Controls.Add(this.AmarilloRadioButton);
            this.ColoresGroupBox.Controls.Add(this.AzulRadioButton);
            this.ColoresGroupBox.Controls.Add(this.VerdeRadioButton);
            this.ColoresGroupBox.Controls.Add(this.RojoRadioButton);
            this.ColoresGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColoresGroupBox.Location = new System.Drawing.Point(47, 161);
            this.ColoresGroupBox.Name = "ColoresGroupBox";
            this.ColoresGroupBox.Size = new System.Drawing.Size(193, 193);
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
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(47, 44);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(185, 26);
            this.NombreTextBox.TabIndex = 3;
            // 
            // CategoriaTextBox
            // 
            this.CategoriaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaTextBox.Location = new System.Drawing.Point(47, 110);
            this.CategoriaTextBox.Name = "CategoriaTextBox";
            this.CategoriaTextBox.Size = new System.Drawing.Size(185, 26);
            this.CategoriaTextBox.TabIndex = 4;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(170, 399);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 34);
            this.GuardarButton.TabIndex = 5;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuardadoErrorProvider
            // 
            this.GuardadoErrorProvider.ContainerControl = this;
            // 
            // GuardadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Notebook.Properties.Resources.CuV;
            this.ClientSize = new System.Drawing.Size(282, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CategoriaTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.ColoresGroupBox);
            this.Controls.Add(this.CategoriaLabel);
            this.Controls.Add(this.NombreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GuardadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardado";
            this.Load += new System.EventHandler(this.GuardadoForm_Load);
            this.ColoresGroupBox.ResumeLayout(false);
            this.ColoresGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuardadoErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label CategoriaLabel;
        private System.Windows.Forms.GroupBox ColoresGroupBox;
        private System.Windows.Forms.RadioButton CafeRadioButton;
        private System.Windows.Forms.RadioButton AmarilloRadioButton;
        private System.Windows.Forms.RadioButton AzulRadioButton;
        private System.Windows.Forms.RadioButton VerdeRadioButton;
        private System.Windows.Forms.RadioButton RojoRadioButton;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox CategoriaTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip GuardadoToolTip;
        private System.Windows.Forms.ErrorProvider GuardadoErrorProvider;
    }
}