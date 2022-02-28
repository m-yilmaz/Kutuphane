### Yap�lacaklar 
- [X] Data katman�na ilgili classlar�n olu�turulmas�
	- Kitap
        - Id Guid (contructor'da otomaik de�er atans�n.)
        - Ad string
        - BasimTarihi DateTimee
        - KitapTurEnum KitapTuru
        - YazarAd string
        - SayfaSayisi int
        - Aciklama string
    - KitapTurEnum
        - Egitim,Psikoloji,Korku,Biyografi,....
    - Kullan�c�
        - Id Guid (contructor'da otomaik de�er atans�n.)
        - AdSoyad string
        - KullaniciAdi string
        - Parola string
        - List< Kitap > OduncAlinanKitaplar
    - Kullan�c�Yontecisi
        - Kullan�c� listesi olmal� ve t�m i�lemler bu liste �zerinden yap�lmal�.
        - Kay�tOl methodu
        - GirisYap methodu
        - KullaniciVarMi methodu
    - KutuphaneYoneticisi
        - Kitap listesi olmal� ve t�m i�lemler bu liste �zerinden yap�lmal�.
        - KitapBagisYap methodu
        - KitapImhaEt methodu
        - KitapOduncAl methodu parametre kullan�c� ve kitap
- [ ] Register ve Login sayfalar�n�n tasarlanmas�
    - G�rsel tasar�m�n yap�lmas�.
    - Register sayfas�nda parola e�le�me kontrol�
    - Ayn� kullan�c� ad�na sahip ki�i var m� kontrol�
    - Register ve login i�lemleri methodlar kullan�larak
    - Login ba�ar�l�ysa KutuphaneForm acilsin. 
    - LoginForm a��l�r ve kapan�rken Kullan�c�yoneticisini serialize ve deserialize ediniz.
- [ ] KutuphaneForm
    - KutuphaneForm a��l�r ve kapan�rken kutuphaneyoneticisi serialize ve deserialize edilir.
    - Kutuphaneform'da menustripdeki butonlara t�kland���nda ilgili formlar�n a��lmas�.
    - ��k�� yap �zelli�i 
    - Context menu strip kullan�larak kitap imha et ve kitap �d�n� al �zelliklerinin eklenmesi.
    - txt arama ve combobox turlerdeki se�im ve text de�i�ti�inde datagridviewde ilgili kitaplar�n listelenmesi.
- [ ] Hesab�mForm
    - Hesab�mSayfas�nda giri� yapan kullan�c� bilgileri g�sterilir.
- [ ] BagisYap Form
    - BagisYap fromda ilgili kitap bilgileri al�narak bir kitap kutuphanedeki kitaplara eklenir.
- [ ] ��k�� Yap  Butonu
    - Kutuphane formu kapatarak loginforma geri d�ner ve ba�ka bir kullan�c� ile giri� yapma imkan� sa�lar.
 
#### �rnek tasar�m
- BagisYap Form

![](./assets/bagisForm.png)


- Kutuphane Form

![](./assets/kutuphaneForm.png)

- Hesabim Form

![](./assets/hesabimForm.png)