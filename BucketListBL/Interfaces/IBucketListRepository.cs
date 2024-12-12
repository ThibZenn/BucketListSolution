using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BucketListBL.Models;

namespace BucketListBL.Interfaces
{
    public interface IBucketListRepository
    {
        BucketList GetBucketList(int id);
        BucketList GetBucketListForMember(int id);
        Member GetMember(int memberId);
        ToDo GetToDo(int todoId);
        Trip GetTrip(int tripId);
        void WriteTrip(Trip trip);
    }
}
