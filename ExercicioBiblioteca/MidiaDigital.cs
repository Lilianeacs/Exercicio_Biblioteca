using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    public class MidiaDigital : ItemBiblioteca, IPodeSerEmprestado
    {
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public bool VerificarEmprestimo { get; set; }
        public MidiaDigital(string titulo, string autor, string anoPublicacao, int pagina)
            : base(titulo, autor, anoPublicacao, pagina) {  } 

        public string DevolverItem(DateTime dataDevolucao)
        {
            return $"Não há devolução!";
        }

        public string EmprestarItem(DateTime dataEmprestimo)
        {
            if (!VerificarEmprestimo)
            {
                VerificarEmprestimo = true;
                DataEmprestimo = dataEmprestimo;
                return $"Titulo: {Titulo} foi emprestada em - {DataEmprestimo.ToShortDateString()}";
            }
            else
                return $"Midia Digital não disponivel";
        }
    }
}
