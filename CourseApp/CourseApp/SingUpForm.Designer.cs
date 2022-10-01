namespace CourseApp
{
	partial class SingUpForm
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.ButtonBack = new System.Windows.Forms.PictureBox();
			this.HideButton = new System.Windows.Forms.Label();
			this.CloseButton = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.HelpLink = new System.Windows.Forms.Label();
			this.WorkerPanel = new System.Windows.Forms.Panel();
			this.Worker = new System.Windows.Forms.Label();
			this.DirectorPanel = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).BeginInit();
			this.panel1.SuspendLayout();
			this.WorkerPanel.SuspendLayout();
			this.DirectorPanel.SuspendLayout();
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
			this.panel2.Size = new System.Drawing.Size(725, 31);
			this.panel2.TabIndex = 3;
			// 
			// ButtonBack
			// 
			this.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ButtonBack.Image = global::CourseApp.Properties.Resources.___1_;
			this.ButtonBack.Location = new System.Drawing.Point(5, 0);
			this.ButtonBack.Name = "ButtonBack";
			this.ButtonBack.Size = new System.Drawing.Size(31, 31);
			this.ButtonBack.TabIndex = 2;
			this.ButtonBack.TabStop = false;
			this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
			// 
			// HideButton
			// 
			this.HideButton.AutoSize = true;
			this.HideButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.HideButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.HideButton.ForeColor = System.Drawing.Color.White;
			this.HideButton.Location = new System.Drawing.Point(685, 5);
			this.HideButton.Name = "HideButton";
			this.HideButton.Size = new System.Drawing.Size(15, 16);
			this.HideButton.TabIndex = 1;
			this.HideButton.Text = "_";
			this.HideButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.AutoSize = true;
			this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.CloseButton.ForeColor = System.Drawing.Color.White;
			this.CloseButton.Location = new System.Drawing.Point(706, 7);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(16, 16);
			this.CloseButton.TabIndex = 0;
			this.CloseButton.Text = "X";
			this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
			this.panel1.Controls.Add(this.HelpLink);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 384);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(725, 31);
			this.panel1.TabIndex = 4;
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
			// 
			// WorkerPanel
			// 
			this.WorkerPanel.Controls.Add(this.Worker);
			this.WorkerPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WorkerPanel.Location = new System.Drawing.Point(119, 111);
			this.WorkerPanel.Name = "WorkerPanel";
			this.WorkerPanel.Size = new System.Drawing.Size(185, 225);
			this.WorkerPanel.TabIndex = 5;
			// 
			// Worker
			// 
			this.Worker.AutoSize = true;
			this.Worker.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.Worker.ForeColor = System.Drawing.Color.White;
			this.Worker.Location = new System.Drawing.Point(10, 205);
			this.Worker.Name = "Worker";
			this.Worker.Size = new System.Drawing.Size(165, 16);
			this.Worker.TabIndex = 0;
			this.Worker.Text = "Производитель работ";
			this.Worker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DirectorPanel
			// 
			this.DirectorPanel.Controls.Add(this.label2);
			this.DirectorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DirectorPanel.Location = new System.Drawing.Point(410, 111);
			this.DirectorPanel.Name = "DirectorPanel";
			this.DirectorPanel.Size = new System.Drawing.Size(185, 225);
			this.DirectorPanel.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(5, 205);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Генеральный директор";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(234, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 24);
			this.label1.TabIndex = 7;
			this.label1.Text = "Зарегистрироваться как:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SingUpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(29)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(725, 415);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DirectorPanel);
			this.Controls.Add(this.WorkerPanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SingUpForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SingUpForm";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ButtonBack)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.WorkerPanel.ResumeLayout(false);
			this.WorkerPanel.PerformLayout();
			this.DirectorPanel.ResumeLayout(false);
			this.DirectorPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label HideButton;
		private System.Windows.Forms.Label CloseButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label HelpLink;
		private System.Windows.Forms.Panel WorkerPanel;
		private System.Windows.Forms.Label Worker;
		private System.Windows.Forms.Panel DirectorPanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox ButtonBack;
	}
}