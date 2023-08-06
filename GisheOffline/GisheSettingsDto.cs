using System;
using System.Collections.Generic;
using System.Text;

namespace TopTis.TouristPanel.Public.Contracts.GisheOffline
{
	public class GisheSettingsDto
	{
		public GisheSettingsDto()
		{
			RefreshTokenOnTicketIssue = false;

			PrintTicket = true;
			CutAfterPrintTicket = true;
			PrintQr = false;
			PrinterName = null;
			IsEventLabelRequired = false;

			OnlineCeckCapacityOnProgramSelect = false;
			OnlineCeckCapacityOnTicketIssue = false;
			CashDeskSyncTimes = 5;
			SettingPassword = "admin";
		}


		public string SettingPassword { get; set; }


		public bool RefreshTokenOnTicketIssue { get; set; }


		public string PrinterName { get; set; }
		public bool CutAfterPrintTicket { get; set; }



		public bool PrintInvoice { get; set; }
		public bool PrintTicket { get; set; }
		public bool OnlyOnePrintPerIssue { get; set; }


		public bool PrintQr { get; set; }


		public bool OnlineCeckCapacityOnTicketIssue { get; set; } = false;
		public bool OnlineCeckCapacityOnProgramSelect { get; set; } = false;


		public bool IsCustomerFullNameRequard { get; set; } = false;
		public bool IsCustomerMobilePhoneRequard { get; set; } = false;


		public bool IsEventLabelRequired { get; set; } = true;
		public bool ShowRemainingCapcity { get; set; } = true;
		public bool CustomerClub { get; set; }


		public int CashDeskSyncTimes { get; set; }
		public int SyncUpcommingDays { get; set; } = 1;
	}
}
