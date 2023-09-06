using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class Imprimir
    {
        public static void ImprimirLivro(DateTime dataDevolucao, DateTime dataEmprestimo, Livro livro) 
        {
            Console.WriteLine(livro.EmprestarItem(dataEmprestimo));
            Console.WriteLine(livro.DevolverItem(dataDevolucao));
        }
        public static void ImprimirRevista(DateTime dataDevolucao, DateTime dataEmprestimo, Revista revista) 
        {
            Console.WriteLine(revista.EmprestarItem(dataEmprestimo));
            Console.WriteLine(revista.DevolverItem(dataDevolucao));
        }
        public static void ImprimirMidiaDigital(DateTime dataDevolucao, DateTime dataEmprestimo, MidiaDigital midiaDigital) 
        {
            Console.WriteLine(midiaDigital.EmprestarItem(dataEmprestimo));
            Console.WriteLine(midiaDigital.DevolverItem(dataDevolucao));
        }
    }
}
