using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace TDPMW_412_3P_EX;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}