namespace ImageResizer
{
    partial class Form1
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
            this._lblTitle = new System.Windows.Forms.Label();
            this._lblDesc = new System.Windows.Forms.Label();
            this._grbChoose = new System.Windows.Forms.GroupBox();
            this._numericResizer = new System.Windows.Forms.NumericUpDown();
            this._btnLoad = new System.Windows.Forms.Button();
            this._btnClear = new System.Windows.Forms.Button();
            this._listBoxChoose = new System.Windows.Forms.ListBox();
            this._btnResize = new System.Windows.Forms.Button();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._grbChoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericResizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblTitle
            // 
            this._lblTitle.AutoSize = true;
            this._lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._lblTitle.Location = new System.Drawing.Point(306, 9);
            this._lblTitle.Name = "_lblTitle";
            this._lblTitle.Size = new System.Drawing.Size(159, 35);
            this._lblTitle.TabIndex = 0;
            this._lblTitle.Text = "Resize image";
            // 
            // _lblDesc
            // 
            this._lblDesc.AutoSize = true;
            this._lblDesc.Location = new System.Drawing.Point(209, 54);
            this._lblDesc.Name = "_lblDesc";
            this._lblDesc.Size = new System.Drawing.Size(368, 20);
            this._lblDesc.TabIndex = 1;
            this._lblDesc.Text = "Please, choose images you want resize (make smaller).";
            // 
            // _grbChoose
            // 
            this._grbChoose.Controls.Add(this._numericResizer);
            this._grbChoose.Controls.Add(this._btnLoad);
            this._grbChoose.Controls.Add(this._btnClear);
            this._grbChoose.Controls.Add(this._listBoxChoose);
            this._grbChoose.Location = new System.Drawing.Point(64, 77);
            this._grbChoose.Name = "_grbChoose";
            this._grbChoose.Size = new System.Drawing.Size(276, 334);
            this._grbChoose.TabIndex = 2;
            this._grbChoose.TabStop = false;
            this._grbChoose.Text = "Choose images";
            // 
            // _numericResizer
            // 
            this._numericResizer.Location = new System.Drawing.Point(55, 295);
            this._numericResizer.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this._numericResizer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numericResizer.Name = "_numericResizer";
            this._numericResizer.Size = new System.Drawing.Size(150, 27);
            this._numericResizer.TabIndex = 5;
            this._numericResizer.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // _btnLoad
            // 
            this._btnLoad.Location = new System.Drawing.Point(136, 245);
            this._btnLoad.Name = "_btnLoad";
            this._btnLoad.Size = new System.Drawing.Size(94, 29);
            this._btnLoad.TabIndex = 4;
            this._btnLoad.Text = "Load";
            this._btnLoad.UseVisualStyleBackColor = true;
            this._btnLoad.Click += new System.EventHandler(this._btnLoad_Click);
            // 
            // _btnClear
            // 
            this._btnClear.Location = new System.Drawing.Point(21, 245);
            this._btnClear.Name = "_btnClear";
            this._btnClear.Size = new System.Drawing.Size(94, 29);
            this._btnClear.TabIndex = 3;
            this._btnClear.Text = "Clear";
            this._btnClear.UseVisualStyleBackColor = true;
            this._btnClear.Visible = false;
            this._btnClear.Click += new System.EventHandler(this._btnClear_Click);
            // 
            // _listBoxChoose
            // 
            this._listBoxChoose.FormattingEnabled = true;
            this._listBoxChoose.ItemHeight = 20;
            this._listBoxChoose.Location = new System.Drawing.Point(6, 39);
            this._listBoxChoose.Name = "_listBoxChoose";
            this._listBoxChoose.Size = new System.Drawing.Size(240, 184);
            this._listBoxChoose.TabIndex = 0;
            this._listBoxChoose.SelectedIndexChanged += new System.EventHandler(this._listBoxChoose_SelectedIndexChanged);
            this._listBoxChoose.KeyDown += new System.Windows.Forms.KeyEventHandler(this._listBoxChoose_KeyDown);
            // 
            // _btnResize
            // 
            this._btnResize.Location = new System.Drawing.Point(380, 243);
            this._btnResize.Name = "_btnResize";
            this._btnResize.Size = new System.Drawing.Size(94, 29);
            this._btnResize.TabIndex = 3;
            this._btnResize.Text = "Resize!";
            this._btnResize.UseVisualStyleBackColor = true;
            this._btnResize.Click += new System.EventHandler(this._btnResize_Click);
            // 
            // _pictureBox
            // 
            this._pictureBox.Location = new System.Drawing.Point(505, 87);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(283, 312);
            this._pictureBox.TabIndex = 4;
            this._pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._pictureBox);
            this.Controls.Add(this._btnResize);
            this.Controls.Add(this._grbChoose);
            this.Controls.Add(this._lblDesc);
            this.Controls.Add(this._lblTitle);
            this.Name = "Form1";
            this.Text = "Resize image";
            this._grbChoose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._numericResizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lblTitle;
        private Label _lblDesc;
        private GroupBox _grbChoose;
        private Button _btnLoad;
        private Button _btnClear;
        private ListBox _listBoxChoose;
        private Button _btnResize;
        private PictureBox _pictureBox;
        private NumericUpDown _numericResizer;
    }
}