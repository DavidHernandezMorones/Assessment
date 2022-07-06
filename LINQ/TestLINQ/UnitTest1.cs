using System;
using LINQ;
using Xunit;

namespace TestLINQ
{
    public class UnitTest1
    {
        string[] names =
        {
            "Juan", "Pablo", "Pedro", "Pepe", "Ana", "Esteban", "Daniel", "Mariano", "Carolina", "Silvia",
            "Roberto", "Juanito", "Juana"
        };

        string[] str =
        {
            "Silvia", "Roberto", "Pepe", "Pedro", "Pablo", "Mariano", "Juanito", "Juana", "Juan", "Esteban", "Daniel",
            "Carolina", "Ana"
        };

        string[] juanes = { "Juan", "Juanito", "Juana" };

        string[] holas =
        {
            "hola Juan", "hola Pablo", "hola Pedro", "hola Pepe", "hola Ana", "hola Esteban", "hola Daniel", "hola Mariano", "hola Carolina", "hola Silvia",
            "hola Roberto", "hola Juanito", "hola Juana"
        };

        [Fact]
        public void SortTest()
        {
            Assert.Equal(str, LinqFunc.sortdesc(names));
        }

        [Fact]
        public void FailingSortTest()
        {
            Assert.NotEqual(names, LinqFunc.sortdesc(names));
        }

        [Fact]
        public void FindTest()
        {
            Assert.True(LinqFunc.find(names, "Juan"));
        }

        [Fact]
        public void FailingFindTest()
        {
            Assert.False(LinqFunc.find(names, "Abc"));
        }

        [Fact]
        public void getJuanesTest()
        {
            Assert.Equal(juanes, LinqFunc.getJuanes(names));
        }

        [Fact]
        public void FailinggetJuanesTest()
        {
            Assert.NotEqual(names, LinqFunc.getJuanes(names));
        }

        [Fact]
        public void concatTest()
        {
            Assert.Equal(holas, LinqFunc.concat(names));
        }

        [Fact]
        public void FailingconcatTest()
        {
            Assert.NotEqual(names, LinqFunc.sortdesc(names));
        }
    }
}