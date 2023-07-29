using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.DiscountCodes
{
	public class DiscountCodeDto
	{
		public Guid Id { get; set; }
		public int Type { get; set; }
		public string Code { get; set; }
		public int CreditAmount { get; set; }
		public int RemainingCreditAmount { get; set; }
		public int Percent { get; set; }
		public string Label { get; set; }
		public Guid? LabelId { get; set; }
		public string Disposable { get; set; }
		public int MinimumPrice { get; set; }
		public int MaximumPrice { get; set; }
		public DateTime? ExpireDateTime { get; set; }
		public DateTime CreationTime { get; set; }
		public string Expired { get; set; }
	}
}
