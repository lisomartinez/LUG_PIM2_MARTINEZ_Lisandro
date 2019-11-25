using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void crearSocio()
        {
            var socio = new Socio(new NroSocio(1), new Nombre("Lisandro"), new Apellido("Martinez"));
            socio.NroSocio.Should().Be(NroSocio.Of(1));
            socio.Nombre.Should().Be(Nombre.Of("Lisandro"));
            socio.Apellido.Should().Be(Apellido.Of("Martinez"));
        }

        [Fact]
        public void NombreValido()
        {
            
            Action act = () => Nombre.Of("");
            act.Should().Throw<NombreInvalidoException>();
        }
    }
}
