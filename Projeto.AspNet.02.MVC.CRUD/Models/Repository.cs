namespace Projeto.AspNet._03.MVC.CRUD.Models
{
    public static class Repository
    {
        private static List<Colab> _todosOsColabs = new List<Colab>();

        public static IEnumerable<Colab> TodosOsColabs
        {
            get { return _todosOsColabs; }
        }

        public static void Inserir(Colab registroColab)
        {
            _todosOsColabs.Add(registroColab);
        }

        public static void Excluir(Colab registroColab)
        {
            _todosOsColabs.Remove(registroColab);
        }
    }
}
