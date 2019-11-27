using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Entidades;
using Entidades.Publicaciones;
using UI.Autores;

namespace UI.Publicaciones
{
    public class LibroDto : IEquatable<LibroDto>
    {
        [Browsable(false)]
        public EntidadId Id { get; }
        public int Nro { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Isbn { get; set; }
        public DateTime Fecha { get; set; }
        public List<AutorDto> Autores { get; set; }

        private LibroDto(EntidadId id, int nro, string titulo, string editorial, string isbn, DateTime fecha, List<AutorDto> autores)
        {
            Id = id;
            Nro = nro;
            Titulo = titulo;
            Editorial = editorial;
            Isbn = isbn;
            Fecha = fecha;
            Autores = autores;
        }

        public static LibroDto FromEntity(Libro libro) => new LibroDto(
            id: libro.Id,
            nro: libro.Numero.AsInt(),
            titulo: libro.Titulo.ToString(),
            editorial: libro.Editorial.ToString(),
            isbn: libro.Isbn.ToString(),
            fecha: libro.Fecha.ToDateTime(),
            autores: libro.Autores.Select(AutorDto.FromEntity).ToList());

        public Libro ToEntity() => new Libro(
            id: Id,
            numero: NroPublicacion.Of(Nro), 
            autores: Autores.Select(a => a.ToEntity()).ToList(),
            fecha: Entidades.Prestamos.Fecha.Of(Fecha),
            titulo: Entidades.Publicaciones.Titulo.Of(Titulo),
            isbn: ISBN.Of(Isbn),
            editorial: Entidades.Publicaciones.Editorial.Of(Editorial)
        );

        public bool Equals(LibroDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((LibroDto) obj);
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }
    }
}