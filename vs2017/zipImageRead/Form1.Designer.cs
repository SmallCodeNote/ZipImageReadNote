namespace zipImageRead
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.button_openZipFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Filename = new System.Windows.Forms.Label();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Prev = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_openZipFile
            // 
            this.button_openZipFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_openZipFile.Location = new System.Drawing.Point(0, 0);
            this.button_openZipFile.Name = "button_openZipFile";
            this.button_openZipFile.Size = new System.Drawing.Size(100, 37);
            this.button_openZipFile.TabIndex = 0;
            this.button_openZipFile.Text = "openZipFile";
            this.button_openZipFile.UseVisualStyleBackColor = true;
            this.button_openZipFile.Click += new System.EventHandler(this.button_openZipFile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Filename);
            this.panel1.Controls.Add(this.button_Next);
            this.panel1.Controls.Add(this.button_Prev);
            this.panel1.Controls.Add(this.button_openZipFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 37);
            this.panel1.TabIndex = 1;
            // 
            // label_Filename
            // 
            this.label_Filename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Filename.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Filename.Location = new System.Drawing.Point(196, 0);
            this.label_Filename.Margin = new System.Windows.Forms.Padding(5);
            this.label_Filename.Name = "label_Filename";
            this.label_Filename.Padding = new System.Windows.Forms.Padding(5);
            this.label_Filename.Size = new System.Drawing.Size(381, 37);
            this.label_Filename.TabIndex = 3;
            this.label_Filename.Text = "...";
            // 
            // button_Next
            // 
            this.button_Next.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Next.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Next.Location = new System.Drawing.Point(148, 0);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(48, 37);
            this.button_Next.TabIndex = 1;
            this.button_Next.Text = "🢂";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Prev
            // 
            this.button_Prev.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Prev.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Prev.Location = new System.Drawing.Point(100, 0);
            this.button_Prev.Name = "button_Prev";
            this.button_Prev.Size = new System.Drawing.Size(48, 37);
            this.button_Prev.TabIndex = 2;
            this.button_Prev.Text = "🢀";
            this.button_Prev.UseVisualStyleBackColor = true;
            this.button_Prev.Click += new System.EventHandler(this.button_Prev_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 584);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 621);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "zipImageRead";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_openZipFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Filename;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Prev;
    }
}

