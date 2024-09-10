using System;
using System.Collections.Generic;

namespace UserInsuranceDetails.WebApi.DAL.Entity;

public partial class XmlDataEntity
{
    public int Id { get; set; }

    public string ConfigCode { get; set; } = null!;

    public string? XmlData { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? ModifiedUser { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public bool? IsDeleted { get; set; }
}
