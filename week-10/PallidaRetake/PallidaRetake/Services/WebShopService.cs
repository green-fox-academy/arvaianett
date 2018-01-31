using PallidaRetake.Models;
using PallidaRetake.Repositories;
using PallidaRetake.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaRetake.Services
{
    public class WebshopService
    {
        private WebshopRepository webshopRepository;

        public WebshopService(WebshopRepository webshopRepository)
        {
            this.webshopRepository = webshopRepository;
        }

        public double GetSum(string itemName, string size, int quantity)
        {
            return webshopRepository.GetItemsPrice(itemName, size) * quantity;
        }

        public WebshopViewModel GetView(string itemName, string size, int quantity)
        {
            return new WebshopViewModel()
            {
                SelectedClothes = webshopRepository.GetSelectedClothes(itemName, size),
                Quantity = quantity,
                Price = GetSum(itemName, size, quantity)
            };
        }

        public WebshopViewModel GetShopView()
        {
            return new WebshopViewModel()
            {
                AllClothes = webshopRepository.GetAllClothes(),
                FilteredByName = webshopRepository.GetFilteredItemNameList(),
                FilteredBySize = webshopRepository.GetFilteredSizeList()
            };
        }

        public List<Clothes> GetQuerySolution(double price, string type)
        {
            if(type == "lower")
            {
                return webshopRepository.GetItemsLowerPrice(price);
            }
            else if(type == "higher")
            {
                return webshopRepository.GetItemsHigherPrice(price);
            }
            else if (type == "equal")
            {
                return webshopRepository.GetItemsEqualPrice(price);
            }
            else
            {
                return webshopRepository.GetEmpthyList(price);
            }
        }
    }
}
