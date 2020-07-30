namespace zb_noty
{
    partial class Noty
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
            this.BorderLeft = new System.Windows.Forms.Panel();
            this.Caption = new System.Windows.Forms.Label();
            this.BorderTop = new System.Windows.Forms.Panel();
            this.BorderBottom = new System.Windows.Forms.Panel();
            this.BorderRight = new System.Windows.Forms.Panel();
            this.Message = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderLeft
            // 
            this.BorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(192)))), ((int)(((byte)(81)))));
            this.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BorderLeft.Location = new System.Drawing.Point(0, 0);
            this.BorderLeft.Margin = new System.Windows.Forms.Padding(4);
            this.BorderLeft.Name = "BorderLeft";
            this.BorderLeft.Size = new System.Drawing.Size(7, 70);
            this.BorderLeft.TabIndex = 0;
            // 
            // Caption
            // 
            this.Caption.AutoSize = true;
            this.Caption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caption.ForeColor = System.Drawing.Color.White;
            this.Caption.Location = new System.Drawing.Point(53, 12);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(111, 21);
            this.Caption.TabIndex = 1;
            this.Caption.Text = "İşlem başarılı";
            // 
            // BorderTop
            // 
            this.BorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(192)))), ((int)(((byte)(81)))));
            this.BorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderTop.Location = new System.Drawing.Point(7, 0);
            this.BorderTop.Margin = new System.Windows.Forms.Padding(4);
            this.BorderTop.Name = "BorderTop";
            this.BorderTop.Size = new System.Drawing.Size(373, 2);
            this.BorderTop.TabIndex = 2;
            // 
            // BorderBottom
            // 
            this.BorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(192)))), ((int)(((byte)(81)))));
            this.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderBottom.ForeColor = System.Drawing.Color.White;
            this.BorderBottom.Location = new System.Drawing.Point(7, 68);
            this.BorderBottom.Margin = new System.Windows.Forms.Padding(4);
            this.BorderBottom.Name = "BorderBottom";
            this.BorderBottom.Size = new System.Drawing.Size(373, 2);
            this.BorderBottom.TabIndex = 3;
            // 
            // BorderRight
            // 
            this.BorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(192)))), ((int)(((byte)(81)))));
            this.BorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BorderRight.Location = new System.Drawing.Point(378, 2);
            this.BorderRight.Margin = new System.Windows.Forms.Padding(4);
            this.BorderRight.Name = "BorderRight";
            this.BorderRight.Size = new System.Drawing.Size(2, 66);
            this.BorderRight.TabIndex = 4;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.Color.White;
            this.Message.Location = new System.Drawing.Point(54, 40);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(258, 17);
            this.Message.TabIndex = 5;
            this.Message.Text = "Kayıt işlemi başarılı bir şekilde tamamlandı.";
            // 
            // Close
            // 
            this.Close.Image = global::zb_noty.Properties.Resources.close;
            this.Close.Location = new System.Drawing.Point(350, 26);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(18, 18);
            this.Close.TabIndex = 6;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Icon
            // 
            this.Icon.Image = global::zb_noty.Properties.Resources.success;
            this.Icon.Location = new System.Drawing.Point(14, 21);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(28, 28);
            this.Icon.TabIndex = 7;
            this.Icon.TabStop = false;
            // 
            // Noty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(212)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(380, 70);
            this.ControlBox = false;
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.BorderRight);
            this.Controls.Add(this.BorderBottom);
            this.Controls.Add(this.BorderTop);
            this.Controls.Add(this.Caption);
            this.Controls.Add(this.BorderLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Noty";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BorderLeft;
        private System.Windows.Forms.Label Caption;
        private System.Windows.Forms.Panel BorderTop;
        private System.Windows.Forms.Panel BorderBottom;
        private System.Windows.Forms.Panel BorderRight;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Icon;
        private System.Windows.Forms.Timer timer;
    }
}

