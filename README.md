This project requires .Net Core 2.2 to be installed in order to run
In order to run this project run the command "dotnet run" in the command window

Swagger documentation can be found at {baseurl}/swagger/index.html

Design decisions and compromises:

This project was made in an ubuntu environment. In order to minimise risk with external services on different operating systems I decided to keep all of the data stored in memory.

Were I operating in a windows environment I would have kept the same data structures for a local DB or file system, but I would have made the Ids for User and Movie primary keys. MovieId and UserId for MovieRating would have been foreign keys.

I did not write unit tests for this project but that would most likely be my next step.

I did not add authentication for the users as that would have been an added source of complexity, in addition it was not asked for and I was trying to keep this to be an MVP.

Similarly I could have stored the average rating for the movie along with a count of how many ratings there were with the Movie object itself. This would have been beneficial in a larger system so that the entire ratings and movie data sources would not have to be read. I decided against this as the dataset was not large enough for any noticable performance gains and would have been an added source of complexity.

My overarching philosopy with the design was to try and maintain some layers, so that the API mapping was seperate from the business logic which was in turn seperate from the CRUD operations on the data sources.
