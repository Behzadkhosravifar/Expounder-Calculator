namespace ExpounderCalculator
{
    partial class CalcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcForm));
            this.rtxtInformation = new System.Windows.Forms.RichTextBox();
            this.rtxtForm = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnShowEvent = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.toolTip4Btn = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtInformation
            // 
            this.rtxtInformation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtxtInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtInformation.Cursor = System.Windows.Forms.Cursors.No;
            this.rtxtInformation.DetectUrls = false;
            this.rtxtInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtInformation.EnableAutoDragDrop = true;
            this.rtxtInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rtxtInformation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtxtInformation.Location = new System.Drawing.Point(0, 355);
            this.rtxtInformation.Name = "rtxtInformation";
            this.rtxtInformation.ReadOnly = true;
            this.rtxtInformation.Size = new System.Drawing.Size(342, 71);
            this.rtxtInformation.TabIndex = 0;
            this.rtxtInformation.TabStop = false;
            this.rtxtInformation.Text = "";
            // 
            // rtxtForm
            // 
            this.rtxtForm.AcceptsTab = true;
            this.rtxtForm.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtxtForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtForm.DetectUrls = false;
            this.rtxtForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rtxtForm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rtxtForm.Location = new System.Drawing.Point(0, 83);
            this.rtxtForm.Name = "rtxtForm";
            this.rtxtForm.Size = new System.Drawing.Size(343, 272);
            this.rtxtForm.TabIndex = 1;
            this.rtxtForm.Text = "";
            this.rtxtForm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtForm_KeyDown);
            this.rtxtForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtForm_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnShowEvent);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.rtxtForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 355);
            this.panel1.TabIndex = 2;
            // 
            // btnAbout
            // 
            this.btnAbout.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnAbout.AllowDrop = true;
            this.btnAbout.AutoEllipsis = true;
            this.btnAbout.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAbout.BackgroundImage = global::ExpounderCalculator.Properties.Resources.About;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Location = new System.Drawing.Point(255, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 65);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "&About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4Btn.SetToolTip(this.btnAbout, "About");
            this.btnAbout.UseCompatibleTextRendering = true;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnShowEvent
            // 
            this.btnShowEvent.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnShowEvent.AllowDrop = true;
            this.btnShowEvent.AutoEllipsis = true;
            this.btnShowEvent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnShowEvent.BackgroundImage = global::ExpounderCalculator.Properties.Resources.Event;
            this.btnShowEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowEvent.Location = new System.Drawing.Point(174, 12);
            this.btnShowEvent.Name = "btnShowEvent";
            this.btnShowEvent.Size = new System.Drawing.Size(75, 65);
            this.btnShowEvent.TabIndex = 7;
            this.btnShowEvent.Text = "&Show Events";
            this.btnShowEvent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4Btn.SetToolTip(this.btnShowEvent, "Show Events");
            this.btnShowEvent.UseCompatibleTextRendering = true;
            this.btnShowEvent.UseVisualStyleBackColor = true;
            this.btnShowEvent.Click += new System.EventHandler(this.btnShowEvent_Click);
            // 
            // btnRun
            // 
            this.btnRun.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnRun.AllowDrop = true;
            this.btnRun.AutoEllipsis = true;
            this.btnRun.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRun.BackgroundImage = global::ExpounderCalculator.Properties.Resources.RunEx;
            this.btnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRun.Location = new System.Drawing.Point(93, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 65);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "&Run";
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4Btn.SetToolTip(this.btnRun, "Run (Enter)");
            this.btnRun.UseCompatibleTextRendering = true;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnNew.AllowDrop = true;
            this.btnNew.AutoEllipsis = true;
            this.btnNew.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNew.BackgroundImage = global::ExpounderCalculator.Properties.Resources.New;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 65);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "&New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4Btn.SetToolTip(this.btnNew, "New (Claer All)");
            this.btnNew.UseCompatibleTextRendering = true;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtxtInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expounder Calculator";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.CalcForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.RichTextBox rtxtInformation;
        private System.Windows.Forms.RichTextBox rtxtForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnShowEvent;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ToolTip toolTip4Btn;
    }
}

