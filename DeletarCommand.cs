using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMCRUD.ViewModel;

namespace WPFMVVMCRUD
{
    public class DeletarCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as FuncionariosViewModel;
            return viewModel != null && viewModel.FuncionarioSelecionado != null;
        }

        public override void Execute(object parameter)
        {
            var viewModel = (FuncionariosViewModel)parameter;
            viewModel.Funcionarios.Remove(viewModel.FuncionarioSelecionado);
            viewModel.FuncionarioSelecionado = viewModel.Funcionarios.FirstOrDefault();
        }
    }
}
