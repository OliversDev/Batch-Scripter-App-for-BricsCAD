namespace BricsCADDialogLibrary
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnBrowseDrawings;
        private System.Windows.Forms.Button btnRemoveDrawings;
        private System.Windows.Forms.Button btnBrowseScript;
        private System.Windows.Forms.Button btnRunScript;
        private System.Windows.Forms.ListBox listBoxDrawings;
        private System.Windows.Forms.TextBox textBoxContents;
        private System.Windows.Forms.Label lblDrawingList;
        private System.Windows.Forms.Label lblScriptContent;
        private System.Windows.Forms.CheckBox chkSaveDrawings;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBrowseDrawings = new System.Windows.Forms.Button();
            this.btnRemoveDrawings = new System.Windows.Forms.Button();
            this.btnBrowseScript = new System.Windows.Forms.Button();
            this.btnRunScript = new System.Windows.Forms.Button();
            this.listBoxDrawings = new System.Windows.Forms.ListBox();
            this.textBoxContents = new System.Windows.Forms.TextBox();
            this.lblDrawingList = new System.Windows.Forms.Label();
            this.lblScriptContent = new System.Windows.Forms.Label();
            this.chkSaveDrawings = new System.Windows.Forms.CheckBox();
            this.linkLblFootnote = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowseDrawings
            // 
            this.btnBrowseDrawings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDrawings.Location = new System.Drawing.Point(526, 203);
            this.btnBrowseDrawings.Name = "btnBrowseDrawings";
            this.btnBrowseDrawings.Size = new System.Drawing.Size(120, 23);
            this.btnBrowseDrawings.TabIndex = 0;
            this.btnBrowseDrawings.Text = "Browse Drawings";
            this.btnBrowseDrawings.UseVisualStyleBackColor = true;
            this.btnBrowseDrawings.Click += new System.EventHandler(this.btnBrowseDrawings_Click);
            // 
            // btnRemoveDrawings
            // 
            this.btnRemoveDrawings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveDrawings.Location = new System.Drawing.Point(652, 203);
            this.btnRemoveDrawings.Name = "btnRemoveDrawings";
            this.btnRemoveDrawings.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveDrawings.TabIndex = 1;
            this.btnRemoveDrawings.Text = "Remove Drawings";
            this.btnRemoveDrawings.UseVisualStyleBackColor = true;
            this.btnRemoveDrawings.Click += new System.EventHandler(this.btnRemoveDrawings_Click);
            // 
            // btnBrowseScript
            // 
            this.btnBrowseScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseScript.Location = new System.Drawing.Point(526, 428);
            this.btnBrowseScript.Name = "btnBrowseScript";
            this.btnBrowseScript.Size = new System.Drawing.Size(120, 23);
            this.btnBrowseScript.TabIndex = 2;
            this.btnBrowseScript.Text = "Browse Scripts";
            this.btnBrowseScript.UseVisualStyleBackColor = true;
            this.btnBrowseScript.Click += new System.EventHandler(this.btnBrowseScript_Click);
            // 
            // btnRunScript
            // 
            this.btnRunScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunScript.Location = new System.Drawing.Point(652, 428);
            this.btnRunScript.Name = "btnRunScript";
            this.btnRunScript.Size = new System.Drawing.Size(120, 23);
            this.btnRunScript.TabIndex = 7;
            this.btnRunScript.Text = "Run Script";
            this.btnRunScript.UseVisualStyleBackColor = true;
            this.btnRunScript.Click += new System.EventHandler(this.btnRunScript_Click);
            // 
            // listBoxDrawings
            // 
            this.listBoxDrawings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDrawings.FormattingEnabled = true;
            this.listBoxDrawings.Location = new System.Drawing.Point(12, 24);
            this.listBoxDrawings.Name = "listBoxDrawings";
            this.listBoxDrawings.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDrawings.Size = new System.Drawing.Size(760, 173);
            this.listBoxDrawings.TabIndex = 3;
            // 
            // textBoxContents
            // 
            this.textBoxContents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContents.Location = new System.Drawing.Point(12, 249);
            this.textBoxContents.Multiline = true;
            this.textBoxContents.Name = "textBoxContents";
            this.textBoxContents.Size = new System.Drawing.Size(760, 173);
            this.textBoxContents.TabIndex = 4;
            // 
            // lblDrawingList
            // 
            this.lblDrawingList.AutoSize = true;
            this.lblDrawingList.Location = new System.Drawing.Point(12, 7);
            this.lblDrawingList.Name = "lblDrawingList";
            this.lblDrawingList.Size = new System.Drawing.Size(65, 13);
            this.lblDrawingList.TabIndex = 5;
            this.lblDrawingList.Text = "Drawing List";
            // 
            // lblScriptContent
            // 
            this.lblScriptContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblScriptContent.AutoSize = true;
            this.lblScriptContent.Location = new System.Drawing.Point(12, 232);
            this.lblScriptContent.Name = "lblScriptContent";
            this.lblScriptContent.Size = new System.Drawing.Size(74, 13);
            this.lblScriptContent.TabIndex = 6;
            this.lblScriptContent.Text = "Script Content";
            // 
            // chkSaveDrawings
            // 
            this.chkSaveDrawings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSaveDrawings.AutoSize = true;
            this.chkSaveDrawings.Checked = true;
            this.chkSaveDrawings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveDrawings.Location = new System.Drawing.Point(422, 432);
            this.chkSaveDrawings.Name = "chkSaveDrawings";
            this.chkSaveDrawings.Size = new System.Drawing.Size(98, 17);
            this.chkSaveDrawings.TabIndex = 8;
            this.chkSaveDrawings.Text = "Save Drawings";
            this.chkSaveDrawings.UseVisualStyleBackColor = true;
            // 
            // linkLblFootnote
            // 
            this.linkLblFootnote.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(174)))), ((int)(((byte)(16)))));
            this.linkLblFootnote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLblFootnote.AutoSize = true;
            this.linkLblFootnote.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLblFootnote.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.linkLblFootnote.Location = new System.Drawing.Point(58, 433);
            this.linkLblFootnote.Name = "linkLblFootnote";
            this.linkLblFootnote.Size = new System.Drawing.Size(192, 13);
            this.linkLblFootnote.TabIndex = 11;
            this.linkLblFootnote.TabStop = true;
            this.linkLblFootnote.Text = "Created by Oliver Wackenreuther, v1.0";
            this.linkLblFootnote.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.linkLblFootnote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblFootnote_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::OW_BricsCAD_Batch_Scripter_v24.Properties.Resources.Logo_BW_NOBG;
            this.pictureBox1.Location = new System.Drawing.Point(12, 428);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLblFootnote);
            this.Controls.Add(this.chkSaveDrawings);
            this.Controls.Add(this.btnRunScript);
            this.Controls.Add(this.lblScriptContent);
            this.Controls.Add(this.lblDrawingList);
            this.Controls.Add(this.textBoxContents);
            this.Controls.Add(this.listBoxDrawings);
            this.Controls.Add(this.btnBrowseScript);
            this.Controls.Add(this.btnRemoveDrawings);
            this.Controls.Add(this.btnBrowseDrawings);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "Batch Scripter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.LinkLabel linkLblFootnote;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
