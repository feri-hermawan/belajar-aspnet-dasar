using GameStore.Api.Entities;

List<Game> games = new (){
    new Game(){
        Id = 1,
        Name = "EAFC 24",
        Genre = "Sport",
        Price = 500000,
        releaseDate = new DateTime(2023,4,24),
        imgUri  = "https://placehols.co/100"    
    },
        new Game(){
        Id = 2,
        Name = "Final Fantasy XVI",
        Genre = "RPG",
        Price = 800000,
        releaseDate = new DateTime(2024,4,24),
        imgUri  = "https://placehols.co/100"    
    },
        new Game(){
        Id = 3,
        Name = "Spiderman 2",
        Genre = "Advanture, Action",
        Price = 900000,
        releaseDate = new DateTime(2023,5,24),
        imgUri  = "https://placehols.co/100"    
    },
};

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => games);
app.MapGet("/games/{id}", (int id) => games.Find(game => game.Id == id));

app.Run();
