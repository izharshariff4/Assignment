using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement_API.Model
{
    [Table("tblHotel")]
    public class DBApproach
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Image { get; set; } = string.Empty;

    }

    public class HotelDbContext : DbContext
    {
        public DbSet<DBApproach> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string strConnection = @"Data Source=.\SQLEXPRESS; Initial Catalog= FaiTraining; Integrated Security = True; TrustServerCertificate=True";
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(strConnection);
        }

    }
    public interface IItemComponent
    {
        List<DBApproach> GetItems();
        DBApproach GetItem(int id);
        void AddItem(DBApproach item);
        void UpdateItem(DBApproach item);
        void DeleteItem(int id);
    }
    public class EmpComponent : IItemComponent
    {
        public void AddEmployee(DBApproach item)
        {
            var context = new HotelDbContext();
            context.Items.Add(item);
            context.SaveChanges();
        }

        public void AddItem(DBApproach item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(int id)
        {
            var context = new HotelDbContext();
            var rec = context.Items.FirstOrDefault(e => e.ItemId == id);
            if (rec != null)
            {
                context.Items.Remove(rec);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Employee not found to delete");
            }
        }

        public DBApproach GetItem(int id)
        {
            var context = new HotelDbContext();
            var rec = context.Items.FirstOrDefault(e => e.ItemId == id);
            if (rec != null)
            {
                return rec;
            }
            else
            {
                throw new Exception("Employee not found to delete");
            }
        }

        public List<DBApproach> GetItems()
        {
            var context = new HotelDbContext();
            return context.Items.ToList();
        }

        public void UpdateItem(DBApproach item)
        {
            var context = new HotelDbContext();
            var rec = context.Items.FirstOrDefault(e => e.ItemId == item.ItemId);
            if (rec != null)
            {
                rec.ItemName = item.ItemName;
                rec.Price = item.Price;
                rec.Image = item.Image;
                
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Employee not found to update");
            }
        }
    }
}
