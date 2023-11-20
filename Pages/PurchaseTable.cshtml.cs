using Microsoft.AspNetCore.Mvc.RazorPages;
using pic5.Data;
using pic5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pic5.Pages
{
    public class PurchaseTableModel : PageModel
    {
        private readonly PurchaseData _purchaseData;
        public List<Purchase> Purchases { get; set; }


        public PurchaseTableModel(PurchaseData purchaseData)
        {
            _purchaseData = purchaseData;
        }

        public void OnGet()
        {
            // Получите данные из базы данных или любого другого источника
            Purchases = _purchaseData.GetPurchases();
            Model = new PurchaseViewModel { Purchases = Purchases};
        }

        // Модель для передачи данных в представление
        public PurchaseViewModel Model { get; set; }
    }
}
