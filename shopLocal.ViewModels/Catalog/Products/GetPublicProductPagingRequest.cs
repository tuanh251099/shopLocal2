﻿using shopLocal.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        //public string Keyword { get; set; }
        public int? CategoryId { get; set; }
    }
