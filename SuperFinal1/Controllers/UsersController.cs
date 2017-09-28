using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SuperFinal1.Context;
using SuperFinal1.Models;
//using System.Windows.Forms;
//using System.Web.Script.Serialization;


namespace SuperFinal1.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {

        private UserContext db = new UserContext();

        // GET: api/Users
        [HttpGet]
        [Route("GetUsers")]
        public IList<User2> GetUsers()
        {
            return db.Users.ToList();
        }

        //Get: api/Users
        [ResponseType(typeof(User))]
        [HttpPost]
        [Route("LoginUser")]
        public IHttpActionResult LoginUser([FromBody] User2 credential)
        {
            var user =
                db.Users.FirstOrDefault(u => u.EmailAdd == credential.EmailAdd && u.Passwword == credential.Passwword);

            if (user!=null)
                return Ok(user);

            return NotFound(); 

        }

        // GET: api/Users/5
        //[ResponseType(typeof(User))]
        //[HttpGet]
        //[Route("GetUserId/{id}")]
        //public IHttpActionResult GetUserId(int id)
        //{
        //    var user = db.Users.FirstOrDefault(u => u.UserId == id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(user);
        //}

        // PUT: api/Users/5
        //[ResponseType(typeof(void))]
        //[HttpPut]
        //[Route("EditTask")]
        //public IHttpActionResult EditTask([FromBody] Todo todos)
        //{

        //    //var user = (from u in db.Users where u.UserId == todos.User.UserId select u).FirstOrDefault();
        //    //var filterUser = db.Users.FirstOrDefault(u => u.UserId == todos.UserId); //Lambda
        //    var user = db.Users.First(u => u.UserId == todos.User.UserId);

        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        foreach (var t in user.Todos)
        //        {
        //            if (t.Id == todos.Id)
        //            {
        //                t.Task = todos.Task;
        //                t.Completed = todos.Completed;
        //            }
        //        }
        //        db.SaveChanges();
        //        return Ok(todos);
        //    }

        //}

        // DELETE: api/Users/5
        //[ResponseType(typeof(User))]
        //[HttpDelete]
        //[Route("DeleteUserTask")]
        //public IHttpActionResult DeleteUserTask([FromBody] Todo todos)
        //{
        //    var filterUser = db.Users.First(u => u.UserId == todos.User.UserId); //Lambda
        //    var todo = db.Todos.First(t => t.Id == todos.Id);
        //    //filterUser.Todos.Remove(todo);
        //    db.Todos.Remove(todo);
        //    var remove = db.Todos.Remove(todo);
        //    db.SaveChanges();
        //    return Ok(remove);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool UserExists(int id)
        //{
        //    return db.Users.Count(e => e.UserId == id) > 0;
        //}
    }
}