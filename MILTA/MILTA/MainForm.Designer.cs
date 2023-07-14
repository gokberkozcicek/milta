namespace MILTA
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node4");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mainToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.sidebarSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.sidebarToolStrip = new System.Windows.Forms.ToolStrip();
            this.nodePropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.drawingAreaToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.outerSectionToolStrip = new System.Windows.Forms.ToolStrip();
            this.upToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.downToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addCylinderToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addConeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addHexagonToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.drawingAreaUserControl1 = new DrawingAreaControlLibrary.DrawingAreaUserControl();
            this.mainMenuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarSplitContainer)).BeginInit();
            this.sidebarSplitContainer.Panel1.SuspendLayout();
            this.sidebarSplitContainer.Panel2.SuspendLayout();
            this.sidebarSplitContainer.SuspendLayout();
            this.sidebarToolStrip.SuspendLayout();
            this.drawingAreaToolStripContainer.ContentPanel.SuspendLayout();
            this.drawingAreaToolStripContainer.LeftToolStripPanel.SuspendLayout();
            this.drawingAreaToolStripContainer.SuspendLayout();
            this.outerSectionToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1037, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.mainToolStripSeparator1,
            this.helpToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(1037, 25);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // mainToolStripSeparator1
            // 
            this.mainToolStripSeparator1.Name = "mainToolStripSeparator1";
            this.mainToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 506);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(1037, 22);
            this.mainStatusStrip.TabIndex = 2;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 49);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.sidebarSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.drawingAreaToolStripContainer);
            this.mainSplitContainer.Size = new System.Drawing.Size(1037, 457);
            this.mainSplitContainer.SplitterDistance = 345;
            this.mainSplitContainer.TabIndex = 3;
            // 
            // sidebarSplitContainer
            // 
            this.sidebarSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebarSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.sidebarSplitContainer.Name = "sidebarSplitContainer";
            this.sidebarSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sidebarSplitContainer.Panel1
            // 
            this.sidebarSplitContainer.Panel1.Controls.Add(this.mainTreeView);
            this.sidebarSplitContainer.Panel1.Controls.Add(this.sidebarToolStrip);
            // 
            // sidebarSplitContainer.Panel2
            // 
            this.sidebarSplitContainer.Panel2.Controls.Add(this.nodePropertyGrid);
            this.sidebarSplitContainer.Size = new System.Drawing.Size(341, 453);
            this.sidebarSplitContainer.SplitterDistance = 220;
            this.sidebarSplitContainer.TabIndex = 0;
            // 
            // mainTreeView
            // 
            this.mainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTreeView.Location = new System.Drawing.Point(0, 25);
            this.mainTreeView.Name = "mainTreeView";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Node0";
            treeNode12.Name = "Node1";
            treeNode12.Text = "Node1";
            treeNode13.Name = "Node2";
            treeNode13.Text = "Node2";
            treeNode14.Name = "Node3";
            treeNode14.Text = "Node3";
            treeNode15.Name = "Node4";
            treeNode15.Text = "Node4";
            this.mainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            this.mainTreeView.Size = new System.Drawing.Size(339, 193);
            this.mainTreeView.TabIndex = 1;
            // 
            // sidebarToolStrip
            // 
            this.sidebarToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upToolStripButton,
            this.downToolStripButton,
            this.deleteToolStripButton});
            this.sidebarToolStrip.Location = new System.Drawing.Point(0, 0);
            this.sidebarToolStrip.Name = "sidebarToolStrip";
            this.sidebarToolStrip.Size = new System.Drawing.Size(339, 25);
            this.sidebarToolStrip.TabIndex = 0;
            this.sidebarToolStrip.Text = "toolStrip2";
            // 
            // nodePropertyGrid
            // 
            this.nodePropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nodePropertyGrid.HelpVisible = false;
            this.nodePropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.nodePropertyGrid.Name = "nodePropertyGrid";
            this.nodePropertyGrid.Size = new System.Drawing.Size(339, 227);
            this.nodePropertyGrid.TabIndex = 0;
            this.nodePropertyGrid.ToolbarVisible = false;
            // 
            // drawingAreaToolStripContainer
            // 
            // 
            // drawingAreaToolStripContainer.ContentPanel
            // 
            this.drawingAreaToolStripContainer.ContentPanel.Controls.Add(this.drawingAreaUserControl1);
            this.drawingAreaToolStripContainer.ContentPanel.Size = new System.Drawing.Size(660, 428);
            this.drawingAreaToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // drawingAreaToolStripContainer.LeftToolStripPanel
            // 
            this.drawingAreaToolStripContainer.LeftToolStripPanel.Controls.Add(this.outerSectionToolStrip);
            this.drawingAreaToolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.drawingAreaToolStripContainer.Name = "drawingAreaToolStripContainer";
            this.drawingAreaToolStripContainer.Size = new System.Drawing.Size(684, 453);
            this.drawingAreaToolStripContainer.TabIndex = 0;
            this.drawingAreaToolStripContainer.Text = "toolStripContainer1";
            // 
            // outerSectionToolStrip
            // 
            this.outerSectionToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.outerSectionToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCylinderToolStripButton,
            this.addConeToolStripButton,
            this.addHexagonToolStripButton});
            this.outerSectionToolStrip.Location = new System.Drawing.Point(0, 3);
            this.outerSectionToolStrip.Name = "outerSectionToolStrip";
            this.outerSectionToolStrip.Size = new System.Drawing.Size(24, 80);
            this.outerSectionToolStrip.TabIndex = 0;
            // 
            // upToolStripButton
            // 
            this.upToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.upToolStripButton.Image = global::MILTA.Properties.Resources.up_arrow_32;
            this.upToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.upToolStripButton.Name = "upToolStripButton";
            this.upToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.upToolStripButton.Text = "upToolStripButton";
            // 
            // downToolStripButton
            // 
            this.downToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.downToolStripButton.Image = global::MILTA.Properties.Resources.down_arrow_32;
            this.downToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.downToolStripButton.Name = "downToolStripButton";
            this.downToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.downToolStripButton.Text = "toolStripButton2";
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolStripButton.Image = global::MILTA.Properties.Resources.trash_32;
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteToolStripButton.Text = "toolStripButton3";
            // 
            // addCylinderToolStripButton
            // 
            this.addCylinderToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addCylinderToolStripButton.Image = global::MILTA.Properties.Resources.rectangle_32;
            this.addCylinderToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCylinderToolStripButton.Name = "addCylinderToolStripButton";
            this.addCylinderToolStripButton.Size = new System.Drawing.Size(30, 20);
            this.addCylinderToolStripButton.Text = "toolStripButton1";
            // 
            // addConeToolStripButton
            // 
            this.addConeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addConeToolStripButton.Image = global::MILTA.Properties.Resources.trapezoid_32;
            this.addConeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addConeToolStripButton.Name = "addConeToolStripButton";
            this.addConeToolStripButton.Size = new System.Drawing.Size(30, 20);
            this.addConeToolStripButton.Text = "toolStripButton2";
            // 
            // addHexagonToolStripButton
            // 
            this.addHexagonToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addHexagonToolStripButton.Image = global::MILTA.Properties.Resources.hexagon_32;
            this.addHexagonToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addHexagonToolStripButton.Name = "addHexagonToolStripButton";
            this.addHexagonToolStripButton.Size = new System.Drawing.Size(22, 20);
            this.addHexagonToolStripButton.Text = "toolStripButton3";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // drawingAreaUserControl1
            // 
            this.drawingAreaUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingAreaUserControl1.Location = new System.Drawing.Point(0, 0);
            this.drawingAreaUserControl1.Name = "drawingAreaUserControl1";
            this.drawingAreaUserControl1.Size = new System.Drawing.Size(660, 428);
            this.drawingAreaUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 528);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "MILTA";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.sidebarSplitContainer.Panel1.ResumeLayout(false);
            this.sidebarSplitContainer.Panel1.PerformLayout();
            this.sidebarSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sidebarSplitContainer)).EndInit();
            this.sidebarSplitContainer.ResumeLayout(false);
            this.sidebarToolStrip.ResumeLayout(false);
            this.sidebarToolStrip.PerformLayout();
            this.drawingAreaToolStripContainer.ContentPanel.ResumeLayout(false);
            this.drawingAreaToolStripContainer.LeftToolStripPanel.ResumeLayout(false);
            this.drawingAreaToolStripContainer.LeftToolStripPanel.PerformLayout();
            this.drawingAreaToolStripContainer.ResumeLayout(false);
            this.drawingAreaToolStripContainer.PerformLayout();
            this.outerSectionToolStrip.ResumeLayout(false);
            this.outerSectionToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator mainToolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer sidebarSplitContainer;
        private System.Windows.Forms.ToolStrip sidebarToolStrip;
        private System.Windows.Forms.ToolStripButton upToolStripButton;
        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.ToolStripButton downToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid nodePropertyGrid;
        private System.Windows.Forms.ToolStripContainer drawingAreaToolStripContainer;
        private System.Windows.Forms.ToolStrip outerSectionToolStrip;
        private System.Windows.Forms.ToolStripButton addCylinderToolStripButton;
        private System.Windows.Forms.ToolStripButton addConeToolStripButton;
        private System.Windows.Forms.ToolStripButton addHexagonToolStripButton;
        private DrawingAreaControlLibrary.DrawingAreaUserControl drawingAreaUserControl1;
    }
}

