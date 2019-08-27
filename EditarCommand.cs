using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMCRUD.ViewModel;

namespace WPFMVVMCRUD
{
    public class EditarCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as FuncionariosViewModel;
            return viewModel != null && viewModel.FuncionarioSelecionado != null;
        }

        public override void Execute(object parameter)
        {
            var viewModel = (FuncionariosViewModel)parameter;
            var cloneFuncionario = (Model.Funcionario)viewModel.FuncionarioSelecionado.Clone();
            var fw = new FuncionarioWindow();
            fw.DataContext = cloneFuncionario;
            fw.ShowDialog();

            if (fw.DialogResult.HasValue && fw.DialogResult.Value)
            {
                viewModel.FuncionarioSelecionado.Nome = cloneFuncionario.Nome;
                viewModel.FuncionarioSelecionado.Sobrenome = cloneFuncionario.Sobrenome;
                viewModel.FuncionarioSelecionado.DataNascimento = cloneFuncionario.DataNascimento;
                viewModel.FuncionarioSelecionado.Sexo = cloneFuncionario.Sexo;
                viewModel.FuncionarioSelecionado.EstadoCivil = cloneFuncionario.EstadoCivil;
                viewModel.FuncionarioSelecionado.DataAdmissao = cloneFuncionario.DataAdmissao;
            }
        }
    }
}
