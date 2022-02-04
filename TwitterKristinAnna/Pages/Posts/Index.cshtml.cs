using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TwitterKristinAnna.Data;
using TwitterKristinAnna.Models;

namespace TwitterKristinAnna.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly BloggingContext _db;
        [BindProperty]

        public Tweet Tweet { get; set; }

        public DbSet<Tweet> Tweets { get; private set; }

        public IndexModel(BloggingContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Tweets = _db.Tweet;
        }

        public async Task<IActionResult> OnPost(Tweet tweet)
        {
            _db.Tweet.AddAsync(tweet);
            await _db.SaveChangesAsync();
            return RedirectToAction("Posts");
        }
       
    }
}

