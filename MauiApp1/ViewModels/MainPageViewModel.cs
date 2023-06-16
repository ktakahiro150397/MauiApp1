using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCalendar.Core.Models;

namespace MauiApp1.ViewModels
{
    public class MainPageViewModel
    {
        public Calendar<CalendarDay> MyCalendar { get; set; } = new Calendar<CalendarDay>();

            
        public MainPageViewModel()
        {
        }

    }
}
