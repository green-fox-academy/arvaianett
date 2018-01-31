using PallidaRetake.Entities;
using PallidaRetake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaRetake.Repositories
{
    public class WebshopRepository
    {
        private WebshopContext webShopContext;

        public WebshopRepository(WebshopContext webShopContext)
        {
            this.webShopContext = webShopContext;
        }

        public List<Clothes> GetAllClothes()
        {
            return webShopContext.Webshop.ToList();
        }

        public List<double> GetAllPrice()
        {
            return GetAllClothes().Select(x => x.UnitPrice).ToList();
        }

        public List<Clothes> GetSelectedClothesList(string itemName, string size)
        {
            return webShopContext.Webshop.Where(c => c.ItemName == itemName).Where(c => c.Size == size).ToList();
        }

        public Clothes GetSelectedClothes(string itemName, string size)
        {
            return GetSelectedClothesList(itemName, size).First();
        }

        public double GetItemsPrice(string itemName, string size)
        {
            return GetSelectedClothes(itemName, size).UnitPrice;
        }

        public List<string> GetFilteredItemNameList()
        {
            return GetAllClothes().Select(x => x.ItemName).Distinct().OrderBy(x => x).ToList();
        }

        public List<string> GetFilteredSizeList()
        {
            return GetAllClothes().Select(x => x.Size).Distinct().OrderBy(x => x).ToList();
        }

        public List<Clothes> GetItemsLowerPrice(double price)
        {
            return GetAllClothes().Where(c => c.UnitPrice < price).ToList();
        }

        public List<Clothes> GetItemsHigherPrice(double? price)
        {
            return GetAllClothes().Where(c => c.UnitPrice > price).ToList();
        }

        public List<Clothes> GetItemsEqualPrice(double? price)
        {
            return GetAllClothes().Where(c => c.UnitPrice == price).ToList();
        }

        public List<Clothes> GetEmpthyList(double? price)
        {
            return GetAllClothes().Where(c => c.UnitPrice == null).ToList();
        }
    }
}
