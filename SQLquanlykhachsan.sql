SELECT datediff(DAY,ChiTietPhieuThuePhong.NgayDangKy,ChiTietPhieuThuePhong.NgayNhan) as tongngay ,LoaiPhong.DonGiaTheoNgay,datediff(DAY,ChiTietPhieuThuePhong.NgayDangKy,ChiTietPhieuThuePhong.NgayNhan)*LoaiPhong.DonGiaTheoNgay as tong
from ChiTietPhieuThuePhong,LoaiPhong,Phong
where Phong.MaPhong = ChiTietPhieuThuePhong.MaPhong and Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong
 and ChiTietPhieuThuePhong.MaPhong = N'202'
 select * from ChiTietPhieuThuePhong
 update ChiTietPhieuThuePhong
 set Tongngay=datediff(DAY,ChiTietPhieuThuePhong.NgayDangKy,ChiTietPhieuThuePhong.NgayNhan),ThanhTien = datediff(DAY,ChiTietPhieuThuePhong.NgayDangKy,ChiTietPhieuThuePhong.NgayNhan)*LoaiPhong.DonGiaTheoNgay
 from LoaiPhong,Phong
 where Phong.MaPhong = ChiTietPhieuThuePhong.MaPhong and Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong and ChiTietPhieuThuePhong.MaPhong = N'405'
 select HoaDon.MaHoaDon,ChiTietPhieuNhanPhong.MaNhanPhong,ChiTietPhieuNhanPhong.MaPhong,ChiTietPhieuNhanPhong.NgayNhan,ChiTietPhieuNhanPhong.NgayTraPhong
,Phong.MaLoaiPhong,LoaiPhong.DonGiaTheoNgay,HoaDon.TongTien 
from HoaDon
join ChiTietPhieuNhanPhong
on HoaDon.MaNhanPhong = ChiTietPhieuNhanPhong.MaNhanPhong
 join  Phong
 on Phong.MaPhong = ChiTietPhieuNhanPhong.MaPhong
 join LoaiPhong
 on LoaiPhong.MaLoaiPhong = Phong.MaLoaiPhong 
 

SELECT datediff(DAY,ChiTietPhieuNhanPhong.NgayNhan,ChiTietPhieuNhanPhong.NgayTraPhong)*LoaiPhong.DonGiaTheoNgay as tong
from ChiTietPhieuNhanPhong,LoaiPhong,Phong,HoaDon
where Phong.MaPhong = ChiTietPhieuNhanPhong.MaPhong and LoaiPhong.MaLoaiPhong = Phong.MaLoaiPhong
 and HoaDon.MaNhanPhong = ChiTietPhieuNhanPhong.MaNhanPhong 
 
create view hehe
as

select HoaDon.MaHoaDon,ChiTietPhieuNhanPhong.MaNhanPhong,ChiTietPhieuNhanPhong.MaPhong,ChiTietPhieuNhanPhong.NgayNhan,ChiTietPhieuNhanPhong.NgayTraPhong
,Phong.MaLoaiPhong,LoaiPhong.DonGiaTheoNgay,HoaDon.TongTien
from HoaDon
join ChiTietPhieuNhanPhong
on HoaDon.MaNhanPhong = ChiTietPhieuNhanPhong.MaNhanPhong
 join  Phong
 on Phong.MaPhong = ChiTietPhieuNhanPhong.MaPhong
 join LoaiPhong
 on LoaiPhong.MaLoaiPhong = Phong.MaLoaiPhong
 

 select DATEDIFF(DAY,hehe.NgayNhan,hehe.NgayTraPhong)*hehe.DonGiaTheoNgay as Tong 
 from hehe


SELECT datediff(DAY,ChiTietPhieuNhanPhong.NgayNhan,ChiTietPhieuNhanPhong.NgayTraPhong)*LoaiPhong.DonGiaTheoNgay as tong
from ChiTietPhieuNhanPhong,LoaiPhong,Phong,HoaDon
where Phong.MaPhong = ChiTietPhieuNhanPhong.MaPhong and LoaiPhong.MaLoaiPhong = Phong.MaLoaiPhong
 and HoaDon.MaNhanPhong = ChiTietPhieuNhanPhong.MaNhanPhong 
 alter trigger update_Tongtien
 on ChiTietPhieuNhanPhong after update
 as
 begin
    set nocount on
	update HoaDon
		set HoaDon.TongTien= TongTien + S.t
		FROM(select NgayNhan,NgayTraPhong,MaNhanPhong,datediff(DAY,NgayNhan,NgayTraPhong) as t
              from inserted join Phong
			  on Phong.MaPhong = inserted.MaPhong) S
		WHERE HoaDon.MaNhanPhong=S.MaNhanPhong

 end
 select HoaDon.MaHoaDon,HoaDon.NhanVienLap,HoaDon.NgayLap,HoaDon.TongTien,ChiTietPhieuNhanPhong.MaPhong,ChiTietPhieuNhanPhong.HoTenKhachHang,ChiTietPhieuNhanPhong.NgayNhan,ChiTietPhieuNhanPhong.NgayTraPhong,LoaiPhong.MaLoaiPhong,LoaiPhong.DonGiaTheoNgay,DanhSachSuDungDichVu.MaSuDungDV,DanhSachSuDungDichVu.SoLuong,DanhSachSuDungDichVu.MaNhanPhong,DichVu.DonGia  from HoaDon
join ChiTietPhieuNhanPhong on ChiTietPhieuNhanPhong.MaKhachHang = HoaDon.MaKhachHang
join Phong on Phong.MaPhong = ChiTietPhieuNhanPhong.MaPhong
join LoaiPhong on LoaiPhong.MaLoaiPhong = Phong.MaLoaiPhong
Left Outer join DanhSachSuDungDichVu on DanhSachSuDungDichVu.MaNhanPhong = ChiTietPhieuNhanPhong.MaNhanPhong 
Left Outer join DichVu on DichVu.MaDichVu = DanhSachSuDungDichVu.MaDichVu


select sum(b.DonGia*a.SoLuong) tongtiendichvu
from DanhSachSuDungDichVu a Left Outer JOiN DichVu b on a.MaDichVu = b.MaDichVu and a.MaNhanPhong ='2'