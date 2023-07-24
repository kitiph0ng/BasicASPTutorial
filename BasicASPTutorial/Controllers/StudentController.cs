using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicASPTutorial.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
	        return Content("คะแนนสอบวิชาคอมพิวเตอร์");
        }

        public IActionResult Detail() {
            return Content("รายละเอียดคะแนนสอบ");
        }

        public IActionResult ShowScore(int id) {
            return Content($"คะแนนสอบของนักเรียนเลขที่ {id} : {new Random().NextInt64(0, 100)}");
        }
    }

}

