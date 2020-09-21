﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.PublicApi.InventoryItemEndpoints
{
    public class CreateInventoryItemRequest : BaseRequest
    {

        public int CatalogItemId { get; set; }
        
        public int Quantity { get; set; }
        
    }
}
