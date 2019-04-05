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
        private string question1;
        public string Question1
        {
            get{ return this.question1; }
            set { this.question1 = value; }
        }
   

        [StringLength(100)]
        private string a;
        public string A
        {
            get { return this.a; }
            set { this.a = value; }
        }
       

        [StringLength(100)]
        private string b;
        public string B
        {
            get { return this.b; }
            set { this.b = value; }
        }

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
