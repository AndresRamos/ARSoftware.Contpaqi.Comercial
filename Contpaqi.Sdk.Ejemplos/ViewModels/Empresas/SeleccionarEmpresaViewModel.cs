using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Data;
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Empresas
{
    public class SeleccionarEmpresaViewModel : ObservableRecipient
    {
        private readonly IDialogCoordinator _dialogCoordinator;
        private readonly IEmpresaRepositorio _empresaRepositorio;
        private Empresa _empresaSeleccionada;
        private string _filtro;

        public SeleccionarEmpresaViewModel(IEmpresaRepositorio empresaRepositorio, IDialogCoordinator dialogCoordinator)
        {
            _empresaRepositorio = empresaRepositorio;
            _dialogCoordinator = dialogCoordinator;

            Empresas = new ObservableCollection<Empresa>();
            EmpresasView = CollectionViewSource.GetDefaultView(Empresas);
            EmpresasView.Filter = EmpresasView_Filter;

            BuscarEmpresasCommand = new AsyncRelayCommand(BuscarEmpresasAsync);
            SeleccionarCommand = new RelayCommand(Seleccionar, CanSeleccionar);
            CancelarCommand = new RelayCommand(Cancelar);
        }

        public string Title { get; } = "Seleccionar Empresa";

        public string Filtro
        {
            get => _filtro;
            set
            {
                SetProperty(ref _filtro, value);
                EmpresasView.Refresh();
            }
        }

        public ObservableCollection<Empresa> Empresas { get; }

        public ICollectionView EmpresasView { get; }

        public Empresa EmpresaSeleccionada
        {
            get => _empresaSeleccionada;
            set
            {
                SetProperty(ref _empresaSeleccionada, value);
                SeleccionarCommand.NotifyCanExecuteChanged();
            }
        }

        public bool SeleccionoEmpresa { get; private set; }

        public IAsyncRelayCommand BuscarEmpresasCommand { get; }
        public IRelayCommand SeleccionarCommand { get; }
        public IRelayCommand CancelarCommand { get; }

        public async Task BuscarEmpresasAsync()
        {
            try
            {
                Empresas.Clear();
                foreach (var empresa in _empresaRepositorio.TraerEmpresas())
                {
                    Empresas.Add(empresa);
                }
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        public void Seleccionar()
        {
            SeleccionoEmpresa = true;
            Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
        }

        public bool CanSeleccionar()
        {
            return EmpresaSeleccionada != null;
        }

        public void Cancelar()
        {
            SeleccionoEmpresa = false;
            Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
        }

        private bool EmpresasView_Filter(object obj)
        {
            if (!(obj is Empresa empresa))
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return string.IsNullOrWhiteSpace(Filtro) ||
                   empresa.Id.ToString().IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   empresa.Nombre.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   empresa.Ruta.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}