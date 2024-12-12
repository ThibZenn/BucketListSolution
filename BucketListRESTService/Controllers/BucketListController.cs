using BucketListBL.Managers;
using BucketListBL.Models;
using BucketListRESTService.Mappers;
using BucketListRESTService.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BucketListRESTService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BucketListController : ControllerBase
    {
        private BucketListManager _bucketListManager;

        public BucketListController(BucketListManager bucketListManager)
        {
            _bucketListManager = bucketListManager;
        }
        [HttpGet("{id}")]
        public ActionResult<BucketList> GetBucketList(int id)
        {
            try
            {
                return Ok(_bucketListManager.GetBucketList(id));
            }
            catch (Exception ex) {return BadRequest(ex.Message);}
        }
        [HttpPost]
        public ActionResult<BucketList> MakeBucketList([FromBody] BucketList bucketList)
        {
            try
            {
                return null;
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [Route("{bucketListId}/ToDos")]
        [HttpPost]
        public ActionResult<BucketList> AddToDoToBucketList(int bucketListId, [FromBody] int toDoId)
        {
            try
            {
                return null;
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [Route("{bucketListId}/trip")]
        [HttpPost]
        public ActionResult<InputTripDTO> MakeTrip(int bucketListId,[FromBody] InputTripDTO tripDTO)
        {
            try
            {
                Trip trip = MapTrip.MapToDomain(tripDTO, _bucketListManager);
                _bucketListManager.WriteTrip(trip);
                return CreatedAtAction(nameof(GetTrip),new { bucketListId = bucketListId, tripId = trip.Id },trip);
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [Route("{bucketListId}/trip/{tripId}/ToDos")]
        [HttpPost]
        public ActionResult<Trip> AddToDoToTrip(int bucketListId,int tripId, [FromBody] int todoId)
        {
            try
            {

                return Ok(_bucketListManager.AddToDoToTrip(tripId,todoId));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [Route("{bucketListId}/trip/{tripId}/Checkout")]
        [HttpPost]
        public ActionResult<Trip> CheckoutTrip(int bucketListId,int tripId)
        {
            try
            {
                return Ok(_bucketListManager.Checkout(tripId));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
        [Route("{bucketListId}/trip/{tripId}")]
        [HttpGet]
        public ActionResult<Trip> GetTrip(int bucketListId,int tripId)
        {
            try
            {
                return Ok(_bucketListManager.GetTrip(tripId));
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}
