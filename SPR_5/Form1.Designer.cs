namespace SPR_5
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
            textBoxInput = new TextBox();
            buttonStart = new Button();
            textBoxOutput = new TextBox();
            textBoxOutputY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(98, 79);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(125, 27);
            textBoxInput.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(104, 127);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "button1";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(229, 79);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(125, 27);
            textBoxOutput.TabIndex = 2;
            // 
            // textBoxOutputY
            // 
            textBoxOutputY.Location = new Point(229, 127);
            textBoxOutputY.Name = "textBoxOutputY";
            textBoxOutputY.Size = new Size(125, 27);
            textBoxOutputY.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 136);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 4;
            label1.Text = "Y";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 86);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 5;
            label2.Text = "S";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxOutputY);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonStart);
            Controls.Add(textBoxInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button buttonStart;
        private TextBox textBoxOutput;
        private TextBox textBoxOutputY;
        private Label label1;
        private Label label2;
    }
}