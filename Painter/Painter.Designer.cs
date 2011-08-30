namespace Painter
{
    partial class Painter
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numLineWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btColor = new System.Windows.Forms.Button();
            this.cbLine = new System.Windows.Forms.CheckBox();
            this.cbPen = new System.Windows.Forms.CheckBox();
            this.paintzone = new System.Windows.Forms.PictureBox();
            this.colorBox = new System.Windows.Forms.ColorDialog();
            this.saveBox = new System.Windows.Forms.SaveFileDialog();
            this.openBox = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintzone)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.numLineWidth);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btLoad);
            this.splitContainer1.Panel1.Controls.Add(this.btSave);
            this.splitContainer1.Panel1.Controls.Add(this.btColor);
            this.splitContainer1.Panel1.Controls.Add(this.cbLine);
            this.splitContainer1.Panel1.Controls.Add(this.cbPen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.paintzone);
            this.splitContainer1.Size = new System.Drawing.Size(884, 471);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 2;
            // 
            // numLineWidth
            // 
            this.numLineWidth.Location = new System.Drawing.Point(68, 168);
            this.numLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLineWidth.Name = "numLineWidth";
            this.numLineWidth.Size = new System.Drawing.Size(37, 19);
            this.numLineWidth.TabIndex = 8;
            this.numLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "線の太さ:";
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(12, 383);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 6;
            this.btLoad.Text = "開く";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(12, 354);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btColor
            // 
            this.btColor.BackColor = System.Drawing.Color.Black;
            this.btColor.Location = new System.Drawing.Point(12, 113);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(50, 50);
            this.btColor.TabIndex = 4;
            this.btColor.UseVisualStyleBackColor = false;
            this.btColor.Click += new System.EventHandler(this.btColor_Click);
            // 
            // cbLine
            // 
            this.cbLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbLine.AutoSize = true;
            this.cbLine.Location = new System.Drawing.Point(12, 40);
            this.cbLine.Name = "cbLine";
            this.cbLine.Size = new System.Drawing.Size(39, 22);
            this.cbLine.TabIndex = 3;
            this.cbLine.Text = "直線";
            this.cbLine.UseVisualStyleBackColor = true;
            this.cbLine.Click += new System.EventHandler(this.cbLine_Click);
            // 
            // cbPen
            // 
            this.cbPen.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbPen.AutoSize = true;
            this.cbPen.Checked = true;
            this.cbPen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPen.Location = new System.Drawing.Point(12, 12);
            this.cbPen.Name = "cbPen";
            this.cbPen.Size = new System.Drawing.Size(34, 22);
            this.cbPen.TabIndex = 2;
            this.cbPen.Text = "ペン";
            this.cbPen.UseVisualStyleBackColor = true;
            this.cbPen.Click += new System.EventHandler(this.cbPen_Click);
            // 
            // paintzone
            // 
            this.paintzone.BackColor = System.Drawing.Color.White;
            this.paintzone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintzone.Location = new System.Drawing.Point(0, 0);
            this.paintzone.Name = "paintzone";
            this.paintzone.Size = new System.Drawing.Size(733, 471);
            this.paintzone.TabIndex = 0;
            this.paintzone.TabStop = false;
            this.paintzone.Paint += new System.Windows.Forms.PaintEventHandler(this.paintzone_Paint);
            this.paintzone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintzone_MouseDown);
            this.paintzone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintzone_MouseMove);
            this.paintzone.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintzone_MouseUp);
            // 
            // saveBox
            // 
            this.saveBox.Filter = "JPEG 画像 (*.jpg) | *.jpg; *jpeg | ビットマップ | *.bmp";
            // 
            // openBox
            // 
            this.openBox.Filter = "JPEG 画像 (*.jpg) | *.jpg; *jpeg | ビットマップ | *.bmp";
            // 
            // Painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 471);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Painter";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintzone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btColor;
        private System.Windows.Forms.CheckBox cbLine;
        private System.Windows.Forms.CheckBox cbPen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.ColorDialog colorBox;
        private System.Windows.Forms.SaveFileDialog saveBox;
        private System.Windows.Forms.OpenFileDialog openBox;
        private System.Windows.Forms.PictureBox paintzone;
        private System.Windows.Forms.NumericUpDown numLineWidth;
        private System.Windows.Forms.Label label1;
    }
}

