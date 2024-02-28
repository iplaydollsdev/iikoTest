using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iikoTestServer.Models
{
    public class Task2Model
    {
        public ProductResponseDto ResponsedProduct { get; set; }
        public ProductRequestDto ProductForRequest { get; set; }

        public Task2Model(ProductResponseDto responsedProduct)
        {
            ResponsedProduct = responsedProduct;

            ProductForRequest = new ProductRequestDto()
            {
                Id = responsedProduct.Id,
                Name = responsedProduct.Name,
                Description = responsedProduct.Description,
                Parent = responsedProduct.Parent,
                Modifiers = responsedProduct.Modifiers,
                TaxCategory = responsedProduct.TaxCategory,
                Category = responsedProduct.Category,
                Color = responsedProduct.Color,
                FontColor = responsedProduct.FontColor,
                FrontImageId = responsedProduct.FrontImageId,
                Position = responsedProduct.Position,
                MainUnit = responsedProduct.MainUnit,
                ExcludedSections = responsedProduct.ExcludedSections,
                DefaultSalePrice = responsedProduct.DefaultSalePrice,
                PlaceType = responsedProduct.PlaceType,
                DefaultIncludedInMenu = responsedProduct.DefaultIncludedInMenu,
                Type = responsedProduct.Type,
                UnitWeight = responsedProduct.UnitWeight,
                UnitCapacity = responsedProduct.UnitCapacity,
                NotInStoreMovement = responsedProduct.NotInStoreMovement
            };
        }
    }
}
