using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System;

namespace lab2zadanie.Models
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class FormModel
    {
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        public DateTime DataUrodzenia { get; set; }
        
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
