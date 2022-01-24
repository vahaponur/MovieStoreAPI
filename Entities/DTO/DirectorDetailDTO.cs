using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    /// <summary>
    /// Director - FirstName,LastName, and Movies (string)
    /// </summary>
    public class DirectorDetailDTO:IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Movies { get; set; }
    }
}
