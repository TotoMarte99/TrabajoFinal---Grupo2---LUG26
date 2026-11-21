using Dato;
using Entidad;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class CategoriaNegocio
    {
        private readonly CategoriaDato categoriaDato = new CategoriaDato();

        public List<Categoria> ObtenerCategorias()
        {
            return categoriaDato.ObtenerTodas();
        }

        public void ValidarCategoria(Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.Descripcion))
            {
                throw new Exception("La descripción es obligatoria.");
            }
        }

        // RN-11: solo el administrador da de alta o modifica categorías
        public void AgregarCategoria(Categoria categoria)
        {
            Sesion.ExigirAdministrador();
            ValidarCategoria(categoria);
            categoria.Id = categoriaDato.Agregar(categoria);
            CategoriaAgregada?.Invoke(this, categoria);
        }

        public void EditarCategoria(Categoria categoria)
        {
            Sesion.ExigirAdministrador();
            ValidarCategoria(categoria);
            if (!categoriaDato.Editar(categoria))
            {
                throw new Exception("La categoría no existe.");
            }
        }

        public event EventHandler<Categoria>? CategoriaAgregada;
    }
}
