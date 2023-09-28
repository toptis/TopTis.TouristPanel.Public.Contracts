using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.VoucherManagements
{
    public class StationStructureDto
    {
        public string Title { get; set; }
        public List<StationDto> Stations { get; set; }
    }
    public class StationDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Nickname { get; set; }
        public int Index { get; set; }
        public bool Checkin { get; set; }
        public bool Checkout { get; set; }
    }
}
