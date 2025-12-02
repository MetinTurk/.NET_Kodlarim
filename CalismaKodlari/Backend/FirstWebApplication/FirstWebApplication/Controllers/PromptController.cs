using Microsoft.AspNetCore.Mvc;

namespace FirstWebApplication.Controllers // DİKKAT: Buradaki "ProjeAdin" kısmını kendi proje isminle değiştir!
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromptController : ControllerBase
    {
        // 1. Basit Test Kapısı (GET)
        // Tarayıcıdan bu adrese gidince çalışır.
        [HttpGet]
        public IActionResult SelamVer()
        {
            return Ok(new { mesaj = "Backend ayakta! Ben hazırım." });
        }

        // 2. Prompt Alma Kapısı (POST)
        // React buraya veri gönderecek. (Tarayıcıdan direkt girilmez, Swagger'dan denenir)
        [HttpPost]
        public IActionResult PromptAl([FromBody] PromptIstegi istek)
        {
            // Şimdilik yapay zekaya bağlamadık, sadece aldığımızı teyit edelim.
            string cevap = $"Seni duydum! İsteğin şuydu: '{istek.UserPrompt}'. Şu an üzerinde çalışıyorum...";

            return Ok(new
            {
                status = "Basarili",
                aiCevabi = cevap
            });
        }
    }

    // React'ten gelecek verinin paketi (Model)
    public class PromptIstegi
    {
        public string UserPrompt { get; set; }
    }
}