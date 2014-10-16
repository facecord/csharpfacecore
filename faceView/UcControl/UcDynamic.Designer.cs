namespace faceView.UcControl
{
    partial class UcDynamic
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            this.StopCamera();
            if (th != null)
                th.Abort();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.cobxCameraList = new System.Windows.Forms.ComboBox();
            this.btnLoading = new System.Windows.Forms.Button();
            this.picFeature = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSpeed = new System.Windows.Forms.Label();
            this.picLoad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFeature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // picCamera
            // 
            this.picCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.picCamera.Location = new System.Drawing.Point(15, 87);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(404, 445);
            this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCamera.TabIndex = 5;
            this.picCamera.TabStop = false;
            // 
            // cobxCameraList
            // 
            this.cobxCameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobxCameraList.FormattingEnabled = true;
            this.cobxCameraList.Location = new System.Drawing.Point(15, 29);
            this.cobxCameraList.Name = "cobxCameraList";
            this.cobxCameraList.Size = new System.Drawing.Size(648, 20);
            this.cobxCameraList.TabIndex = 6;
            // 
            // btnLoading
            // 
            this.btnLoading.Location = new System.Drawing.Point(530, 3);
            this.btnLoading.Name = "btnLoading";
            this.btnLoading.Size = new System.Drawing.Size(120, 23);
            this.btnLoading.TabIndex = 7;
            this.btnLoading.Text = "加载";
            this.btnLoading.UseVisualStyleBackColor = true;
            this.btnLoading.Visible = false;
            this.btnLoading.Click += new System.EventHandler(this.btnLoading_Click);
            // 
            // picFeature
            // 
            this.picFeature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.picFeature.Location = new System.Drawing.Point(429, 87);
            this.picFeature.Name = "picFeature";
            this.picFeature.Size = new System.Drawing.Size(360, 445);
            this.picFeature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFeature.TabIndex = 0;
            this.picFeature.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(13, 61);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(65, 12);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Text = "检测倒计时";
            // 
            // picLoad
            // 
            this.picLoad.Location = new System.Drawing.Point(669, 26);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(120, 26);
            this.picLoad.TabIndex = 11;
            this.picLoad.TabStop = false;
            this.picLoad.Click += new System.EventHandler(this.btnLoading_Click);
            this.picLoad.MouseEnter += new System.EventHandler(this.picLoad_MouseEnter);
            this.picLoad.MouseLeave += new System.EventHandler(this.picLoad_MouseLeave);
            // 
            // UcDynamic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(248)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picFeature);
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.btnLoading);
            this.Controls.Add(this.cobxCameraList);
            this.Controls.Add(this.picCamera);
            this.Name = "UcDynamic";
            this.Size = new System.Drawing.Size(810, 555);
            this.Load += new System.EventHandler(this.UcDynamic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFeature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.ComboBox cobxCameraList;
        private System.Windows.Forms.Button btnLoading;
        private System.Windows.Forms.PictureBox picFeature;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.PictureBox picLoad;
    }
}
