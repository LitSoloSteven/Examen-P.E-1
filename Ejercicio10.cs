using System;
using System.Drawing;
using System.Windows.Forms;

namespace MatricesApp
{
    public class FrmDiagonales4x4 : Form
    {
        private TextBox[,] matrizInput = new TextBox[4, 4];
        private Label? lblDiagonalPrincipal;
        private Label? lblDiagonalSecundaria;
        private Button? btnMostrarDiagonales;

        public FrmDiagonales4x4()
        {
            this.Text = "Diagonales de Matriz 4x4";
            this.Size = new Size(500, 350);
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            Label lblTitulo = new Label()
            {
                Text = "Ingrese los valores de la matriz 4x4:",
                Location = new Point(100, 20),
                AutoSize = true
            };
            Controls.Add(lblTitulo);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrizInput[i, j] = new TextBox()
                    {
                        Location = new Point(100 + j * 40, 50 + i * 30),
                        Size = new Size(30, 20)
                    };
                    Controls.Add(matrizInput[i, j]);
                }
            }

            btnMostrarDiagonales = new Button()
            {
                Text = "Mostrar Diagonales",
                Location = new Point(150, 180),
                Width = 150
            };
            btnMostrarDiagonales.Click += (s, e) => CalcularDiagonales();
            Controls.Add(btnMostrarDiagonales);

            lblDiagonalPrincipal = new Label()
            {
                Location = new Point(100, 220),
                AutoSize = true,
                Text = "Diagonal principal: "
            };
            lblDiagonalSecundaria = new Label()
            {
                Location = new Point(100, 250),
                AutoSize = true,
                Text = "Diagonal secundaria: "
            };
            Controls.Add(lblDiagonalPrincipal);
            Controls.Add(lblDiagonalSecundaria);
        }

        private void CalcularDiagonales()
        {
            try
            {
                int[,] matriz = new int[4, 4];
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                        matriz[i, j] = int.Parse(matrizInput[i, j].Text);

                string diagPrincipal = "";
                string diagSecundaria = "";

                for (int i = 0; i < 4; i++)
                {
                    diagPrincipal += matriz[i, i] + " ";
                    diagSecundaria += matriz[i, 3 - i] + " ";
                }

                if (lblDiagonalPrincipal != null)
                    lblDiagonalPrincipal.Text = "Diagonal principal: " + diagPrincipal;
                if (lblDiagonalSecundaria != null)
                    lblDiagonalSecundaria.Text = "Diagonal secundaria: " + diagSecundaria;
            }
            catch
            {
                MessageBox.Show("Por favor ingrese solo números válidos.", "Error de entrada");
            }
        }
    }

    static class Program
    {
        /// <summary>
        ///  Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDiagonales4x4());
        }
    }
}