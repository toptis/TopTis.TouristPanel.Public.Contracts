using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.DiscountCodes
{
	public class DiscountPerTicketTypeDto
	{
		public Guid ProviderAppId { get; set; }
		public Guid ProgramId { get; set; }
		public Guid ProgramTicketTypeId { get; set; }
		public Guid? EventTicketTypeId { get; set; }
		public Guid? EventId { get; set; }
		public bool ProgramAsService { get; set; }
		public int Count { get; set; }
		public int TotalTicketPrice { get; set; }
		public int TotalBuyPrice { get; set; }
		public int TotalCommissionPrice { get; set; }
		public int DiscountAmount { get; set; }
	}
}
