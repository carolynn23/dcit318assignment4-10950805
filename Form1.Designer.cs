namespace DrawingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            vScrollBar1 = new VScrollBar();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(719, 1);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 495);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(913, 1);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(18, 495);
            vScrollBar1.TabIndex = 1;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(vScrollBar1);
            Controls.Add(textBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Drawing App";
            Load += Form1_Load;
            Paint += Form1_Paint;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private VScrollBar vScrollBar1;
    }
}
