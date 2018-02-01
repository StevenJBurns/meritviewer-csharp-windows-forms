using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using SJB.MeritViewer.WindowsForms.UI;

namespace SJB.MeritViewer.WindowsForms.Program
  {
  static class Program
    {
    /// <summary>The main entry point for the application.</summary>
    [STAThread]
    static void Main()
      {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FormMain());
      }
    }
  }
