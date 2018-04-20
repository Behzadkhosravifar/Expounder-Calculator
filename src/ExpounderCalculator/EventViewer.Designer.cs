namespace ExpounderCalculator
{
    partial class EventViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventViewer));
            this.rtxtEventViewer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtEventViewer
            // 
            this.rtxtEventViewer.AcceptsTab = true;
            this.rtxtEventViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtEventViewer.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.rtxtEventViewer, "rtxtEventViewer");
            this.rtxtEventViewer.ForeColor = System.Drawing.Color.MediumBlue;
            this.rtxtEventViewer.Name = "rtxtEventViewer";
            this.rtxtEventViewer.ReadOnly = true;
            // 
            // EventViewer
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtxtEventViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EventViewer";
            this.Load += new System.EventHandler(this.EventViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtEventViewer;
    }
}