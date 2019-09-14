namespace SqlDerleyicisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rchDerle = new System.Windows.Forms.RichTextBox();
            this.btnDerle = new DevExpress.XtraEditors.SimpleButton();
            this.ABOUT = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(2, 311);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(921, 309);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "DERLEME";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ABOUT);
            this.groupControl2.Controls.Add(this.btnDerle);
            this.groupControl2.Controls.Add(this.rchDerle);
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(921, 303);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "SORGU";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(917, 287);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // rchDerle
            // 
            this.rchDerle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rchDerle.Location = new System.Drawing.Point(2, 23);
            this.rchDerle.Name = "rchDerle";
            this.rchDerle.Size = new System.Drawing.Size(649, 280);
            this.rchDerle.TabIndex = 0;
            this.rchDerle.Text = "";
            // 
            // btnDerle
            // 
            this.btnDerle.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnDerle.Appearance.Options.UseFont = true;
            this.btnDerle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDerle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDerle.ImageOptions.Image")));
            this.btnDerle.Location = new System.Drawing.Point(697, 61);
            this.btnDerle.Name = "btnDerle";
            this.btnDerle.Size = new System.Drawing.Size(205, 80);
            this.btnDerle.TabIndex = 1;
            this.btnDerle.Text = "EXECUTE";
            this.btnDerle.Click += new System.EventHandler(this.btnDerle_Click);
            // 
            // ABOUT
            // 
            this.ABOUT.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.ABOUT.Appearance.Options.UseFont = true;
            this.ABOUT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.ABOUT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.ABOUT.Location = new System.Drawing.Point(697, 172);
            this.ABOUT.Name = "ABOUT";
            this.ABOUT.Size = new System.Drawing.Size(205, 80);
            this.ABOUT.TabIndex = 2;
            this.ABOUT.Text = "ABOUT";
            this.ABOUT.Click += new System.EventHandler(this.ABOUT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 620);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Form1";
            this.Text = "MİNİ SQL DERLEYİCİSİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton ABOUT;
        private DevExpress.XtraEditors.SimpleButton btnDerle;
        private System.Windows.Forms.RichTextBox rchDerle;
    }
}

