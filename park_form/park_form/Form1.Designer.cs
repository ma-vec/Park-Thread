namespace park_form
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
            label1 = new Label();
            label2 = new Label();
            listBoxEnter = new ListBox();
            listBoxExit = new ListBox();
            listBoxPark = new ListBox();
            buttonStart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 33);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingressi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(665, 33);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Uscite";
            // 
            // listBoxEnter
            // 
            listBoxEnter.FormattingEnabled = true;
            listBoxEnter.ItemHeight = 15;
            listBoxEnter.Location = new Point(33, 83);
            listBoxEnter.Name = "listBoxEnter";
            listBoxEnter.Size = new Size(119, 244);
            listBoxEnter.TabIndex = 2;
            // 
            // listBoxExit
            // 
            listBoxExit.FormattingEnabled = true;
            listBoxExit.ItemHeight = 15;
            listBoxExit.Location = new Point(665, 83);
            listBoxExit.Name = "listBoxExit";
            listBoxExit.Size = new Size(119, 244);
            listBoxExit.TabIndex = 3;
            // 
            // listBoxPark
            // 
            listBoxPark.FormattingEnabled = true;
            listBoxPark.ItemHeight = 15;
            listBoxPark.Location = new Point(274, 83);
            listBoxPark.Name = "listBoxPark";
            listBoxPark.Size = new Size(283, 244);
            listBoxPark.TabIndex = 4;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(33, 369);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(751, 50);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStart);
            Controls.Add(listBoxPark);
            Controls.Add(listBoxExit);
            Controls.Add(listBoxEnter);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBoxEnter;
        private ListBox listBoxExit;
        private ListBox listBoxPark;
        private Button buttonStart;
    }
}
