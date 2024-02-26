namespace super_market_project
{
    partial class Form6
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
            this.prodect_view = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.orderinfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prodect_view
            // 
            this.prodect_view.Location = new System.Drawing.Point(111, 30);
            this.prodect_view.Name = "prodect_view";
            this.prodect_view.Size = new System.Drawing.Size(152, 23);
            this.prodect_view.TabIndex = 0;
            this.prodect_view.Text = "prodect view";
            this.prodect_view.UseVisualStyleBackColor = true;
            this.prodect_view.Click += new System.EventHandler(this.prodect_view_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(7, 79);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(282, 150);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.AutoSizeChanged += new System.EventHandler(this.Form6_Load);
            this.crystalReportViewer1.MarginChanged += new System.EventHandler(this.Form6_Load);
            this.crystalReportViewer1.PaddingChanged += new System.EventHandler(this.Form6_Load);
            this.crystalReportViewer1.Resize += new System.EventHandler(this.Form6_Load);
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(438, 79);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(150, 150);
            this.crystalReportViewer2.TabIndex = 2;
            // 
            // orderinfo
            // 
            this.orderinfo.Location = new System.Drawing.Point(438, 30);
            this.orderinfo.Name = "orderinfo";
            this.orderinfo.Size = new System.Drawing.Size(75, 23);
            this.orderinfo.TabIndex = 3;
            this.orderinfo.Text = "order info";
            this.orderinfo.UseVisualStyleBackColor = true;
            this.orderinfo.Click += new System.EventHandler(this.orderinfo_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 261);
            this.Controls.Add(this.orderinfo);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.prodect_view);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button prodect_view;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.Button orderinfo;
    }
}