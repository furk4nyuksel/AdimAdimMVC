using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcOrnek4EntityFrameworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            SchoolEntities db = new SchoolEntities();

            #region  Veri Ekleme
            //Teacher addTeacher = new Teacher()
            //{
            //    CreateDate=DateTime.Now,
            //    IsActive=true,
            //    IsDelete=false,
            //    TeacherName="Ahmet Hoca"
            //};

            //db.Teacher.Add(addTeacher);//teacher tablosuna bu modeli ekle
            //db.SaveChanges();//değişiklikleri kaydet 

            #endregion

            #region Çoklu Veri Ekleme
            // 50 adet rastgele veri ekleyelim
            //for(int i = 0; i <= 50; i++)
            // {
            //     Teacher addTeacher = new Teacher()
            //     {
            //         CreateDate = DateTime.Now,
            //         IsActive = true,
            //         IsDelete = false,
            //         TeacherName = Guid.NewGuid().ToString()
            //     };

            //     db.Teacher.Add(addTeacher);
            // }

            // db.SaveChanges();
            #endregion

            #region Listeleme işlemi
            //var query = db.Teacher.ToList();

            ////listelemek için foreach kullanacağız

            //foreach (var item in query)
            //{
            //    Console.WriteLine("Ögretmen Adı {0}",item.TeacherName);
            //}

            //Console.ReadLine();
            #endregion

            #region Filtreli Listeleme İşlemi
            //var query = db.Teacher.Where(s => s.TeacherId == 2).SingleOrDefault();

            //Console.WriteLine("Ögretmen Adı: "+query.TeacherName);

            //Console.ReadLine();
            #endregion

            #region Update İşlemi
            //var query = db.Teacher.Where(s => s.TeacherId == 3).SingleOrDefault();

            //query.TeacherName = "Ayşe Hoca";
            //query.IsActive = false;
            //query.IsDelete = true;

            //db.SaveChanges();



            #endregion

            #region Veri Silme İşlemi
            //var query = db.Teacher.Where(s => s.TeacherId == 4).SingleOrDefault();

            //db.Teacher.Remove(query);
            //db.SaveChanges();
            #endregion

            #region Bağlı Tablodan Veri Çekme İşlemi 

            //var query = db.Lessons.ToList();

            //foreach (var item in query)
            //{
            //    Console.WriteLine("Ders Adı: "+item.LessonsName+" Ögretmen Adı: "+item.Teacher.TeacherName);
            //}

            //Console.ReadLine();
            #endregion

            #region Tekli Kayıt Getirme
            var query = db.Lessons.Where(s => s.LessonsId == 1).SingleOrDefault();

            Console.WriteLine(query.Teacher.TeacherName);

            Console.ReadLine();
            #endregion
        }
    }
}
