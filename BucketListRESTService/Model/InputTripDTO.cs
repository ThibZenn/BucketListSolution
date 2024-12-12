using BucketListBL.Models;

namespace BucketListRESTService.Model
{
    public class InputTripDTO
    {
        public InputTripDTO(int memberId)
        {
            this.MemberId = memberId;
        }

        public int MemberId { get; set; }
    }
}
