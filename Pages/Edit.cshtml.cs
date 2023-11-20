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
    public class Edit : PageModel
    {
        private readonly PurchaseData _purchaseData;

        [BindProperty]
        public Purchase Purchase { get; set; }

        public Edit(PurchaseData purchaseData)
        {
            _purchaseData = purchaseData;
        }

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
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _purchaseData.UpdatePurchase(Purchase);

            return RedirectToPage("./PurchaseTable");
        }
    }
}
