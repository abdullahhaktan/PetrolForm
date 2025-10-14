# PetrolForm

[TR]

**Akaryakıt İstasyonu Yönetim Uygulaması**

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Database](https://img.shields.io/badge/Database-SQL_Server-CC2927.svg)](https://www.microsoft.com/en-us/sql-server)
[![Platform](https://img.shields.io/badge/Platform-Desktop%20App-informational.svg)]()
[![GitHub repo size](https://img.shields.io/github/repo-size/abdullahhaktan/PetrolForm)](https://github.com/abdullahhaktan/PetrolForm)

---

## 💻 Proje Hakkında

**PetrolForm**, bir akaryakıt istasyonunun satış, stok ve kasa yönetimini kolaylaştırmak için geliştirilmiş Windows Forms tabanlı bir masaüstü uygulamasıdır.  
Bu sistem, istasyon yöneticilerinin yakıt fiyatlarını, depo durumlarını ve kasa hareketlerini kolayca takip etmesini sağlar.

---

## ✨ Temel Özellikler ve Modüller

### Yakıt Yönetimi
* **Farklı Yakıt Türleri:** Kurşunsuz95, Kurşunsuz97, EuroDizel10, YeniProDizel ve Gaz gibi yakıt türleri için ayrı yönetim modülleri.
* **Stok Güncelleme:** Satış sonrasında stok seviyeleri otomatik olarak güncellenir.
* **Depo Görselleştirmesi:** ProgressBar ve etiketler aracılığıyla depo doluluk oranı görsel olarak izlenir.

### Satış ve Kasa Yönetimi
* **Satış Kaydı:** Yapılan her satış, araç plakası ve yakıt türü ile birlikte veritabanına kaydedilir.
* **Kasa Takibi:** Satışlardan elde edilen gelir otomatik olarak kasaya eklenir.
* **Tutar Hesaplama:** Satılan litreye göre anlık fiyat hesaplaması.

### Kullanıcı Arayüzü
* **Windows Forms Arayüzü:** Basit, anlaşılır ve kullanıcı dostu bir masaüstü tasarımı.
* **NumericUpDown Kullanımı:** Litre seçimi için dinamik giriş alanları.
* **Gerçek Zamanlı Güncelleme:** Her işlem sonrası etiket ve progress bar değerleri otomatik olarak yenilenir.

---

## 🧩 Teknik Altyapı

| Teknoloji | Açıklama |
|------------|-----------|
| **C# (.NET Framework)** | Uygulamanın geliştirilme dili |
| **Windows Forms** | Grafiksel kullanıcı arayüzü |
| **SQL Server** | Veritabanı sistemi |
| **ADO.NET** | Veritabanı bağlantı ve sorgu işlemleri |

---

## 🚀 Nasıl Çalıştırılır?

1.  **Projeyi Klonlayın:**
    ```bash
    git clone https://github.com/abdullahhaktan/PetrolForm
    cd PetrolForm
    ```

2.  **Visual Studio’da Açın:**
    * `PetrolForm.sln` dosyasını açın.

3.  **Veritabanı Bağlantısını Düzenleyin:**
    * `Form1.cs` dosyasındaki bağlantı cümlesini kendi SQL Server ayarlarınıza göre güncelleyin.
    ```csharp
    SqlConnection conn = new SqlConnection("Data Source=SUNUCUNUZ;Initial Catalog=DbPetrol;Integrated Security=True;Encrypt=False;");
    ```

4.  **Projeyi Derleyip Çalıştırın:**
    * `Build Solution (F6)` komutu ile derleyin.
    * `F5` tuşuna basarak uygulamayı başlatın.

---

## 🖼️ Ekran Görüntüsü

<img width="924" height="397" alt="PetrolForm Screenshot" src="https://github.com/user-attachments/assets/8e84c61a-08ee-4fc9-ae59-609a8c0fa533" />

---
---

[EN]

# PetrolForm

**Fuel Station Management Application**

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Database](https://img.shields.io/badge/Database-SQL_Server-CC2927.svg)](https://www.microsoft.com/en-us/sql-server)
[![Platform](https://img.shields.io/badge/Platform-Desktop%20App-informational.svg)]()
[![GitHub repo size](https://img.shields.io/github/repo-size/abdullahhaktan/PetrolForm)](https://github.com/abdullahhaktan/PetrolForm)

---

## 💻 About the Project

**PetrolForm** is a Windows Forms–based desktop application developed to simplify the management of fuel station operations, including sales, inventory, and cash flow.  
It enables managers to track fuel prices, tank levels, and cash transactions easily.

---

## ✨ Core Features and Modules

### Fuel Management
* **Multiple Fuel Types:** Supports Unleaded95, Unleaded97, EuroDiesel10, NewProDiesel, and Gas.
* **Automatic Stock Update:** Reduces the stock automatically after each sale.
* **Visual Tank Indicators:** Displays tank fill levels using progress bars.

### Sales and Cash Management
* **Transaction Recording:** Saves each sale with vehicle plate, fuel type, and price.
* **Cash Tracking:** Automatically updates the cash register after each transaction.
* **Dynamic Price Calculation:** Calculates total cost based on selected liters and current fuel price.

### User Interface
* **Windows Forms UI:** Clean and user-friendly desktop interface.
* **NumericUpDown Controls:** For liter input and real-time calculation.
* **Instant Refresh:** UI labels and bars update automatically after every operation.

---

## 🧩 Technical Stack

| Technology | Description |
|-------------|-------------|
| **C# (.NET Framework)** | Programming language |
| **Windows Forms** | GUI framework |
| **SQL Server** | Database system |
| **ADO.NET** | Data access technology |

---

## 🚀 How to Run

1.  **Clone the Project:**
    ```bash
    git clone https://github.com/abdullahhaktan/PetrolForm
    cd PetrolForm
    ```

2.  **Open in Visual Studio:**
    * Open the `PetrolForm.sln` file.

3.  **Configure the Database Connection:**
    * Update the connection string in `Form1.cs` to match your SQL Server setup.
    ```csharp
    SqlConnection conn = new SqlConnection("Data Source=YOUR_SERVER;Initial Catalog=DbPetrol;Integrated Security=True;Encrypt=False;");
    ```

4.  **Build and Run the Application:**
    * Build the solution (`Build Solution` or **F6**).
    * Press **F5** to start the application.

---

## 🖼️ Screenshot

<img width="924" height="397" alt="PetrolForm Screenshot" src="https://github.com/user-attachments/assets/8e84c61a-08ee-4fc9-ae59-609a8c0fa533" />
