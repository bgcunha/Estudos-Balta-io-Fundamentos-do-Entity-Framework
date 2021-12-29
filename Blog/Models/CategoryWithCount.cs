using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Post")]
    public class CategoryWithCount
    {
        public string Name { get; set; }
        public int Count { get; set; }

    }
}