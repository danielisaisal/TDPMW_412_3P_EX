//using Java.Lang;
using TDPMW_412_3P_EX.MVVM.ViewModels;
using TDPMW_412_3P_EX.MVVM.Models;

namespace TDPMW_412_3P_EX;
public partial class Materia : ContentPage
{
    public Materia()
    {
        InitializeComponent();
        BindingContext = new MateriaViewModel();
    }
}