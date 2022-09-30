namespace GoogleMaps_Application
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.smallimage = new System.Windows.Forms.ImageList(this.components);
            this.bigimage = new System.Windows.Forms.ImageList(this.components);
            this.BKProgress = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.Strip_State = new System.Windows.Forms.StatusStrip();
            this.lbl_state = new System.Windows.Forms.ToolStripStatusLabel();
            this.pb_state = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.Strip_State.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 1;
            this.treeView1.ImageList = this.smallimage;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 4;
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.Size = new System.Drawing.Size(248, 537);
            this.treeView1.TabIndex = 0;
            // 
            // smallimage
            // 
            this.smallimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallimage.ImageStream")));
            this.smallimage.TransparentColor = System.Drawing.Color.Transparent;
            this.smallimage.Images.SetKeyName(0, "country_small.png");
            this.smallimage.Images.SetKeyName(1, "city_small.png");
            this.smallimage.Images.SetKeyName(2, "Entypo_2b(2)_16.png");
            this.smallimage.Images.SetKeyName(3, "Entypo_2d(1)_16.png");
            this.smallimage.Images.SetKeyName(4, "Entypo_26ab(0)_16.png");
            // 
            // bigimage
            // 
            this.bigimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("bigimage.ImageStream")));
            this.bigimage.TransparentColor = System.Drawing.Color.Transparent;
            this.bigimage.Images.SetKeyName(0, "country.png");
            this.bigimage.Images.SetKeyName(1, "city.png");
            // 
            // BKProgress
            // 
            this.BKProgress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BKProgress_DoWork);
            this.BKProgress.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BKProgress_RunWorkerCompleted);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webView21);
            this.splitContainer1.Size = new System.Drawing.Size(869, 537);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 3;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(2, 3);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(612, 534);
            this.webView21.Source = new System.Uri("https://www.microsoft.com", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click);
            // 
            // Strip_State
            // 
            this.Strip_State.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_state,
            this.pb_state});
            this.Strip_State.Location = new System.Drawing.Point(0, 537);
            this.Strip_State.Name = "Strip_State";
            this.Strip_State.Size = new System.Drawing.Size(869, 22);
            this.Strip_State.TabIndex = 4;
            this.Strip_State.Text = "statusStrip1";
            // 
            // lbl_state
            // 
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(39, 17);
            this.lbl_state.Text = "Ready";
            // 
            // pb_state
            // 
            this.pb_state.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pb_state.Name = "pb_state";
            this.pb_state.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.pb_state.Size = new System.Drawing.Size(245, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 559);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Strip_State);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.Strip_State.ResumeLayout(false);
            this.Strip_State.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList smallimage;
        private System.Windows.Forms.ImageList bigimage;
        private System.ComponentModel.BackgroundWorker BKProgress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip Strip_State;
        private System.Windows.Forms.ToolStripStatusLabel lbl_state;
        private System.Windows.Forms.ToolStripProgressBar pb_state;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

