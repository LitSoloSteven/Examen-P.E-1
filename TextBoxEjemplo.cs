using System.Windows.Forms;
using System.Drawing;

public class MiniForm : Form
{
    private TextBox t;

    public MiniForm()
    {
        this.Text = "Mini Demo";
        this.Size = new Size(300, 150);

        t = new TextBox { Location = new Point(50, 20), Text = "Escribe aquí" };
        Button b = new Button { Location = new Point(50, 50), Text = "Mostrar" };
        
        b.Click += (s, e) => {
            MessageBox.Show("El texto es: " + t.Text);
        };

        Controls.Add(t);
        Controls.Add(b);
    }
    
    [System.STAThread]
    public static void Main()
    {
        Application.Run(new MiniForm());
    }
}
