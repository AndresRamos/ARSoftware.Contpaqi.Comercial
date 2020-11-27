using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Almacenes
{
    public class ListadoAlmacenesViewModel : ObservableRecipient
    {
        private readonly IAlmacenRepositorio _almacenRepositorio;
        private readonly IDialogCoordinator _dialogCoordinator;
        private Almacen _almacenSeleccionado;
        private bool _buscarObjectosRelacionados = true;
        private string _duracionBusqueda;
        private string _filtro;

        public ListadoAlmacenesViewModel(IAlmacenRepositorio almacenRepositorio, IDialogCoordinator dialogCoordinator)
        {
            _almacenRepositorio = almacenRepositorio;
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
            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Almacenes.Clear();
                foreach (var almacen in _almacenRepositorio.TraerAlmacenes())
                {
                    Almacenes.Add(almacen);
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
                OnPropertyChanged(nameof(NumeroAlmacenes));
            }
        }

        private bool AlmacenesView_Filter(object obj)
        {
            var almacen = obj as Almacen;
            if (almacen is null)
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