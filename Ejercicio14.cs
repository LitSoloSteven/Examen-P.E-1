using System;
using System.Drawing;
using System.Windows.Forms;

namespace MatricesApp
{
    public class FrmMultiplicacion3x2x2x3 : Form
    {
        private TextBox[,] matrizA = new TextBox[3, 2];
        private TextBox[,] matrizB = new TextBox[2, 3];
        private Label[,] matrizResultado = new Label[3, 3];
        private Button? btnCalcular;

        public FrmMultiplicacion3x2x2x3()
        {
            this.Text = "Multiplicación (3x2) × (2x3)";
            this.Size = new Size(550, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            Label lblA = new Label() { Text = "Matriz A (3x2)", Location = new Point(40, 20), AutoSize = true };
            Label lblB = new Label() { Text = "Matriz B (2x3)", Location = new Point(220, 20), AutoSize = true };
            Label lblR = new Label() { Text = "Resultado (3x3)", Location = new Point(400, 20), AutoSize = true };
            Controls.AddRange(new Control[] { lblA, lblB, lblR });

            // Crear matriz A
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrizA[i, j] = new TextBox() { Location = new Point(50 + j * 30, 50 + i * 30), Width = 25 };
                    Controls.Add(matrizA[i, j]);
                }
            }

            // Crear matriz B
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizB[i, j] = new TextBox() { Location = new Point(220 + j * 30, 50 + i * 30), Width = 25 };
                    Controls.Add(matrizB[i, j]);
                }
            }

            // Crear matriz resultado
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizResultado[i, j] = new Label()
                    {
                        Location = new Point(400 + j * 30, 50 + i * 30),
                        Size = new Size(25, 20),
                        BorderStyle = BorderStyle.FixedSingle,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    Controls.Add(matrizResultado[i, j]);
                }
            }

            btnCalcular = new Button()
            {
                Text = "Multiplicar",
                Location = new Point(200, 150),
                Width = 120
            };
            btnCalcular.Click += (s, e) => Multiplicar();
            Controls.Add(btnCalcular);
        }

        private void Multiplicar()
        {
            try
            {
                int[,] A = new int[3, 2];
                int[,] B = new int[2, 3];
                int[,] R = new int[3, 3];

                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 2; j++)
                        A[i, j] = int.Parse(matrizA[i, j].Text);

                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < 3; j++)
                        B[i, j] = int.Parse(matrizB[i, j].Text);

                // Multiplicación: (3x2) × (2x3) = (3x3)
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        R[i, j] = A[i, 0] * B[0, j] + A[i, 1] * B[1, j];
                    }
                }

                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        matrizResultado[i, j].Text = R[i, j].ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese solo números enteros válidos en todas las casillas.", "Error de entrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error");
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
            Application.Run(new FrmMultiplicacion3x2x2x3());
        }
    }
}