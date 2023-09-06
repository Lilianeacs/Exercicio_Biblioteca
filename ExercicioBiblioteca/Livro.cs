using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public bool VerificarEmprestimo { get; set; }
        public Livro(string titulo, string autor, string anoPublicacao, int pagina)
            : base(titulo, autor, anoPublicacao, pagina) { }

        public string DevolverItem(DateTime dataDevolucao)
        {
            if (VerificarEmprestimo)
            {
                VerificarEmprestimo = false;
                DataDevolucao = dataDevolucao;
                return $"O Livro {Titulo} foi devolvida em {DataDevolucao.ToShortDateString()}";
            }
            else
                return $"O Livro não foi devolvida.";
        }

        public string EmprestarItem(DateTime dataEmprestimo)
        {
            if (!VerificarEmprestimo)
            {
                VerificarEmprestimo = true;
                DataEmprestimo = dataEmprestimo;
                DataDevolucao = dataEmprestimo.AddDays(5);
                return $"Titulo: {Titulo} foi emprestada em - {DataEmprestimo.ToShortDateString()}";
            }
            else
                return $"Livro já está alugada!";
        }
    }
}
