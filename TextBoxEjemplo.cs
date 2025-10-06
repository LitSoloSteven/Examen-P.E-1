using System.Windows.Forms;
using System.Drawing;

namespace TextBoxEjemploSimple
{
    public class MiFormulario : Form
    {
        private TextBox txtDato;

        public MiFormulario()
        {
            this.Text = "Ejemplo de TextBox";
            this.Size = new Size(300, 200);

            txtDato = new TextBox();
            txtDato.Location = new Point(50, 50);
            txtDato.Text = "Escribe algo..."; 

            Button btnAccion = new Button();
            btnAccion.Text = "Leer Texto";
            btnAccion.Location = new Point(50, 80);
            
            btnAccion.Click += new System.EventHandler(this.LeerTexto_Click);

            this.Controls.Add(txtDato);
            this.Controls.Add(btnAccion);
        }

        private void LeerTexto_Click(object sender, System.EventArgs e)
        {
            // LA LÍNEA CLAVE: Obtenemos el texto del TextBox
            string textoCapturado = txtDato.Text; 
            
            MessageBox.Show("¡Capturamos el texto! Dice: " + textoCapturado, "TextBox Leído");
        }
        
        [System.STAThread]
        public static void Main()
        {
            Application.Run(new MiFormulario());
        }
    }
}
