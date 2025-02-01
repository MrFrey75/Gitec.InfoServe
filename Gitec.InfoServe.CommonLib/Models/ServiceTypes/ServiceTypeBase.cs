﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models
{
    public class ServiceTypeBase
    {
        public ServiceTypeModel ServiceType { get; set; } = ServiceTypeModel.UnknownService;
    }
}