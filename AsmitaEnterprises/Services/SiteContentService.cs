using System.Collections.Generic;
using AsmitaEnterprises.Models;

namespace AsmitaEnterprises.Services;

public class SiteContentService
{
    public SiteSettings Settings { get; } = new SiteSettings();

    private static readonly List<ServiceItem> _staticServices = new()
    {
        new ServiceItem
        {
            Id = "s1",
            NameKey = "Svc_Install_Title",
            Name = "Installation",
            DescriptionKey = "Svc_Install_Desc",
            Description = "Professional installation at your location.",
            IconType = "wrench",
            DisplayOrder = 1
        },
        new ServiceItem
        {
            Id = "s2",
            NameKey = "Svc_Servicing_Title",
            Name = "Servicing",
            DescriptionKey = "Svc_Servicing_Desc",
            Description = "Regular servicing for better performance.",
            IconType = "cog",
            DisplayOrder = 2
        },
        new ServiceItem
        {
            Id = "s3",
            NameKey = "Svc_Filter_Title",
            Name = "Filter Replacement",
            DescriptionKey = "Svc_Filter_Desc",
            Description = "Genuine filters with best quality.",
            IconType = "filter",
            DisplayOrder = 3
        },
        new ServiceItem
        {
            Id = "s4",
            NameKey = "Svc_Repair_Title",
            Name = "Repair",
            DescriptionKey = "Svc_Repair_Desc",
            Description = "All types of repair services.",
            IconType = "tools",
            DisplayOrder = 4
        },
        new ServiceItem
        {
            Id = "s5",
            NameKey = "Svc_AMC_Title",
            Name = "AMC / Maintenance",
            DescriptionKey = "Svc_AMC_Desc",
            Description = "Annual maintenance contracts available.",
            IconType = "shield-check",
            DisplayOrder = 5
        },
        new ServiceItem
        {
            Id = "s6",
            NameKey = "Svc_Assembly_Title",
            Name = "Custom Assembly",
            DescriptionKey = "Svc_Assembly_Desc",
            Description = "Assembly as per your water & budget.",
            IconType = "cogs",
            DisplayOrder = 6
        }
    };

    public IEnumerable<ServiceItem> GetServices() => _staticServices;
}
