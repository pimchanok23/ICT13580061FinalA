using System;
using SQLite;
using Xamarin.Forms;

namespace ICT13580061FinalA.model
{
    public class profile 
    {
       [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [NotNull]
        [MaxLength(2001)]
        public string name { get; set; }
        public string lastname{ get; set; }
        public string adderss { get; set; }
        public string mail { get; set; }
        [NotNull]
        [MaxLength(100)]
		
        public string gendet{ get; set; }
		public string department { get; set; }
		public string phone { get; set; }
		public string status { get; set; }
		public string child { get; set; }
        public string money { get; set; }
        public string old { get; set; }
    }
}

