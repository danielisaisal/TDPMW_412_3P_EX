using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PropertyChanged;
using TDPMW_412_3P_EX.MVVM.Models;
using TDPMW_412_3P_EX.MVVM.Views;

namespace TDPMW_412_3P_EX.MVVM.ViewModels
{
    
    [AddINotifyPropertyChangedInterface]
    
    public class MateriaViewModel 
    {
        public MateriaModel Materiax { get; set; }
        public Materia Datos { get; set; }
        public string NombreMateria { get; set; }
        public string Rubro1 { get; set; }
        public string Rubro2 { get; set; }
        public string Rubro3 { get; set; }
        public double porcentage1 { get; set; }
        public double porcentage2 { get; set; }
        public double porcentage3 { get; set; }
        public double cal1 { get; set; }
        public double cal2 { get; set; }
        public double cal3 { get; set; }
        public double cal4 { get; set; }
        public ICommand Calculo { get; set; }
        
        public MateriaViewModel() {

            Calculo = new Command(() =>
            {
                Materiax = new MateriaModel
                {
                    materia = NombreMateria,
                    rubro1 = Rubro1,
                    rubro2 = Rubro2,
                    rubro3 = Rubro3,
                    porcentaje1 = porcentage1,
                    porcentaje2 = porcentage2,
                    porcentaje3 = porcentage3,
                    calificacion1 = cal1,
                    calificacion2 = cal2,
                    calificacion3 = cal3
                };

                if ((porcentage1 + porcentage2 + porcentage3) == 100)
                {
                    if(cal1 > 10 || cal1 < 0 || cal2 > 10 || cal2 < 0 || cal3 > 10 || cal3 < 0)
                    {
                        App.Current.MainPage.DisplayAlert("Calificación", "Te pasaste de calificación", "OK");
                    }
                    else
                    {
                        cal4 = Math.Round((Materiax.calificacion1 * (Materiax.porcentaje1 / 100)) + (Materiax.calificacion2 * (Materiax.porcentaje2 / 100)) + (Materiax.calificacion3 * (Materiax.porcentaje3 / 100)));
                        App.Current.MainPage.DisplayAlert("Calificación", "Materia: " + Materiax.materia + "\nCalificacion final: " + cal4, "OK");
                    }
                }
                else {
                    App.Current.MainPage.DisplayAlert("Porcentaje", "Te pasaste de porcentaje", "OK");
                }
            });
        }
    }
}
