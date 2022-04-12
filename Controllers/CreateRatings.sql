CREATE TABLE Ratings
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    RestaurantId INT NOT NULL,
    FoodScore FLOAT NOT NULL CHECK(FoodScore >=0.0 AND FoodScore <= 5.0),
    CleanlinessScore FLOAT NOT NULL CHECK (CleanlinessScore >=0.0 AND CleanlinessScore <= 5.0),
    AtmosphereScore FLOAT NOT NULL CHECK(AtmosphereScore >=0.0 AND AtmosphereScore <= 5.0)
)