using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Product.Core.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }


        [JsonIgnore]
        [ForeignKey("UserId")]
        public virtual Users User { get; set; }
    }
}
