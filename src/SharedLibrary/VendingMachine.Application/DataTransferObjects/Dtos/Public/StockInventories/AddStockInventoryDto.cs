﻿using System;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Application.DataTransferObjects.Interface.Public.StockInventories;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories
{
    public class AddStockInventoryDto : IAddStockInventoryDto
    {
        [Required]
        public int TotalItems { get; set; }
        public bool IsOutOfStock { get; set; }
        
        [Required]
        public long? StatusId { get; set; }
        
        [Required]
        public Guid? ProductId { get; set; }
        

        [System.Text.Json.Serialization.JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public Guid? CreatorUserId { get; set; }
    }
}
