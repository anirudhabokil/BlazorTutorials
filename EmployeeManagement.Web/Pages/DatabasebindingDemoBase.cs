using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class DatabasebindingDemoBase : ComponentBase
    {
        protected string Name { get; set; } = "Tom";
        public string Gender { get; set; } = "Male";
        public string Color { get; set; } = "background-color:white";

        public string Description { get; set; }
    }
}
