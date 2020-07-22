using HotelFinder.Business.Abstact;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository hotelRepository;
        public HotelManager(IHotelRepository hotelRepository)
        {
            this.hotelRepository = hotelRepository;
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            return hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            hotelRepository.DeleteHotel(id);
        }

        public Hotel GetHotelById(int id)
        {
            return hotelRepository.GetHotelById(id);
        }
        public Hotel GetHotelByName(string name)
        {
            return hotelRepository.GetHotelByName(name);
        }
        public List<Hotel> GetHotels()
        {
            return hotelRepository.GetHotels();
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return hotelRepository.UpdateHotel(hotel);
        }
    }
}
