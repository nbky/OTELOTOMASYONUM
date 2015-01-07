
select m.TCKimlik,(m.Ad+' '+m.Soyad) as [Ad Soyad],h.GirisTarihi,h.CikisTarihi,o.isim,m.Telefon from musteriler as m
left join hangiodadakimvar as h on m.ID=h.MusteriID
left join odalar as o on o.ID=h.OdaID where m.TCKimlik=12345678902

select * from musteriler
select * from odalar
select * from hangiodadakimvar

insert into hangiodadakimvar(GirisTarihi,CikisTarihi)values
('2014-10-26','2014-10-30')