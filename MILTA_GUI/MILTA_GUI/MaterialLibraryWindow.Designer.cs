namespace MILTA_GUI
{
    partial class MaterialLibraryWindow
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
            this.materialToolStrip = new System.Windows.Forms.ToolStrip();
            this.materialDataGridView = new System.Windows.Forms.DataGridView();
            this.exportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.importToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.restoreToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.materialToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialToolStrip
            // 
            this.materialToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripButton,
            this.importToolStripButton,
            this.restoreToolStripButton});
            this.materialToolStrip.Location = new System.Drawing.Point(0, 0);
            this.materialToolStrip.Name = "materialToolStrip";
            this.materialToolStrip.Size = new System.Drawing.Size(800, 25);
            this.materialToolStrip.TabIndex = 0;
            this.materialToolStrip.Text = "toolStrip1";
            // 
            // materialDataGridView
            // 
            this.materialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialDataGridView.Location = new System.Drawing.Point(0, 25);
            this.materialDataGridView.Name = "materialDataGridView";
            this.materialDataGridView.Size = new System.Drawing.Size(800, 425);
            this.materialDataGridView.TabIndex = 1;
            // 
            // exportToolStripButton
            // 
            this.exportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportToolStripButton.Image = global::MILTA_GUI.Properties.Resources.Import;
            this.exportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToolStripButton.Name = "exportToolStripButton";
            this.exportToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.exportToolStripButton.Text = "Import Material Library";
            // 
            // importToolStripButton
            // 
            this.importToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.importToolStripButton.Image = global::MILTA_GUI.Properties.Resources.Export;
            this.importToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importToolStripButton.Name = "importToolStripButton";
            this.importToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.importToolStripButton.Text = "Export Material Library";
            // 
            // restoreToolStripButton
            // 
            this.restoreToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.restoreToolStripButton.Image = global::MILTA_GUI.Properties.Resources.restore_settings;
            this.restoreToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.restoreToolStripButton.Name = "restoreToolStripButton";
            this.restoreToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.restoreToolStripButton.Text = "Restore Defaults";
            // 
            // MaterialLibraryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialDataGridView);
            this.Controls.Add(this.materialToolStrip);
            this.Name = "MaterialLibraryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Material Library";
            this.Load += new System.EventHandler(this.MaterialLibraryWindow_Load);
            this.materialToolStrip.ResumeLayout(false);
            this.materialToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip materialToolStrip;
        private System.Windows.Forms.ToolStripButton exportToolStripButton;
        private System.Windows.Forms.ToolStripButton importToolStripButton;
        private System.Windows.Forms.DataGridView materialDataGridView;
        private System.Windows.Forms.ToolStripButton restoreToolStripButton;
    }
}