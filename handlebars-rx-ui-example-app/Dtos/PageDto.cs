using System.Collections.Generic;

namespace Handlebars.Rx.UI.Example.App.Dtos
{
    public class PageDto
    {
        public PageDto()
        {
            this.Fragments = new HashSet<FragmentDto>();
        }
        public string Name { get; set; }
        public ICollection<FragmentDto> Fragments { get; set; }
    }
}