namespace BecomeRich
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Friend")]
    public partial class Friend
    {
        
        public Friend(string friendName, int friendAge, int friendHomeTownId)
        {
            this.Name = friendName;
            this.Age = friendAge;
            this.HomeTownId = friendHomeTownId;
         
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Friend()
        {
            Players = new HashSet<Player>();
        }

        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public int? Age { get; set; }

        public int? HomeTownId { get; set; }

        public virtual Town Town { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Player> Players { get; set; }
    }
}
