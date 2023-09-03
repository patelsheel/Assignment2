using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2.Entities
{
	[Table("Students")]
	public class Student
	{
		public int StudentID { get; set; }
		[MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
		public DateTime DateofBirth { get; set; }
		[MaxLength(50)]
		public string AcademicYr { get; set; }
	}
}

