namespace CourseApp
{
    partial class Registration
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
			this.SingUpBottom = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.InputSurnameBox = new System.Windows.Forms.TextBox();
			this.InputNameBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.InputPasswordBox = new System.Windows.Forms.TextBox();
			this.InputLoginBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// SingUpBottom
			// 
			this.SingUpBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(77)))), ((int)(((byte)(1)))));
			this.SingUpBottom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SingUpBottom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SingUpBottom.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.SingUpBottom.ForeColor = System.Drawing.Color.White;
			this.SingUpBottom.Location = new System.Drawing.Point(108, 251);
			this.SingUpBottom.Name = "SingUpBottom";
			this.SingUpBottom.Size = new System.Drawing.Size(165, 27);
			this.SingUpBottom.TabIndex = 7;
			this.SingUpBottom.Text = "Зарегистрироваться";
			this.SingUpBottom.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(114, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 24);
			this.label3.TabIndex = 10;
			this.label3.Text = "Регистрация";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// InputSurnameBox
			// 
			this.InputSurnameBox.Location = new System.Drawing.Point(117, 204);
			this.InputSurnameBox.Name = "InputSurnameBox";
			this.InputSurnameBox.Size = new System.Drawing.Size(240, 20);
			this.InputSurnameBox.TabIndex = 14;
			// 
			// InputNameBox
			// 
			this.InputNameBox.Location = new System.Drawing.Point(117, 165);
			this.InputNameBox.Name = "InputNameBox";
			this.InputNameBox.Size = new System.Drawing.Size(240, 20);
			this.InputNameBox.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(34, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 16);
			this.label4.TabIndex = 12;
			this.label4.Text = "Фамилия:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(34, 166);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "Имя:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// InputPasswordBox
			// 
			this.InputPasswordBox.Location = new System.Drawing.Point(117, 123);
			this.InputPasswordBox.Name = "InputPasswordBox";
			this.InputPasswordBox.Size = new System.Drawing.Size(240, 20);
			this.InputPasswordBox.TabIndex = 15;
			// 
			// InputLoginBox
			// 
			this.InputLoginBox.Location = new System.Drawing.Point(118, 84);
			this.InputLoginBox.Name = "InputLoginBox";
			this.InputLoginBox.Size = new System.Drawing.Size(240, 20);
			this.InputLoginBox.TabIndex = 16;
			// 
			// Registration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 300);
			this.Controls.Add(this.InputLoginBox);
			this.Controls.Add(this.InputPasswordBox);
			this.Controls.Add(this.InputSurnameBox);
			this.Controls.Add(this.InputNameBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.SingUpBottom);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Registration";
			this.Text = "Registration";
			this.Load += new System.EventHandler(this.Registration_Load);
			this.Controls.SetChildIndex(this.SingUpBottom, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.InputNameBox, 0);
			this.Controls.SetChildIndex(this.InputSurnameBox, 0);
			this.Controls.SetChildIndex(this.InputPasswordBox, 0);
			this.Controls.SetChildIndex(this.InputLoginBox, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SingUpBottom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputSurnameBox;
        private System.Windows.Forms.TextBox InputNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InputPasswordBox;
		private System.Windows.Forms.TextBox InputLoginBox;
	}
}