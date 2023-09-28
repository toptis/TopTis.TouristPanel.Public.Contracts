using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.VoucherManagements
{
    public class RevokedVoucherBasketDto
    {
        public Guid BasketId { get; set; }
        public int RevokedCount { get; set; }
        public bool Status { get; set; }
        public DateTime IssueDateTime { get; set; }
        public string CustomerFullName { get; set; }
        public string CustomerMobilePhone { get; set; }
        public string CustomerNationalCode { get; set; }
        public List<StationRevokedDto> Stations { get; set; }
    }


    public class StationRevokedDto
    {
        public Guid StationId { get; set; }
        public bool Checkin { get; set; }
        public DateTime? CheckinDateTime { get; set; }
        public bool Checkout { get; set; }
        public DateTime? CheckoutDateTime { get; set; }
    }



}
