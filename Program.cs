using System;
using System.Drawing;
using System.Windows.Forms;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Crear formulario
        Form form = new Form();
        form.Text = "Saludo";
        form.StartPosition = FormStartPosition.CenterScreen;
        form.ClientSize = new Size(320, 160);

        // Crear botón Saludar
        Button btnSaludar = new Button();
        btnSaludar.Text = "Saludar";
        btnSaludar.Location = new Point((form.ClientSize.Width - 80) / 2, 50);
        btnSaludar.AutoSize = true;
        btnSaludar.Click += (s, e) =>
        {
            MessageBox.Show("¡Hola! Has hecho clic en el botón.", "Saludo");
        };

        form.Controls.Add(btnSaludar);

        Application.Run(form);
    }
}