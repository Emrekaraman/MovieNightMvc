using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieNightMvc.Areas.Admin.ViewModels
{
    public class DashboardViewModel
    {
        public List<MovieYearCount> MovieYearCounts { get; set; }
    }
}