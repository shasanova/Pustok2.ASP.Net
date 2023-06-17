﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Pustok2.Entities
{
	public class Setting
	{
		[Key]	
		public string Key { get; set; }

		[Required]
        [MaxLength(100)]

        public string Value { get; set; }

    }
}

