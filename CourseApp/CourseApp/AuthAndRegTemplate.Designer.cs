namespace CourseApp
{
    partial class AuthAndRegTemplate
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthAndRegTemplate));
			this.panel2 = new System.Windows.Forms.Panel();
			this.ButtonBack = new System.Windows.Forms.PictureBox();
			this.HideButton = new System.Windows.Forms.Label();
			this.CloseButton = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
			this.panel2.Controls.Add(this.ButtonBack);
			this.panel2.Controls.Add(this.HideButton);
			this.panel2.Controls.Add(this.CloseButton);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(370, 31);
			this.panel2.TabIndex = 2;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
			// 
			// ButtonBack
			// 
			this.ButtonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonBack.Image = global::CourseApp.Properties.Resources.png;
			this.ButtonBack.Location = new System.Drawing.Point(5, 3);
			this.ButtonBack.Name = "ButtonBack";
			this.ButtonBack.Size = new System.Drawing.Size(30, 25);
			this.ButtonBack.TabIndex = 9;
			this.ButtonBack.TabStop = false;
			this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
			// 
			// HideButton
			// 
			this.HideButton.AutoSize = true;
			this.HideButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.HideButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.HideButton.ForeColor = System.Drawing.Color.White;
			this.HideButton.Location = new System.Drawing.Point(330, 5);
			this.HideButton.Name = "HideButton";
			this.HideButton.Size = new System.Drawing.Size(15, 16);
			this.HideButton.TabIndex = 1;
			this.HideButton.Text = "_";
			this.HideButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
			this.HideButton.MouseEnter += new System.EventHandler(this.HideButton_MouseEnter);
			this.HideButton.MouseLeave += new System.EventHandler(this.HideButton_MouseLeave);
			// 
			// CloseButton
			// 
			this.CloseButton.AutoSize = true;
			this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.CloseButton.ForeColor = System.Drawing.Color.White;
			this.CloseButton.Location = new System.Drawing.Point(351, 7);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(16, 16);
			this.CloseButton.TabIndex = 0;
			this.CloseButton.Text = "X";
			this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
			this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(34, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Логин:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(34, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Пароль:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AuthAndRegTemplate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(370, 223);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AuthAndRegTemplate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Auth";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label HideButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ButtonBack;
    }
}