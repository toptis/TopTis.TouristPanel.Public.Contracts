using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.VoucherManagements
{
    public class RevokedVoucherDto
    {
        public RevokingType RevokingType { get; set; }
        public Guid Id { get; set; }
        public int RevokedCount { get; set; }
        public bool Status { get; set; }
        public bool StationRevokeStatus { get; set; }
        public DateTime IssueDateTime { get; set; }
        public string CustomerFullName { get; set; }
        public string CustomerMobilePhone { get; set; }
        public string CustomerNationalCode { get; set; }
        public List<StationRevokedDto> Stations { get; set; }
    }


    public class StationRevokedDto
    {
        public Guid StationId { get; set; }
        public Guid StationNickname { get; set; }
        public bool Revoked { get; set; }
        public DateTime RevokedDateTime { get; set; }
    }



}
