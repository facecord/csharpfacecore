namespace faceView.UcControl
{
    partial class UcCompar
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.lblCompar = new System.Windows.Forms.Label();
            this.btn1Select = new System.Windows.Forms.Button();
            this.btn2Select = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompar = new System.Windows.Forms.Button();
            this.pic1Select = new System.Windows.Forms.PictureBox();
            this.pic2Select = new System.Windows.Forms.PictureBox();
            this.picCompar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1Select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2Select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompar)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Location = new System.Drawing.Point(42, 87);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(295, 382);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic2.Location = new System.Drawing.Point(477, 87);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(295, 382);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 0;
            this.pic2.TabStop = false;
            // 
            // lblCompar
            // 
            this.lblCompar.BackColor = System.Drawing.Color.Transparent;
            this.lblCompar.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCompar.ForeColor = System.Drawing.Color.Red;
            this.lblCompar.Location = new System.Drawing.Point(343, 215);
            this.lblCompar.Name = "lblCompar";
            this.lblCompar.Size = new System.Drawing.Size(128, 73);
            this.lblCompar.TabIndex = 1;
            // 
            // btn1Select
            // 
            this.btn1Select.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1Select.Location = new System.Drawing.Point(3, 519);
            this.btn1Select.Name = "btn1Select";
            this.btn1Select.Size = new System.Drawing.Size(110, 35);
            this.btn1Select.TabIndex = 3;
            this.btn1Select.Text = "选择照片";
            this.btn1Select.UseVisualStyleBackColor = true;
            this.btn1Select.Visible = false;
            this.btn1Select.Click += new System.EventHandler(this.btn1Select_Click);
            // 
            // btn2Select
            // 
            this.btn2Select.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2Select.Location = new System.Drawing.Point(699, 519);
            this.btn2Select.Name = "btn2Select";
            this.btn2Select.Size = new System.Drawing.Size(110, 35);
            this.btn2Select.TabIndex = 3;
            this.btn2Select.Text = "选择照片";
            this.btn2Select.UseVisualStyleBackColor = true;
            this.btn2Select.Visible = false;
            this.btn2Select.Click += new System.EventHandler(this.btn2Select_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(145, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "选择照片必须是bmp,png,jpg,jpeg,tif格式中的一种";
            // 
            // btnCompar
            // 
            this.btnCompar.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompar.Location = new System.Drawing.Point(349, 519);
            this.btnCompar.Name = "btnCompar";
            this.btnCompar.Size = new System.Drawing.Size(110, 35);
            this.btnCompar.TabIndex = 3;
            this.btnCompar.Text = "开始比对";
            this.btnCompar.UseVisualStyleBackColor = true;
            this.btnCompar.Visible = false;
            this.btnCompar.Click += new System.EventHandler(this.btnCompar_Click);
            // 
            // pic1Select
            // 
            this.pic1Select.Location = new System.Drawing.Point(119, 478);
            this.pic1Select.Name = "pic1Select";
            this.pic1Select.Size = new System.Drawing.Size(134, 46);
            this.pic1Select.TabIndex = 5;
            this.pic1Select.TabStop = false;
            this.pic1Select.Click += new System.EventHandler(this.btn1Select_Click);
            this.pic1Select.MouseEnter += new System.EventHandler(this.pic2Select_MouseEnter);
            this.pic1Select.MouseLeave += new System.EventHandler(this.pic2Select_MouseLeave);
            // 
            // pic2Select
            // 
            this.pic2Select.Location = new System.Drawing.Point(559, 478);
            this.pic2Select.Name = "pic2Select";
            this.pic2Select.Size = new System.Drawing.Size(134, 46);
            this.pic2Select.TabIndex = 5;
            this.pic2Select.TabStop = false;
            this.pic2Select.Click += new System.EventHandler(this.btn2Select_Click);
            this.pic2Select.MouseEnter += new System.EventHandler(this.pic2Select_MouseEnter);
            this.pic2Select.MouseLeave += new System.EventHandler(this.pic2Select_MouseLeave);
            // 
            // picCompar
            // 
            this.picCompar.Location = new System.Drawing.Point(340, 478);
            this.picCompar.Name = "picCompar";
            this.picCompar.Size = new System.Drawing.Size(134, 46);
            this.picCompar.TabIndex = 6;
            this.picCompar.TabStop = false;
            this.picCompar.Click += new System.EventHandler(this.btnCompar_Click);
            this.picCompar.MouseEnter += new System.EventHandler(this.picCompar_MouseEnter);
            this.picCompar.MouseLeave += new System.EventHandler(this.picCompar_MouseLeave);
            // 
            // UcCompar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(248)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picCompar);
            this.Controls.Add(this.pic2Select);
            this.Controls.Add(this.pic1Select);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn2Select);
            this.Controls.Add(this.btnCompar);
            this.Controls.Add(this.btn1Select);
            this.Controls.Add(this.lblCompar);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Name = "UcCompar";
            this.Size = new System.Drawing.Size(812, 557);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1Select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2Select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label lblCompar;
        private System.Windows.Forms.Button btn1Select;
        private System.Windows.Forms.Button btn2Select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompar;
        private System.Windows.Forms.PictureBox pic1Select;
        private System.Windows.Forms.PictureBox pic2Select;
        private System.Windows.Forms.PictureBox picCompar;
    }
}
