namespace DesignPattern23Example
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Singleton_button = new System.Windows.Forms.Button();
            this.groupBox_Creational = new System.Windows.Forms.GroupBox();
            this.AbstractFactory_button = new System.Windows.Forms.Button();
            this.groupBox_Creational.SuspendLayout();
            this.SuspendLayout();
            // 
            // Singleton_button
            // 
            this.Singleton_button.Location = new System.Drawing.Point(17, 21);
            this.Singleton_button.Name = "Singleton_button";
            this.Singleton_button.Size = new System.Drawing.Size(170, 23);
            this.Singleton_button.TabIndex = 0;
            this.Singleton_button.Text = "單例模式(Singleton)";
            this.Singleton_button.UseVisualStyleBackColor = true;
            this.Singleton_button.Click += new System.EventHandler(this.Singleton_button_Click);
            // 
            // groupBox_Creational
            // 
            this.groupBox_Creational.Controls.Add(this.AbstractFactory_button);
            this.groupBox_Creational.Controls.Add(this.Singleton_button);
            this.groupBox_Creational.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Creational.Name = "groupBox_Creational";
            this.groupBox_Creational.Size = new System.Drawing.Size(740, 89);
            this.groupBox_Creational.TabIndex = 2;
            this.groupBox_Creational.TabStop = false;
            this.groupBox_Creational.Text = "7種創建";
            // 
            // AbstractFactory_button
            // 
            this.AbstractFactory_button.Location = new System.Drawing.Point(17, 50);
            this.AbstractFactory_button.Name = "AbstractFactory_button";
            this.AbstractFactory_button.Size = new System.Drawing.Size(170, 23);
            this.AbstractFactory_button.TabIndex = 1;
            this.AbstractFactory_button.Text = "抽象工廠模式(AbstractFactory)";
            this.AbstractFactory_button.UseVisualStyleBackColor = true;
            this.AbstractFactory_button.Click += new System.EventHandler(this.AbstractFactory_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 261);
            this.Controls.Add(this.groupBox_Creational);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Creational.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Singleton_button;
        private System.Windows.Forms.GroupBox groupBox_Creational;
        private System.Windows.Forms.Button AbstractFactory_button;
    }
}

