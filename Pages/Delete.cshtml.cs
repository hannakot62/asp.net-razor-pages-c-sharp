using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pic5.Data;
using pic5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pic5.Pages
{
    public class Delete : PageModel
    {
        private readonly PurchaseData _purchaseData;

        public Delete(PurchaseData purchaseData)
        {
            _purchaseData = purchaseData;
        }

        [BindProperty]
        public Purchase Purchase { get; set; }

        public IActionResult OnGet(int id)
        {
            Purchase = _purchaseData.GetPurchaseById(id);

            if (Purchase == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            _purchaseData.DeletePurchaseById(Purchase.Id);

            return RedirectToPage("./PurchaseTable");
        }
    }
}
