namespace Notebook
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.ContraseñaLabel = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.LoginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LoginToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.VisibleButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(254, 207);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(68, 20);
            this.UsuarioLabel.TabIndex = 0;
            this.UsuarioLabel.Text = "Usuario:";
            // 
            // ContraseñaLabel
            // 
            this.ContraseñaLabel.AutoSize = true;
            this.ContraseñaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaLabel.Location = new System.Drawing.Point(226, 239);
            this.ContraseñaLabel.Name = "ContraseñaLabel";
            this.ContraseñaLabel.Size = new System.Drawing.Size(96, 20);
            this.ContraseñaLabel.TabIndex = 1;
            this.ContraseñaLabel.Text = "Contraseña:";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(328, 204);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(202, 26);
            this.UsuarioTextBox.TabIndex = 2;
            this.UsuarioTextBox.TextChanged += new System.EventHandler(this.UsuarioTextBox_TextChanged);
            this.UsuarioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContraseñaTextBox_KeyPress);
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaTextBox.Location = new System.Drawing.Point(328, 236);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.PasswordChar = '*';
            this.ContraseñaTextBox.Size = new System.Drawing.Size(202, 26);
            this.ContraseñaTextBox.TabIndex = 3;
            this.ContraseñaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContraseñaTextBox_KeyPress);
            // 
            // IngresarButton
            // 
            this.IngresarButton.Location = new System.Drawing.Point(351, 291);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(96, 34);
            this.IngresarButton.TabIndex = 4;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.UseVisualStyleBackColor = true;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // LoginErrorProvider
            // 
            this.LoginErrorProvider.ContainerControl = this;
            // 
            // LoginToolTip
            // 
            this.LoginToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.LoginToolTip_Popup);
            // 
            // VisibleButton
            // 
            this.VisibleButton.BackgroundImage = global::Notebook.Properties.Resources.images;
            this.VisibleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisibleButton.Location = new System.Drawing.Point(505, 236);
            this.VisibleButton.Name = "VisibleButton";
            this.VisibleButton.Size = new System.Drawing.Size(25, 26);
            this.VisibleButton.TabIndex = 5;
            this.VisibleButton.UseVisualStyleBackColor = true;
            this.VisibleButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Notebook.Properties.Resources.ImagenLogin;
            this.pictureBox1.Location = new System.Drawing.Point(328, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Notebook.Properties.Resources.color_fondo_azul_claro_brillante_color_azul_claro_degradado_40417_157;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VisibleButton);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.ContraseñaLabel);
            this.Controls.Add(this.UsuarioLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label ContraseñaLabel;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.Button IngresarButton;
        private System.Windows.Forms.ErrorProvider LoginErrorProvider;
        private System.Windows.Forms.ToolTip LoginToolTip;
        private System.Windows.Forms.Button VisibleButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

