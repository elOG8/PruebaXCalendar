using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls.Shapes;
using XCalendar.Core.Enums;
using XCalendar.Core.Models;
using System.Collections.ObjectModel;


namespace PruebaXCal.ViewModels
{
    public class CalendarViewModel : BaseViewModel
    {

        public Calendar<CalendarDay> Calendar { get; set; } = new Calendar<CalendarDay>();

    }

}
