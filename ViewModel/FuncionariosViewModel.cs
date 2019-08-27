using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMCRUD.ViewModel
{
    public class FuncionariosViewModel : BaseNotifyPropertyChanged
    {
        public ObservableCollection<Model.Funcionario> Funcionarios { get; private set; }
        public DeletarCommand Deletar { get; private set; } = new DeletarCommand();
        public NovoCommand Novo { get; private set; } = new NovoCommand();
        public EditarCommand Editar { get; private set; } = new EditarCommand();


        private Model.Funcionario _funcionarioSelecionado;
        public Model.Funcionario FuncionarioSelecionado
        {
            get { return _funcionarioSelecionado; }
            set
            {
                SetField(ref _funcionarioSelecionado, value);
                Deletar.RaiseCanExecuteChanged();
                Editar.RaiseCanExecuteChanged();
            }
        }

        public FuncionariosViewModel()
        {
            Funcionarios = new ObservableCollection<Model.Funcionario>();
            Funcionarios.Add(new Model.Funcionario()
            {
                Id = 1,
                Nome = "André",
                Sobrenome = "Lima",
                DataNascimento = new DateTime(1984, 12, 31),
                Sexo = Model.Sexo.Masculino,
                EstadoCivil = Model.EstadoCivil.Casado,
                DataAdmissao = new DateTime(2010, 1, 1)
            });

            FuncionarioSelecionado = Funcionarios.FirstOrDefault();
        }
    }
}
