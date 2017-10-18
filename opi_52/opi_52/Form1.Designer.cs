namespace opi_52
{
    partial class Form1
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
            this.button = new System.Windows.Forms.Button();
            this.position = new System.Windows.Forms.Label();
            this.position2 = new System.Windows.Forms.Label();
            this.part = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button.Location = new System.Drawing.Point(160, 150);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(50, 50);
            this.button.TabIndex = 0;
            this.button.UseVisualStyleBackColor = true;
            this.button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            this.button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(20, 320);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(96, 13);
            this.position.TabIndex = 1;
            this.position.Text = "Позиция кнопки: ";
            // 
            // position2
            // 
            this.position2.AutoSize = true;
            this.position2.Location = new System.Drawing.Point(110, 320);
            this.position2.Name = "position2";
            this.position2.Size = new System.Drawing.Size(0, 13);
            this.position2.TabIndex = 3;
            // 
            // part
            // 
            this.part.AutoSize = true;
            this.part.Location = new System.Drawing.Point(130, 340);
            this.part.Name = "part";
            this.part.Size = new System.Drawing.Size(0, 13);
            this.part.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Местонахождение: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.part);
            this.Controls.Add(this.position2);
            this.Controls.Add(this.position);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Чорнобель Д.С. КНТ-116 ЛР5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label position2;
        private System.Windows.Forms.Label part;
        private System.Windows.Forms.Label label1;
    }
}

