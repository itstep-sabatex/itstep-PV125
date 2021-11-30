namespace WinFormsHelloWorld
{
    partial class MainForm
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btHelloWorld = new System.Windows.Forms.Button();
            this.btShowHelloWorld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(664, 395);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 34);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(546, 395);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(112, 34);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 2;
            // 
            // btHelloWorld
            // 
            this.btHelloWorld.Location = new System.Drawing.Point(321, 395);
            this.btHelloWorld.Name = "btHelloWorld";
            this.btHelloWorld.Size = new System.Drawing.Size(219, 34);
            this.btHelloWorld.TabIndex = 3;
            this.btHelloWorld.Text = "ShowDialog Hello World";
            this.btHelloWorld.UseVisualStyleBackColor = true;
            this.btHelloWorld.Click += new System.EventHandler(this.btHelloWorld_Click);
            // 
            // btShowHelloWorld
            // 
            this.btShowHelloWorld.Location = new System.Drawing.Point(123, 395);
            this.btShowHelloWorld.Name = "btShowHelloWorld";
            this.btShowHelloWorld.Size = new System.Drawing.Size(178, 34);
            this.btShowHelloWorld.TabIndex = 4;
            this.btShowHelloWorld.Text = "Show Hello World";
            this.btShowHelloWorld.UseVisualStyleBackColor = true;
            this.btShowHelloWorld.Click += new System.EventHandler(this.btShowHelloWorld_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 437);
            this.Controls.Add(this.btShowHelloWorld);
            this.Controls.Add(this.btHelloWorld);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btCancel);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Hello World";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btCancel;
        private Button btOk;
        private TextBox textBox1;
        private Button btHelloWorld;
        private Button btShowHelloWorld;
    }
}