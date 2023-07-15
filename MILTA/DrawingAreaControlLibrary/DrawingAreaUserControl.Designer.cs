namespace DrawingAreaControlLibrary
{
    partial class DrawingAreaUserControl
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
            this.drawingAreaPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawingAreaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingAreaPictureBox
            // 
            this.drawingAreaPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.drawingAreaPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingAreaPictureBox.Location = new System.Drawing.Point(0, 0);
            this.drawingAreaPictureBox.Name = "drawingAreaPictureBox";
            this.drawingAreaPictureBox.Size = new System.Drawing.Size(800, 450);
            this.drawingAreaPictureBox.TabIndex = 0;
            this.drawingAreaPictureBox.TabStop = false;
            this.drawingAreaPictureBox.ClientSizeChanged += new System.EventHandler(this.drawingAreaPictureBox_ClientSizeChanged);
            this.drawingAreaPictureBox.SizeChanged += new System.EventHandler(this.drawingAreaPictureBox_SizeChanged);
            this.drawingAreaPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingAreaPictureBox_Paint);
            this.drawingAreaPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingAreaPictureBox_MouseDown);
            this.drawingAreaPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingAreaPictureBox_MouseMove);
            // 
            // DrawingAreaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drawingAreaPictureBox);
            this.Name = "DrawingAreaUserControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.DrawingAreaUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawingAreaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingAreaPictureBox;
    }
}
