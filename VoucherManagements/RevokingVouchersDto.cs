using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.VoucherManagements
{
    public class RevokingVouchersDto
    {
      public RevokingType RevokingType { get; set; }
      public Guid Id { get; set; }
      public Guid? StationId { get; set; }
    }
}
