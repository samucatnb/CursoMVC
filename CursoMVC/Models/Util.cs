using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public static class Util
    {
        
        /// <summary>
        /// Função retorna se classe não é nula
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool VerificarClasseNaoNula<T>(this T obj)
        {

            return obj == null? false: true; //!typeof(T).Equals(null) ? true : false ;
        }

        /*
        public static bool VerificarPropriedadesNaoNulas<T>(this T obj)
        {
            return typeof(T).GetProperties().All(a => a.GetValue(obj) != null);
        }*/
    }
}
