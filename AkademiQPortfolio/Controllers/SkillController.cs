using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolio.Controllers;

public class SkillController : Controller
{
    //Buraya contexti kullandırtacağız

    //İlgili tabloya created ve update tarihleri gelecek

    private readonly portfolyodbContext _portfolyodbContext;

    public SkillController(portfolyodbContext portfolyodbContext)
    {
        _portfolyodbContext = portfolyodbContext;
    }

    public IActionResult Index()
    {
        //tüm yetenekleri listele _portfolyodbContext
        //bizim veri tabanında 10 tane verimiz var bu 10 veriyi liste şekilinde getiriyor
        // 4 5 tane veri var

        var SkillList = _portfolyodbContext.SkillTables.ToList();
        return View(SkillList);
    }

    [HttpGet]
    //HttpGet ile 5 numaralı id ye ait verileri getirdik bu şekilde sayfa ilk açıldığında neyi güncelleyeceğimizi göreceğiz
    public IActionResult UpdateSkill(int id)
    {
        //İlgili veriyi veri tabanından buluyoruz dışarıdan aldığımız id değerine göre
        //Güncelleme sayfası ilk açıldığında ilgili verilerin getirilmesi
        var SkillUpdate = _portfolyodbContext.SkillTables.Find(id); 

        return View(SkillUpdate);
    }

    [HttpPost]
    //HttpPost ile 5 numaralı idyi güncelleyeceğiz htmlde ilgili metin kutularında değişiklikleri yapıp güncelle butonuna basıldığında burası çalışacak
    public IActionResult UpdateSkill(SkillTable skill)
    {
        //skill = SkillTable bu classta yer alan verilere göre verimiz var
        //Gelen verilerde güncellemek istediğimiz veriyi değiştirdikten sonra bu verinin güncellenmesi

        //Bir verinin güncellenmesi için * adım
        //1. adım veri tabanı bağlantısı tablo bağlantısı
        //2. adım güncellenecek veriyi al
        //3.adım güncellenecek veriyi güncelle
        //4.adım ctrl + s kaydet
        //5.adım bitiş

        _portfolyodbContext.SkillTables.Update(skill); //1,2,3. adım
        _portfolyodbContext.SaveChanges(); // 4.adım


        return RedirectToAction("Index");
    }


    //Araştırılacak burada neden httpget kullandık
    public IActionResult DeleteSkill(int id)
    {
        //1. adım veri tabanı bağlantısı tablo bağlantısı
        //2.Adım ilgili veriyi bul neye göre -> idye göre
        //3.adım veriyi sil
        //4.adım değişiklikleri kaydet
        //5.adım bitiş

        var value = _portfolyodbContext.SkillTables.Find(id); // 1ve2. adım

        _portfolyodbContext.SkillTables.Remove(value); //3.adım

        _portfolyodbContext.SaveChanges(); //4.adım

        return RedirectToAction("Index"); //5.adım
    }


    [HttpGet]
    public IActionResult CreateSkill()
    {
       
        return View();
    }


    [HttpPost]
    public IActionResult CreateSkill(SkillTable table)
    {
        _portfolyodbContext.SkillTables.Add(table);
        _portfolyodbContext.SaveChanges();
        return RedirectToAction("Index");
    }


}