namespace TDPMW_412_3P_EX;
using TDPMW_412_3P_EX.MVVM.Views;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Inicio();
	}
}
