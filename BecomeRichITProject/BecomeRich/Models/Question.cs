namespace BecomeRich
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Question
    {
        public int Id { get; set; }

        public Question()
        { }
        public Question(string addQuestion, string addA, string addB, string addC, string addD, string addAnswear, int addCategoryId)
        {
            this.Question1 = addQuestion;
            this.A = addA;
            this.B = addB;
            this.C = addC;
            this.D = addD;
            this.Answear = addAnswear;
            this.CategoryId = addCategoryId;

        }
        [Column("Question")]
        [StringLength(250)]
        public string Question1 { get; set; }


        [StringLength(100)]
        public string A{ get; set; }
       

        [StringLength(100)]
        public string B { get; set; }

        [StringLength(100)]
        public string C { get; set; }

        [StringLength(100)]
        public string D { get; set; }

        [StringLength(100)]
        public string Answear { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
