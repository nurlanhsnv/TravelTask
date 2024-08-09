using EntitiesT.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesT.Concrete
{
    public class Comment : BaseEntity
    {
        public string Comments { get; set; }
        public string Content { get; set; }
        public int BlogPostId { get; set; }   
        public int UserId { get; set; }
    }
}
