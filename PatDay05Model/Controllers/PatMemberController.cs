using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using PatDay05Model.Models;

namespace PatDay05Model.Controllers
{
    public class PatMemberController : Controller
    {
        static List<PatMember> members = new List<PatMember>()
        {
            new PatMember { MemberId = Guid.NewGuid().ToString(), UserName = "patuan", FullName = "Phạm Anh Tuấn", Password = "A123@12", Email = "anhtuan@gmail.com" },
            new PatMember { MemberId = Guid.NewGuid().ToString(), UserName = "tvanh",   FullName = "Trần Văn Anh",   Password = "B123@34", Email = "anhtran@gmail.com" },
            new PatMember { MemberId = Guid.NewGuid().ToString(), UserName = "nthao",   FullName = "Nguyễn Thị Thảo", Password = "C123@56", Email = "thaonguyen@gmail.com" },
            new PatMember { MemberId = Guid.NewGuid().ToString(), UserName = "pvnam",   FullName = "Phạm Văn Nam",   Password = "D123@78", Email = "nampham@gmail.com" },
            new PatMember { MemberId = Guid.NewGuid().ToString(), UserName = "ltmai",   FullName = "Lê Thị Mai",     Password = "E123@90", Email = "maile@gmail.com" }
        };
        public IActionResult  Index()
        {
            // scaffolding

            return View(members);
        }
        // Get PatCreate
        public IActionResult PatCreate()
        {
            return View();
        }

        // POST PatCreate
        [HttpPost]
        public IActionResult PatCreate(PatMember model)
        {
            var member = new PatMember();
            member.MemberId = Guid.NewGuid().ToString();
            member.FullName = model.FullName;
            member.UserName = model.UserName;
            member.Password = model.Password;
            member.Email = model.Email;

            members.Add(member);

            return RedirectToAction("Index");
        }

        // Get PatEdit
        [HttpGet]
        public IActionResult PatEdit(string id)
        {
            var model = members.Where(x => x.MemberId == id).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public IActionResult PatEdit(string id, PatMember model)
        {
            members.Where(x => x.MemberId == id).FirstOrDefault().FullName = model.FullName;
            members.Where(x => x.MemberId == id).FirstOrDefault().UserName = model.UserName;
            members.Where(x => x.MemberId == id).FirstOrDefault().Password = model.Password;
            members.Where(x => x.MemberId == id).FirstOrDefault().Email = model.Email;

            return RedirectToAction("Index");
        }

        // Details
        [HttpGet]
        public IActionResult PatDetails(string id)
        {
            var model = members.Where(x => x.MemberId == id).FirstOrDefault();
            return View(model);
        }

        // PatDelete
        [HttpGet]
        public IActionResult PatDelete(string id)
        {
            var model = members.Where(x => x.MemberId == id).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public IActionResult PatDelete(string id, PatMember model)
        {
            // Tìm thành viên theo MemberId
            var member = members.FirstOrDefault(m => m.MemberId == id);
            if (member != null)
            {
                members.Remove(member); // Xóa khỏi danh sách
            }
            return RedirectToAction("Index");
        }
        public IActionResult PatGetMember()
        {
            var patMember = new PatMember();
            patMember.MemberId = Guid.NewGuid().ToString();
            patMember.UserName = "patuan";
            patMember.FullName = "Phạm Anh Tuấn";
            patMember.Password = "A123@12";
            patMember.Email = "anhtuan@gmail.com";

            ViewBag.patMember = patMember;

            return View();
        }

        public IActionResult PatGetMembers()
        {
            return View(members);
        }
    }
}