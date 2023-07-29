using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.GisheOffline
{
	public class InvoiceSyncResultDto
	{
		public InvoiceSyncResultDto() { }
		public Guid ShoppingCartId { get; set; }
		public bool Synced { get; set; }
		public List<VoucherSyncResultDto> Items { get; set; }

	}
}
