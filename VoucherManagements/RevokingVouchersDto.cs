using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.VoucherManagements
{
    public class RevokingVoucherBasketInput
    {
      public Guid BasketId { get; set; }
      public Guid? StationId { get; set; }
    }
}
