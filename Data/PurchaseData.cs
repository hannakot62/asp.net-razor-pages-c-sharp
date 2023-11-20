using pic5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pic5.Data
{
    public class PurchaseData
    {
        private  MySqlDataAccess _dataAccess;

        public PurchaseData(string connectionString)
        {
            _dataAccess = new MySqlDataAccess(connectionString);
        }

        public List<Purchase> GetPurchases()
        {
            string sql = "SELECT * FROM purchases";
            return _dataAccess.LoadData<Purchase>(sql);
        }

        public void SavePurchase(Purchase purchase)
        {
            string sql = "INSERT INTO purchases (Item, Price, DepartmentId) VALUES (@Item, @Price, @DepartmentId)";
            _dataAccess.SaveData(sql, purchase);
        }

        public void DeletePurchaseById(int id)
        {
            string sql = "DELETE FROM purchases WHERE Id = @Id";
            _dataAccess.SaveData(sql, new { Id = id });
        }
    
        public void UpdatePurchase(Purchase purchase)
        {
            string sql = "UPDATE purchases SET item=@item, price=@price, departmentId=@departmentId WHERE id = @id";
            _dataAccess.UpdateData(sql, purchase);
        }


        public Purchase GetPurchaseById(int id)
        {
            string sql = "SELECT * FROM purchases WHERE id = @Id";
            return _dataAccess.LoadData<Purchase>(sql, new { Id= id}).FirstOrDefault();
        }
    }

}
