/* Generated by MyraPad at 14.12.2019 14:54:23 */
using System;

namespace Myra.Samples.DebugConsole
{
	public partial class DebugPanel
	{
		public event EventHandler Removed;

		public DebugPanel()
		{
			BuildUI();

			_buttonHideDebug.Click += _buttonHideDebug_Click;
		}

		private void _buttonHideDebug_Click(object sender, System.EventArgs e)
		{
			RemoveFromDesktop();

			var ev = Removed;
			if (ev != null)
			{
				ev(this, EventArgs.Empty);
			}
		}
	}
}