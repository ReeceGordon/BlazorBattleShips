using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace BattleShips.Models
{
    public class InputTile
    {
        [Required]
        [Range(1, 10, ErrorMessage = "The field X must be a number between 1 - 10.")]
        public int X { get; set; }

        [Required]
        [StringLength(1)]
        [RegularExpression(@"^([A-J])$", ErrorMessage ="The field Y must be a character between A - J.")]
        public string Y { get; set; }
    }
}
