using AACSharp_Assignment_Serialization_Deserialization.Classes;
using Newtonsoft.Json;

namespace AACSharp_Assignment_Serialization_Deserialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void btn_list_Click(object sender, EventArgs e)
        {

            try
            {
                // JSON dosyas�n�n yolu (�al��ma dizinine g�re)
                string path = Path.Combine(Application.StartupPath, "products.json");

                // Dosyadan JSON i�eri�ini oku
                string json = File.ReadAllText(path);

                List<Product> urunler = JsonConvert.DeserializeObject<List<Product>>(json);
                dataGridView1.DataSource = urunler;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void btn_addJson_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "products.json";
                List<Product> urunler = new List<Product>();
                string existingJson = "";
                // 1. Dosya varsa, i�eri�i oku ve mevcut �r�nleri deserialize et
                if (File.Exists(path))
                {
                    existingJson = File.ReadAllText(path);
                    urunler = JsonConvert.DeserializeObject<List<Product>>(existingJson) ?? new List<Product>();
                }

                // 2. Yeni �r�n� olu�tur
                Product yeniUrun = new Product
                {
                    UrunAdi = text_name.Text,
                    Fiyat = Convert.ToDouble(text_price.Text)
                };

                // 3. Yeni �r�n� listeye ekle
                urunler.Add(yeniUrun);

                // 4. Listeyi JSON'a �evir ve dosyaya yaz
                string yeniJson = JsonConvert.SerializeObject(urunler, Formatting.Indented);
                File.WriteAllText(path, yeniJson);

                text_name.Text = "";
                text_price.Text = "";

                dataGridView1.DataSource = urunler;



                // 5. (�ste�e ba�l�) Ba�ar� mesaj�
                MessageBox.Show("�r�n ba�ar�yla eklendi!");


            }
            catch (Exception ex) {
            
            }
        }
    }
}
