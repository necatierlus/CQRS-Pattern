﻿using DAL.CQRS.Queries.Request;
using DAL.CQRS.Queries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler
    {
        public GetByIdProductQueryResponse GetByIdProduct(GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(p => p.Id == getByIdProductQueryRequest.Id);
            return new GetByIdProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                CreateTime = product.CreateTime
            };
        }
    }
}
