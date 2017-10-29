namespace SJB.MeritViewer.CSharp.WindowsForms.Views
{
  partial class frmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.labelForTreeView = new System.Windows.Forms.Label();
      this.buttonSettings = new System.Windows.Forms.Button();
      this.buttonAbout = new System.Windows.Forms.Button();
      this.listView1 = new System.Windows.Forms.ListView();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonFilterAll = new System.Windows.Forms.Button();
      this.labelAppHeader = new System.Windows.Forms.Label();
      this.pbxSelectedMerit = new System.Windows.Forms.PictureBox();
      this.buttonFilterVS = new System.Windows.Forms.Button();
      this.buttonFilterNC = new System.Windows.Forms.Button();
      this.buttonFilterTR = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedMerit)).BeginInit();
      this.SuspendLayout();
      // 
      // treeView1
      // 
      this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.treeView1.Location = new System.Drawing.Point(10, 109);
      this.treeView1.Margin = new System.Windows.Forms.Padding(2);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(274, 343);
      this.treeView1.TabIndex = 0;
      this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
      // 
      // labelForTreeView
      // 
      this.labelForTreeView.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelForTreeView.Location = new System.Drawing.Point(7, 80);
      this.labelForTreeView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelForTreeView.Name = "labelForTreeView";
      this.labelForTreeView.Size = new System.Drawing.Size(277, 27);
      this.labelForTreeView.TabIndex = 1;
      this.labelForTreeView.Text = "Select a Category, Group or Merit Here...";
      this.labelForTreeView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // buttonSettings
      // 
      this.buttonSettings.Location = new System.Drawing.Point(808, 476);
      this.buttonSettings.Name = "buttonSettings";
      this.buttonSettings.Size = new System.Drawing.Size(96, 32);
      this.buttonSettings.TabIndex = 2;
      this.buttonSettings.Text = "Settings";
      this.buttonSettings.UseVisualStyleBackColor = true;
      // 
      // buttonAbout
      // 
      this.buttonAbout.Location = new System.Drawing.Point(808, 514);
      this.buttonAbout.Name = "buttonAbout";
      this.buttonAbout.Size = new System.Drawing.Size(96, 32);
      this.buttonAbout.TabIndex = 3;
      this.buttonAbout.Text = "About";
      this.buttonAbout.UseVisualStyleBackColor = true;
      // 
      // listView1
      // 
      this.listView1.Location = new System.Drawing.Point(395, 237);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(277, 215);
      this.listView1.TabIndex = 4;
      this.listView1.UseCompatibleStateImageBehavior = false;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(10, 522);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(274, 27);
      this.label1.TabIndex = 6;
      this.label1.Text = "Filter by Empire or Select All Here...";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // buttonFilterAll
      // 
      this.buttonFilterAll.BackgroundImage = global::SJB.MeritViewer.CSharp.WindowsForms.Properties.Resources.logo_planetside;
      this.buttonFilterAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.buttonFilterAll.Location = new System.Drawing.Point(10, 457);
      this.buttonFilterAll.Name = "buttonFilterAll";
      this.buttonFilterAll.Size = new System.Drawing.Size(64, 64);
      this.buttonFilterAll.TabIndex = 7;
      this.buttonFilterAll.UseVisualStyleBackColor = true;
      // 
      // labelAppHeader
      // 
      this.labelAppHeader.Font = new System.Drawing.Font("Verdana", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelAppHeader.Location = new System.Drawing.Point(10, -2);
      this.labelAppHeader.Name = "labelAppHeader";
      this.labelAppHeader.Size = new System.Drawing.Size(894, 57);
      this.labelAppHeader.TabIndex = 12;
      this.labelAppHeader.Text = "PlanetSide MeritViewer";
      this.labelAppHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.labelAppHeader.Click += new System.EventHandler(this.labelAppHeader_Click);
      // 
      // pbxSelectedMerit
      // 
      this.pbxSelectedMerit.Location = new System.Drawing.Point(430, 124);
      this.pbxSelectedMerit.Name = "pbxSelectedMerit";
      this.pbxSelectedMerit.Size = new System.Drawing.Size(200, 40);
      this.pbxSelectedMerit.TabIndex = 11;
      this.pbxSelectedMerit.TabStop = false;
      // 
      // buttonFilterVS
      // 
      this.buttonFilterVS.BackgroundImage = global::SJB.MeritViewer.CSharp.WindowsForms.Properties.Resources.logo_vs;
      this.buttonFilterVS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.buttonFilterVS.Location = new System.Drawing.Point(220, 457);
      this.buttonFilterVS.Name = "buttonFilterVS";
      this.buttonFilterVS.Size = new System.Drawing.Size(64, 64);
      this.buttonFilterVS.TabIndex = 10;
      this.buttonFilterVS.UseVisualStyleBackColor = true;
      // 
      // buttonFilterNC
      // 
      this.buttonFilterNC.BackgroundImage = global::SJB.MeritViewer.CSharp.WindowsForms.Properties.Resources.logo_nc;
      this.buttonFilterNC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.buttonFilterNC.Location = new System.Drawing.Point(150, 457);
      this.buttonFilterNC.Name = "buttonFilterNC";
      this.buttonFilterNC.Size = new System.Drawing.Size(64, 64);
      this.buttonFilterNC.TabIndex = 9;
      this.buttonFilterNC.UseVisualStyleBackColor = true;
      // 
      // buttonFilterTR
      // 
      this.buttonFilterTR.BackgroundImage = global::SJB.MeritViewer.CSharp.WindowsForms.Properties.Resources.logo_tr;
      this.buttonFilterTR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.buttonFilterTR.Location = new System.Drawing.Point(80, 457);
      this.buttonFilterTR.Name = "buttonFilterTR";
      this.buttonFilterTR.Size = new System.Drawing.Size(64, 64);
      this.buttonFilterTR.TabIndex = 8;
      this.buttonFilterTR.UseVisualStyleBackColor = true;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(915, 561);
      this.Controls.Add(this.labelAppHeader);
      this.Controls.Add(this.pbxSelectedMerit);
      this.Controls.Add(this.buttonFilterVS);
      this.Controls.Add(this.buttonFilterNC);
      this.Controls.Add(this.buttonFilterTR);
      this.Controls.Add(this.buttonFilterAll);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.buttonAbout);
      this.Controls.Add(this.buttonSettings);
      this.Controls.Add(this.labelForTreeView);
      this.Controls.Add(this.treeView1);
      this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(371, 240);
      this.Name = "frmMain";
      this.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
      this.ShowIcon = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MeritViewer";
      ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedMerit)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.Label labelForTreeView;
    private System.Windows.Forms.Button buttonSettings;
    private System.Windows.Forms.Button buttonAbout;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttonFilterAll;
    private System.Windows.Forms.Button buttonFilterTR;
    private System.Windows.Forms.Button buttonFilterNC;
    private System.Windows.Forms.Button buttonFilterVS;
    private System.Windows.Forms.PictureBox pbxSelectedMerit;
    private System.Windows.Forms.Label labelAppHeader;
  }
}