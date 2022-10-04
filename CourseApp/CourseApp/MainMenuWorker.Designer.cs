namespace CourseApp
{
    partial class MainMenuWorker
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
            this.OrdersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.OrdersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrdersButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.OrdersButton.ForeColor = System.Drawing.Color.White;
            this.OrdersButton.Location = new System.Drawing.Point(289, 105);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(130, 60);
            this.OrdersButton.TabIndex = 13;
            this.OrdersButton.Text = "Заказ строительных материалов";
            this.OrdersButton.UseVisualStyleBackColor = false;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Главное меню";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrdersButton);
            this.Name = "MainMenuWorker";
            this.Text = "MainMenuWorker";
            this.Load += new System.EventHandler(this.MainMenuWorker_Load);
            this.Controls.SetChildIndex(this.OrdersButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Label label1;
    }
}