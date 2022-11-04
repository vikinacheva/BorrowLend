using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;   
using BorrowLend.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BorrowLend.Models.ViewModels
{
    public class ExpenseVM
    {
        public Expense? Expense { get; set; }
        public IEnumerable<SelectListItem>? TypeDropDown { get; set; }
    }
}
