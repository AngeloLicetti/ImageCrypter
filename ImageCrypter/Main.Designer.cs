namespace ImageCrypter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cmdEncrypt = new System.Windows.Forms.Button();
            this.cmdDecrypt = new System.Windows.Forms.Button();
            this.grpDecrypt = new System.Windows.Forms.GroupBox();
            this.lblMensajeD = new System.Windows.Forms.Label();
            this.btnReiniciarD = new System.Windows.Forms.Button();
            this.lblGuardarD = new System.Windows.Forms.Label();
            this.lblAbrirD = new System.Windows.Forms.Label();
            this.cmdDecryptSave = new System.Windows.Forms.Button();
            this.cmdDecryptOpen = new System.Windows.Forms.Button();
            this.lblDecryptInfo = new System.Windows.Forms.Label();
            this.grpEncrypt = new System.Windows.Forms.GroupBox();
            this.lblMensajeE = new System.Windows.Forms.Label();
            this.btnReiniciarE = new System.Windows.Forms.Button();
            this.lblGuardarE = new System.Windows.Forms.Label();
            this.lblCargarE = new System.Windows.Forms.Label();
            this.lblSeleccionarE = new System.Windows.Forms.Label();
            this.cmdEncryptPayload = new System.Windows.Forms.Button();
            this.cmdEncryptSave = new System.Windows.Forms.Button();
            this.cmdEncryptOpen = new System.Windows.Forms.Button();
            this.lblEncryptInfo = new System.Windows.Forms.Label();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.grpDecrypt.SuspendLayout();
            this.grpEncrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdEncrypt
            // 
            this.cmdEncrypt.Enabled = false;
            this.cmdEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEncrypt.Location = new System.Drawing.Point(189, 205);
            this.cmdEncrypt.Name = "cmdEncrypt";
            this.cmdEncrypt.Size = new System.Drawing.Size(111, 23);
            this.cmdEncrypt.TabIndex = 9;
            this.cmdEncrypt.Text = "Encriptar";
            this.cmdEncrypt.UseVisualStyleBackColor = true;
            this.cmdEncrypt.Click += new System.EventHandler(this.cmdEncrypt_Click);
            // 
            // cmdDecrypt
            // 
            this.cmdDecrypt.Enabled = false;
            this.cmdDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDecrypt.Location = new System.Drawing.Point(183, 206);
            this.cmdDecrypt.Name = "cmdDecrypt";
            this.cmdDecrypt.Size = new System.Drawing.Size(111, 23);
            this.cmdDecrypt.TabIndex = 11;
            this.cmdDecrypt.Text = "Desencriptar";
            this.cmdDecrypt.UseVisualStyleBackColor = true;
            this.cmdDecrypt.Click += new System.EventHandler(this.cmdDecrypt_Click);
            // 
            // grpDecrypt
            // 
            this.grpDecrypt.Controls.Add(this.lblMensajeD);
            this.grpDecrypt.Controls.Add(this.btnReiniciarD);
            this.grpDecrypt.Controls.Add(this.lblGuardarD);
            this.grpDecrypt.Controls.Add(this.lblAbrirD);
            this.grpDecrypt.Controls.Add(this.cmdDecryptSave);
            this.grpDecrypt.Controls.Add(this.cmdDecryptOpen);
            this.grpDecrypt.Controls.Add(this.lblDecryptInfo);
            this.grpDecrypt.Controls.Add(this.cmdDecrypt);
            this.grpDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDecrypt.Location = new System.Drawing.Point(11, 12);
            this.grpDecrypt.Name = "grpDecrypt";
            this.grpDecrypt.Size = new System.Drawing.Size(300, 242);
            this.grpDecrypt.TabIndex = 20;
            this.grpDecrypt.TabStop = false;
            this.grpDecrypt.Text = "Desencriptar una imagen";
            // 
            // lblMensajeD
            // 
            this.lblMensajeD.AutoSize = true;
            this.lblMensajeD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeD.Location = new System.Drawing.Point(6, 160);
            this.lblMensajeD.Name = "lblMensajeD";
            this.lblMensajeD.Size = new System.Drawing.Size(292, 15);
            this.lblMensajeD.TabIndex = 31;
            this.lblMensajeD.Text = "Seleccione los datos requeridos usando los botones";
            // 
            // btnReiniciarD
            // 
            this.btnReiniciarD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciarD.Location = new System.Drawing.Point(9, 112);
            this.btnReiniciarD.Name = "btnReiniciarD";
            this.btnReiniciarD.Size = new System.Drawing.Size(162, 23);
            this.btnReiniciarD.TabIndex = 30;
            this.btnReiniciarD.Text = "Reiniciar valores";
            this.btnReiniciarD.UseVisualStyleBackColor = true;
            this.btnReiniciarD.Visible = false;
            this.btnReiniciarD.Click += new System.EventHandler(this.btnReiniciarD_Click);
            // 
            // lblGuardarD
            // 
            this.lblGuardarD.AutoSize = true;
            this.lblGuardarD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardarD.Location = new System.Drawing.Point(177, 75);
            this.lblGuardarD.Name = "lblGuardarD";
            this.lblGuardarD.Size = new System.Drawing.Size(113, 15);
            this.lblGuardarD.TabIndex = 29;
            this.lblGuardarD.Text = "Nada seleccionado";
            // 
            // lblAbrirD
            // 
            this.lblAbrirD.AutoSize = true;
            this.lblAbrirD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrirD.Location = new System.Drawing.Point(177, 36);
            this.lblAbrirD.Name = "lblAbrirD";
            this.lblAbrirD.Size = new System.Drawing.Size(113, 15);
            this.lblAbrirD.TabIndex = 28;
            this.lblAbrirD.Text = "Nada seleccionado";
            // 
            // cmdDecryptSave
            // 
            this.cmdDecryptSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDecryptSave.Location = new System.Drawing.Point(9, 72);
            this.cmdDecryptSave.Name = "cmdDecryptSave";
            this.cmdDecryptSave.Size = new System.Drawing.Size(162, 23);
            this.cmdDecryptSave.TabIndex = 26;
            this.cmdDecryptSave.Text = "Guardar como archivo de texto";
            this.cmdDecryptSave.UseVisualStyleBackColor = true;
            this.cmdDecryptSave.Click += new System.EventHandler(this.cmdDecryptSave_Click);
            // 
            // cmdDecryptOpen
            // 
            this.cmdDecryptOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDecryptOpen.Location = new System.Drawing.Point(9, 33);
            this.cmdDecryptOpen.Name = "cmdDecryptOpen";
            this.cmdDecryptOpen.Size = new System.Drawing.Size(162, 23);
            this.cmdDecryptOpen.TabIndex = 25;
            this.cmdDecryptOpen.Text = "Abrir imagen encriptada";
            this.cmdDecryptOpen.UseVisualStyleBackColor = true;
            this.cmdDecryptOpen.Click += new System.EventHandler(this.cmdDecryptOpen_Click);
            // 
            // lblDecryptInfo
            // 
            this.lblDecryptInfo.AutoSize = true;
            this.lblDecryptInfo.Location = new System.Drawing.Point(6, 207);
            this.lblDecryptInfo.Name = "lblDecryptInfo";
            this.lblDecryptInfo.Size = new System.Drawing.Size(100, 18);
            this.lblDecryptInfo.TabIndex = 22;
            this.lblDecryptInfo.Text = "<Information>";
            // 
            // grpEncrypt
            // 
            this.grpEncrypt.Controls.Add(this.lblMensajeE);
            this.grpEncrypt.Controls.Add(this.btnReiniciarE);
            this.grpEncrypt.Controls.Add(this.lblGuardarE);
            this.grpEncrypt.Controls.Add(this.lblCargarE);
            this.grpEncrypt.Controls.Add(this.lblSeleccionarE);
            this.grpEncrypt.Controls.Add(this.cmdEncryptPayload);
            this.grpEncrypt.Controls.Add(this.cmdEncryptSave);
            this.grpEncrypt.Controls.Add(this.cmdEncryptOpen);
            this.grpEncrypt.Controls.Add(this.lblEncryptInfo);
            this.grpEncrypt.Controls.Add(this.cmdEncrypt);
            this.grpEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEncrypt.Location = new System.Drawing.Point(317, 12);
            this.grpEncrypt.Name = "grpEncrypt";
            this.grpEncrypt.Size = new System.Drawing.Size(300, 242);
            this.grpEncrypt.TabIndex = 21;
            this.grpEncrypt.TabStop = false;
            this.grpEncrypt.Text = "Encriptar una imagen";
            // 
            // lblMensajeE
            // 
            this.lblMensajeE.AutoSize = true;
            this.lblMensajeE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeE.Location = new System.Drawing.Point(6, 160);
            this.lblMensajeE.Name = "lblMensajeE";
            this.lblMensajeE.Size = new System.Drawing.Size(292, 15);
            this.lblMensajeE.TabIndex = 32;
            this.lblMensajeE.Text = "Seleccione los datos requeridos usando los botones";
            // 
            // btnReiniciarE
            // 
            this.btnReiniciarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciarE.Location = new System.Drawing.Point(11, 152);
            this.btnReiniciarE.Name = "btnReiniciarE";
            this.btnReiniciarE.Size = new System.Drawing.Size(162, 23);
            this.btnReiniciarE.TabIndex = 31;
            this.btnReiniciarE.Text = "Reiniciar valores";
            this.btnReiniciarE.UseVisualStyleBackColor = true;
            this.btnReiniciarE.Visible = false;
            this.btnReiniciarE.Click += new System.EventHandler(this.btnReiniciarE_Click);
            // 
            // lblGuardarE
            // 
            this.lblGuardarE.AutoSize = true;
            this.lblGuardarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardarE.Location = new System.Drawing.Point(179, 115);
            this.lblGuardarE.Name = "lblGuardarE";
            this.lblGuardarE.Size = new System.Drawing.Size(113, 15);
            this.lblGuardarE.TabIndex = 30;
            this.lblGuardarE.Text = "Nada seleccionado";
            // 
            // lblCargarE
            // 
            this.lblCargarE.AutoSize = true;
            this.lblCargarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargarE.Location = new System.Drawing.Point(179, 36);
            this.lblCargarE.Name = "lblCargarE";
            this.lblCargarE.Size = new System.Drawing.Size(113, 15);
            this.lblCargarE.TabIndex = 30;
            this.lblCargarE.Text = "Nada seleccionado";
            // 
            // lblSeleccionarE
            // 
            this.lblSeleccionarE.AutoSize = true;
            this.lblSeleccionarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarE.Location = new System.Drawing.Point(179, 75);
            this.lblSeleccionarE.Name = "lblSeleccionarE";
            this.lblSeleccionarE.Size = new System.Drawing.Size(113, 15);
            this.lblSeleccionarE.TabIndex = 31;
            this.lblSeleccionarE.Text = "Nada seleccionado";
            // 
            // cmdEncryptPayload
            // 
            this.cmdEncryptPayload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEncryptPayload.Location = new System.Drawing.Point(9, 33);
            this.cmdEncryptPayload.Name = "cmdEncryptPayload";
            this.cmdEncryptPayload.Size = new System.Drawing.Size(164, 23);
            this.cmdEncryptPayload.TabIndex = 29;
            this.cmdEncryptPayload.Text = "Cargar archivo a encriptar";
            this.cmdEncryptPayload.UseVisualStyleBackColor = true;
            this.cmdEncryptPayload.Click += new System.EventHandler(this.cmdEncryptPayload_Click);
            // 
            // cmdEncryptSave
            // 
            this.cmdEncryptSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEncryptSave.Location = new System.Drawing.Point(9, 112);
            this.cmdEncryptSave.Name = "cmdEncryptSave";
            this.cmdEncryptSave.Size = new System.Drawing.Size(164, 23);
            this.cmdEncryptSave.TabIndex = 28;
            this.cmdEncryptSave.Text = "Guardar como imagen";
            this.cmdEncryptSave.UseVisualStyleBackColor = true;
            this.cmdEncryptSave.Click += new System.EventHandler(this.cmdEncryptSave_Click);
            // 
            // cmdEncryptOpen
            // 
            this.cmdEncryptOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEncryptOpen.Location = new System.Drawing.Point(9, 72);
            this.cmdEncryptOpen.Name = "cmdEncryptOpen";
            this.cmdEncryptOpen.Size = new System.Drawing.Size(164, 23);
            this.cmdEncryptOpen.TabIndex = 27;
            this.cmdEncryptOpen.Text = "Seleccionar imagen a copiar";
            this.cmdEncryptOpen.UseVisualStyleBackColor = true;
            this.cmdEncryptOpen.Click += new System.EventHandler(this.cmdEncryptOpen_Click);
            // 
            // lblEncryptInfo
            // 
            this.lblEncryptInfo.AutoSize = true;
            this.lblEncryptInfo.Location = new System.Drawing.Point(12, 206);
            this.lblEncryptInfo.Name = "lblEncryptInfo";
            this.lblEncryptInfo.Size = new System.Drawing.Size(100, 18);
            this.lblEncryptInfo.TabIndex = 23;
            this.lblEncryptInfo.Text = "<Information>";
            // 
            // ofdOpen
            // 
            this.ofdOpen.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 261);
            this.Controls.Add(this.grpEncrypt);
            this.Controls.Add(this.grpDecrypt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageCrypter";
            this.grpDecrypt.ResumeLayout(false);
            this.grpDecrypt.PerformLayout();
            this.grpEncrypt.ResumeLayout(false);
            this.grpEncrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdEncrypt;
        private System.Windows.Forms.Button cmdDecrypt;
        private System.Windows.Forms.GroupBox grpDecrypt;
        private System.Windows.Forms.GroupBox grpEncrypt;
        private System.Windows.Forms.Label lblDecryptInfo;
        private System.Windows.Forms.Label lblEncryptInfo;
        private System.Windows.Forms.Button cmdDecryptSave;
        private System.Windows.Forms.Button cmdDecryptOpen;
        private System.Windows.Forms.Button cmdEncryptSave;
        private System.Windows.Forms.Button cmdEncryptOpen;
        private System.Windows.Forms.Button cmdEncryptPayload;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.Label lblGuardarD;
        private System.Windows.Forms.Label lblAbrirD;
        private System.Windows.Forms.Label lblCargarE;
        private System.Windows.Forms.Label lblSeleccionarE;
        private System.Windows.Forms.Label lblGuardarE;
        private System.Windows.Forms.Button btnReiniciarD;
        private System.Windows.Forms.Button btnReiniciarE;
        private System.Windows.Forms.Label lblMensajeD;
        private System.Windows.Forms.Label lblMensajeE;
    }
}

