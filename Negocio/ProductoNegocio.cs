using Dato;
using Entidad;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class ProductoNegocio
    {
        private readonly ProductoDato productoDato = new ProductoDato();

        public List<Producto> ObtenerProductos()
        {
            return productoDato.ObtenerTodos();
        }

        public void ValidarProducto(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new Exception("El nombre es obligatorio.");
            if (producto.Nombre.Length > 100)
                throw new Exception("El nombre no puede superar los 100 caracteres.");
            if (producto.IdCategoria <= 0)
                throw new Exception("Debe seleccionar una categoría.");
            if (producto.PrecioCaja <= 0)
                throw new Exception("El precio por caja debe ser mayor a 0.");
            if (producto.StockCajas < 0)
                throw new Exception("El stock no puede ser negativo.");
            if (producto.StockMinimo < 0)
                throw new Exception("El stock mínimo no puede ser negativo.");
            if (productoDato.ExisteNombre(producto.Nombre, producto.Id))
                throw new Exception("Ya existe un producto con ese nombre.");
        }

        public void AgregarProducto(Producto producto)
        {
            producto.Nombre = producto.Nombre.Trim();
            ValidarProducto(producto);
            producto.Id = productoDato.Agregar(producto);
        }

        public void EditarProducto(Producto producto)
        {
            producto.Nombre = producto.Nombre.Trim();
            ValidarProducto(producto);
            if (!productoDato.Editar(producto))
                throw new Exception("El producto no existe.");
        }
    }
}
