using System;
using System.Drawing;
using System.Windows.Forms;

namespace MatricesApp
{
    public class FrmSumaMatrices3x3 : Form
    {
        private TextBox[,] matrizA = new TextBox[3, 3];
        private TextBox[,] matrizB = new TextBox[3, 3];
        private Label[,] matrizResultado = new Label[3, 3];
        private Button? btnCalcular;

        public FrmSumaMatrices3x3()
        {
            this.Text = "Suma de Matrices 3x3";
            this.Size = new Size(500, 400);
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            Label lblA = new Label() { Text = "Matriz A", Location = new Point(50, 20) };
            Label lblB = new Label() { Text = "Matriz B", Location = new Point(200, 20) };
            Label lblR = new Label() { Text = "Resultado", Location = new Point(350, 20) };
            Controls.AddRange(new Control[] { lblA, lblB, lblR });

            // Crear campos de entrada y salida
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizA[i, j] = new TextBox() { Location = new Point(50 + j * 30, 50 + i * 30), Width = 25 };
                    matrizB[i, j] = new TextBox() { Location = new Point(200 + j * 30, 50 + i * 30), Width = 25 };
                    matrizResultado[i, j] = new Label() { Location = new Point(350 + j * 30, 50 + i * 30), Width = 25, TextAlign = ContentAlignment.MiddleCenter, BorderStyle = BorderStyle.FixedSingle };

                    Controls.Add(matrizA[i, j]);
                    Controls.Add(matrizB[i, j]);
                    Controls.Add(matrizResultado[i, j]);
                }
            }

            btnCalcular = new Button() { Text = "Sumar", Location = new Point(180, 160), Width = 100 };
            btnCalcular.Click += (s, e) => CalcularSuma();
            Controls.Add(btnCalcular);
        }

        private void CalcularSuma()
        {
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int a = int.Parse(matrizA[i, j].Text);
                        int b = int.Parse(matrizB[i, j].Text);
                        matrizResultado[i, j].Text = (a + b).ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Por favor ingrese solo números válidos en todas las casillas.", "Error de entrada");
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
            Application.Run(new FrmSumaMatrices3x3());
        }
    }
}
