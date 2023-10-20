using System;

namespace KiemTra3{

    class Program {

        static List<SinhVienA> StudentList = new List<SinhVienA>();
        static void Title(){
            Console.WriteLine($"{"ID",10} {"Ten",15} {"DiaChi",10} {"Toan",10} {"Ly",10} {"Hoa",10} {"DiemUT",10} {"Tong",10}");
        }

        static void ShowList(){
            Console.WriteLine("\t\t=====Danh sach=======");
            Title();
            foreach (var item in StudentList)
            {
                item.Xuat();
            }
        }


        static bool IsEmpty(){
            if(StudentList.Count==0){
                return true;
            } else {
                return false;
            }
        }

        static void AddStudent(){
            SinhVienA x = new SinhVienA();
            x.Nhap();
            StudentList.Add(x);
        }

        static void SearchByKey(string key,string DiaChi, double TongDiem){
            Title();
            if(key =="DiaChi"){
                foreach(var item in StudentList){
                    if(item.DiaChi == DiaChi){
                        item.Xuat();
                    }
                }
            } else if(key == "TongDiem"){
                foreach(var item in StudentList){
                    if(item.Tong == TongDiem){
                        item.Xuat();
                    }
                }
            } else {
                Console.WriteLine("Key không hợp lệ");
            }
        }

        static void SortByMark(){
            StudentList.Sort((x,y)=> x.Tong.CompareTo(y.Tong));
            ShowList();
        }

        static void RemoveStuddent(string DiaChi){
            bool isRemove = false;
           for(int i =0 ;i<StudentList.Count; i++){
            if(StudentList[i].DiaChi == DiaChi){
                StudentList.RemoveAt(i);
                isRemove = true;
                i--;
            }
           }
            if(isRemove){
                if(IsEmpty()){
                    Console.WriteLine("Danh sách trống");
                } else {
                    ShowList();
                }
                
            } else {
                Console.WriteLine("Địa chỉ bạn nhập vào không có trong danh sách");
            }
        }


        static void Menu(){
            while(true){
                Console.WriteLine("\t\t=======MENU========");
                Console.WriteLine("1.Thêm 1 sinh viên vào danh sach");
                Console.WriteLine("2.Hiển thị danh sách sinh viên");
                Console.WriteLine("3.Tìm kiếm theo địa chỉ");
                Console.WriteLine("4.Tìm kiếm theo điểm");
                Console.WriteLine("5.Sắp xếp theo tổng điểm: ");
                Console.WriteLine("6.Xóa phần tử bất ký: ");
                Console.WriteLine("7.Thoát");
                 Console.WriteLine("\t\t=======END========");
                Console.Write("Nhập vào lựa chọn: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if(n==1){
                 AddStudent();  
                } 
                else if(n==2){
                    if(IsEmpty()){
                        Console.WriteLine("Danh sách không có sinh viên nào: ");
                    } else {
                        ShowList();
                    }
                }
                else if(n==3){
                    if(IsEmpty()){
                        Console.WriteLine("Danh sách không có sinh viên nào: ");
                    } else {
                        Console.Write("Nhập vào địa chỉ cần tìm kiếm: ");
                        string DiaChi = Console.ReadLine();
                        SearchByKey("DiaChi",DiaChi,0);

                    }
                }
                else if(n==4){
                    if(IsEmpty()){
                        Console.WriteLine("Danh sách không có sinh viên nào: ");
                    } else {
                          Console.Write("Nhập vào tổng điểm cần tìm kiếm: ");
                        double Tong = Convert.ToInt32(Console.ReadLine());
                        SearchByKey("TongDiem","",Tong);
                        
                    }
                }
                else if(n==5){
                    if(IsEmpty()){
                        Console.WriteLine("Danh sách không có sinh viên nào: ");
                    } else {
                       SortByMark();
                    }
                }
                else if(n==6){
                    if(IsEmpty()){
                        Console.WriteLine("Danh sách không có sinh viên nào: ");
                    } else {
                        Console.Write("Nhập vào địa chỉ muốn xóa: ");
                        string DiaChi = Console.ReadLine();
                        RemoveStuddent(DiaChi);
                    }
                } else if(n==7){
                    Console.WriteLine("Đã thoát");
                    break;
                } else {
                    Console.WriteLine("Lựa chọn bạn nhập không chính xác");
                }



            }
        }

        static void Main(string[] args){
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
          Menu();
        }

    }


}
