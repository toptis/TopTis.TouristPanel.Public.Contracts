using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.GisheOffline
{
	public class TicketTypeDto
	{
		public Guid EventTicketTypeId { get; set; }
		public Guid ProgramTicketTypeId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string ExtraDescription { get; set; }
		public string Image { get; set; }
		public int Price { get; set; }
		public int TotalCapacity { get; set; }
		public int OnlineRemainingCapacity { get; set; }
		public int GisheOfflineCapacityAllowed { get; set; }
		public int OfflineTicketsIssued { get; private set; }
		public string GroupTitle { get; set; }
		public int Index { get; set; }
	}
}
