namespace BecomeRich
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Player")]
    public partial class Player
    {
        public Player()
        { }
        public Player(string playerName, int playerAge, int playerHomeTownId, int playerFriendId)
        {
            this.Name = playerName;
            this.Age = playerAge;
            this.HomeTownId = playerHomeTownId;
            this.FriendId = playerFriendId;
        }
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public int? Age { get; set; }

        public int? HomeTownId { get; set; }

        public int? FriendId { get; set; }

        public virtual Friend Friend { get; set; }

        public virtual Town Town { get; set; }
    }
}
