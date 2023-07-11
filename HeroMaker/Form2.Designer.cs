namespace HeroMaker
{
    partial class Form2
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            btn_sort_AZ = new Button();
            btn_sort_ZA = new Button();
            btn_delete = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(30, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(231, 379);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(286, 77);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(480, 335);
            textBox1.TabIndex = 1;
            // 
            // btn_sort_AZ
            // 
            btn_sort_AZ.Location = new Point(284, 33);
            btn_sort_AZ.Name = "btn_sort_AZ";
            btn_sort_AZ.Size = new Size(98, 27);
            btn_sort_AZ.TabIndex = 2;
            btn_sort_AZ.Text = "A to Z";
            btn_sort_AZ.UseVisualStyleBackColor = true;
            btn_sort_AZ.Click += btn_sort_AZ_Click;
            // 
            // btn_sort_ZA
            // 
            btn_sort_ZA.Location = new Point(399, 33);
            btn_sort_ZA.Name = "btn_sort_ZA";
            btn_sort_ZA.Size = new Size(88, 27);
            btn_sort_ZA.TabIndex = 3;
            btn_sort_ZA.Text = "Z to A";
            btn_sort_ZA.UseVisualStyleBackColor = true;
            btn_sort_ZA.Click += btn_sort_ZA_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(507, 33);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(93, 27);
            btn_delete.TabIndex = 4;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_sort_ZA);
            Controls.Add(btn_sort_AZ);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button btn_sort_AZ;
        private Button btn_sort_ZA;
        private Button btn_delete;
    }
}