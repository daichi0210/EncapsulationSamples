namespace EncapsulationSamples
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
            labelColorResult = new Label();
            textBoxColorValue = new TextBox();
            buttonSetColor = new Button();
            SuspendLayout();
            // 
            // labelColorResult
            // 
            labelColorResult.AutoSize = true;
            labelColorResult.Location = new Point(12, 9);
            labelColorResult.Name = "labelColorResult";
            labelColorResult.Size = new Size(60, 15);
            labelColorResult.TabIndex = 0;
            labelColorResult.Text = "設定した色";
            // 
            // textBoxColorValue
            // 
            textBoxColorValue.Location = new Point(78, 6);
            textBoxColorValue.Name = "textBoxColorValue";
            textBoxColorValue.Size = new Size(100, 23);
            textBoxColorValue.TabIndex = 1;
            textBoxColorValue.Text = "Black";
            // 
            // buttonSetColor
            // 
            buttonSetColor.Location = new Point(184, 5);
            buttonSetColor.Name = "buttonSetColor";
            buttonSetColor.Size = new Size(75, 23);
            buttonSetColor.TabIndex = 2;
            buttonSetColor.Text = "色を設定する";
            buttonSetColor.UseVisualStyleBackColor = true;
            buttonSetColor.Click += buttonSetColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 37);
            Controls.Add(buttonSetColor);
            Controls.Add(textBoxColorValue);
            Controls.Add(labelColorResult);
            Name = "Form1";
            Text = "文字で色設定";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelColorResult;
        private TextBox textBoxColorValue;
        private Button buttonSetColor;
    }
}
