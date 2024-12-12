using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketListBL.Models
{
    public class BucketList
    {
        public BucketList(int id, string name, Member member, List<ToDo> toDos)
        {
            Id = id;
            Name = name;
            Member = member;
            ToDos = toDos;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Member Member { get; set; }
        public List<ToDo> ToDos { get; set; }
    }
}
