namespace BinanceApp.WinForm
{
	using System;
	using System.Threading;
	using System.Windows.Forms;

	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (!ApplicationControl.Runnable("Binance"))
			{
				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmMain());
		}

		class ApplicationControl
		{
			static Mutex mtx = null;

			public static bool Runnable(string mtxName)
			{
				Mutex.TryOpenExisting(mtxName, out mtx);

				if (mtx == null)
				{
					mtx = new Mutex(true, mtxName);
					return true;
				}
				else
				{
					mtx.Close();
					return false;
				}
			}
		}
	}
}