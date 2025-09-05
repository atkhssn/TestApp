namespace TestApp
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
            inputText = new TextBox();
            greetings = new Label();
            okBtn = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // inputText
            // 
            inputText.Location = new Point(521, 111);
            inputText.Name = "inputText";
            inputText.Size = new Size(208, 27);
            inputText.TabIndex = 0;
            // 
            // greetings
            // 
            greetings.AutoSize = true;
            greetings.Location = new Point(521, 88);
            greetings.Name = "greetings";
            greetings.Size = new Size(50, 20);
            greetings.TabIndex = 1;
            greetings.Text = "label1";
            // 
            // okBtn
            // 
            okBtn.Location = new Point(635, 208);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 2;
            okBtn.Text = "button1";
            okBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(521, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(521, 152);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(okBtn);
            Controls.Add(greetings);
            Controls.Add(inputText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputText;
        private Label greetings;
        private Button okBtn;
        private TextBox textBox1;
        private Label label1;
    }
}
