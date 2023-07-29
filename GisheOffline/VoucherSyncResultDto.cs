using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.GisheOffline
{
	public class VoucherSyncResultDto
	{
		public VoucherSyncResultDto() { }
		public Guid ProgramId { get; set; }
		public Guid EventId { get; set; }
		public Guid TicketTypeId { get; set; }
		public bool ProgramAsService { get; set; }
		public int Quantity { get; set; }
	}
}
