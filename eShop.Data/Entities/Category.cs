using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    class Category
    {
        public int Id { get; set; }
        public string title { get; set; }
        public int sortOrder { get; set; }
        public bool isShowOnHome { get; set; }
        public int? parentId { get; set; }
        public Status Status { get; set; }
    }
}
