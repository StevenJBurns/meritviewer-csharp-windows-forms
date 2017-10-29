using System;
using System.Windows.Forms;
using SJB.MeritViewer.CSharp.WindowsForms.Views;


namespace SJB.MeritViewer.CSharp.WindowsForms
{
  static class Program
  {
  [STAThread]
  static void Main()
    {
      Application.EnableVisualStyles();

      Application.Run(new frmMain());

    }
  }
}
