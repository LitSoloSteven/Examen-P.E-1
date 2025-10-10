using System;
using System.Drawing;
using System.Windows.Forms;

namespace MatricesApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSumaPares4x4());
        }
    }

    public class FrmSumaPares4x4 : Form
    {
        private Label[,] matrizLabels = new Label[4, 4];
        private Button? btnGenerar;
        private Label? lblResultado;
        private Random random = new Random();

        public FrmSumaPares4x4()
        {
            this.Text = "Suma de Elementos Pares (4x4)";
            this.Size = new Size(400, 350);
            CrearInterfaz();
        }

        private void CrearInterfaz()
        {
            Label titulo = new Label()
            {
                Text = "Matriz generada aleatoriamente:",
                Location = new Point(50, 20),
                AutoSize = true
            };
            Controls.Add(titulo);

            // Crear etiquetas para mostrar la matriz
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrizLabels[i, j] = new Label()
                    {
                        Location = new Point(80 + j * 40, 50 + i * 30),
                        Size = new Size(30, 20),
                        BorderStyle = BorderStyle.FixedSingle,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    Controls.Add(matrizLabels[i, j]);
                }
            }

            btnGenerar = new Button()
            {
                Text = "Generar y Calcular",
                Location = new Point(120, 180),
                Width = 150
            };
            btnGenerar.Click += (s, e) => GenerarYSumar();
            Controls.Add(btnGenerar);

            lblResultado = new Label()
            {
                Text = "Suma de pares: ",
                Location = new Point(120, 220),
                AutoSize = true
            };
            Controls.Add(lblResultado);
        }

        private void GenerarYSumar()
        {
            int sumaPares = 0;

            // Generar números y sumarlos si son pares
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int valor = random.Next(1, 100);
                    matrizLabels[i, j].Text = valor.ToString();

                    if (valor % 2 == 0)
                        sumaPares += valor;
                }
            }

            if (lblResultado != null)
                lblResultado.Text = $"Suma de pares: {sumaPares}";
        }
    }
}
