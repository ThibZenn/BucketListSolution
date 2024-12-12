using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BucketListBL.Interfaces;
using BucketListBL.Models;

namespace BucketListBL.Managers
{
    public class BucketListManager
    {
        private IBucketListRepository _repo;

        public BucketListManager(IBucketListRepository repo)
        {
            _repo = repo;
        }

        public Trip AddToDoToTrip(int tripId, int todoId)
        {
            Trip trip = _repo.GetTrip(tripId);
            ToDo toDo =_repo.GetToDo(todoId);
            trip.TodoListDone.Add(toDo);
            return trip;
        }

        public Trip Checkout(int tripId)
        {
            Trip trip = _repo.GetTrip(tripId);
            BucketList bucketList = _repo.GetBucketListForMember(trip.Member.Id);
            foreach (ToDo toDo in trip.TodoListDone)
            {
                bucketList.ToDos.Remove(toDo);
            }
            return trip;
        }

        public BucketList GetBucketList(int id)
        {
            return _repo.GetBucketList(id);
        }

        public Member GetMember(int memberId)
        {
            return _repo.GetMember(memberId);
        }

        public Trip GetTrip(int tripId)
        {
            return _repo.GetTrip(tripId);
        }

        public void WriteTrip(Trip trip)
        {
            _repo.WriteTrip(trip);
        }
    }
}
