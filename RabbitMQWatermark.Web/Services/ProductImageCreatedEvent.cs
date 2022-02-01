using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQWatermark.Web.Services
{
    public class ProductImageCreatedEvent
    {
        public string ImageName { get; set; }
    }
}
