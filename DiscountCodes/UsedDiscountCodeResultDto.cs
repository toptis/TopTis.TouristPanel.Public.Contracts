using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.DiscountCodes
{
	public class UsedDiscountCodeResultDto
	{
		public int DiscountAmount { get; set; }
		public Guid? DiscountCodeTransactionId { get; set; }
	}
}
