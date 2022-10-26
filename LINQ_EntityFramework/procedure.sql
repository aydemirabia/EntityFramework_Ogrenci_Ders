--use EntityFrameworkLINQ_SinavOgrenci
--select * from tbl_notlar
--create procedure not_listesi
--as
--select NOTID as "Not ID",OGRAD+' '+OGRSOYAD as "Ad Soyad",
--DERSAD as "Ders",SINAV1,SINAV2,SINAV3,ORTALAMA,DURUM from tbl_notlar 
--inner join tbl_ogrenci on tbl_notlar.OGR=tbl_ogrenci.ID
--inner join tbl_dersler on tbl_dersler.DERSID=tbl_notlar.DERS

execute not_listesi