
namespace Paint2
{
    partial class PaintPr
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
            this.PanelPaint = new System.Windows.Forms.Panel();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.PanelPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPaint
            // 
            this.PanelPaint.BackColor = System.Drawing.Color.Aqua;
            this.PanelPaint.Controls.Add(this.btnRectangle);
            this.PanelPaint.Controls.Add(this.btnCircle);
            this.PanelPaint.Controls.Add(this.btnPen);
            this.PanelPaint.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelPaint.Location = new System.Drawing.Point(685, 0);
            this.PanelPaint.Name = "PanelPaint";
            this.PanelPaint.Size = new System.Drawing.Size(115, 450);
            this.PanelPaint.TabIndex = 0;
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.Red;
            this.btnRectangle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRectangle.Location = new System.Drawing.Point(15, 290);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(97, 77);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.Red;
            this.btnCircle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircle.Location = new System.Drawing.Point(19, 150);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(75, 77);
            this.btnCircle.TabIndex = 1;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnPen
            // 
            this.btnPen.BackColor = System.Drawing.Color.Red;
            this.btnPen.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPen.Location = new System.Drawing.Point(19, 12);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(75, 77);
            this.btnPen.TabIndex = 0;
            this.btnPen.Text = "Pen";
            this.btnPen.UseVisualStyleBackColor = false;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BackColor = System.Drawing.Color.White;
            this.pictureBoxHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHome.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(685, 450);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 1;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxHome_Paint);
            this.pictureBoxHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHome_MouseDown);
            this.pictureBoxHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHome_MouseMove);
            this.pictureBoxHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHome_MouseUp);
            // 
            // PaintPr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxHome);
            this.Controls.Add(this.PanelPaint);
            this.Name = "PaintPr";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelPaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPaint;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnRectangle;
    }
}

