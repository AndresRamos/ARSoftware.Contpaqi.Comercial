using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.UnidadesMedida
{
    public class ListadoUnidadesMedidaViewModel : ObservableRecipient
    {
        private readonly IDialogCoordinator _dialogCoordinator;
        private readonly IUnidadMedidaRepository<UnidadMedida> _unidadMedidaRepository;
        private string _duracionBusqueda;
        private string _filtro;
        private UnidadMedida _unidadMedidaSeleccionada;

        public ListadoUnidadesMedidaViewModel(IUnidadMedidaRepository<UnidadMedida> unidadMedidaRepository, IDialogCoordinator dialogCoordinator)
        {
            _unidadMedidaRepository = unidadMedidaRepository;
            _dialogCoordinator = dialogCoordinator;
            UnidadesMedida = new ObservableCollection<UnidadMedida>();
            UnidadesMedidaView = CollectionViewSource.GetDefaultView(UnidadesMedida);
            UnidadesMedidaView.Filter = UnidadesMedidaView_Filter;

            BuscarUnidadesCommand = new AsyncRelayCommand(BuscarUnidadesAsync);
        }

        public string Title => "Unidades De Medida";

        public string Filtro
        {
            get => _filtro;
            set
            {
                SetProperty(ref _filtro, value);
                UnidadesMedidaView.Refresh();
                OnPropertyChanged(nameof(NumeroUnidades));
            }
        }

        public ObservableCollection<UnidadMedida> UnidadesMedida { get; }

        public ICollectionView UnidadesMedidaView { get; }

        public UnidadMedida UnidadMedidaSeleccionada
        {
            get => _unidadMedidaSeleccionada;
            set => SetProperty(ref _unidadMedidaSeleccionada, value);
        }

        public int NumeroUnidades => UnidadesMedidaView.Cast<object>().Count();

        public string DuracionBusqueda
        {
            get => _duracionBusqueda;
            private set => SetProperty(ref _duracionBusqueda, value);
        }

        public IAsyncRelayCommand BuscarUnidadesCommand { get; }

        public async Task BuscarUnidadesAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                UnidadesMedida.Clear();
                foreach (var unidadMedida in _unidadMedidaRepository.TraerTodo())
                {
                    UnidadesMedida.Add(unidadMedida);
                    progressDialogController.SetMessage($"Numero de unidades: {UnidadesMedida.Count}");
                    await Task.Delay(50);
                }

                stopwatch.Stop();
                DuracionBusqueda = stopwatch.Elapsed.ToString("g");
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
            finally
            {
                await progressDialogController.CloseAsync();
                OnPropertyChanged(nameof(NumeroUnidades));
            }
        }

        private bool UnidadesMedidaView_Filter(object obj)
        {
            if (!(obj is UnidadMedida unidadMedida))
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return string.IsNullOrWhiteSpace(Filtro) ||
                   unidadMedida.Id.ToString().IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   unidadMedida.Nombre.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}