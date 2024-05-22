using TDPMW_412_3P_EX.MVVM.ViewModels;
namespace TDPMW_412_3P_EX;

public partial class Semestre : ContentPage
{
	public Semestre()
	{
		InitializeComponent();
		BindingContext = new SemestreViewModel();
	}

    private void btnEvaluar_Clicked(object sender, EventArgs e)
    {
		btnCalcularCalificacion.IsEnabled = true;
		txtCalificacion3.IsEnabled = true;
    }
}