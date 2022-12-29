using System.Collections.Generic;
using GuiltyGear.WebApp.Context;
using GuiltyGear.WebApp.Data;
using GuiltyGear.WebApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace GuiltyGear.WebApp;

public class RepositoryTest
{
    [Fact]
    public void RepositoryGetCharacterFromRepository()
    {
        // Arrange
        var characterTest = new StriveCharacter { Id = 1, Name = "Sol Badguy" };
        var context = new Mock<GuiltyGearDatabase>();
        
        // Act
        var repository = new StriveRepository(context.Object);
        var character = repository.GetCharacterData(1).Result;

        // Assert
        Assert.Equal(characterTest, character);
    }
}
