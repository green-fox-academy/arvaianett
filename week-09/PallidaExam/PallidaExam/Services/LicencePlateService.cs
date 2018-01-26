using PallidaExam.Models;
using PallidaExam.Repositories;
using System.Collections.Generic;

namespace PallidaExam.Services
{
    public class LicencePlateService
    {
        private LicencePlateRepository licencePlateRepository;

        public LicencePlateService(LicencePlateRepository licencePlateRepository)
        {
            this.licencePlateRepository = licencePlateRepository;
        }

        public List<LicencePlate> GetAllPlates(FilterOptions filterOptions)
        {
            if(filterOptions.Q != null)
            {
                return licencePlateRepository.GetPlatesByQ(filterOptions);
            }
            else if(filterOptions.Diplomat != null)
            {
                return licencePlateRepository.GetDiplomatCars();
            }
            else if(filterOptions.Police != null)
            {
                return licencePlateRepository.GetPoliceCars();
            }

            return licencePlateRepository.GetAllPlates();
        }

        public List<LicencePlate> GetFilteredListByBrand(string brand)
        {
            return licencePlateRepository.GetFilteredListByBrand(brand);
        }
    }
}
