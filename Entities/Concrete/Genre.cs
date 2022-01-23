using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Genre:IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}