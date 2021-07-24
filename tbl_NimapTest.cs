

namespace CrudOperation.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_NimapTest
    {
        [Required(ErrorMessage = "Please Enter Product Id")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please Enter Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please Enter Category Id")]
        public Nullable<int> CategoryId { get; set; }

        [Required(ErrorMessage = "Please Enter Category Name")]
        public string CategoryName { get; set; }
    }
}
