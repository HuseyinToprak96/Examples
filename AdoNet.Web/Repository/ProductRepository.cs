using AdoNet.Web.Framework;
using AdoNet.Web.Interfaces;
using AdoNet.Web.Models;
using System.Data;
using System.Data.SqlClient;
namespace AdoNet.Web.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConfiguration _configuration;

        private string _connectionString;

        public ProductRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("_dbConnection");
        }

        public Product Add(Product entity)
        {
            string sql = "INSERT INTO Products (Name, Description, Price,Stock) VALUES (@Name, @Description, @Price,@Stock)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // SQL komutunu ve parametrelerini oluştur
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Parametre değerlerini ata
                    command.Parameters.AddWithValue("@Name", entity.Name);
                    command.Parameters.AddWithValue("@Description", entity.Description);
                    command.Parameters.AddWithValue("@Price", entity.Price);
                    command.Parameters.AddWithValue("@Stock", entity.Stock);
                    // Bağlantıyı aç
                    connection.Open();

                    // Komutu çalıştır
                    command.ExecuteNonQuery();

                    // ExecuteScalar kullanarak eklenen verinin ID değerini al
                    entity.Id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return entity;
        }

        public bool Delete(int id)
        {
            string sql = "DELETE FROM Products WHERE Id = @Id";

            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // SQL komutunu ve parametreyi oluştur
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Parametre değerini ata
                    command.Parameters.AddWithValue("@Id", id);

                    // Bağlantıyı aç
                    connection.Open();

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }

        public Product Get(int id)
        {
            // Belirli bir veriyi getirmek için SQL sorgusunu oluştur
            string sql = "SELECT * FROM Products WHERE Id = @Id";

            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // SQL sorgusunu ve parametreyi oluştur
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Parametre değerini ata
                    command.Parameters.AddWithValue("@Id", id);

                    // Bağlantıyı aç
                    connection.Open();

                    // Komutu çalıştır ve SqlDataReader oluştur
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Veri varsa
                        if (reader.Read())
                        {
                            // Veriyi oku ve nesneye doldur
                            var veri = new Product()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Description = reader["Description"].ToString(),
                                Price =Convert.ToDecimal(reader["Price"]),
                                Stock = Convert.ToInt32(reader["Stock"])
                            };

                            // Nesneyi döndür
                            return veri;
                        }
                    }
                }
            }
            return null;
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            // Tüm verileri getirmek için SQL sorgusunu oluştur
            string sql = "SELECT * FROM Products";

            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // SQL sorgusunu ve bağlantıyı kullanarak SqlDataAdapter oluştur
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    // DataTable oluştur
                    DataTable dataTable = new DataTable();

                    // Verileri adaptöre doldur
                    adapter.Fill(dataTable);

                    // DataTable'ı döndür
                    return DatatableConvertToList.DataTableToList<Product>(dataTable);
                }
            }
        }

        public bool Update(Product entity)
        {
            string sql = "UPDATE Products SET Name = @Name, Description = @Description, Price = @Price, Stock=@Stock WHERE Id = @Id";

            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // SQL komutunu ve parametrelerini oluştur
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Parametre değerlerini ata
                    command.Parameters.AddWithValue("@Name", entity.Name);
                    command.Parameters.AddWithValue("@Description", entity.Description);
                    command.Parameters.AddWithValue("@Price", entity.Price);
                    command.Parameters.AddWithValue("@Stock", entity.Stock);
                    command.Parameters.AddWithValue("@Id", entity.Id);

                    // Bağlantıyı aç
                    connection.Open();

                    // Komutu çalıştır
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}
