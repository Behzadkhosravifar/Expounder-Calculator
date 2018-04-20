namespace ExpounderCalculator
{
    partial class AnswerEventView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnswerEventView));
            this.toolTip2Btn = new System.Windows.Forms.ToolTip(this.components);
            this.btnSavedEvent = new System.Windows.Forms.Button();
            this.btnAllEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolTip2Btn
            // 
            this.toolTip2Btn.AutomaticDelay = 100;
            this.toolTip2Btn.AutoPopDelay = 10000;
            this.toolTip2Btn.InitialDelay = 100;
            this.toolTip2Btn.ReshowDelay = 20;
            this.toolTip2Btn.ShowAlways = true;
            // 
            // btnSavedEvent
            // 
            this.btnSavedEvent.BackgroundImage = global::ExpounderCalculator.Properties.Resources.SavedEvent;
            resources.ApplyResources(this.btnSavedEvent, "btnSavedEvent");
            this.btnSavedEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavedEvent.ForeColor = System.Drawing.Color.Red;
            this.btnSavedEvent.Name = "btnSavedEvent";
            this.toolTip2Btn.SetToolTip(this.btnSavedEvent, resources.GetString("btnSavedEvent.ToolTip"));
            this.btnSavedEvent.UseVisualStyleBackColor = true;
            this.btnSavedEvent.Click += new System.EventHandler(this.btnSavedEvent_Click);
            // 
            // btnAllEvent
            // 
            this.btnAllEvent.BackgroundImage = global::ExpounderCalculator.Properties.Resources.AllEvent;
            resources.ApplyResources(this.btnAllEvent, "btnAllEvent");
            this.btnAllEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllEvent.ForeColor = System.Drawing.Color.Red;
            this.btnAllEvent.Name = "btnAllEvent";
            this.toolTip2Btn.SetToolTip(this.btnAllEvent, resources.GetString("btnAllEvent.ToolTip"));
            this.btnAllEvent.UseVisualStyleBackColor = true;
            this.btnAllEvent.Click += new System.EventHandler(this.btnAllEvent_Click);
            // 
            // AnswerEventView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.btnSavedEvent);
            this.Controls.Add(this.btnAllEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnswerEventView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAllEvent;
        private System.Windows.Forms.Button btnSavedEvent;
        private System.Windows.Forms.ToolTip toolTip2Btn;
    }
}