namespace CourseApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HelpLink = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HideButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SingInButton = new System.Windows.Forms.Button();
            this.SingUpBottom = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.HelpLink);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 31);
            this.panel1.TabIndex = 0;
            // 
            // HelpLink
            // 
            this.HelpLink.AutoSize = true;
            this.HelpLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpLink.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.HelpLink.ForeColor = System.Drawing.Color.White;
            this.HelpLink.Location = new System.Drawing.Point(20, 7);
            this.HelpLink.Name = "HelpLink";
            this.HelpLink.Size = new System.Drawing.Size(67, 16);
            this.HelpLink.TabIndex = 0;
            this.HelpLink.Text = "Помощь";
            this.HelpLink.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.HideButton);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 31);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // HideButton
            // 
            this.HideButton.AutoSize = true;
            this.HideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.HideButton.ForeColor = System.Drawing.Color.White;
            this.HideButton.Location = new System.Drawing.Point(295, 5);
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
            this.CloseButton.Location = new System.Drawing.Point(316, 7);
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
            this.label1.Location = new System.Drawing.Point(78, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Войдите в систему или \r\nзарегистрируйтесь";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SingInButton
            // 
            this.SingInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.SingInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SingInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SingInButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.SingInButton.ForeColor = System.Drawing.Color.White;
            this.SingInButton.Location = new System.Drawing.Point(53, 144);
            this.SingInButton.Name = "SingInButton";
            this.SingInButton.Size = new System.Drawing.Size(76, 27);
            this.SingInButton.TabIndex = 2;
            this.SingInButton.Text = "Войти";
            this.SingInButton.UseVisualStyleBackColor = false;
            this.SingInButton.Click += new System.EventHandler(this.SingInButton_Click);
            // 
            // SingUpBottom
            // 
            this.SingUpBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(77)))), ((int)(((byte)(1)))));
            this.SingUpBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SingUpBottom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SingUpBottom.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.SingUpBottom.ForeColor = System.Drawing.Color.White;
            this.SingUpBottom.Location = new System.Drawing.Point(174, 144);
            this.SingUpBottom.Name = "SingUpBottom";
            this.SingUpBottom.Size = new System.Drawing.Size(122, 27);
            this.SingUpBottom.TabIndex = 3;
            this.SingUpBottom.Text = "Регистрация";
            this.SingUpBottom.UseVisualStyleBackColor = false;
            this.SingUpBottom.Click += new System.EventHandler(this.SingUpBottom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(335, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SingUpBottom);
            this.Controls.Add(this.SingInButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label HelpLink;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label HideButton;
		private System.Windows.Forms.Label CloseButton;
		private System.Windows.Forms.Button SingInButton;
		private System.Windows.Forms.Button SingUpBottom;
		private System.Windows.Forms.Label label1;
	}
}

