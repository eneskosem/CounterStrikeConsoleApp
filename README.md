# 🎯 Counter Strike Silah Sistemleri (Backend)

Bu projede, Counter Strike benzeri bir oyunun **silah sistemlerinin backend mimarisi** C# dili ile nesne yönelimli programlama prensiplerine uygun şekilde geliştirilmiştir.

## 🔫 Silah Türleri

Cephanede 4 farklı silah türü bulunmaktadır:

1. **Bıçak**  
2. **Roket Atar** (ateşli)  
3. **Tabanca** (ateşli)  
4. **Tüfek** (ateşli)

---

## ⚙️ Ortak Silah Özellikleri

Tüm silahlar aşağıdaki temel özellikleri taşır:

- Marka  
- Model  
- Menzil Tipi (`Yakın`, `Uzak`, `Daha Uzak`)  
- Ağırlık  
- Rakibi **öldürme** veya **yaralama** (ses efektleri ile)

---

## 🔥 Ateşli Silah Özellikleri

Sadece ateşli silahlara ait özel özellikler:

- Mermi Tipi (`Saçma`, `Çekirdekli`, `Roket`)  
- Mermi Kapasitesi  
- Kalibre  
- Kalan Mermi Sayısı  
- Ateş Sesi  
- Şarjör Sesi  
- Şarjör Dolumu Özelliği

> 💡 **Ateşli silahlar ateş etmeden önce mermi kontrolü yapar.**  
> 🔥 **Öldürme olasılığı 1/6'dır.**

### 🎯 Mermi Tipi & Kapasite Bilgileri

| Silah        | Mermi Tipi   | Kapasite | Açıklama |
|--------------|--------------|----------|----------|
| Roket Atar   | Roket        | 1        | Yakınlaştırma/uzaklaştırma destekler |
| Tabanca      | Çekirdekli   | 15       | Tam şarjör dolumu yapılır |
| Tüfek (Pompalı) | Saçma      | 4        | Şarjör tek tek doldurulur |
| Tüfek (Taramalı) | Çekirdekli | 50       | Tam dolum yapılır, yakınlaştırma/uzaklaştırma destekler |

---

## 🔪 Bıçak Özellikleri

- **Bileyleme** ve **Kesme** işlemi yapılabilir.  
- Düşman 5 kez kesilirse **ölür**.

---

## 👨‍💻 Kullanılan Teknolojiler

- C# (.NET)
- OOP (Nesne Yönelimli Programlama)
- Konsol uygulaması

---

## 📂 Proje Yapısı

/CounterStrikeBackend
│
├── Program.cs
├── Models/
│ ├── Weapon.cs
│ ├── Knife.cs
│ ├── Firearm.cs
│ ├── Pistol.cs
│ ├── RocketLauncher.cs
│ ├── Rifle.cs
│
├── Enums/
│ ├── RangeType.cs
│ ├── AmmoType.cs
│ ├── RifleType.cs
│
└── README.md

---

## 🧪 Test Edilen Senaryolar

-- Mermi yokken ateş edilmesi engellenir.
-- Tam dolu şarjöre yeniden mermi doldurulamaz.
-- Pompalı tüfek şarjörünü tek tek doldurur.
-- Bıçak ile 5 kez saldırı sonucu düşman ölür.
-- Ateşli silahlar ile her ateşlemede rastgele öldürme/yaralama kararı verilir.

