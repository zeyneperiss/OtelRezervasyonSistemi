using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using EntityLayer;
using MySql.Data.MySqlClient;

namespace BusinessLayer
{
    public class FaturaManager
    {
        private FaturaDAL faturaDAL = new FaturaDAL();

        public bool FaturaOlustur(int rezervasyonID, decimal toplamTutar)
        {
            var fatura = new Fatura
            {
                RezervasyonID = rezervasyonID,
                FaturaTarihi = DateTime.Now,
                ToplamTutar = toplamTutar,
                OdemeDurumu = false
            };
            return faturaDAL.FaturaOlustur(fatura);

        }
        public List<Fatura> TumFaturalariGetir()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT F.*, R.GirisTarihi, R.CikisTarihi, M.Ad AS MusteriAdi, O.OdaNumarasi 
                           FROM Faturalar F
                           JOIN Rezervasyonlar R ON F.RezervasyonID = R.RezervasyonID
                           JOIN Musteriler M ON R.MusteriID = M.MusteriID
                           JOIN Odalar O ON R.OdaID = O.OdaID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        List<Fatura> faturalar = new List<Fatura>();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                faturalar.Add(new Fatura
                                {
                                    FaturaID = Convert.ToInt32(reader["FaturaID"]),
                                    RezervasyonID = Convert.ToInt32(reader["RezervasyonID"]),
                                    FaturaTarihi = Convert.ToDateTime(reader["FaturaTarihi"]),
                                    ToplamTutar = Convert.ToDecimal(reader["ToplamTutar"]),
                                    OdemeDurumu = Convert.ToBoolean(reader["OdemeDurumu"]),
                                    MusteriAdi = reader["MusteriAdi"].ToString(),
                                    OdaNumarasi = reader["OdaNumarasi"].ToString(),
                                    GirisTarihi = Convert.ToDateTime(reader["GirisTarihi"]),
                                    CikisTarihi = Convert.ToDateTime(reader["CikisTarihi"])
                                });
                            }
                        }
                        return faturalar;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Faturalar listelenirken hata: {ex.Message}");
                return new List<Fatura>();
            }
        }
    }



}
