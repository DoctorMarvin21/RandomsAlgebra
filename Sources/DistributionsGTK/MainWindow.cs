﻿using System;
namespace DistributionsGTK
{
	public partial class MainWindow : Gtk.Window
	{
		public MainWindow() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}
	}
}