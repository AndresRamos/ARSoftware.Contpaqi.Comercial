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

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Almacenes
{
    public class ListadoAlmacenesViewModel : ObservableRecipient
    {
        private readonly IAlmacenRepository<Almacen> _almacenRepository;
        private readonly IDialogCoordinator _dialogCoordinator;
        private Almacen _almacenSeleccionado;
        private bool _buscarObjectosRelacionados = true;
        private string _duracionBusqueda;
        private string _filtro;

        public ListadoAlmacenesViewModel(IAlmacenRepository<Almacen> almacenRepository, IDialogCoordinator dialogCoordinator)
        {
            _almacenRepository = almacenRepository;
            _dialogCoordinator = dialogCoordinator;
            Almacenes = new ObservableCollection<Almacen>();
            AlmacenesView = CollectionViewSource.GetDefaultView(Almacenes);
            AlmacenesView.Filter = AlmacenesView_Filter;

            BuscarAlmacenesCommand = new AsyncRelayCommand(BuscarAlmacenesAsync);
        }

        public string Title => "Almacenes";

        public string Filtro
        {
            get => _filtro;
            set
            {
                SetProperty(ref _filtro, value);
                AlmacenesView.Refresh();
                OnPropertyChanged(nameof(NumeroAlmacenes));
            }
        }

        public ObservableCollection<Almacen> Almacenes { get; }

        public ICollectionView AlmacenesView { get; }

        public Almacen AlmacenSeleccionado
        {
            get => _almacenSeleccionado;
            set => SetProperty(ref _almacenSeleccionado, value);
        }

        public bool BuscarObjectosRelacionados
        {
            get => _buscarObjectosRelacionados;
            set => SetProperty(ref _buscarObjectosRelacionados, value);
        }

        public int NumeroAlmacenes => AlmacenesView.Cast<object>().Count();

        public string DuracionBusqueda
        {
            get => _duracionBusqueda;
            private set => SetProperty(ref _duracionBusqueda, value);
        }

        public IAsyncRelayCommand BuscarAlmacenesCommand { get; }

        public async Task BuscarAlmacenesAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Almacenes.Clear();
                foreach (var almacen in _almacenRepository.TraerTodo())
                {
                    Almacenes.Add(almacen);
                    progressDialogController.SetMessage($"Numero de almacenes: {Almacenes.Count}");
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
                OnPropertyChanged(nameof(NumeroAlmacenes));
            }
        }

        private bool AlmacenesView_Filter(object obj)
        {
            if (!(obj is Almacen almacen))
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return string.IsNullOrWhiteSpace(Filtro) ||
                   almacen.Id.ToString().IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   almacen.Codigo.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   almacen.Nombre.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}