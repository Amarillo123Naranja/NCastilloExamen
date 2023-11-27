using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult GetAll()
        {
            ML.Usuario usuario = new ML.Usuario();
            ML.Result result = BL.Usuario.GetAll();
            usuario.Usuarios = result.Objects;

            return View(usuario);    
 
        }

        [HttpGet]
        public ActionResult Form(int? idUsuario) 
        {
            ML.Usuario usuario = new ML.Usuario();

            if(idUsuario == null)
            {
                return View();

            }
            else
            {
                ML.Result result = BL.Usuario.GetById(idUsuario.Value);

                if (result.Correct)
                {
                    usuario = (ML.Usuario)result.Object;    
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "Ocurrio un error";
                }
            }
        
            return View(usuario);
        
        
        }

        [HttpPost]

        public ActionResult Form(ML.Usuario usuario)
        {
            if (usuario.IdUsuario > 0) 
            {
                ML.Result result = BL.Usuario.Update(usuario);

                if (result.Correct)
                {
                    return RedirectToAction("GetAll");

                }
                else
                {
                    return RedirectToAction("GetAll");


                }
            
            
            }
            else
            {
                ML.Result result = BL.Usuario.Add(usuario); 

                if(result.Correct) 
                {
                    return RedirectToAction("GetAll");

                }
                else
                {
                    return RedirectToAction("GetAll");
                }
            }

            return RedirectToAction("GetAll");    
        }    


        public ActionResult Delete(int idUsuario) 
        {
            ML.Result result = BL.Usuario.Delete(idUsuario);

            if (result.Correct)
            {
                return RedirectToAction("GetAll");
            }
            else
            {
                return RedirectToAction("GetAll");   
            }
       
        
        }
    }
}