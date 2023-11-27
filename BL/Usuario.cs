using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using(DL.NCastilloExamenEntities context = new DL.NCastilloExamenEntities())
                {
                    var query = context.UsuarioGetAll().ToList();

                    result.Objects = new List<Object>();

                    if(query != null)
                    {
                       

                        foreach(var registro in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();

                            usuario.IdUsuario = registro.IdUsuario;

                            usuario.Nombre = registro.Nombre;

                            usuario.ApellidoPaterno = registro.ApellidoPaterno;

                            usuario.ApellidoMaterno = registro.ApellidoMaterno;

                            usuario.Edad = registro.Edad.Value;

                            result.Objects.Add(usuario);

                        }

                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio un error";
                    }




                }



            }
            catch(Exception ex) 
            {
                result.Correct = false; 
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }

            return result;  

        }



        public static ML.Result Add(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.NCastilloExamenEntities context = new DL.NCastilloExamenEntities())
                {

                    int filasAfectadas = context.UsuarioAdd(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Edad);

                    if(filasAfectadas > 0)
                    {
                        result.Correct = true;
                        result.ErrorMessage = "Exito";
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error";

                    }




                }
            }
            catch (Exception ex)
            {
                result.Correct = false; 
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;

        }



        public static ML.Result Update(ML.Usuario usuario) 
        {
            ML.Result result = new ML.Result();

            try
            {
                using(DL.NCastilloExamenEntities context = new DL.NCastilloExamenEntities())
                {
                    int filasAfectadas = context.UsuarioUpdate(usuario.IdUsuario, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Edad);

                    if(filasAfectadas > 0)
                    {
                        result.Correct = true;
                        result.ErrorMessage = "Exito";
                    }
                    else
                    {
                        result.Correct = false; 
                        result.ErrorMessage = "Error";
                    }





                }
            }
            catch(Exception ex) 
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            
            
            
            }
            return result;  
        
        
        }


        public static ML.Result GetById (int idUsuario) 
        
        {
            ML.Result result = new ML.Result ();

            try
            {
                using(DL.NCastilloExamenEntities context = new DL.NCastilloExamenEntities())
                {

                    var query = context.UsuarioGetById(idUsuario).SingleOrDefault();

                    result.Object = new List<Object>();

                    if(query != null)
                    {
                        ML.Usuario usuario = new ML.Usuario();

                        usuario.IdUsuario = query.IdUsuario;

                        usuario.Nombre = query.Nombre;

                        usuario.ApellidoPaterno = query.ApellidoPaterno;

                        usuario.ApellidoMaterno = query.ApellidoMaterno;

                        usuario.Edad = query.Edad.Value;

                        result.Object = usuario;

                        result.Correct = true;



                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error";
                    }

                }
            }
            catch(Exception ex) 
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            
            
            }
        
        
        return result;
        
        }


        public static ML.Result Delete (int idUsuario)
        {

            ML.Result result = new ML.Result(); 
            
            try
            {
                using(DL.NCastilloExamenEntities context = new DL.NCastilloExamenEntities())
                {

                    int filasAfectadas = context.UsuarioDelete(idUsuario);

                    if(filasAfectadas > 0)
                    {
                        result.Correct = true;
                        result.ErrorMessage = "Exito";
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error";  
                    }



                }

            }
            catch( Exception ex) 
            { 
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            
            
            
            }

            return result;


        }

    }
}
