namespace test_vs_project
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
            _addButton = new Button();
            _subButton = new Button();
            _textBoxLhs = new TextBox();
            _textBoxRhs = new TextBox();
            _textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // _addButton
            // 
            _addButton.Location = new Point(12, 41);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(75, 23);
            _addButton.TabIndex = 3;
            _addButton.Text = "add";
            _addButton.UseVisualStyleBackColor = true;
            _addButton.Click += _addButton_Click;
            // 
            // _subButton
            // 
            _subButton.Location = new Point(12, 70);
            _subButton.Name = "_subButton";
            _subButton.Size = new Size(75, 23);
            _subButton.TabIndex = 4;
            _subButton.Text = "sub";
            _subButton.UseVisualStyleBackColor = true;
            _subButton.Click += _subButton_Click;
            // 
            // _textBoxLhs
            // 
            _textBoxLhs.Location = new Point(12, 12);
            _textBoxLhs.Name = "_textBoxLhs";
            _textBoxLhs.Size = new Size(101, 23);
            _textBoxLhs.TabIndex = 0;
            // 
            // _textBoxRhs
            // 
            _textBoxRhs.Location = new Point(119, 12);
            _textBoxRhs.Name = "_textBoxRhs";
            _textBoxRhs.Size = new Size(101, 23);
            _textBoxRhs.TabIndex = 1;
            // 
            // _textBoxResult
            // 
            _textBoxResult.Location = new Point(226, 12);
            _textBoxResult.Name = "_textBoxResult";
            _textBoxResult.ReadOnly = true;
            _textBoxResult.Size = new Size(101, 23);
            _textBoxResult.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_textBoxResult);
            Controls.Add(_textBoxRhs);
            Controls.Add(_textBoxLhs);
            Controls.Add(_subButton);
            Controls.Add(_addButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button _addButton;
        private Button _subButton;
        private TextBox _textBoxLhs;
        private TextBox _textBoxRhs;
        private TextBox _textBoxResult;
    }
}
