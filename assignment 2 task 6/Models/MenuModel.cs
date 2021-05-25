using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace assignment_2_task_6.Models
{
    /// <summary>
    ///  This class ia the menu model class that contains the DbContext inner class.
    /// </summary>
    public class MenuModel
    {   

        public int Id { get; set; }
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        public string itemName { get; set; }
        [DataType(DataType.Currency)]
        public decimal itemPrice { get; set; }
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        public string itemDescription { get; set; }
    }
    public class MenuDBContext : DbContext
    {
        public DbSet<MenuModel> MenuModels { get; set; }
    }
}


