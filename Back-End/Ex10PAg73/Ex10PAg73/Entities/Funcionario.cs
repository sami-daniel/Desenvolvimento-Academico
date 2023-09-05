using Ex10PAg73.Entities.Enums;
namespace Ex10PAg73.Entities
{
    class Funcionario
    {
        public string Nome { get; private set; }
        public ClassedoFuncionario classedoFuncionario { get; private set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, ClassedoFuncionario classedoFuncionario)
        {
            Nome = nome;
            this.classedoFuncionario = classedoFuncionario;
        }
    }
}
