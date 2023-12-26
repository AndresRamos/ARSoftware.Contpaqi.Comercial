using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using AutoMapper;

namespace Sdk.Extras.ConsoleApp;

public class EditarDocumento
{
    private readonly IConceptoDocumentoRepository<ConceptoDocumentoDto> _conceptoDocumentoRepository;
    private readonly IDocumentoRepository<DocumentoDto> _documentoRepository;
    private readonly IDocumentoService _documentoService;
    private readonly IMapper _mapper;

    public EditarDocumento(IDocumentoService documentoService, IDocumentoRepository<DocumentoDto> documentoRepository, IMapper mapper,
        IConceptoDocumentoRepository<ConceptoDocumentoDto> conceptoDocumentoRepository)
    {
        _documentoService = documentoService;
        _documentoRepository = documentoRepository;
        _mapper = mapper;
        _conceptoDocumentoRepository = conceptoDocumentoRepository;
    }

    public void Editar()
    {
        var codigoConcepto = "PRUEBAFACTURA";
        var serie = "PRUEBA";
        var folio = 1;

        DocumentoDto? documentoDto = _documentoRepository.BuscarPorLlave(codigoConcepto, serie, folio);

        if (documentoDto is null)
            throw new Exception($"No se encontró el documento con el código {codigoConcepto} y la serie {serie} y el folio {folio}.");

        ConceptoDocumentoDto? conceptoDocumentoDto = _conceptoDocumentoRepository.BuscarPorCodigo(codigoConcepto);

        var documento = _mapper.Map<Documento>(documentoDto);
        documento.Concepto = _mapper.Map<ConceptoDocumento>(conceptoDocumentoDto);
        documento.FormaPago = FormaPagoEnum._03;
        documento.MetodoPago = MetodoPagoEnum.PPD;
        documento.Observaciones = "Observaciones editadas";
        documento.Referencia = "Referencia editada";
        documento.DatosExtra.Add(nameof(admDocumentos.CTEXTOEXTRA1), "Texto Extra 1 editado");

        _documentoService.Actualizar(documento);
    }
}
