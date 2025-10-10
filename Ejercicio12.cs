using System;
using System.Drawing;
using System.Windows.Forms;

namespace MatricesApp
{
    public class FrmMultiplicacion2x2 : Form
    {
        private TextBox[,] matrizA = new TextBox[2, 2];
        private TextBox[,] matrizB = new TextBox[2, 2];
        private Label[,] matrizResultado = new Label[2, 2];
        private Button? btnMultiplicar;

        public FrmMultiplicacion2x2()
        {
            this.Text = "Multiplicación de Matrices 2x2";
            this.Size = new Size(450, 300);
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            Label lblA = new Label() { Text = "Matriz A", Location = new Point(50, 20) };
            Label lblB = new Label() { Text = "Matriz B", Location = new Point(200, 20) };
            Label lblR = new Label() { Text = "Resultado", Location = new Point(350, 20) };
            Controls.AddRange(new Control[] { lblA, lblB, lblR });

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrizA[i, j] = new TextBox() { Location = new Point(50 + j * 30, 50 + i * 30), Width = 25 };
                    matrizB[i, j] = new TextBox() { Location = new Point(200 + j * 30, 50 + i * 30), Width = 25 };
                    matrizResultado[i, j] = new Label() { Location = new Point(350 + j * 30, 50 + i * 30), Width = 25, BorderStyle = BorderStyle.FixedSingle, TextAlign = ContentAlignment.MiddleCenter };

                    Controls.Add(matrizA[i, j]);
                    Controls.Add(matrizB[i, j]);
                    Controls.Add(matrizResultado[i, j]);
                }
            }

            btnMultiplicar = new Button() { Text = "Multiplicar", Location = new Point(170, 130), Width = 100 };
            btnMultiplicar.Click += (s, e) => Multiplicar();
            Controls.Add(btnMultiplicar);
        }

        private void Multiplicar()
        {
            try
            {
                int[,] A = new int[2, 2];
                int[,] B = new int[2, 2];
                int[,] R = new int[2, 2];

                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < 2; j++)
                    {
                        A[i, j] = int.Parse(matrizA[i, j].Text);
                        B[i, j] = int.Parse(matrizB[i, j].Text);
                    }

                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < 2; j++)
                        R[i, j] = A[i, 0] * B[0, j] + A[i, 1] * B[1, j];

                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < 2; j++)
                        matrizResultado[i, j].Text = R[i, j].ToString();
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
            Application.Run(new FrmMultiplicacion2x2());
        }
    }
}