using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public interface IPodeSerEmprestado
    {
        public string EmprestarItem(DateTime dataEmprestimo);
        public string DevolverItem(DateTime dataDevolucao);
    }
}
