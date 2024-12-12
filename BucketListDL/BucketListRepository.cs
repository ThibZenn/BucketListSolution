using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BucketListBL.Interfaces;
using BucketListBL.Models;

namespace BucketListDL
{
    public class BucketListRepository : IBucketListRepository
    {
        private int bucketListId = 1;
        private int memberId = 1;
        private int toDoId = 1;
        private int tripId = 1;
        private Dictionary<int, BucketList> bucketLists = new();
        private Dictionary<int, Member> members = new();
        private Dictionary<int, ToDo> toDos = new();
        private Dictionary<int, Trip> trips = new();

        public BucketListRepository()
        {
            members.Add(memberId, new Member(memberId, "Jos", "jos@gmail.com")); memberId++;
            members.Add(memberId, new Member(memberId, "Ashley", "ashley@gmail.com")); memberId++;
            members.Add(memberId, new Member(memberId, "Claire", "claire@gmail.com")); memberId++;
            toDos.Add(toDoId, new ToDo(toDoId, "Visit Machu Picchu", "Walk a 5 day trail to Machu Picchu")); toDoId++;
            toDos.Add(toDoId, new ToDo(toDoId, "Swim with Dolphins", "Swim with Dolphins in an open sea")); toDoId++;
            toDos.Add(toDoId, new ToDo(toDoId, "Grand Canyon", "Descent to colorado river")); toDoId++;
            bucketLists.Add(bucketListId, new BucketList(bucketListId, "Before 50", members[1], toDos.Values.ToList())); bucketListId++;
        }

        public BucketList GetBucketList(int id)
        {
            return bucketLists[id];
        }

        public BucketList GetBucketListForMember(int id)
        {
            return bucketLists.Values.Where(x => x.Member.Id == id).First();
        }

        public Member GetMember(int memberId)
        {
            return members[memberId];
        }

        public ToDo GetToDo(int todoId)
        {
            return toDos[todoId];
        }

        public Trip GetTrip(int tripId)
        {
            return trips[tripId];
        }

        public void WriteTrip(Trip trip)
        {
            trip.Id = tripId;
            trips.Add(tripId, trip);
            tripId++;
        }
    }
}
