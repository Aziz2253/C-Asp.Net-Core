using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
    public class ProductController : Controller
    {

        Context context=new Context();
        public IActionResult Index()
        {

            var values=context.Products.ToList();//Ürün Sınıfında yer alan değerleri döndürür

            return View(values);
        }



        // Ürün Ekleme

        [HttpGet]  //Sayfa Yüklendiği zaman çalışacak Method
        public IActionResult AddProduct() { 

            return View();
        
        }

        [HttpPost]  //Herhangi bi işlem yapıldığı zaman çalışacak method
        public IActionResult AddProduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index"); //Ürün Eklendiğinde Indexe yönlendir
        }

        public IActionResult Delete(int id)
        {
            var value=context.Products.Where(x=>x.Id==id).FirstOrDefault();
            // FirstOrDefault Id sini komple hafızaya alır
            context.Remove(value);  
            context.SaveChanges();

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult UpdateProduct(int id) {

            var deger=context.Products.Where(x=>x.Id== id).FirstOrDefault();


            return View(deger);
            }

        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {

            var deger = context.Products.Where(x => x.Id == p.Id).FirstOrDefault();
            deger.Name = p.Name;
            deger.Price = p.Price;  
            deger.Stock=p.Stock;
            context.SaveChanges();


            return RedirectToAction("Index");
        }


    }
}
