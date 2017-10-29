using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SJB.MeritViewer.CSharp.WindowsForms.Views
{
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
      initializeCustomFont();
    }

    void initializeCustomFont()
    {
      //Create your private font collection object.
      PrivateFontCollection pfc = new PrivateFontCollection();

      //Select your font from the resources.
      //My font here is "Digireu.ttf"
      int fontLength = Properties.Resources.Coalition.Length;

      // create a buffer to read in to
      byte[] fontdata = Properties.Resources.Coalition;

      // create an unsafe memory block for the font data
      System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

      // copy the bytes to the unsafe memory block
      Marshal.Copy(fontdata, 0, data, fontLength);

      // pass the font to the font collection
      pfc.AddMemoryFont(data, fontLength);

      labelAppHeader.Font = new Font(pfc.Families[0], 32);
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {

    }

    private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
    {

    }

    private void labelAppHeader_Click(object sender, EventArgs e)
    {

    }
  }
}
