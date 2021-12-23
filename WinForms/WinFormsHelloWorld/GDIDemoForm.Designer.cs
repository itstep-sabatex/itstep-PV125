namespace WinFormsHelloWorld
{
    partial class GDIDemoForm
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
            this.pPicture = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.myButton1 = new WinFormsHelloWorld.MyButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDraw = new System.Windows.Forms.Button();
            this.pPicture.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPicture
            // 
            this.pPicture.Controls.Add(this.label1);
            this.pPicture.Controls.Add(this.myButton1);
            this.pPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPicture.Location = new System.Drawing.Point(0, 48);
            this.pPicture.Name = "pPicture";
            this.pPicture.Size = new System.Drawing.Size(800, 402);
            this.pPicture.TabIndex = 0;
            this.pPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.pPicture_Paint);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 253);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // myButton1
            // 
            this.myButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.myButton1.Location = new System.Drawing.Point(0, 0);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(800, 74);
            this.myButton1.TabIndex = 1;
            this.myButton1.Text = "myButton1";
            this.myButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btDraw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 48);
            this.panel2.TabIndex = 1;
            // 
            // btDraw
            // 
            this.btDraw.Location = new System.Drawing.Point(30, 3);
            this.btDraw.Name = "btDraw";
            this.btDraw.Size = new System.Drawing.Size(112, 34);
            this.btDraw.TabIndex = 0;
            this.btDraw.Text = "Draw";
            this.btDraw.UseVisualStyleBackColor = true;
            this.btDraw.Click += new System.EventHandler(this.btDraw_Click);
            this.btDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.btDraw_Paint);
            // 
            // GDIDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pPicture);
            this.Controls.Add(this.panel2);
            this.Name = "GDIDemoForm";
            this.Text = "GDIDemoForm";
            this.pPicture.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pPicture;
        private Panel panel2;
        private Button btDraw;
        private MyButton myButton1;
        private Label label1;
    }
}