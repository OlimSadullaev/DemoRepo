﻿namespace StockPhoto.Entities
{
    public class Author
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? NickName { get; set; }

        public DateTime Date_of_Birth { get; set; }

        public DateTime Date_of_Registration { get; set; }
    }
}
