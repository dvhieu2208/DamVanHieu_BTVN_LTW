using DVHLesson1;

namespace DVHLesson01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DVH Lesson01");
            string choice;
            List<Student> students = new List<Student>()
            {
                new Student { masv = "SV001", hoTen = "Nguyen Van A", ngaySinh = new DateTime(2000, 1, 1), gioiTinh = true, email = "nguyenvana@example.com", soDienThoai = "0123456789", nganhHoc = "CNTT", diemTrungBinh = 8.5f, trangThai = true } ,
                new Student { masv = "SV002", hoTen = "Tran Thi B", ngaySinh = new DateTime(2001, 2, 2), gioiTinh = false, email = "Chungtrinhj@gmaii.com", soDienThoai = "0987654321", nganhHoc = "Kinh te", diemTrungBinh = 7.2f, trangThai = true }
            };
            do
            {
                // menu
                chucNang();
                Console.Write("Nhap lua chon cua ban: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Nhập thông tin sinh viên
                        ThemSinhVien(students);
                        break;
                    case "2":
                        // Hiển thị thông tin sinh viên
                        HienThiSinhVien(students);
                        break;
                    case "3":
                        //Tìm sinh viên theo mã 
                        timSinhVienTheoMa(students);
                        break;
                    case "4":
                        //Tìm sinh viên theo tên
                        timSinhVienTheoTen(students);
                        break;
                    case "5":
                        //Cập nhật 
                        capNhat(students);
                        break;
                    case "6":
                        //Xóa sinh viên
                        XoaSinhVien(students);
                        break;
                    case "7":
                        //Sắp xếp theo họ tên
                        SapXepTheoHoTen(students);
                        break;
                    case "8":
                        //Sắp xếp theo điểm trung bình
                        SapXepTheoDiemTB(students);
                        break;
                    case "9":
                        //Hiển thị sinh viên có điểm từ 8 trở lên
                        HienThiSinhVienDiemTu8(students);
                        break;
                    case "10":
                        //Hiển thị sinh viên có điểm cao nhất
                        HienThiSinhVienDiemCaoNhat(students);
                        break;
                    case "11":
                        //Tính điểm trung bình của toàn bộ sinh viên
                        TinhDiemTBTotCai(students);
                            break;
                    case "12":
                        //Thống kê sinh viên theo ngành
                        ThongKeTheoNganh(students);
                        break;
                    case "13":
                        //Thống kê sinh viên theo trạng thái
                        ThongKeTheoTrangThai(students);
                        break;
                    case "14":
                        Console.WriteLine("Thoat chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                        break;
                }

            } while (choice != "14");

        }
        static void chucNang()
        {
            Console.WriteLine("=====MENU=====");
            Console.WriteLine("1.Nhap thong tin sinh vien");
            Console.WriteLine("2.Hien thi thong tin sinh vien");
            Console.WriteLine("3.Tim sinh vien theo ma");
            Console.WriteLine("4.Tim gan dung theo ho ten");
            Console.WriteLine("5.Cap nhat sinh vien");
            Console.WriteLine("6.Xoa sinh vien");
            Console.WriteLine("7.Sap xep theo ho ten");
            Console.WriteLine("8.Sap xep theo diem trung binh");
            Console.WriteLine("9.Hien thi sinh vien co diem tu 8 tro len");
            Console.WriteLine("10.Hien thi sinh vien co diem cao nhat");
            Console.WriteLine("11.Tinh diem trung binh toan bo sinh vien");
            Console.WriteLine("12.Thong ke sinh vien theo nganh");
            Console.WriteLine("13.Thong ke sinh vien theo trang thai");
            Console.WriteLine("14.Thoat chuong trinh");
        }

        static void ThemSinhVien(List<Student> students)
        {
            Student student = new Student();
            Console.Write("Nhap ma sinh vien: ");
            student.masv = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            student.hoTen = Console.ReadLine();
            Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
            student.ngaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Nhap gioi tinh (true/false): ");
            student.gioiTinh = bool.Parse(Console.ReadLine());
            Console.Write("Nhap email: ");
            student.email = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            student.soDienThoai = Console.ReadLine();
            Console.Write("Nhap nganh hoc: ");
            student.nganhHoc = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            student.diemTrungBinh = float.Parse(Console.ReadLine());
            Console.Write("Nhap trang thai (true/false): ");
            student.trangThai = bool.Parse(Console.ReadLine());
            students.Add(student);
        }
        // Hiển thị thông tin sinh viên
        static void HienThiSinhVien(List<Student> students)
        {
            Console.WriteLine("Danh sách sinh viên:");
            foreach (var student in students)
            {
                Console.WriteLine($"Ma SV: {student.masv}, Ho ten: {student.hoTen}, Ngay sinh: {student.ngaySinh.ToString("dd/MM/yyyy")}, Gioi tinh: {(student.gioiTinh ? "Nam" : "Nu")}, Email: {student.email}, SĐT: {student.soDienThoai}, Nganh hoc: {student.nganhHoc}, Diem TB: {student.diemTrungBinh}, Trang thai: {(student.trangThai ? "Dang hoc" : "Nghi hoc")}");
            }
        }
        //Tìm sinh viên theo mã
        static void timSinhVienTheoMa(List<Student> students)
        {
            string maCanTim;
            Console.WriteLine("Nhap ma sinh vien can tim: ");
            maCanTim = Console.ReadLine();
            bool timThay = false;
            foreach (var student in students)
            {
                if (maCanTim == student.masv)
                {
                    Console.WriteLine($"Ma SV: {student.masv}, Ho ten: {student.hoTen}, Ngay sinh: " +
                        $"{student.ngaySinh.ToString("dd/MM/yyyy")}, Gioi tinh: {(student.gioiTinh ? "Nam" : "Nu")}, " +
                        $"Email: {student.email}, SĐT: {student.soDienThoai}, Nganh hoc: {student.nganhHoc}, Diem TB: {student.diemTrungBinh}, " +
                        $"Trang thai: {(student.trangThai ? "Dang hoc" : "Nghi hoc")}");
                    timThay = true;
                }
            }
            if (!timThay)
            {
                Console.WriteLine("Khong tim thay sinh vien co ma " + maCanTim);
            }
        }
        //Tìm sinh viên theo tên 
        static void timSinhVienTheoTen(List<Student> students)
        {
            Console.Write("Nhap ten can tim: ");
            string tenCanTim = Console.ReadLine();

            bool timThay = false;

            foreach (var student in students)
            {
                if (string.Equals(tenCanTim, student.hoTen, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(
                        $"Ma SV: {student.masv}, Ho ten: {student.hoTen}, Ngay sinh: " +
                        $"{student.ngaySinh:dd/MM/yyyy}, Gioi tinh: {(student.gioiTinh ? "Nam" : "Nu")}, " +
                        $"Email: {student.email}, SĐT: {student.soDienThoai}, " +
                        $"Nganh hoc: {student.nganhHoc}, Diem TB: {student.diemTrungBinh}, " +
                        $"Trang thai: {(student.trangThai ? "Dang hoc" : "Nghi hoc")}"
                    );

                    timThay = true;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("Khong tim thay sinh vien co ten " + tenCanTim);
            }
        }
        //Cập nhật sinh viên
        static void capNhat(List<Student> students)
        {
            Console.Write("Nhap ma sinh vien can cap nhat: ");
            string maCapNhat = Console.ReadLine();
            var sv = students.FirstOrDefault(s => s.masv.Equals(maCapNhat, StringComparison.OrdinalIgnoreCase));
            if(sv == null)
            {
                Console.WriteLine("Sinh vien nay khong ton tai!");
                return;
            }
            Console.WriteLine("Nhap thong tin moi: ");
            Console.Write($"Ho ten hien tai [{sv.hoTen}]: ");
            string ten = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(ten)) sv.hoTen = ten;

            Console.Write($"Ngay sinh hien tai [{sv.ngaySinh:dd/MM/yyyy}]: ");
            string ns = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(ns)) sv.ngaySinh = DateTime.ParseExact(ns, "dd/MM/yyyy", null);

            Console.Write($"Email hien tai [{sv.email}]: ");
            string email = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(email)) sv.email = email;

            Console.Write($"SDT hien tai [{sv.soDienThoai}]: ");
            string sdt = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(sdt)) sv.soDienThoai = sdt;

            Console.Write($"Nganh hoc hien tai [{sv.nganhHoc}]: ");
            string nganh = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nganh)) sv.nganhHoc = nganh;

            Console.Write($"Diem TB hien tai [{sv.diemTrungBinh}]: ");
            string diem = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(diem)) sv.diemTrungBinh = float.Parse(diem);

            Console.WriteLine("Cap nhat thong tin thanh cong!");
        }
        // 6. Xóa sinh viên
        static void XoaSinhVien(List<Student> students)
        {
            Console.Write("Nhap ma sinh vien can xoa: ");
            string ma = Console.ReadLine();
            var sv = students.FirstOrDefault(s => s.masv.Equals(ma, StringComparison.OrdinalIgnoreCase));

            if (sv == null)
            {
                Console.WriteLine("Sinh vien khong ton tai!");
                return;
            }

            students.Remove(sv);
            Console.WriteLine("Xoa sinh vien thanh cong!");
        }

        // 7. Sắp xếp theo họ tên
        static void SapXepTheoHoTen(List<Student> students)
        {
            var dsSapXep = students.OrderBy(s => s.hoTen).ToList();
            Console.WriteLine("Danh sach sau khi sap xep theo ho ten (A-Z):");
            foreach (var student in dsSapXep)
            {
                Console.WriteLine($"Ma SV: {student.masv}, Ho ten: {student.hoTen}, Ngay sinh: {student.ngaySinh.ToString("dd/MM/yyyy")}, Gioi tinh: {(student.gioiTinh ? "Nam" : "Nu")}, Email: {student.email}, SĐT: {student.soDienThoai}, Nganh hoc: {student.nganhHoc}, Diem TB: {student.diemTrungBinh}, Trang thai: {(student.trangThai ? "Dang hoc" : "Nghi hoc")}");
            }
        }

        // 8. Sắp xếp theo điểm trung bình
        static void SapXepTheoDiemTB(List<Student> students)
        {
            var dsSapXep = students.OrderByDescending(s => s.diemTrungBinh).ToList();
            Console.WriteLine("Danh sach sau khi sap xep theo diem trung binh (Giam dan):");
            foreach (var student in dsSapXep)
            {
                Console.WriteLine($"Ma SV: {student.masv}, Ho ten: {student.hoTen}, Ngay sinh: {student.ngaySinh.ToString("dd/MM/yyyy")}, Gioi tinh: {(student.gioiTinh ? "Nam" : "Nu")}, Email: {student.email}, SĐT: {student.soDienThoai}, Nganh hoc: {student.nganhHoc}, Diem TB: {student.diemTrungBinh}, Trang thai: {(student.trangThai ? "Dang hoc" : "Nghi hoc")}");
            }
        }

        // 9. Hiển thị sinh viên có điểm từ 8 trở lên
        static void HienThiSinhVienDiemTu8(List<Student> students)
        {
            var dsGioi = students.Where(s => s.diemTrungBinh >= 8.0f).ToList();
            Console.WriteLine("Danh sach sinh vien co diem TB >= 8.0:");
            foreach (var student in dsGioi)
            {
                Console.WriteLine($"Ma SV: {student.masv}, Ho ten: {student.hoTen}, Ngay sinh: {student.ngaySinh.ToString("dd/MM/yyyy")}, Gioi tinh: {(student.gioiTinh ? "Nam" : "Nu")}, Email: {student.email}, SĐT: {student.soDienThoai}, Nganh hoc: {student.nganhHoc}, Diem TB: {student.diemTrungBinh}, Trang thai: {(student.trangThai ? "Dang hoc" : "Nghi hoc")}");
            }
        }

        // 10. Hiển thị sinh viên có điểm cao nhất
        static void HienThiSinhVienDiemCaoNhat(List<Student> students)
        {
            if (students.Count == 0) return;
            float maxDiem = students.Max(s => s.diemTrungBinh);
            var dsMax = students.Where(s => s.diemTrungBinh == maxDiem).ToList();

            Console.WriteLine($"Sinh vien co diem cao nhat ({maxDiem}):");
            foreach (var student in dsMax)
            {
                Console.WriteLine($"Ma SV: {student.masv}, Ho ten: {student.hoTen}, Ngay sinh: {student.ngaySinh.ToString("dd/MM/yyyy")}, Gioi tinh: {(student.gioiTinh ? "Nam" : "Nu")}, Email: {student.email}, SĐT: {student.soDienThoai}, Nganh hoc: {student.nganhHoc}, Diem TB: {student.diemTrungBinh}, Trang thai: {(student.trangThai ? "Dang hoc" : "Nghi hoc")}");
            }
        }

        // 11. Tính điểm trung bình toàn bộ sinh viên
        static void TinhDiemTBTotCai(List<Student> students)
        {
            if (students.Count == 0) return;
            double dtbChung = students.Average(s => s.diemTrungBinh);
            Console.WriteLine($"Diem trung binh cua toan bo sinh vien: {dtbChung:F2}");
        }

        // 12. Thống kê sinh viên theo ngành
        static void ThongKeTheoNganh(List<Student> students)
        {
            var nhomNganh = students.GroupBy(s => s.nganhHoc);
            Console.WriteLine("Thong ke sinh vien theo nganh:");
            foreach (var g in nhomNganh)
            {
                Console.WriteLine($"- Nganh {g.Key}: {g.Count()} sinh vien");
            }
        }

        // 13. Thống kê sinh viên theo trạng thái
        static void ThongKeTheoTrangThai(List<Student> students)
        {
            int dangHoc = students.Count(s => s.trangThai);
            int nghiHoc = students.Count(s => !s.trangThai);

            Console.WriteLine("Thong ke theo trang thai:");
            Console.WriteLine($"- Dang hoc: {dangHoc} sinh vien");
            Console.WriteLine($"- Nghi hoc: {nghiHoc} sinh vien");
        }
    }
}


