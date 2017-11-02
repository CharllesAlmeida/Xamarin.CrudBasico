using SQLite.Net.Interop;
using SQLite;

using Xamarin.Forms;

namespace CrudBasico.Model{
     public interface IConfig{
         string DiretorioDB { get; }
         ISQLitePlatform Plataforma { get; }
     }
}