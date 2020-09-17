using System.Collections.Generic;
using Xunit;

namespace Test
{
    public class MethTest
    {
        private readonly List<int> _unsortedOdd = new List<int> { 2, 1, 3 };
        private readonly List<int> _unsortedEven = new List<int> { 2,1, 3, 4 };
        
        private readonly List<int> _nullList = null;
        private readonly List<int> _emptyList = new List<int>();

        private readonly List<int> _sortedOdd = new List<int> { 1, 2, 3 };
        private readonly List<int> _sortedEven = new List<int> { 1, 2, 3 };

        [Fact]
        public void Mittelwert_UnsortedOddList_ShouldBeTwo()
        {
            //Act
            var res = Meth.Mittelwert(_unsortedOdd);
            
            //Assert
            Assert.Equal(2, res);
        }

        [Fact]
        public void Mittelwert_UnsortedEvenList_ShouldBeTwoPointFive()
        {
            //Act
            var res = Meth.Mittelwert(_unsortedEven);
            
            //Assert
            Assert.Equal(2.5, res);
        }

        [Fact]
        public void Mittelwert_Null_ReturnsNull()
        {
            //Act
            var res = Meth.Mittelwert(_nullList);
            
            //Assert
            Assert.Null(res);
        }

        [Fact]
        public void Mittelwert_EmptyList_ReturnsNull()
        {
            //Act
            var res = Meth.Mittelwert(_emptyList);
            
            //Assert
            Assert.Null(res);
        }

        [Fact]
        public void Mittelwert_SortedOdd_Two()
        {
            //Act
            var res = Meth.Mittelwert(_sortedOdd);

            //Assert
            Assert.Equal(2,res);
        }

        [Fact]
        public void Mittelwert_SortedEven_TwoPointFive()
        {
            //Act
            var res = Meth.Mittelwert(_sortedEven);
            
            //Assert
            Assert.Equal(2.5, res);
        }
    }
}
