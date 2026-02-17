using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentFormApp.Data;
using StudentFormApp.Models;


namespace StudentFormApp.Pages.Student
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _db;

        public CreateModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public StudentInput Form { get; set; } = new();

        public string? SuccessMessage { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var entity = new StudentFormApp.Models.Student
            {
                Name = Form.Name,
                Number = Form.Number,
                Email = Form.Email,
                Dob = Form.Dob
            };

            _db.Students.Add(entity);
            _db.SaveChanges();

            SuccessMessage = $"Saved successfully. Student Id: {entity.Id}";

            ModelState.Clear();
            Form = new StudentInput();

            return Page();
        }
    }
}