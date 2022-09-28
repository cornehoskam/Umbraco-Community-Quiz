﻿
using NPoco;

using Umbraco.Cms.Infrastructure.Persistence.DatabaseAnnotations;

namespace Quiz.Site.Models
{
    [TableName(Quiz.Tables.QuizResultTable)]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public class QuizResult
    {
        [Column("id")]
        [PrimaryKeyColumn]
        public int Id { get; set; }

        [Column("quizId")]
        public string QuizId { get; set; }

        [Column("datecreated")]
        public DateTime DateCreated { get; set; }

        [Column("authorMemberId")]
        public string MemberId { get; set; }

        [Column("score")]
        public int Score { get; set; }

        [Column("total")]
        public int Total { get; set; }
    }
}