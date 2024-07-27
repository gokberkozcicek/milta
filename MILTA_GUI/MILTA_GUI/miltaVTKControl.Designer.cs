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
            this.vtkToolStripContainer.SuspendLayout();
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
            // miltaVTKControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vtkToolStripContainer);
            this.Name = "miltaVTKControl";
            this.Size = new System.Drawing.Size(732, 437);
            this.Load += new System.EventHandler(this.miltaVTKControl_Load);
            this.vtkToolStripContainer.ResumeLayout(false);
            this.vtkToolStripContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer vtkToolStripContainer;
    }
}
