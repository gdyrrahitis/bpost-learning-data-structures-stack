namespace Command.Pattern.WForm
{
    using System;
    using System.Windows.Forms;

    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
