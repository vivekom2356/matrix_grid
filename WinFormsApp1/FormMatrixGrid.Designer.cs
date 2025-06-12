namespace WinFormsApp1
{
    partial class FormMatrixGrid
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatrixGrid));
            toolStripSeparator1 = new ToolStripSeparator();
            startbutton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            stopbutton = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            menuStrip1 = new MenuStrip();
            maxSize = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 69);
            // 
            // startbutton
            // 
            startbutton.AutoSize = false;
            startbutton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            startbutton.Image = (Image)resources.GetObject("startbutton.Image");
            startbutton.ImageScaling = ToolStripItemImageScaling.None;
            startbutton.ImageTransparentColor = Color.Magenta;
            startbutton.Name = "startbutton";
            startbutton.Size = new Size(64, 64);
            startbutton.Text = "Start";
            startbutton.Click += toolStripButton5_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 69);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 69);
            // 
            // stopbutton
            // 
            stopbutton.AutoSize = false;
            stopbutton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            stopbutton.Image = (Image)resources.GetObject("stopbutton.Image");
            stopbutton.ImageTransparentColor = Color.Magenta;
            stopbutton.Name = "stopbutton";
            stopbutton.Size = new Size(64, 64);
            stopbutton.Text = "stopbutton";
            stopbutton.Click += toolStripButton1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, startbutton, toolStripSeparator2, toolStripSeparator3, stopbutton });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 69);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { maxSize });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // maxSize
            // 
            maxSize.Name = "maxSize";
            maxSize.Size = new Size(95, 29);
            maxSize.Text = "max size";
            // 
            // FormMatrixGrid
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 766);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMatrixGrid";
            Text = "MatrixGrid";
            Load += OnPaint;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton startbutton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton stopbutton;
        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem maxSize;
    }
}
