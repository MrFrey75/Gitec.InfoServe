using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitec.InfoServe.CommonLib.Enumerations;

public enum StorageType
{
    UNKNOWN = 0,
    NTFS = 1,
    FAT32 = 2,
    EXT4 = 3,
    APFS = 4,
    EXFAT = 5
}