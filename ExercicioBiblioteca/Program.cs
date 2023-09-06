namespace ExercicioBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro("As Cronicas de Gelo e Fogo","Gorger","1996", 35);
            Revista revista = new Revista("As Cronicas de Gelo e Fogo", "Gorger", "1996", 35);
            MidiaDigital midia = new MidiaDigital("As Cronicas de Gelo e Fogo", "Gorger", "1996", 35);

            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Adicionar(livro);
            biblioteca.Adicionar(revista);
            biblioteca.Adicionar(midia);

            DateTime dataEmprestimo = DateTime.Now;
            DateTime dataDevolucao = dataEmprestimo.AddDays(10);

            Imprimir.ImprimirLivro(dataDevolucao, dataEmprestimo, livro);
            Console.WriteLine();
            Imprimir.ImprimirRevista(dataDevolucao, dataEmprestimo, revista);
            Console.WriteLine();
            Imprimir.ImprimirMidiaDigital(dataDevolucao, dataEmprestimo, midia);
            Console.ReadKey();
        }
    }
}