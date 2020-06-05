namespace ColorPicker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.labelRed = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.labelRed255 = new System.Windows.Forms.Label();
            this.labelGreen255 = new System.Windows.Forms.Label();
            this.labelRed1 = new System.Windows.Forms.Label();
            this.labelGreen1 = new System.Windows.Forms.Label();
            this.labelBlue1 = new System.Windows.Forms.Label();
            this.labelBlue255 = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.trackBarRed, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRed, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackBarBlue, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.trackBarGreen, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelRed255, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelGreen255, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelRed1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelGreen1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelBlue1, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelBlue255, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelBlue, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelGreen, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxColor, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(621, 310);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // trackBarRed
            // 
            this.trackBarRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.trackBarRed, 2);
            this.trackBarRed.LargeChange = 17;
            this.trackBarRed.Location = new System.Drawing.Point(313, 37);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(305, 28);
            this.trackBarRed.TabIndex = 0;
            this.trackBarRed.TickFrequency = 17;
            this.trackBarRed.Value = 125;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // labelRed
            // 
            this.labelRed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(269, 42);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(38, 17);
            this.labelRed.TabIndex = 3;
            this.labelRed.Text = "Red:";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.trackBarBlue, 2);
            this.trackBarBlue.LargeChange = 17;
            this.trackBarBlue.Location = new System.Drawing.Point(313, 241);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(305, 28);
            this.trackBarBlue.TabIndex = 2;
            this.trackBarBlue.TickFrequency = 17;
            this.trackBarBlue.Value = 125;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.trackBarGreen, 2);
            this.trackBarGreen.LargeChange = 17;
            this.trackBarGreen.Location = new System.Drawing.Point(313, 139);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(305, 28);
            this.trackBarGreen.TabIndex = 1;
            this.trackBarGreen.TickFrequency = 17;
            this.trackBarGreen.Value = 125;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // labelRed255
            // 
            this.labelRed255.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRed255.AutoSize = true;
            this.labelRed255.Location = new System.Drawing.Point(586, 68);
            this.labelRed255.Name = "labelRed255";
            this.labelRed255.Size = new System.Drawing.Size(32, 17);
            this.labelRed255.TabIndex = 4;
            this.labelRed255.Text = "255";
            // 
            // labelGreen255
            // 
            this.labelGreen255.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGreen255.AutoSize = true;
            this.labelGreen255.Location = new System.Drawing.Point(586, 170);
            this.labelGreen255.Name = "labelGreen255";
            this.labelGreen255.Size = new System.Drawing.Size(32, 17);
            this.labelGreen255.TabIndex = 6;
            this.labelGreen255.Text = "255";
            // 
            // labelRed1
            // 
            this.labelRed1.AutoSize = true;
            this.labelRed1.Location = new System.Drawing.Point(313, 68);
            this.labelRed1.Name = "labelRed1";
            this.labelRed1.Size = new System.Drawing.Size(16, 17);
            this.labelRed1.TabIndex = 5;
            this.labelRed1.Text = "0";
            // 
            // labelGreen1
            // 
            this.labelGreen1.AutoSize = true;
            this.labelGreen1.Location = new System.Drawing.Point(313, 170);
            this.labelGreen1.Name = "labelGreen1";
            this.labelGreen1.Size = new System.Drawing.Size(16, 17);
            this.labelGreen1.TabIndex = 7;
            this.labelGreen1.Text = "0";
            // 
            // labelBlue1
            // 
            this.labelBlue1.AutoSize = true;
            this.labelBlue1.Location = new System.Drawing.Point(313, 272);
            this.labelBlue1.Name = "labelBlue1";
            this.labelBlue1.Size = new System.Drawing.Size(16, 17);
            this.labelBlue1.TabIndex = 8;
            this.labelBlue1.Text = "0";
            // 
            // labelBlue255
            // 
            this.labelBlue255.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBlue255.AutoSize = true;
            this.labelBlue255.Location = new System.Drawing.Point(586, 272);
            this.labelBlue255.Name = "labelBlue255";
            this.labelBlue255.Size = new System.Drawing.Size(32, 17);
            this.labelBlue255.TabIndex = 9;
            this.labelBlue255.Text = "255";
            // 
            // labelBlue
            // 
            this.labelBlue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(267, 246);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(40, 17);
            this.labelBlue.TabIndex = 10;
            this.labelBlue.Text = "Blue:";
            // 
            // labelGreen
            // 
            this.labelGreen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(255, 144);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(52, 17);
            this.labelGreen.TabIndex = 11;
            this.labelGreen.Text = "Green:";
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxColor.Location = new System.Drawing.Point(3, 37);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBoxColor, 7);
            this.pictureBoxColor.Size = new System.Drawing.Size(242, 232);
            this.pictureBoxColor.TabIndex = 12;
            this.pictureBoxColor.TabStop = false;
            this.pictureBoxColor.MouseHover += new System.EventHandler(this.pictureBoxColor_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 310);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(639, 357);
            this.Name = "Form1";
            this.Text = "ColorPicker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelRed255;
        private System.Windows.Forms.Label labelGreen255;
        private System.Windows.Forms.Label labelRed1;
        private System.Windows.Forms.Label labelGreen1;
        private System.Windows.Forms.Label labelBlue1;
        private System.Windows.Forms.Label labelBlue255;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.PictureBox pictureBoxColor;
    }
}

