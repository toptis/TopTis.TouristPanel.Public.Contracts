using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.GisheOffline
{
	public class EventDto
	{
		public Guid EventId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string ExtraDescription { get; set; }
		public string Image { get; set; }
		public List<TicketTypeDto> TicketTypes { get; set; }
		public List<string> Labels { get; set; }
	}
}
