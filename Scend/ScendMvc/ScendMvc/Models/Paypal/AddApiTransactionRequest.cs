﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScendMvc.Models.Paypal
{
    public class AddApiTransactionRequest : ApiTransactionPayload
    {
        public string userApiKey { get; set; }

        public int apiId { get; set; }
    }
}
