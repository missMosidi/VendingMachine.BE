﻿using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Products;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.Products.Query
{
    public class GetProductByStatusIdHandlerQuery : BaseGetByStatusIDRequestHandler<Product, DetailedProductDto, GetProductByStatusIdDto, VendingMachineDbContext>
    {
        public GetProductByStatusIdHandlerQuery(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
