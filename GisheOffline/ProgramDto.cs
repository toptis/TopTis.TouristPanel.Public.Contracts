using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.GisheOffline
{
	public class ProgramDto
	{
		public Guid Id { get; set; }
		public bool ProgramAsService { get; set; }
        public bool StationBasedRevoking { get; set; }
        public string Title { get; set; }
		public string Description { get; set; }
		public string ExtraDescription { get; set; }
		public string Image { get; set; }
		public bool IsSelected { get; set; }
		public List<EventDto> Events { get; set; }
	}
}
