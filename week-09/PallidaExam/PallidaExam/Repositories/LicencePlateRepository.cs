using PallidaExam.Entities;
using PallidaExam.Models;
using System.Collections.Generic;
using System.Linq;

namespace PallidaExam.Repositories
{
    public class LicencePlateRepository
    {
        private CarContext carContext;

        public LicencePlateRepository(CarContext carContext)
        {
            this.carContext = carContext;
        }

        public List<LicencePlate> GetAllPlates()
        {
            return carContext.LicencePlates
                .ToList();
        }

        public List<LicencePlate> GetPlatesByQ(FilterOptions filterOptions)
        {
            return carContext.LicencePlates.Where(p => p.Plate.Contains(filterOptions.Q))
                .ToList();
        }

        public List<LicencePlate> GetPoliceCars()
        {
            return carContext.LicencePlates.Where(p => p.Plate.StartsWith("RB"))
                .ToList();
        }

        public List<LicencePlate> GetDiplomatCars()
        {
            return carContext.LicencePlates.Where(p => p.Plate.StartsWith("DT"))
                .ToList();
        }

        public List<LicencePlate> GetFilteredListByBrand(string brand)
        {
            return carContext.LicencePlates.Where(p => p.CarBrand == brand)
                .ToList();
        }
    }
}
