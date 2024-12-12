using BucketListBL.Managers;
using BucketListBL.Models;
using BucketListRESTService.Model;

namespace BucketListRESTService.Mappers
{
    public static class MapTrip
    {
        public static Trip MapToDomain(InputTripDTO dto, BucketListManager bucketListManager)
        {
            return new Trip(bucketListManager.GetMember(dto.MemberId));
        }
    }
}
