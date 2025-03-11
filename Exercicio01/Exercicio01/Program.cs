using Exercicio01;

internal class Program
{
    private static void Main(string[] args)
    {
        Livro l1 = new Livro();
        l1.Titulo = "A volta dos que não foram";
        l1.Autor = "Ubiratan Anarfa";
        l1.Editora = "Cia Sem Letras";
        l1.AnoLancamento = 2010;
        l1.mostrarLivro();

        Livro l2 = new Livro();
        l2.Titulo = "O morro dos ventos que não uivam";
        l2.Autor = "Zeferina Muda";
        l2.Editora = "Editora Tempos Remotos";
        l2.AnoLancamento = 1985;
        l2.mostrarLivro();
    }
}