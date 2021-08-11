
namespace TriangleSierpinski
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PointAx = new System.Windows.Forms.TextBox();
            this.ControlPic = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PointAy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PointBx = new System.Windows.Forms.TextBox();
            this.textBox_PointBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_PointCx = new System.Windows.Forms.TextBox();
            this.textBox_PointCy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_PointStartX = new System.Windows.Forms.TextBox();
            this.textBox_PointStartY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_LoopCounter = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_LoopRefreshCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Точка А";
            // 
            // textBox_PointAx
            // 
            this.textBox_PointAx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PointAx.Location = new System.Drawing.Point(171, 42);
            this.textBox_PointAx.Name = "textBox_PointAx";
            this.textBox_PointAx.Size = new System.Drawing.Size(64, 34);
            this.textBox_PointAx.TabIndex = 1;
            this.textBox_PointAx.Text = "100";
            // 
            // ControlPic
            // 
            this.ControlPic.BackColor = System.Drawing.Color.White;
            this.ControlPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ControlPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlPic.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlPic.ErrorImage = null;
            this.ControlPic.Image = ((System.Drawing.Image)(resources.GetObject("ControlPic.Image")));
            this.ControlPic.ImageLocation = "";
            this.ControlPic.InitialImage = null;
            this.ControlPic.Location = new System.Drawing.Point(339, 0);
            this.ControlPic.Name = "ControlPic";
            this.ControlPic.Size = new System.Drawing.Size(1115, 869);
            this.ControlPic.TabIndex = 2;
            this.ControlPic.TabStop = false;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Lime;
            this.button_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_start.Location = new System.Drawing.Point(108, 397);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(94, 49);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(192, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(269, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // textBox_PointAy
            // 
            this.textBox_PointAy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PointAy.Location = new System.Drawing.Point(244, 42);
            this.textBox_PointAy.Name = "textBox_PointAy";
            this.textBox_PointAy.Size = new System.Drawing.Size(64, 34);
            this.textBox_PointAy.TabIndex = 1;
            this.textBox_PointAy.Text = "600";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Точка B";
            // 
            // textBox_PointBx
            // 
            this.textBox_PointBx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PointBx.Location = new System.Drawing.Point(171, 82);
            this.textBox_PointBx.Name = "textBox_PointBx";
            this.textBox_PointBx.Size = new System.Drawing.Size(64, 34);
            this.textBox_PointBx.TabIndex = 1;
            this.textBox_PointBx.Text = "500";
            // 
            // textBox_PointBy
            // 
            this.textBox_PointBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PointBy.Location = new System.Drawing.Point(244, 82);
            this.textBox_PointBy.Name = "textBox_PointBy";
            this.textBox_PointBy.Size = new System.Drawing.Size(64, 34);
            this.textBox_PointBy.TabIndex = 1;
            this.textBox_PointBy.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Точка C";
            // 
            // textBox_PointCx
            // 
            this.textBox_PointCx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PointCx.Location = new System.Drawing.Point(171, 122);
            this.textBox_PointCx.Name = "textBox_PointCx";
            this.textBox_PointCx.Size = new System.Drawing.Size(64, 34);
            this.textBox_PointCx.TabIndex = 1;
            this.textBox_PointCx.Text = "900";
            // 
            // textBox_PointCy
            // 
            this.textBox_PointCy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PointCy.Location = new System.Drawing.Point(244, 122);
            this.textBox_PointCy.Name = "textBox_PointCy";
            this.textBox_PointCy.Size = new System.Drawing.Size(64, 34);
            this.textBox_PointCy.TabIndex = 1;
            this.textBox_PointCy.Text = "600";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Начальная точка";
            // 
            // textBox_PointStartX
            // 
            this.textBox_PointStartX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PointStartX.Location = new System.Drawing.Point(171, 162);
            this.textBox_PointStartX.Name = "textBox_PointStartX";
            this.textBox_PointStartX.Size = new System.Drawing.Size(64, 34);
            this.textBox_PointStartX.TabIndex = 1;
            this.textBox_PointStartX.Text = "600";
            // 
            // textBox_PointStartY
            // 
            this.textBox_PointStartY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_PointStartY.Location = new System.Drawing.Point(244, 162);
            this.textBox_PointStartY.Name = "textBox_PointStartY";
            this.textBox_PointStartY.Size = new System.Drawing.Size(64, 34);
            this.textBox_PointStartY.TabIndex = 1;
            this.textBox_PointStartY.Text = "400";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Циклы";
            // 
            // label_LoopCounter
            // 
            this.label_LoopCounter.AutoSize = true;
            this.label_LoopCounter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_LoopCounter.Location = new System.Drawing.Point(108, 460);
            this.label_LoopCounter.Name = "label_LoopCounter";
            this.label_LoopCounter.Size = new System.Drawing.Size(23, 28);
            this.label_LoopCounter.TabIndex = 5;
            this.label_LoopCounter.Text = "0";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(5, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 82);
            this.label8.TabIndex = 0;
            this.label8.Text = "Обновлять через заданное количество циклов";
            // 
            // textBox_LoopRefreshCount
            // 
            this.textBox_LoopRefreshCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_LoopRefreshCount.Location = new System.Drawing.Point(244, 310);
            this.textBox_LoopRefreshCount.Name = "textBox_LoopRefreshCount";
            this.textBox_LoopRefreshCount.Size = new System.Drawing.Size(64, 34);
            this.textBox_LoopRefreshCount.TabIndex = 1;
            this.textBox_LoopRefreshCount.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 869);
            this.Controls.Add(this.label_LoopCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.ControlPic);
            this.Controls.Add(this.textBox_LoopRefreshCount);
            this.Controls.Add(this.textBox_PointStartY);
            this.Controls.Add(this.textBox_PointCy);
            this.Controls.Add(this.textBox_PointBy);
            this.Controls.Add(this.textBox_PointAy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_PointStartX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_PointCx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_PointBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_PointAx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Треугольник Серпинского";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControlPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PointAx;
        private System.Windows.Forms.PictureBox ControlPic;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PointAy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_PointBx;
        private System.Windows.Forms.TextBox textBox_PointBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_PointCx;
        private System.Windows.Forms.TextBox textBox_PointCy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_PointStartX;
        private System.Windows.Forms.TextBox textBox_PointStartY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_LoopCounter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_LoopRefreshCount;
    }
}

