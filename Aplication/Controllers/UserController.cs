using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers;

public class UserController : Controller
{
    private static List<User> _users = new List<User>
    {
        new User { Id = 1, Name = "1", Email = "1" },
        new User { Id = 2, Name = "1", Email = "2" },
        new User { Id = 3, Name = "1", Email = "3" },
        new User { Id = 4, Name = "1", Email = "4" },
        new User { Id = 5, Name = "1", Email = "5" },
        new User { Id = 6, Name = "1", Email = "6" },
        new User { Id = 7, Name = "1", Email = "7" },
        new User { Id = 8, Name = "1", Email = "8" },
        new User { Id = 9, Name = "1", Email = "9" },
        new User { Id = 10, Name = "1", Email = "10" },
        new User { Id = 11, Name = "1", Email = "11" },
        new User { Id = 12, Name = "1", Email = "12" },
        new User { Id = 13, Name = "1", Email = "13" },
        new User { Id = 14, Name = "1", Email = "14" }
    };
    
    private int UserId = _users.Count;
    
    public IActionResult First()
    {
        return View(_users);
    }

    public IActionResult Details(int id)
    {
        var us = _users.FirstOrDefault(u => u.Id == id);
        if (us == null) return NotFound();
        return View(us);
    }
    
    public IActionResult Edit(User upUser)
    {
        var us = _users.FirstOrDefault(u => u.Id == upUser.Id);
        if (us == null) return NotFound();
        us.Name = upUser.Name;
        us.Email = upUser.Email;
        return RedirectToAction("First");
    }
    
    public IActionResult Delete(int id)
    {
        var us = _users.FirstOrDefault(u => u.Id == id);
        if (us == null) return NotFound();
        _users.Remove(us);
        return RedirectToAction("First");
    }
    public IActionResult InpBox(User user)
    {
        user.Id = ++UserId;
        _users.Add(user);
        return RedirectToAction("First");
    }
}