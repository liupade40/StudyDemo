namespace SelfControl
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.self1 = new SelfControl.Self();
            this.customControl11 = new SelfControl.CustomControl1();
            this.SuspendLayout();
            // 
            // self1
            // 
            this.self1.Location = new System.Drawing.Point(3, 0);
            this.self1.Name = "self1";
            this.self1.Size = new System.Drawing.Size(272, 115);
            this.self1.TabIndex = 0;
            this.self1.Load += new System.EventHandler(this.self1_Load);
            // 
            // customControl11
            // 
            this.customControl11.Location = new System.Drawing.Point(568, 133);
            this.customControl11.Name = "customControl11";
            this.customControl11.Size = new System.Drawing.Size(75, 23);
            this.customControl11.TabIndex = 1;
            this.customControl11.Text = "customControl11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customControl11);
            this.Controls.Add(this.self1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Self self1;
        private CustomControl1 customControl11;
    }
}

