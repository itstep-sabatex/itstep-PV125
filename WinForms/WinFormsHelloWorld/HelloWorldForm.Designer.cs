namespace WinFormsHelloWorld
{
    partial class HelloWorldForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bBoll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bBoll
            // 
            this.bBoll.Location = new System.Drawing.Point(251, 144);
            this.bBoll.Name = "bBoll";
            this.bBoll.Size = new System.Drawing.Size(112, 34);
            this.bBoll.TabIndex = 0;
            this.bBoll.Text = "bBoll";
            this.bBoll.UseVisualStyleBackColor = true;
            this.bBoll.Click += new System.EventHandler(this.bBoll_Click);
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bBoll);
            this.Name = "HelloWorldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelloWorldForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HelloWorldForm_FormClosed);
            this.Load += new System.EventHandler(this.HelloWorldForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button bBoll;
    }
}