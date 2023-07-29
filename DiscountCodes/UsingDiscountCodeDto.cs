using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.DiscountCodes
{
	public class UsingDiscountCodeDto
	{
		public Guid? IssuerId { get; set; }
		public string Code { get; set; }
		public int TotalInvoiceAmount { get; set; }
		public int TotalDiscountAmount { get; set; }
		public List<DiscountPerTicketTypeDto> TicketTypes { get; set; }
	}
}
