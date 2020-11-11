﻿using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.StockInventories.Command
{
    public class AddStockInventoryHandlerCommand : BaseAddRequestHandler<StockInventory, AddStockInventoryDto, VendingMachineDbContext>
    {
        public AddStockInventoryHandlerCommand(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
