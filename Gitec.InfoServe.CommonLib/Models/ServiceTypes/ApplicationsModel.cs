using System;
using System.Text.RegularExpressions;
using Gitec.InfoServe.CommonLib.Data;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models.ServiceTypes;

public class ApplicationsModel : ServiceTypeBase
{
    public string ApplicationName { get; set; }
    public Version ApplicationVersion { get; set; }
    public string ApplicationDescription { get; set; }
    public Uri ApplicationPath { get; set; }
    public ApplicationType ApplicationCategory { get; set; }

    public ApplicationsModel()
    {
        ServiceType = ServiceTypeModel.Applications;
        ApplicationName = string.Empty;
        ApplicationVersion = new Version(0, 0);
        ApplicationDescription = string.Empty;
        ApplicationPath = new Uri("file:///");
        ApplicationCategory = ApplicationType.UNKNOWN;
    }
}