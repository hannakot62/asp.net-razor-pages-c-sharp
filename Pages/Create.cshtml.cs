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
    public class Create : PageModel
    {

        private readonly PurchaseData _purchaseData;

        [BindProperty]
        public Purchase Purchase { get; set; }

        public Create(PurchaseData purchaseData)
        {
            _purchaseData = purchaseData;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _purchaseData.SavePurchase(Purchase);

            return RedirectToPage("./PurchaseTable");
        }
    }
}

