namespace opi_53
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
            this.components = new System.ComponentModel.Container();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this.textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textbox.Location = new System.Drawing.Point(136, 160);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(100, 20);
            this.textbox.TabIndex = 0;
            this.textbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textbox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.textbox);
            this.Name = "Form1";
            this.Text = "Чорнобель Д.С. КНТ-116 ЛР5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.TextBox textbox;



    }
}

