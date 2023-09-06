using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public abstract class ItemBiblioteca
    {
        public  string Titulo { get; }
        public  string Autor { get; }
        public  string AnoPublicacao { get; }
        public  int NumeroPagina { get; }
        protected ItemBiblioteca(string titulo, string autor, string anoPublicacao, int pagina)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            NumeroPagina = pagina;
        }
    }
}
