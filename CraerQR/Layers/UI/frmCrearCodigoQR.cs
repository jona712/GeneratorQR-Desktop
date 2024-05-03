using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CraerQR.Entidades
{
    public partial class frmCrearCodigoQR : Form
    {

        public frmCrearCodigoQR()
        {
            InitializeComponent();
        }

        private void btnCrearQR_Click(object sender, EventArgs e)
        {    
            try
            {
                erpErrores.Clear();

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Guardar código QR";
                saveFile.Filter = "Imágenes PNG (*.png)|*.png|Todos los archivos (*.*)|*.*";
                saveFile.FileName = "codigoQR.png";

                if (rdbTexto.Checked == false) {
                    erpErrores.SetError(gpbTipoDato, "Debe seleccionar un tipo de dato");
                    return;
                }

                if (rdbTexto.Checked)
                {
                    if (string.IsNullOrEmpty(txtTexto.Text))
                    {
                        erpErrores.SetError(txtTexto, "Debe ingresar el texto");
                        return;
                    }

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {

                        string rutaImagen = saveFile.FileName;

                        if (File.Exists(rutaImagen))
                            File.Delete(rutaImagen);

                        // Crear imagen quickresponse
                        Image quickResponseImage = QuickResponse.QuickResponseGenerador(txtTexto.Text, 53);

                        // Salvarla en c:\temp para luego ser leida
                        quickResponseImage.Save(rutaImagen, ImageFormat.Png);

                        MessageBox.Show("Se generó correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", ex.Message);
                msg.AppendFormat("Source         {0}\n", ex.Source);
                msg.AppendFormat("InnerException {0}\n", ex.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", ex.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", ex.TargetSite);
            }

        }

        private void frmCrearCodigoQR_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdbTexto_CheckedChanged(object sender, EventArgs e)
        {
            txtTexto.Visible = true;
        }
    }
}
