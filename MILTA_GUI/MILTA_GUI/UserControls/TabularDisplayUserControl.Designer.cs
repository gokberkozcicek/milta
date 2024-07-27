namespace MILTA_GUI
{
    partial class TabularDisplayUserControl
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
            this.displaySplitContainer = new System.Windows.Forms.SplitContainer();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.resultCustomChartUserControl = new MILTA_GUI.CustomChartUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.displaySplitContainer)).BeginInit();
            this.displaySplitContainer.Panel1.SuspendLayout();
            this.displaySplitContainer.Panel2.SuspendLayout();
            this.displaySplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // displaySplitContainer
            // 
            this.displaySplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displaySplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displaySplitContainer.Location = new System.Drawing.Point(0, 0);
            this.displaySplitContainer.Name = "displaySplitContainer";
            // 
            // displaySplitContainer.Panel1
            // 
            this.displaySplitContainer.Panel1.Controls.Add(this.resultCustomChartUserControl);
            // 
            // displaySplitContainer.Panel2
            // 
            this.displaySplitContainer.Panel2.Controls.Add(this.resultDataGridView);
            this.displaySplitContainer.Size = new System.Drawing.Size(833, 479);
            this.displaySplitContainer.SplitterDistance = 386;
            this.displaySplitContainer.SplitterWidth = 5;
            this.displaySplitContainer.TabIndex = 0;
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultDataGridView.Location = new System.Drawing.Point(0, 0);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.Size = new System.Drawing.Size(438, 475);
            this.resultDataGridView.TabIndex = 0;
            // 
            // resultCustomChartUserControl
            // 
            this.resultCustomChartUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultCustomChartUserControl.Location = new System.Drawing.Point(0, 0);
            this.resultCustomChartUserControl.Name = "resultCustomChartUserControl";
            this.resultCustomChartUserControl.Size = new System.Drawing.Size(382, 475);
            this.resultCustomChartUserControl.TabIndex = 0;
            // 
            // TabularDisplayUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.displaySplitContainer);
            this.Name = "TabularDisplayUserControl";
            this.Size = new System.Drawing.Size(833, 479);
            this.displaySplitContainer.Panel1.ResumeLayout(false);
            this.displaySplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displaySplitContainer)).EndInit();
            this.displaySplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer displaySplitContainer;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private CustomChartUserControl resultCustomChartUserControl;
    }
}
