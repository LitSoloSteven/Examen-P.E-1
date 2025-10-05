using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabelEnVSCode
{
    public class VentanaPrincipal : Form
    {
        private Label lblMensaje;
        private Button btnCambiar;

        public VentanaPrincipal()
        {
            // Configuración de la ventana
            this.Text = "Ejemplo de Label en VS Code";
            this.Size = new Size(400, 200);

            // Crear Label
            lblMensaje = new Label();
            lblMensaje.Text = "Hola Crack!";
            lblMensaje.Location = new Point(50, 40);
            lblMensaje.Font = new Font("Arial", 14);
            lblMensaje.ForeColor = Color.DarkBlue;
            lblMensaje.AutoSize = true;

            // Crear botón
            btnCambiar = new Button();
            btnCambiar.Text = "Cambiar texto";
            btnCambiar.Location = new Point(50, 80);
            btnCambiar.Click += BtnCambiar_Click;

            // Agregar controles
            Controls.Add(lblMensaje);
            Controls.Add(btnCambiar);
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "¡Texto cambiado desde VS Code!";
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new VentanaPrincipal());
        }
    }
}
