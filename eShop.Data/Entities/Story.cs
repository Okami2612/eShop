using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShop.Data.Entities
{
    [Table("Stories")]
    public class Story
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public DateTime dateCreate { get; set; }
        public DateTime publishDate { get; set; }
    }
}
