using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Actor:IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
}