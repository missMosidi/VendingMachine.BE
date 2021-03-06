﻿using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.ProductImages.Query
{
    public class GetProductImageByStatusCodeHandlerQuery : BaseGetByStatusCodeRequestHandler<ProductImage, DetailedProductImageDto, GetProductImageByStatusCodeDto, VendingMachineDbContext>
    {
        public GetProductImageByStatusCodeHandlerQuery(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
