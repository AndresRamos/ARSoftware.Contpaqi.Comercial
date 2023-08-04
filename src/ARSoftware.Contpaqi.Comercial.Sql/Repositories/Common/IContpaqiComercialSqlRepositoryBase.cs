using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Specification;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;

/// <summary>
///     Interfaz base para los repositorios de SQL de Contpaqi Comercial.
/// </summary>
/// <typeparam name="T">
///     Tabla de SQL de Contpaqi Comercial.
/// </typeparam>
public interface IContpaqiComercialSqlRepositoryBase<T> where T : class
{
    /// <summary>
    ///     Devuelve de forma asincrónica un valor que indica si existe algún elemento de una secuencia que satisface una
    ///     condición especificada.
    /// </summary>
    /// <param name="specification">
    ///     Especificación que define el filtro de búsqueda.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación que se debe observar mientras se espera a que se complete la
    ///     tarea.
    /// </param>
    /// <returns>
    ///     Una tarea que representa la operación asincrónica. El resultado de la tarea contiene un valor que indica si existe
    ///     algún elemento de la secuencia que satisface la condición especificada.
    /// </returns>
    Task<bool> AnyAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Devuelve de forma asincrónica el número de elementos de una secuencia que satisfacen una condición especificada.
    /// </summary>
    /// <param name="specification">
    ///     Especificación que define el filtro de búsqueda.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación que se debe observar mientras se espera a que se complete la
    ///     tarea.
    /// </param>
    /// <returns>
    ///     Una tarea que representa la operación asincrónica. El resultado de la tarea contiene el número de elementos de la
    ///     secuencia que satisface la condición especificada.
    /// </returns>
    Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Devuelve de forma asincrónica el primer elemento de una secuencia o un valor predeterminado si la secuencia no
    ///     contiene ningún elemento.
    /// </summary>
    /// <param name="specification">
    ///     Especificación que define el filtro de búsqueda.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación que se debe observar mientras se espera a que se complete la tarea.
    /// </param>
    /// <returns>
    ///     Una tarea que representa la operación asincrónica. El resultado de la tarea contiene el primer elemento de la
    ///     secuencia que satisface la condición especificada si se encuentra; de lo contrario, el valor predeterminado para el
    ///     tipo de elemento.
    /// </returns>
    Task<T?> FirstOrDefaultAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Devuelve de forma asincrónica una lista de elementos que satisfacen la condición especificada.
    /// </summary>
    /// <param name="specification">
    ///     Especificación que define el filtro de búsqueda.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación que se debe observar mientras se espera a que se complete la
    ///     tarea.
    /// </param>
    /// <returns>
    ///     Una tarea que representa la operación asincrónica. El resultado de la tarea contiene una lista de elementos que
    ///     satisfacen la condición especificada.
    /// </returns>
    Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Devuelve de forma asincrónica el único elemento de una secuencia que satisface una condición especificada o un
    ///     valor predeterminado si no existe dicho elemento; Este método produce una excepción si más de un elemento cumple la
    ///     condición.
    /// </summary>
    /// <param name="specification">
    ///     Especificación que define el filtro de búsqueda.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación que se debe observar mientras se espera a que se complete la
    ///     tarea.
    /// </param>
    /// <returns>
    ///     Una tarea que representa la operación asincrónica. El resultado de la tarea contiene el único elemento de la
    ///     secuencia que satisface la condición especificada, o el valor predeterminado para el tipo de elemento si la
    ///     secuencia está vacía.
    /// </returns>
    Task<T?> SingleOrDefaultAsync(ISingleResultSpecification<T> specification, CancellationToken cancellationToken = default);
}

/// <summary>
///     Interfaz base para los repositorios de SQL de Contpaqi Comercial.
/// </summary>
/// <typeparam name="T">
///     Tabla de SQL de Contpaqi Comercial.
/// </typeparam>
/// <typeparam name="TResult">
///     Tipo al que se va a mapear el resultado de la consulta.
/// </typeparam>
public interface IContpaqiComercialSqlRepositoryBase<T, TResult> where T : class
{
    /// <summary>
    ///     Devuelve de forma asincrónica un valor que indica si existe algún elemento de una secuencia que satisface una
    ///     condición especificada.
    /// </summary>
    /// <param name="specification">
    ///     Especificación que define el filtro de búsqueda.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación que se debe observar mientras se espera a que se complete la
    ///     tarea.
    /// </param>
    /// <returns>
    ///     Una tarea que representa la operación asincrónica. El resultado de la tarea contiene un valor que indica si existe
    ///     algún elemento de la secuencia que satisface la condición especificada.
    /// </returns>
    Task<bool> AnyAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Devuelve de forma asincrónica el número de elementos de una secuencia que satisfacen una condición especificada.
    /// </summary>
    /// <param name="specification">
    ///     Especificación que define el filtro de búsqueda.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación que se debe observar mientras se espera a que se complete la
    ///     tarea.
    /// </param>
    /// <returns>
    ///     Una tarea que representa la operación asincrónica. El resultado de la tarea contiene el número de elementos de la
    ///     secuencia que satisface la condición especificada.
    /// </returns>
    Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Devuelve de forma asincrónica el primer elemento de una secuencia o un valor predeterminado si la secuencia no
    ///     contiene ningún elemento.
    /// </summary>
    /// <param name="specification">
    ///     Especificación que define el filtro de búsqueda.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación que se debe observar mientras se espera a que se complete la tarea.
    /// </param>
    /// <returns>
    ///     Una tarea que representa la operación asincrónica. El resultado de la tarea contiene el primer elemento de la
    ///     secuencia que satisface la condición especificada si se encuentra; de lo contrario, el valor predeterminado para el
    ///     tipo de elemento.
    /// </returns>
    Task<TResult?> FirstOrDefaultAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Devuelve de forma asincrónica una lista de elementos que satisfacen la condición especificada.
    /// </summary>
    /// <param name="specification">
    ///     Especificación que define el filtro de búsqueda.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación que se debe observar mientras se espera a que se complete la
    ///     tarea.
    /// </param>
    /// <returns>
    ///     Una tarea que representa la operación asincrónica. El resultado de la tarea contiene una lista de elementos que
    ///     satisfacen la condición especificada.
    /// </returns>
    Task<List<TResult>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Devuelve de forma asincrónica el único elemento de una secuencia que satisface una condición especificada o un
    ///     valor predeterminado si no existe dicho elemento; Este método produce una excepción si más de un elemento cumple la
    ///     condición.
    /// </summary>
    /// <param name="specification">
    ///     Especificación que define el filtro de búsqueda.
    /// </param>
    /// <param name="cancellationToken">
    ///     Token de cancelación que se debe observar mientras se espera a que se complete la
    ///     tarea.
    /// </param>
    /// <returns>
    ///     Una tarea que representa la operación asincrónica. El resultado de la tarea contiene el único elemento de la
    ///     secuencia que satisface la condición especificada, o el valor predeterminado para el tipo de elemento si la
    ///     secuencia está vacía.
    /// </returns>
    Task<TResult?> SingleOrDefaultAsync(ISingleResultSpecification<T> specification, CancellationToken cancellationToken = default);
}
