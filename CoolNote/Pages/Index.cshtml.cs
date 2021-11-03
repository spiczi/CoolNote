using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoolNote.Pages
{
    public class IndexModel : PageModel
    {
        public string Note => DataManager.Note;
        public int EditsAmount => DataManager.EditsAmount;
    }
}