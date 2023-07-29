using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.GisheOffline
{
	public class InvoiceSyncDto
	{
		public InvoiceSyncDto() { }
		public Guid ShoppingCartId { get; set; }
		public long DiscountAmount { get; set; }
		public string DiscountCode { get; set; }
		public string DiscountCodeLabel { get; set; }
		public Guid? DiscountCodeId { get; set; }
		public Guid? DiscountCodeTransactionId { get; set; }
		public int PayableAmount { get; set; }
		public string CustomerMobilePhone { get; set; }
		public string CustomerFullName { get; set; }
		public string InternalTrackingCode { get; set; }
		public List<VoucherSyncDto> Items { get; set; }

	}
}
