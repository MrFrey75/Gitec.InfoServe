using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models.ServiceTypes;

public class UnknownModel : ServiceTypeBase
{
    public UnknownModel()
    {
        ServiceType = ServiceTypeModel.UnknownService;
    }

}