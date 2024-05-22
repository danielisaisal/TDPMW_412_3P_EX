using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TDPMW_412_3P_EX.MVVM.Models;
using TDPMW_412_3P_EX.MVVM.Views;

namespace TDPMW_412_3P_EX.MVVM.ViewModels
{
    public class SemestreViewModel
    {
        public ICommand Consejo { get; set; }
        public ICommand Calculo { get; set; }
        public SemestreModel SemestreM { get; set; }
        public string NomMateria { get; set; }
        public double valor1 { get; set; }
        public double valor2 { get; set; }
        public double valor3 { get; set; }
        public double calificacion1 { get; set; }
        public double calificacion2 { get; set; }
        public double calificacion3 { get; set; }
        public double cal4 { get; set; }
        public double calificacionRes;
        public double valor4;

        public SemestreViewModel()
        {
            Consejo = new Command(() => {
                if ((valor1 + valor2 + valor3) == 100)
                {
                    if (calificacion1 > 10 || calificacion1 < 0 || calificacion2 > 10 || calificacion2 < 0 || calificacion3 > 10 || calificacion3 < 0)
                    {
                        App.Current.MainPage.DisplayAlert("Status calificacion", "Te pasaste de calificacion", "OK");
                    }
                    else
                    {
                        calificacionRes = (Math.Round(calificacion1 * (valor1 / 100)) + Math.Round(calificacion2 * (valor2 / 100)));
                        valor4 = Math.Round(calificacionRes / (valor3 / 100));
                        if (calificacionRes >= 6)
                        {
                            App.Current.MainPage.DisplayAlert("Status para 10", "Calificacion actual: " + calificacionRes + "\nCalificacion necesaria: " + valor4 + "\nTienes que sacar tres 10 para sacar 10", "OK");
                            if (calificacion1 == 10 && calificacion2 == 10)
                            {
                                App.Current.MainPage.DisplayAlert("Status para 10", "Ya casi logras tener un 10 perfecto", "OK");
                            }
                            else
                            {
                                App.Current.MainPage.DisplayAlert("Status para 10", "No alcanzaras el 10", "OK");
                            }
                        }
                        else
                        {
                            App.Current.MainPage.DisplayAlert("Status para 6", "Calificacion actual: " + calificacionRes + "\nCalificacion necesaria: " + valor4, "OK");
                            App.Current.MainPage.DisplayAlert("Status", "No te des por vencido", "OK");
                        }
                    }
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("Status", "Te pasaste de porcentaje", "OK");
                }
                
            });

            Calculo = new Command(() =>
            {
                SemestreM = new SemestreModel {
                    nombreMateria = NomMateria,
                    valorParcial1 = valor1,
                    valorParcial2 = valor2,
                    valorParcial3 = valor3,
                    calificacionParcial1 = calificacion1,
                    calificacionParcial2= calificacion2,
                    calificacionParcial3= calificacion3
                };
                cal4 = Math.Round((SemestreM.calificacionParcial1 * (SemestreM.valorParcial1/100)) + (SemestreM.calificacionParcial2 * (SemestreM.valorParcial2 / 100)) + (SemestreM.calificacionParcial3 * (SemestreM.valorParcial3 / 100)));
                App.Current.MainPage.DisplayAlert("Calificacion final", "Materia: " + SemestreM.nombreMateria + "\nCalificacion final: " + cal4, "OK");
            });
        }
    }
}
