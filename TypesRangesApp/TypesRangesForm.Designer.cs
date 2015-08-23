namespace WindowsFormsApplication1
{
    partial class TypesRangesForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "byte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.byte_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "sbyte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.sbyte_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "short";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.short_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(162, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "ushort";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ushort_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "int";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.int_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(162, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "uint";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.uint_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(29, 167);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "long";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.long_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(162, 167);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "ulong";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ulong_Click);
            // 
            // TypesRangesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 269);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 269);
            this.Name = "TypesRangesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Types Ranges";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

