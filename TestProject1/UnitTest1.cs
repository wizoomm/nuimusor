using AutoFixture;
using NSubstitute;
using TestConsole4.Core;
using TestConsole4.Model;
using TestConsole4.Services;

namespace TestProject1;

public class UnitTest1
{
    private Fixture fixture = new Fixture();

    [Fact]
    public void Find_WithRealData_ReturnsExpected()
    {
        var notes = fixture.Build<Note>()
            .With(x => x.Title, "одинаковый тайл для всех")
            .CreateMany();

        var repo = Substitute.For<INoteRepository>();
        repo.GetAll().Returns(notes);


        var noteService = new SuperNote(repo);

        var result = noteService.GetAllForToday();

        Assert.NotNull(result);
    }
}