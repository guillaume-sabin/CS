using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP.Models;

namespace LesChats.Controllers
{
    public class ChatController : Controller
    {
        private static List<ChatModel> _chats = ChatModel.GetMeuteDeChats();
        // GET: Chat
        public ActionResult Index()
        {
            return View(_chats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            return View(_chats.FirstOrDefault(x => x.Id == id));
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_chats.Where(x => x.Id == id).Single());
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = _chats.FirstOrDefault(x => x.Id == id);
                if(c != null && c is ChatModel)
                    _chats.Remove(c);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
