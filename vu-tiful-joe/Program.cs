﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace vu_tiful_joe
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}
	}
}

public class Int32TextBox : TextBox {
    public bool m_bAllowMinus = false;
	protected override void OnKeyPress(KeyPressEventArgs e) {
		base.OnKeyPress(e);

		NumberFormatInfo fi = CultureInfo.CurrentCulture.NumberFormat;

		string c = e.KeyChar.ToString();
        if (!m_bAllowMinus) {
            if (c == "-")
            {
                e.Handled = true;
                return;
            }
        }

		if (char.IsDigit(c, 0))
			return;

		if ((SelectionStart == 0) && (c.Equals(fi.NegativeSign)))
			return;

		// copy/paste
		if ((((int)e.KeyChar == 22) || ((int)e.KeyChar == 3))
			&& ((ModifierKeys & Keys.Control) == Keys.Control))
			return;

		if (e.KeyChar == '\b')
			return;

		e.Handled = true;
	}

	protected override void WndProc(ref System.Windows.Forms.Message m) {
		const int WM_PASTE = 0x0302;
		if (m.Msg == WM_PASTE) {
			string text = Clipboard.GetText();
			if (string.IsNullOrEmpty(text))
				return;

			if ((text.IndexOf('+') >= 0) && (SelectionStart != 0))
				return;

			int i;
			if (!int.TryParse(text, out i)) // change this for other integer types
				return;

			if ((i < 0) && (SelectionStart != 0))
				return;
		}
		base.WndProc(ref m);
	}
}