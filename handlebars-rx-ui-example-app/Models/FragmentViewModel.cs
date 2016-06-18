using System.Collections.Generic;

namespace Handlebars.Rx.UI.Example.App.Models
{
    public class FragmentViewModel
    {
        public FragmentViewModel()
        {

        }

        public string Name { get; set; }

        public Dictionary<string,string> Properties { get; set; }
    }
}