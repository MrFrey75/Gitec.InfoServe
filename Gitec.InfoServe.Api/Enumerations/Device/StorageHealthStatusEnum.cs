using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitec.InfoServe.CommonLib.Enumerations;

public enum StorageHealthStatusEnum
{
    UNKNOWN = 0,
    HEALTHY = 1,
    WARNING = 2,
    FAILING = 3,
    FAILED = 4
}