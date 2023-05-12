using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutApp.Core.DTOs
{
    public class ArticleDTO : ArticleMainDTO
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
    }
}
