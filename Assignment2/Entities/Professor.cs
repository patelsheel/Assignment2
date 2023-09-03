﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2.Entities
{
	[Table("Professors")]
	public class Professor
	{
		public int ProfessorID { get; set; }
		[MaxLength(50)]
		public string FirstName { get; set; }
		[MaxLength(50)]
		public string LastName { get; set; }
		public DateTime DateofBirth { get; set; }
		public string ClasstheyTeach { get; set; }
	}
}

