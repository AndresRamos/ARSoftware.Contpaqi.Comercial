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

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Conceptos
{
    public class ListadoConceptosViewModel : ObservableRecipient
    {
        private readonly IConceptoDocumentoRepository<ConceptoDocumento> _conceptoDocumentoRepository;
        private readonly IDialogCoordinator _dialogCoordinator;
        private ConceptoDocumento _conceptoSeleccionado;
        private string _duracionBusqueda;
        private string _filtro;

        public ListadoConceptosViewModel(IConceptoDocumentoRepository<ConceptoDocumento> conceptoDocumentoRepository, IDialogCoordinator dialogCoordinator)
        {
            _conceptoDocumentoRepository = conceptoDocumentoRepository;
            _dialogCoordinator = dialogCoordinator;
            Conceptos = new ObservableCollection<ConceptoDocumento>();
            ConceptosView = CollectionViewSource.GetDefaultView(Conceptos);
            ConceptosView.Filter = ConceptosView_Filter;

            BuscarConceptosCommand = new AsyncRelayCommand(BuscarConceptosAsync);
        }

        public string Title => "Conceptos";

        public string Filtro
        {
            get => _filtro;
            set
            {
                SetProperty(ref _filtro, value);
                ConceptosView.Refresh();
                OnPropertyChanged(nameof(NumeroConceptos));
            }
        }

        public ObservableCollection<ConceptoDocumento> Conceptos { get; }

        public ICollectionView ConceptosView { get; }

        public ConceptoDocumento ConceptoSeleccionado
        {
            get => _conceptoSeleccionado;
            set => SetProperty(ref _conceptoSeleccionado, value);
        }

        public int NumeroConceptos => ConceptosView.Cast<object>().Count();

        public string DuracionBusqueda
        {
            get => _duracionBusqueda;
            private set => SetProperty(ref _duracionBusqueda, value);
        }

        public IAsyncRelayCommand BuscarConceptosCommand { get; }

        public async Task BuscarConceptosAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Conceptos.Clear();
                foreach (var concepto in _conceptoDocumentoRepository.GetAll())
                {
                    Conceptos.Add(concepto);
                    progressDialogController.SetMessage($"Numero de conceptos: {Conceptos.Count}");
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
                OnPropertyChanged(nameof(NumeroConceptos));
            }
        }

        private bool ConceptosView_Filter(object obj)
        {
            if (!(obj is ConceptoDocumento concepto))
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return string.IsNullOrWhiteSpace(Filtro) ||
                   concepto.Id.ToString().IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   concepto.Codigo.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   concepto.Nombre.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}