using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;


namespace Serializarjson
{
    class Program
    {
        static void Main(string[] args)
        {


           
                Usuario usuario = new Usuario()
                {
                    Nome = "JOSE SANTANA MACHADO",
                    Cpf = "032.323.537.97",
                    email = "hfmk2015@gmail.com"

                };
            
                StreamWriter stream = new StreamWriter(@"C:\CursoC#\outro.json");
                JavaScriptSerializer serializador = new JavaScriptSerializer();
                string jsonseializador = serializador.Serialize(usuario);
                stream.WriteLine(jsonseializador);
                stream.Close();

            
            StreamReader streamreader = new StreamReader(@"C:\CursoC#\outro.json");
            string linhaslidas = streamreader.ReadToEnd();

            JavaScriptSerializer deserializador = new JavaScriptSerializer();
            Usuario leitura = (Usuario)deserializador.Deserialize(linhaslidas,typeof(Usuario));
            Console.WriteLine("Nome = {0},Cpf = {1},Email = {2}",usuario.Nome,usuario.Cpf,usuario.email);

            Console.ReadKey();





                


            
                
                    


        }
    }
}
