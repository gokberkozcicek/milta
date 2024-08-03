namespace MILTA_GUI
{
    partial class miltaVTKControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vtkToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.viewItemsToolStrip = new System.Windows.Forms.ToolStrip();
            this.isometricToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.setFrontViewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomFitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.vtkToolStripContainer.TopToolStripPanel.SuspendLayout();
            this.vtkToolStripContainer.SuspendLayout();
            this.viewItemsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // vtkToolStripContainer
            // 
            // 
            // vtkToolStripContainer.ContentPanel
            // 
            this.vtkToolStripContainer.ContentPanel.Size = new System.Drawing.Size(732, 412);
            this.vtkToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vtkToolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.vtkToolStripContainer.Name = "vtkToolStripContainer";
            this.vtkToolStripContainer.Size = new System.Drawing.Size(732, 437);
            this.vtkToolStripContainer.TabIndex = 0;
            this.vtkToolStripContainer.Text = "toolStripContainer1";
            // 
            // vtkToolStripContainer.TopToolStripPanel
            // 
            this.vtkToolStripContainer.TopToolStripPanel.Controls.Add(this.viewItemsToolStrip);
            // 
            // viewItemsToolStrip
            // 
            this.viewItemsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.viewItemsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isometricToolStripButton,
            this.setFrontViewToolStripButton,
            this.zoomFitToolStripButton});
            this.viewItemsToolStrip.Location = new System.Drawing.Point(3, 0);
            this.viewItemsToolStrip.Name = "viewItemsToolStrip";
            this.viewItemsToolStrip.Size = new System.Drawing.Size(112, 25);
            this.viewItemsToolStrip.TabIndex = 0;
            // 
            // isometricToolStripButton
            // 
            this.isometricToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.isometricToolStripButton.Image = global::MILTA_GUI.Properties.Resources.Isometric;
            this.isometricToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.isometricToolStripButton.Name = "isometricToolStripButton";
            this.isometricToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.isometricToolStripButton.Text = "toolStripButton1";
            this.isometricToolStripButton.ToolTipText = "Isometric View";
            // 
            // setFrontViewToolStripButton
            // 
            this.setFrontViewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.setFrontViewToolStripButton.Image = global::MILTA_GUI.Properties.Resources.Front;
            this.setFrontViewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setFrontViewToolStripButton.Name = "setFrontViewToolStripButton";
            this.setFrontViewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.setFrontViewToolStripButton.Text = "toolStripButton2";
            this.setFrontViewToolStripButton.ToolTipText = "Front View";
            // 
            // zoomFitToolStripButton
            // 
            this.zoomFitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomFitToolStripButton.Image = global::MILTA_GUI.Properties.Resources.ZoomToFit;
            this.zoomFitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomFitToolStripButton.Name = "zoomFitToolStripButton";
            this.zoomFitToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.zoomFitToolStripButton.Text = "toolStripButton3";
            this.zoomFitToolStripButton.ToolTipText = "Zoom Fit";
            // 
            // miltaVTKControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vtkToolStripContainer);
            this.Name = "miltaVTKControl";
            this.Size = new System.Drawing.Size(732, 437);
            this.Load += new System.EventHandler(this.miltaVTKControl_Load);
            this.vtkToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.vtkToolStripContainer.TopToolStripPanel.PerformLayout();
            this.vtkToolStripContainer.ResumeLayout(false);
            this.vtkToolStripContainer.PerformLayout();
            this.viewItemsToolStrip.ResumeLayout(false);
            this.viewItemsToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer vtkToolStripContainer;
        private System.Windows.Forms.ToolStrip viewItemsToolStrip;
        private System.Windows.Forms.ToolStripButton isometricToolStripButton;
        private System.Windows.Forms.ToolStripButton setFrontViewToolStripButton;
        private System.Windows.Forms.ToolStripButton zoomFitToolStripButton;
    }
}
