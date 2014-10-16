namespace faceView.UcControl
{
    partial class UcDynamicCom
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSpeed = new System.Windows.Forms.Label();
            this.picFeature = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.lblCom = new System.Windows.Forms.Label();
            this.picTemp = new System.Windows.Forms.PictureBox();
            this.btnCompar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.picCompar = new System.Windows.Forms.PictureBox();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.picSelect = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFeature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTemp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // picCamera
            // 
            this.picCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.picCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCamera.Location = new System.Drawing.Point(14, 41);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(414, 406);
            this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCamera.TabIndex = 5;
            this.picCamera.TabStop = false;
            // 
            // cobxCameraList
            // 
            this.cobxCameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobxCameraList.FormattingEnabled = true;
            this.cobxCameraList.Location = new System.Drawing.Point(17, 29);
            this.cobxCameraList.Name = "cobxCameraList";
            this.cobxCameraList.Size = new System.Drawing.Size(648, 20);
            this.cobxCameraList.TabIndex = 6;
            // 
            // btnLoading
            // 
            this.btnLoading.Location = new System.Drawing.Point(531, 3);
            this.btnLoading.Name = "btnLoading";
            this.btnLoading.Size = new System.Drawing.Size(120, 23);
            this.btnLoading.TabIndex = 7;
            this.btnLoading.Text = "加载";
            this.btnLoading.UseVisualStyleBackColor = true;
            this.btnLoading.Visible = false;
            this.btnLoading.Click += new System.EventHandler(this.btnLoading_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSpeed.Location = new System.Drawing.Point(15, 16);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(77, 14);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Text = "检测倒计时";
            // 
            // picFeature
            // 
            this.picFeature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.picFeature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFeature.Location = new System.Drawing.Point(434, 41);
            this.picFeature.Name = "picFeature";
            this.picFeature.Size = new System.Drawing.Size(212, 203);
            this.picFeature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFeature.TabIndex = 0;
            this.picFeature.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(501, 0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(87, 35);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPhoto.Location = new System.Drawing.Point(594, 0);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(87, 35);
            this.btnPhoto.TabIndex = 12;
            this.btnPhoto.Text = "拍照";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Visible = false;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // lblCom
            // 
            this.lblCom.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCom.Location = new System.Drawing.Point(675, 304);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(74, 60);
            this.lblCom.TabIndex = 11;
            this.lblCom.Text = "相似度";
            // 
            // picTemp
            // 
            this.picTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.picTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTemp.Location = new System.Drawing.Point(434, 250);
            this.picTemp.Name = "picTemp";
            this.picTemp.Size = new System.Drawing.Size(212, 197);
            this.picTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTemp.TabIndex = 0;
            this.picTemp.TabStop = false;
            // 
            // btnCompar
            // 
            this.btnCompar.Font = new System.Drawing.Font("宋体", 14.25F);
            this.btnCompar.Location = new System.Drawing.Point(632, 527);
            this.btnCompar.Name = "btnCompar";
            this.btnCompar.Size = new System.Drawing.Size(99, 25);
            this.btnCompar.TabIndex = 12;
            this.btnCompar.Text = "开始比对";
            this.btnCompar.UseVisualStyleBackColor = true;
            this.btnCompar.Visible = false;
            this.btnCompar.Click += new System.EventHandler(this.btnCompar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.picSelect);
            this.panel1.Controls.Add(this.picPhoto);
            this.panel1.Controls.Add(this.picCompar);
            this.panel1.Controls.Add(this.lblCom);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.picTemp);
            this.panel1.Controls.Add(this.picCamera);
            this.panel1.Controls.Add(this.picFeature);
            this.panel1.Controls.Add(this.btnPhoto);
            this.panel1.Controls.Add(this.lblSpeed);
            this.panel1.Location = new System.Drawing.Point(17, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 461);
            this.panel1.TabIndex = 13;
            // 
            // picLoad
            // 
            this.picLoad.Location = new System.Drawing.Point(671, 26);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(120, 26);
            this.picLoad.TabIndex = 14;
            this.picLoad.TabStop = false;
            this.picLoad.Click += new System.EventHandler(this.btnLoading_Click);
            this.picLoad.MouseEnter += new System.EventHandler(this.picLoad_MouseEnter);
            this.picLoad.MouseLeave += new System.EventHandler(this.picLoad_MouseLeave);
            // 
            // picCompar
            // 
            this.picCompar.Location = new System.Drawing.Point(660, 393);
            this.picCompar.Name = "picCompar";
            this.picCompar.Size = new System.Drawing.Size(101, 35);
            this.picCompar.TabIndex = 13;
            this.picCompar.TabStop = false;
            this.picCompar.Click += new System.EventHandler(this.btnCompar_Click);
            this.picCompar.MouseEnter += new System.EventHandler(this.picCompar_MouseEnter);
            this.picCompar.MouseLeave += new System.EventHandler(this.picCompar_MouseLeave);
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(660, 72);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(101, 35);
            this.picPhoto.TabIndex = 13;
            this.picPhoto.TabStop = false;
            this.picPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            this.picPhoto.MouseEnter += new System.EventHandler(this.picPhoto_MouseEnter);
            this.picPhoto.MouseLeave += new System.EventHandler(this.picPhoto_MouseLeave);
            // 
            // picSelect
            // 
            this.picSelect.Location = new System.Drawing.Point(660, 156);
            this.picSelect.Name = "picSelect";
            this.picSelect.Size = new System.Drawing.Size(101, 35);
            this.picSelect.TabIndex = 13;
            this.picSelect.TabStop = false;
            this.picSelect.Click += new System.EventHandler(this.btnSelect_Click);
            this.picSelect.MouseEnter += new System.EventHandler(this.picSelect_MouseEnter);
            this.picSelect.MouseLeave += new System.EventHandler(this.picSelect_MouseLeave);
            // 
            // UcDynamicCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(248)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCompar);
            this.Controls.Add(this.btnLoading);
            this.Controls.Add(this.cobxCameraList);
            this.Name = "UcDynamicCom";
            this.Size = new System.Drawing.Size(810, 555);
            this.Load += new System.EventHandler(this.UcDynamic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFeature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTemp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.ComboBox cobxCameraList;
        private System.Windows.Forms.Button btnLoading;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.PictureBox picFeature;
        private System.Windows.Forms.Button btnCompar;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.PictureBox picTemp;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picSelect;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.PictureBox picCompar;
        private System.Windows.Forms.PictureBox picLoad;
    }
}
