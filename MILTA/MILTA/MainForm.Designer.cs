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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node4");
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.sidebarSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.treeViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.sidebarToolStrip = new System.Windows.Forms.ToolStrip();
            this.upToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.downToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nodePropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.drawingAreaToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.drawingAreaUserControl1 = new DrawingAreaControlLibrary.DrawingAreaUserControl();
            this.outerContourToolStrip = new System.Windows.Forms.ToolStrip();
            this.addCylinderToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addConeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addHexagonToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.innerContourToolStrip = new System.Windows.Forms.ToolStrip();
            this.addInnerCylinderToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addInnerConeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addInnerHexagonToolStripButton = new System.Windows.Forms.ToolStripButton();
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
            this.outerContourToolStrip.SuspendLayout();
            this.innerContourToolStrip.SuspendLayout();
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
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(1140, 24);
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
            this.mainToolStrip.Size = new System.Drawing.Size(1140, 25);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
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
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
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
            // mainToolStripSeparator1
            // 
            this.mainToolStripSeparator1.Name = "mainToolStripSeparator1";
            this.mainToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // mainStatusStrip
            // 
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 415);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(1140, 22);
            this.mainStatusStrip.TabIndex = 2;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 49);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.sidebarSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.drawingAreaToolStripContainer);
            this.mainSplitContainer.Size = new System.Drawing.Size(1140, 366);
            this.mainSplitContainer.SplitterDistance = 379;
            this.mainSplitContainer.SplitterWidth = 5;
            this.mainSplitContainer.TabIndex = 3;
            // 
            // sidebarSplitContainer
            // 
            this.sidebarSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebarSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.sidebarSplitContainer.Margin = new System.Windows.Forms.Padding(4);
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
            this.sidebarSplitContainer.Size = new System.Drawing.Size(375, 362);
            this.sidebarSplitContainer.SplitterDistance = 175;
            this.sidebarSplitContainer.SplitterWidth = 5;
            this.sidebarSplitContainer.TabIndex = 0;
            // 
            // mainTreeView
            // 
            this.mainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTreeView.ImageIndex = 0;
            this.mainTreeView.ImageList = this.treeViewImageList;
            this.mainTreeView.Location = new System.Drawing.Point(0, 25);
            this.mainTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.mainTreeView.Name = "mainTreeView";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Node1";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Node2";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Node3";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Node4";
            this.mainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.mainTreeView.SelectedImageIndex = 0;
            this.mainTreeView.Size = new System.Drawing.Size(373, 148);
            this.mainTreeView.TabIndex = 1;
            // 
            // treeViewImageList
            // 
            this.treeViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeViewImageList.ImageStream")));
            this.treeViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.treeViewImageList.Images.SetKeyName(0, "shaft-32.png");
            this.treeViewImageList.Images.SetKeyName(1, "right-node-arrow-32.png");
            this.treeViewImageList.Images.SetKeyName(2, "down-node-arrow-32.png");
            this.treeViewImageList.Images.SetKeyName(3, "rectangle-32.png");
            this.treeViewImageList.Images.SetKeyName(4, "trapezoid-32.png");
            this.treeViewImageList.Images.SetKeyName(5, "hexagon-32.png");
            // 
            // sidebarToolStrip
            // 
            this.sidebarToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upToolStripButton,
            this.downToolStripButton,
            this.deleteToolStripButton});
            this.sidebarToolStrip.Location = new System.Drawing.Point(0, 0);
            this.sidebarToolStrip.Name = "sidebarToolStrip";
            this.sidebarToolStrip.Size = new System.Drawing.Size(373, 25);
            this.sidebarToolStrip.TabIndex = 0;
            this.sidebarToolStrip.Text = "toolStrip2";
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
            // nodePropertyGrid
            // 
            this.nodePropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nodePropertyGrid.HelpVisible = false;
            this.nodePropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.nodePropertyGrid.Margin = new System.Windows.Forms.Padding(4);
            this.nodePropertyGrid.Name = "nodePropertyGrid";
            this.nodePropertyGrid.Size = new System.Drawing.Size(373, 180);
            this.nodePropertyGrid.TabIndex = 0;
            this.nodePropertyGrid.ToolbarVisible = false;
            // 
            // drawingAreaToolStripContainer
            // 
            // 
            // drawingAreaToolStripContainer.ContentPanel
            // 
            this.drawingAreaToolStripContainer.ContentPanel.Controls.Add(this.drawingAreaUserControl1);
            this.drawingAreaToolStripContainer.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.drawingAreaToolStripContainer.ContentPanel.Size = new System.Drawing.Size(720, 337);
            this.drawingAreaToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // drawingAreaToolStripContainer.LeftToolStripPanel
            // 
            this.drawingAreaToolStripContainer.LeftToolStripPanel.Controls.Add(this.outerContourToolStrip);
            this.drawingAreaToolStripContainer.LeftToolStripPanel.Controls.Add(this.innerContourToolStrip);
            this.drawingAreaToolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.drawingAreaToolStripContainer.Margin = new System.Windows.Forms.Padding(4);
            this.drawingAreaToolStripContainer.Name = "drawingAreaToolStripContainer";
            this.drawingAreaToolStripContainer.Size = new System.Drawing.Size(752, 362);
            this.drawingAreaToolStripContainer.TabIndex = 0;
            this.drawingAreaToolStripContainer.Text = "toolStripContainer1";
            // 
            // drawingAreaUserControl1
            // 
            this.drawingAreaUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingAreaUserControl1.Location = new System.Drawing.Point(0, 0);
            this.drawingAreaUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.drawingAreaUserControl1.Name = "drawingAreaUserControl1";
            this.drawingAreaUserControl1.Size = new System.Drawing.Size(720, 337);
            this.drawingAreaUserControl1.TabIndex = 0;
            // 
            // outerContourToolStrip
            // 
            this.outerContourToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.outerContourToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCylinderToolStripButton,
            this.addConeToolStripButton,
            this.addHexagonToolStripButton});
            this.outerContourToolStrip.Location = new System.Drawing.Point(0, 3);
            this.outerContourToolStrip.Name = "outerContourToolStrip";
            this.outerContourToolStrip.Size = new System.Drawing.Size(24, 80);
            this.outerContourToolStrip.TabIndex = 0;
            // 
            // addCylinderToolStripButton
            // 
            this.addCylinderToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addCylinderToolStripButton.Image = global::MILTA.Properties.Resources.rectangle_32;
            this.addCylinderToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCylinderToolStripButton.Name = "addCylinderToolStripButton";
            this.addCylinderToolStripButton.Size = new System.Drawing.Size(22, 20);
            this.addCylinderToolStripButton.Text = "toolStripButton1";
            this.addCylinderToolStripButton.Click += new System.EventHandler(this.addOuterCylinderToolStripButton_Click);
            // 
            // addConeToolStripButton
            // 
            this.addConeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addConeToolStripButton.Image = global::MILTA.Properties.Resources.trapezoid_32;
            this.addConeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addConeToolStripButton.Name = "addConeToolStripButton";
            this.addConeToolStripButton.Size = new System.Drawing.Size(22, 20);
            this.addConeToolStripButton.Text = "toolStripButton2";
            this.addConeToolStripButton.Click += new System.EventHandler(this.addOuterConeToolStripButton_Click);
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
            // innerContourToolStrip
            // 
            this.innerContourToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.innerContourToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInnerCylinderToolStripButton,
            this.addInnerConeToolStripButton,
            this.addInnerHexagonToolStripButton});
            this.innerContourToolStrip.Location = new System.Drawing.Point(0, 83);
            this.innerContourToolStrip.Name = "innerContourToolStrip";
            this.innerContourToolStrip.Size = new System.Drawing.Size(32, 99);
            this.innerContourToolStrip.TabIndex = 1;
            // 
            // addInnerCylinderToolStripButton
            // 
            this.addInnerCylinderToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addInnerCylinderToolStripButton.Image = global::MILTA.Properties.Resources.wire_rectangle_32;
            this.addInnerCylinderToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addInnerCylinderToolStripButton.Name = "addInnerCylinderToolStripButton";
            this.addInnerCylinderToolStripButton.Size = new System.Drawing.Size(30, 20);
            this.addInnerCylinderToolStripButton.Text = "toolStripButton1";
            this.addInnerCylinderToolStripButton.Click += new System.EventHandler(this.addInnerCylinderToolStripButton_Click);
            // 
            // addInnerConeToolStripButton
            // 
            this.addInnerConeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addInnerConeToolStripButton.Image = global::MILTA.Properties.Resources.wire_trapezoid_32;
            this.addInnerConeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addInnerConeToolStripButton.Name = "addInnerConeToolStripButton";
            this.addInnerConeToolStripButton.Size = new System.Drawing.Size(30, 20);
            this.addInnerConeToolStripButton.Text = "toolStripButton2";
            this.addInnerConeToolStripButton.Click += new System.EventHandler(this.addInnerConeToolStripButton_Click);
            // 
            // addInnerHexagonToolStripButton
            // 
            this.addInnerHexagonToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addInnerHexagonToolStripButton.Image = global::MILTA.Properties.Resources.wire_hexagon_32;
            this.addInnerHexagonToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addInnerHexagonToolStripButton.Name = "addInnerHexagonToolStripButton";
            this.addInnerHexagonToolStripButton.Size = new System.Drawing.Size(30, 20);
            this.addInnerHexagonToolStripButton.Text = "toolStripButton3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 437);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.outerContourToolStrip.ResumeLayout(false);
            this.outerContourToolStrip.PerformLayout();
            this.innerContourToolStrip.ResumeLayout(false);
            this.innerContourToolStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStrip outerContourToolStrip;
        private System.Windows.Forms.ToolStripButton addCylinderToolStripButton;
        private System.Windows.Forms.ToolStripButton addConeToolStripButton;
        private System.Windows.Forms.ToolStripButton addHexagonToolStripButton;
        private DrawingAreaControlLibrary.DrawingAreaUserControl drawingAreaUserControl1;
        private System.Windows.Forms.ImageList treeViewImageList;
        private System.Windows.Forms.ToolStrip innerContourToolStrip;
        private System.Windows.Forms.ToolStripButton addInnerCylinderToolStripButton;
        private System.Windows.Forms.ToolStripButton addInnerConeToolStripButton;
        private System.Windows.Forms.ToolStripButton addInnerHexagonToolStripButton;
    }
}

