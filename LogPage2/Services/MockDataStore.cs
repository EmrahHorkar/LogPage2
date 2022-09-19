using DXMauiApp1.Models;

namespace DXMauiApp1.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            DateTime baseDate = DateTime.Today;
            this.items = new List<Item>() {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Başarı Mobile", Description="Ankara Teknoloji Geliştirme Bölgesi, Cyberplaza, A Blok 6. Kat, A-602, 06800 Bilkent / Ankara", Phone="+90 (312) 265 01 40", Product="HELIOS", ProductDescription="Helios; uzaktan akıllı sayaç verilerinin okunmasını, verilerin depolanmasını, alarm oluşturulmasını, envanter, veri yönetimini sağlayan ve ihtiyaca göre kişiselleştirilebilen minimum insan gücü ile çalışan bir IoT platformudur. Helios Alçak Gerilim Kontrol ve İzleme Plarformu; YEDAŞ ve OEDAŞ da 30.000’den fazla noktada, Bilkent Cyberpark da ise 500’den fazla sayacın okunmasında kullanılmaktadır."},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Başarı Teknoloji", Description="Cyberplaza A Blok,\r\n6. Kat No:601 Bilkent,\r\n06800 Çankaya – ANKARA", Phone="+90 (312) 841 62 62", Product="DİJİTAL İMZA", ProductDescription="Dijital imza, elektronik imzanın en gelişmiş ve güvenilir biçimidir. Dijital imzalar, her imzalayan kimliği ve imzalanan belgelerin doğruluğu ile ilgili en yüksek güvenceyi sağladığından, bu dijital imzaları en zorlu yasal gereksinimleri ve düzenleme gereksinimlerini karşılamak için kullanabilirsiniz."},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Başarı Kaan", Description="Dumlupınar Bulvarı Kızılırmak Mah. No:3 Next Level Ofis A Blok Kat:27 124-125 Söğütözü / ANKARA",Phone="0532 111 99 93", Product="OYUN VE UYGULAMALAR", ProductDescription="Başarı Mobile, kurulduğu tarihten itibaren mobil cihazlara yönelik toplamda 120’nin üzerinde oyun ve uygulama geliştirmiş, mobil pazar üzerinden dağıtımını ve yönetimini yapmıştır. Bugün de müşterilerinden gelen talepler doğrultusunda mobil içerik geliştirme ve yönetimine devam etmekteyiz."},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Başarı Telekom", Description="Dumlupınar Bulvarı Kızılırmak Mah. No:3 Next Level Ofis A Blok Kat:27 124-125 Söğütözü / ANKARARA",Phone=" +90 312 409 50 00", Product="APPMARKET", ProductDescription="Android kullanıcılarına yönelik olarak oyun ve uygulamaların sunulduğu AppMarket,Türkiye’nin yerli ve milli imkanlarla geliştirilmiş ilk Android pazarıdır. Başarı Mobile, 2013 Şubat’ından bu yana Turkcell Android Marketini geliştirme ve yönetme sürecinden sorumludur. AppMarket, Android, Symbian ve Java platformları için oyun ve uygulama hizmeti sunan Turkcell’in uygulama marketidir." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Başarı Enerji", Description="Güzeltepe Mah. Ahmet Rasim Sk. No:11/3\r\n06690 Çankaya / Ankara ", Phone=" +90 312 440 33 03",Product="ANDROİD LAUNCHER (KAAN/SNAPP LAUNCHER)", ProductDescription="Android telefonların kişiselleştirilebilmesini sağlayan uygulamamız Snapp Launcher ve Kaan Launcher markaları ile Google Play’de yer almaktadır. Kullanıcılar, hava durumu ve güncel haber bilgilerine hızlı ve kolay bir şekilde uygulama aracılığıyla ulaşmaktadır."},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Başarı Telematik", Description="Dumlupınar Bulv. Kızılırmak Mah. No:3 Next Level Ofis A Blok Kat:27 124-125 Söğütözü/ ANKARA",Phone="+90 312 409 50 00", Product="FOTOĞRAF BASKI SERVİSİ (CELLOGRAF)",ProductDescription="Başarı Mobile, Cellograf projesiyle 2013 yılında Turkcell Mobil İnternet Uygulama Yarışması’nda birincilik ödül kazanmıştır. Cepten fotoğraf baskı hizmeti sunan uygulama sayesinde kullanıcılar, çektikleri fotoğrafları uygulama içerisinde yer alan ürün kategorilerinden (kupa baskı,taş baskı, yağlı boya tablo gibi) seçim yaparak baskı yaptırılabilir veya hediye olarak yakınlarına gönderebilirler. Cellograf uygulaması Turkcell, LG ve Samsung ile işbirliği yapmaktadır. Hedefleri arasında yeni iş birlikleri oluşturmak vardır."},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Başarı Servis", Description="Next Level Ofis Eskişehir Yolu No:3 A Blok 27.Kat No:124-125 Söğütözü / ANKARA", Phone="+90 312 409 50 00", Product= "EIH İZLEME SİSTEMİ (SÜPERGÖZ)", ProductDescription="TEİAŞ Enerji İletim ve Nakil Hatlarının Helikopterlerle Denetlenmesi ve Raporlanması Projesi, diğer adıyla Süpergöz, TEİAŞ bünyesindeki 50.000km 380 kV ve 154 kV enerji iletim ve nakil hatlarının, helikopterlerin üzerinde yer alan elektro-optik ekipmanlar ile kontrol edilerek iletim ve nakil hatlarındaki arızalı veya arızalı olabilecek yerlerin tespit edilip kayıt altına alınması, belirli formatta ve periyotta raporlanması, arıza durumunda nokta tespiti, arıza mahaline personel ve malzeme nakli işlerini kapsamaktadır.\r\n\r\nBaşarı Mobile, bu proje kapsamında 4 adet farklı ve yüksek kalitede çekim yapabilen kameralardan alınan verilerin ortak bir merkezde bulunması için bu verilerin kaydedilmesi ve tek bir tıkla kolayca erişilmesini sağlayan yazılımı geliştirmiştir"}
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            this.items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = this.items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            this.items.Remove(oldItem);
            this.items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = this.items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            this.items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(this.items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(this.items);
        }
        public IEnumerable<Item> GetItems(bool forceRefresh = false)
        {
            return this.items;
        }
    }
}