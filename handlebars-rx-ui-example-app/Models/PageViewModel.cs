using System.Collections.Generic;

namespace Handlebars.Rx.UI.Example.App.Models
{
    public class PageViewModel
    {        
        public PageViewModel()
        {
            Fragments = new HashSet<FragmentViewModel>();
        }

        public PageViewModel(string name)
            :this()
        {
            Name = name;
        }

        public string Name { get; set; }

        public ICollection<FragmentViewModel> Fragments { get; set; }
    }
}