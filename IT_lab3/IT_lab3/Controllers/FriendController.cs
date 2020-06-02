using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IT_lab3.Models;

namespace IT_lab3.Controllers
{
    public class FriendController : Controller
    {
        //Static data 
        public static List<FriendModel> friendsList = new List<FriendModel>();
      
   
        // GET: Friend
        public ActionResult Index()
        {
            return View(friendsList);
        }

        public ActionResult Create()
        {
            FriendModel newFriend = new FriendModel();
            return View(newFriend);
        }

        [HttpPost]
        public ActionResult Create(FriendModel friendToAdd)
        {
            if (!ModelState.IsValid)
            {
                return View(friendToAdd);
            }
            friendsList.Add(friendToAdd);
            return View("Index", friendsList);
        }

        public ActionResult Edit(int id)
        {
            //FriendModel friendToEdit = friendsList.ElementAt(id);
            FriendModel friendToEdit = friendsList.Find(f => f.Id == id);


            friendToEdit.Id = id;
            return View(friendToEdit);
        }

        [HttpPost]
        public ActionResult Edit(FriendModel friend)
        {
            if (!ModelState.IsValid)
            {
                return View(friend);
            }

            //FriendModel forUpdate = friendsList.ElementAt(friend.Id);
            FriendModel forUpdate = friendsList.Find(f => f.Id == friend.Id);
            forUpdate.Id = friend.Id;
            forUpdate.Name = friend.Name;
            forUpdate.Place = friend.Place;

            return View("Index", friendsList);
        }

        public ActionResult Delete(int id)
        {
            FriendModel friendToDelete = friendsList.Find(f => f.Id == id);
            friendsList.Remove(friendToDelete);
            return View("Index", friendsList);
        }
    }
}