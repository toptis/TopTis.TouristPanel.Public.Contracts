using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.GisheOffline
{
	public class VoucherSyncDto
	{
		public VoucherSyncDto() { }
		public Guid ItemId { get; set; }
		public string EventTitle { get; set; }
		public Guid ProgramId { get; set; }

		public Guid? EventId { get; set; }
		public Guid TicketTypeId { get; set; }
		public bool Synced { get; set; }
		public int Quantity { get; set; }
		public string EventLabel { get; set; }
		public List<Guid> TicketIds { get; set; }
	}
}
