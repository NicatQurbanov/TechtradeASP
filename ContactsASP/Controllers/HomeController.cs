
using ContactsASP;
using ContactsASP.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace ContactsASP.Controllers
{

    public class HomeController : Controller
    {
        public ContactsRepository Repository { get; set; } = new ContactsRepository();

        static int notFoundId = 0; 

        public List<Contact> Contacts => ContactsRepository.Contacts;
        public IActionResult Index() =>  View(Contacts);    
        public IActionResult Contact(int id)
        {
            Contact? contact = Repository.GetContact(id);

            if (contact == null)
            {
                notFoundId = id;
                return RedirectToAction("NotFound");
            }

            return View(contact);
        }

        public IActionResult NotFound()
        {
            return View(notFoundId);
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            if(!ModelState.IsValid) 
            {
                return View(contact);
            }
            Repository.AddContact(contact);
            return RedirectToAction("Index");
        }
       
    }
}
