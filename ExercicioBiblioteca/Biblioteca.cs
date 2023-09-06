using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class Biblioteca
    {
        public List<IPodeSerEmprestado> listaBiblioteca { get; set; }
        public Biblioteca()
        {
            listaBiblioteca = new List<IPodeSerEmprestado>();
        }

        public void Adicionar(IPodeSerEmprestado item)
        {
            listaBiblioteca.Add(item);
        }

        public void Emprestar(IPodeSerEmprestado item, DateTime dataEmprestimo)
        {
            item.EmprestarItem(dataEmprestimo);
        }
        public void Devolver(IPodeSerEmprestado item, DateTime dataDevolucao)
        {
            item.DevolverItem(dataDevolucao);
        }
    }
}
