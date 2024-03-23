using c_2024.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_2024.Business;

public class CourseManager
{
    Course[] courses = new Course[3];//değişken global hale getirildi (satır no 50)

    //ctor yazıp enter dediğimizde aşağıdaki blok oluşturulur.

    //constroctur (yapıcı blok)
    //Class çağırıldığında ilk olarak constructor yapısı çalışır new komutu verildiği için.
    public CourseManager() 
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".Net 8...";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Python";
        course2.Description = "Python 3.5";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "JAVA";
        course3.Description = "Java ile Nesene...";
        course3.Price = 55;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
        //Course[] courses = {course1, course2, course3};//yukarıda bilgiyi de dizi içine aldık.

    }//Bu yapı db den veri geliyormuş gibi programı simüle etmek için oluşturulmuş bir yapıdır.
    //normalde bu veriler db tarafından çekilir.

    //Metod yapısı aşağıdaki şekilde oluşturulur. GetAll diye metod oluşturuldu.
    //program tarafında coursemanager.GetAll(); şeklinde bu metod çağırılabilir.
    public Course[] GetAll() //eğer değer döndüren fonks. yada metod kullanılacaksa nasıl bir değer döneceğini tanımlamız lazım.
    {
        /*corses i çağırmaya kalktığımızda gelmeyecek. sebebi corses sadece constructor yapısında tanımlı olduğu için.
        bu hatayı gidermek için Course[] courses tanımını direk classın altına alarak local bir değişkenolmaktan alıp,
        global bir değişken haline getiriyoruz.
        */
        //Normalde veri kaynağından veri çekilierek getirilir.
        //Console.WriteLine("Kurslar Listeledni...");
        
        return courses; //değer döndüren yapı olduğu için return ile neyin döneceğini tanımladık.
    }
}
