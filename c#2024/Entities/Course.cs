using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace c_2024.Entities;

public class Course 
{
    //Kullanılacak tanımlamalar yapılır.
    public int Id { get; set; } //id 
    public string Name { get; set; } //isim
    public string Description { get; set; } //açıklama
    
    public double Price { get; set; } //fiyat
}
