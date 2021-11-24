using LINQ;
using System.Linq;

IBookRepo repo = new BookRepo();
IDataWriter<Book> writer = new ConsoleWriter<Book>();
IDataWriter<BookDTO> dtoWriter = new ConsoleWriter<BookDTO>();

Console.WriteLine("Få ut alla böcker");
writer.Write(repo.Books);
writer.NewLine();

//Console.WriteLine(" Få ut en bok:");
//Book oneBook = repo.Books.First();
//writer.Write(oneBook);
//writer.NewLine();

//Console.WriteLine(" Få ut en bok med Clean i namnet:");
//Book oneBookWithNameContainsClean = repo.Books.First(b => b.Name.Contains("Clean"));
//writer.Write(oneBookWithNameContainsClean);
//writer.NewLine();

// Jämför Single och SingleOrDefault

// Jämför Single vs First

//Console.WriteLine(" Få ut en böcker skrivna efter 2010:");
//List<Book> booksWrittenAfter2010 = repo.Books.Where(b => b.FirstPublished > new DateTime(2010,1,1)).ToList();
//writer.Write(booksWrittenAfter2010);
//writer.NewLine();



//Console.WriteLine(" Får ut böckerna som DTOer");
//List<BookDTO> booksAsDTOs = repo.Books.Select(b => new BookDTO { ID = b.ID, Name = b.Name }).ToList();
//dtoWriter.Write(booksAsDTOs);
//dtoWriter.NewLine();



//Console.WriteLine("Anrop kan \"kedjas\"");
//Console.WriteLine("Få ut böcker som DTOer. Böckerna ska vara dyrare än 250 spänn och sorterade i alfabetisk ordning");
//List<BookDTO> filteredBooksAsDTOs = repo.Books
//    .Where(book => book.Price > 250)
//    .Select(b => new BookDTO { ID = b.ID, Name = b.Name })
//    .OrderBy(dto => dto.Name)
//    .ToList();
//dtoWriter.Write(filteredBooksAsDTOs);
//dtoWriter.NewLine();

// Alternativ syntax
//Console.WriteLine("Alternativ syntax");
//IEnumerable<Book> booksWrittenAfter2010 =
//    from book in repo.Books
//    where book.FirstPublished > new DateTime(2010, 1, 1)
//    select book;
//writer.Write(booksWrittenAfter2010);
//writer.NewLine();


// Jämför med SQL:

// select * from Books where FirstPublished > DateFromParts(2010,1,1)


