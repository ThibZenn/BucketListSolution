using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketListBL.Models
{
    public class Trip
    {
        public Trip(Member member)
        {
            Member = member;
        }

        public int Id { get; set; }
        public List<ToDo> TodoListDone { get; set; } = new();
        public Member Member { get; set; }
    }
}
