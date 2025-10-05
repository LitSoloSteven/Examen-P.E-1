using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabelSimple
{
    public class VentanaPrincipal : Form
    {
        private Label lblMensaje;

        public VentanaPrincipal()
        {
            // Configurar la ventana
            this.Text = "Ejemplo básico de Label";
            this.Size = new Size(1366, 768);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Crear el label
            lblMensaje = new Label();
            lblMensaje.Text = "ejemplo de label, lol";
            lblMensaje.Font = new Font("Arial", 32);
            lblMensaje.ForeColor = Color.DarkBlue;
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(80, 50);

            // Agregar el label al formulario
            Controls.Add(lblMensaje);
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new VentanaPrincipal());
        }
    }
}
