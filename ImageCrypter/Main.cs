using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCrypter
{
    public partial class Main : Form
    {
        string decryptInput = "";
        string decryptOutput = "";

        string encryptInput = "";
        string encryptOutput = "";
        string encryptPayload = "";

        public Main()
        {
            InitializeComponent();
            lblDecryptInfo.Text = "";
            lblEncryptInfo.Text = "";
        }


        //
        //  File Dialog Stuff
        //

        // Decrypt

        void UpdateDecryptButtons()
        {
            if (decryptInput != "" && decryptOutput != "")
                cmdDecrypt.Enabled = true;
            else
                cmdDecrypt.Enabled = false;
        }

        private void cmdDecryptOpen_Click(object sender, EventArgs e)
        {
            ofdOpen = new OpenFileDialog();
            ofdOpen.Filter = "Image files|*.jpg;*.gif;*.png";
            if(ofdOpen.ShowDialog() == DialogResult.OK)
            {
                decryptInput = ofdOpen.FileName;
                UpdateDecryptButtons();
                lblAbrirD.ForeColor = System.Drawing.Color.Green;
                lblAbrirD.Text = "Selección correcta";
            }
        }

        private void cmdDecryptSave_Click(object sender, EventArgs e)
        {
            sfdSave = new SaveFileDialog();
            sfdSave.Filter = "Text files|*.txt";
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                decryptOutput = sfdSave.FileName;
                UpdateDecryptButtons();
                lblGuardarD.ForeColor = System.Drawing.Color.Green;
                lblGuardarD.Text = "Selección correcta";
            }
            UpdateDecryptButtons();
        }

        // Encrypt

        void UpdateEncryptButtons()
        {
            if (encryptInput != "" && encryptOutput != "" && encryptPayload != "")
                cmdEncrypt.Enabled = true;
            else
                cmdEncrypt.Enabled = false;
        }

        private void cmdEncryptOpen_Click(object sender, EventArgs e)
        {
            ofdOpen = new OpenFileDialog();
            ofdOpen.Filter = "Image files|*.jpg;*.gif;*.png";
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                encryptInput = ofdOpen.FileName;
                UpdateDecryptButtons();
                lblSeleccionarE.ForeColor = System.Drawing.Color.Green;
                lblSeleccionarE.Text = "Selección correcta";
            }
            UpdateEncryptButtons();
        }

        private void cmdEncryptSave_Click(object sender, EventArgs e)
        {
            sfdSave = new SaveFileDialog();
            sfdSave.Filter = "Image files|*.jpg;*.gif;*.png";
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                encryptOutput = sfdSave.FileName;
                UpdateDecryptButtons();
                lblGuardarE.ForeColor = System.Drawing.Color.Green;
                lblGuardarE.Text = "Selección correcta";
            }
            UpdateEncryptButtons();
        }

        private void cmdEncryptPayload_Click(object sender, EventArgs e)
        {
            ofdOpen = new OpenFileDialog();
            ofdOpen.Filter = "Text files|*.txt";
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                encryptPayload = ofdOpen.FileName;
                UpdateDecryptButtons();
                lblCargarE.ForeColor = System.Drawing.Color.Green;
                lblCargarE.Text = "Selección correcta";
            }
            UpdateEncryptButtons();
        }

        //
        //  Crypter Methods
        //

        // Decrypt

        private async void cmdDecrypt_Click(object sender, EventArgs e)
        {
            int b = 1;
            ImageCrypter img = new ImageCrypter(decryptInput, decryptOutput);
            try
            {
                Task<int> t = Task.Factory.StartNew(() => img.Decrypt(b));

                Invoke((MethodInvoker)delegate
                {
                    lblDecryptInfo.Text = "Desencriptando...";
                });

                await t;
                if (t.Result >= 0)
                {
                    MessageBox.Show(this, "Listo!\nSegundos transcurridos: " + t.Result / 1000.0, "Mensaje desencriptado exitosamente");

                    Invoke((MethodInvoker)delegate
                    {
                        lblDecryptInfo.Text = "Mensaje desencriptado.";
                        cmdDecrypt.Enabled = false;
                        cmdDecryptOpen.Enabled = false;
                        cmdDecryptSave.Enabled = false;
                        lblMensajeD.Visible = false;
                        btnReiniciarD.Visible = true;
                    });
                }
                else if (t.Result < 0)
                {
                    throw new ArgumentException();
                }
            }
            catch
            {
                MessageBox.Show(this, "Ha ocurrido un error. Vuelva a intentarlo.", "Error");
                reiniciarD();
            }
        }

        // Encrypt

        private async void cmdEncrypt_Click(object sender, EventArgs e)
        {
            int b = 1;
            ImageCrypter img = new ImageCrypter(encryptInput, encryptOutput, encryptPayload);
            try
            {
                Task<int> t = Task.Factory.StartNew(() => img.Encrypt(b));

                Invoke((MethodInvoker)delegate
                {
                    lblEncryptInfo.Text = "Encriptando...";
                });

                await t;
                if (t.Result >= 0)
                {
                    MessageBox.Show(this, "Listo!\nSegundos transcurridos: " + t.Result / 1000.0, "Mensaje encriptado exitosamente");

                    Invoke((MethodInvoker)delegate
                    {
                        lblEncryptInfo.Text = "Mensaje encriptado.";
                        cmdEncrypt.Enabled = false;
                        cmdEncryptOpen.Enabled = false;
                        cmdEncryptSave.Enabled = false;
                        cmdEncryptPayload.Enabled = false;
                        lblMensajeE.Visible = false;
                        btnReiniciarE.Visible = true;
                    });
                }
                else if (t.Result < 0)
                {
                    throw new ArgumentException();
                }
            }
            catch
            {
                MessageBox.Show(this, "Ha ocurrido un error. Vuelva a intentarlo.", "Error");
                reiniciarE();
            }
        }

        private void btnReiniciarD_Click(object sender, EventArgs e)
        {
            reiniciarD();
        }

        private void btnReiniciarE_Click(object sender, EventArgs e)
        {
            reiniciarE();
        }

        private void reiniciarD()
        {
            decryptInput = "";
            decryptOutput = "";
            UpdateDecryptButtons();
            lblDecryptInfo.Text = "";
            lblAbrirD.ForeColor = System.Drawing.Color.Black;
            lblAbrirD.Text = "Nada seleccionado";
            lblGuardarD.ForeColor = System.Drawing.Color.Black;
            lblGuardarD.Text = "Nada seleccionado";
            btnReiniciarD.Visible = false;
            lblMensajeD.Visible = true;
            cmdDecryptOpen.Enabled = true;
            cmdDecryptSave.Enabled = true;
        }

        private void reiniciarE()
        {
            encryptInput = "";
            encryptOutput = "";
            UpdateEncryptButtons();
            lblEncryptInfo.Text = "";
            lblCargarE.ForeColor = System.Drawing.Color.Black;
            lblCargarE.Text = "Nada seleccionado";
            lblSeleccionarE.ForeColor = System.Drawing.Color.Black;
            lblSeleccionarE.Text = "Nada seleccionado";
            lblGuardarE.ForeColor = System.Drawing.Color.Black;
            lblGuardarE.Text = "Nada seleccionado";
            btnReiniciarE.Visible = false;
            lblMensajeE.Visible = true;
            cmdEncryptOpen.Enabled = true;
            cmdEncryptSave.Enabled = true;
            cmdEncryptPayload.Enabled = true;
        }
    }
}
