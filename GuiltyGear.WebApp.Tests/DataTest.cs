using GuiltyGear.WebApp.Data;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace GuiltyGear.WebApp;

public class DataTest
{
    [Fact]
    public void RepositoryGetsStriveCharacterFromRepository()
    {
        // Arrange
        var character = new StriveCharacter();
        var context = new Mock<DbContext>();
        var dbSetMock = new Mock<DbSet<StriveCharacter>>();
        
        context.Setup(x => x.Set<StriveCharacter>()).Returns(dbSetMock.Object);
        dbSetMock.Setup(x => x.Find(It.IsAny<int>())).Returns(character);
        
        // Act
        
        // Assert
    }
}
