# Manav_Uygulamasi – C# Konsol Uygulaması

Bu basit C# konsol uygulamasıyla, kullanıcı bir manavdan almak istediği meyveyi seçer ve seçilen meyvenin fiyatı ekrana yazdırılır.

---

## 🎯 Amaç

Kullanıcıdan meyve seçimini alıp, sabit tanımlanmış fiyatlarla karşılaştırarak doğru fiyat bilgisini kullanıcıya göstermek.

Uygulama, sabit değer kontrolü yaptığı için **`switch-case`** yapısı tercih edilmiştir.  
Koşullu işlemler (`&&`, `||`) gerektirmediğinden dolayı **`if-else` yerine daha sade bir yapı sunar.**

---

## 🧩 Özellikler

- Elma, Armut, Çilek, Muz ve Diğer meyveler için fiyat tanımı yapılır.
- Kullanıcıdan satın alınmak istenen meyve alınır.
- Seçilen meyveye göre uygun fiyat ekrana yazdırılır.
- Büyük-küçük harf duyarlılığı ortadan kaldırılmıştır (`ToLower()` ile).
- Tanınmayan girişler "Diğer" kategorisine girer.

---

## 🛠 Kullanılan Teknolojiler

- C# (.NET Console App)
- Visual Studio

---

## 🚀 Nasıl Çalıştırılır?

1. Visual Studio / VS Code'da yeni bir Console App projesi aç.
2. `Program.cs` dosyasına kodu yapıştır.
3. Projeyi çalıştır (`F5` veya `Run`).
4. Konsoldaki yönlendirmeye göre bir meyve ismi gir.
5. Fiyat ekrana yazdırılacaktır.

---
