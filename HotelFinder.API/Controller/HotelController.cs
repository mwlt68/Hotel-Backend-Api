using System.Collections.Generic;
using HotelFinder.Business.Abstact;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelFinder.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        public IHotelService hotelService;
        public HotelController(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }
        [HttpGet]
        public List<Hotel> Get()
        {
            return hotelService.GetHotels();
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetById(int id)
        {
            var hotel = hotelService.GetHotelById(id);
            if (hotel != null)
            {
                return Ok(hotel);
            }
            return NotFound();
        }
        [HttpGet("[action]/{name}")]
        public IActionResult GetByName(string name)
        {
            var hotel = hotelService.GetHotelByName(name);
            if (hotel != null)
            {
                return Ok(hotel);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Post([FromBody] Hotel hotel)
        {
            var createHotel = hotelService.CreateHotel(hotel);
            return CreatedAtAction("Get",new { id= createHotel.Id},createHotel) ;
        }
        [HttpPut]
        public Hotel Put([FromBody] Hotel hotel)
        {
            return hotelService.UpdateHotel(hotel);
        }
        [HttpDelete("{id}")] 
        public IActionResult Delete(int id)
        {
            if (hotelService.GetHotelById(id) != null)
            {
                hotelService.DeleteHotel(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
