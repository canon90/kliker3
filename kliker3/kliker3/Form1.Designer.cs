

namespace kliker3
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
            go = new Button();
            label1 = new Label();
            stop = new Button();
            SuspendLayout();
            // 
            // go
            // 
            go.Location = new Point(566, 353);
            go.Name = "go";
            go.Size = new Size(126, 46);
            go.TabIndex = 0;
            go.Text = "go";
            go.UseVisualStyleBackColor = true;
            go.Click += go_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(411, 70);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // stop
            // 
            stop.Location = new Point(392, 353);
            stop.Name = "stop";
            stop.Size = new Size(121, 46);
            stop.TabIndex = 2;
            stop.Text = "stop";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stop);
            Controls.Add(label1);
            Controls.Add(go);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button go;
        private Label label1;
        private Button stop;
    }
}