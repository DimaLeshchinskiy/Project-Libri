using System;

namespace ProjectLibri.Models
{
	public class Role : IModel
	{
		public string id { get; set; }
		public string name { get; set; }
		public int reservationAmount { get; set; }
		public int loanAmount { get; set; }
		public List<Function> functions { get; set; }
	}

}