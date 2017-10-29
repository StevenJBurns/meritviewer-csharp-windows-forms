using System;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SJB.MeritViewer.CSharp.WindowsForms.Views;

namespace SJB.MeritViewer.CSharp.WindowsForms
{
  static class Program
  {
  [STAThread]
  static void Main()
    {
      Application.EnableVisualStyles();

      //InitFont();

      Application.Run(new frmMain());

    }

  }
}
