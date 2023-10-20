using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra3
{
    internal class SinhVienA
    {

        public int ID{ get; set;}
        public string Ten { get; set;}

        public string DiaChi { get; set;}

        public float Toan { get; set; }

        public float Ly { get; set; }

        public float Hoa{ get; set; }

        public float DiemUT{ get; set; }

        public double Tong{
            get
            {   
                return Toan + Ly + Hoa + DiemUT;
            }
        }
        static int id = 999;
        public SinhVienA(){
            id = id+1;
            this.ID = id;
            this.Ten = "";
            this.DiaChi = "";
        }

        public void Nhap(){
            try{
            //     Console.Write("Nhập vào ID: ");
            // this.ID = Console.ReadLine();

            Console.Write("Nhập vào Họ tên: ");
            this.Ten = Console.ReadLine();

            Console.Write("Nhập vào Địa Chỉ: ");
            this.DiaChi = Console.ReadLine();

            Console.Write("Nhập vào điểm Toán ");
            this.Toan = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhập vào điểm Lý: ");
            this.Ly = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhập vào điểm Hóa: ");
            this.Hoa = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhập vào Điểm UT: ");
            this.DiemUT = Convert.ToSingle(Console.ReadLine());
            } catch(Exception ){
                Console.WriteLine("Thông tin bạn nhập không hợp lệ lên sẽ để giá trị mặc định");
            }
        }

        public void Xuat(){
            Console.WriteLine($"{this.ID,10} {this.Ten,15} {this.DiaChi,10} {this.Toan,10} {this.Ly,10} {this.Hoa,10} {this.DiemUT,10} {this.Tong,10}");
        }

    }
}
