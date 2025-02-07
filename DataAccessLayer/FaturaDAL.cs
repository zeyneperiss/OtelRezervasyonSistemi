using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace DataAccessLayer
{
    public class FaturaDAL
    {
        public bool FaturaOlustur(Fatura fatura)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    string query = "INSERT INTO Faturalar (RezervasyonID, FaturaTarihi, ToplamTutar, OdemeDurumu) " +
                                 "VALUES (@rezervasyonID, @faturaTarihi, @toplamTutar, @odemeDurumu)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rezervasyonID", fatura.RezervasyonID);
                        cmd.Parameters.AddWithValue("@faturaTarihi", fatura.FaturaTarihi);
                        cmd.Parameters.AddWithValue("@toplamTutar", fatura.ToplamTutar);
                        cmd.Parameters.AddWithValue("@odemeDurumu", fatura.OdemeDurumu);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fatura oluşturulurken hata: {ex.Message}");
                return false;
            }
        }
    }
}
