Task1


using ConsoleApp1;

Car car = new Car();

car.speed = 300;

car.colour = "Black";

car.Vin = "QWERTY";

Console.WriteLine(car.speed);







using ConsoleApp1.Controller;

BookController bookController = new BookController();

bookController.GetAllByAuthor();

bookController.GetById();

bookController.Search();