
namespace git
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBox1 = new System.Windows.Forms.TextBox();
            this.tBox2 = new System.Windows.Forms.TextBox();
            this.tBoxOtv = new System.Windows.Forms.TextBox();
            this.Calk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBox1
            // 
            this.tBox1.Location = new System.Drawing.Point(48, 44);
            this.tBox1.Name = "tBox1";
            this.tBox1.Size = new System.Drawing.Size(100, 20);
            this.tBox1.TabIndex = 0;
            // 
            // tBox2
            // 
            this.tBox2.Location = new System.Drawing.Point(215, 44);
            this.tBox2.Name = "tBox2";
            this.tBox2.Size = new System.Drawing.Size(100, 20);
            this.tBox2.TabIndex = 1;
            // 
            // tBoxOtv
            // 
            this.tBoxOtv.Location = new System.Drawing.Point(48, 129);
            this.tBoxOtv.Name = "tBoxOtv";
            this.tBoxOtv.Size = new System.Drawing.Size(267, 20);
            this.tBoxOtv.TabIndex = 2;
            // 
            // Calk
            // 
            this.Calk.Location = new System.Drawing.Point(49, 91);
            this.Calk.Name = "Calk";
            this.Calk.Size = new System.Drawing.Size(47, 23);
            this.Calk.TabIndex = 3;
            this.Calk.Text = "+";
            this.Calk.UseVisualStyleBackColor = true;
            this.Calk.Click += new System.EventHandler(this.Calk_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Calk);
            this.Controls.Add(this.tBoxOtv);
            this.Controls.Add(this.tBox2);
            this.Controls.Add(this.tBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox1;
        private System.Windows.Forms.TextBox tBox2;
        private System.Windows.Forms.TextBox tBoxOtv;
        private System.Windows.Forms.Button Calk;
        private System.Windows.Forms.Button button1;
    }
}

