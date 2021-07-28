using System;

namespace Catlog.DTOs
{
    public record ItemDto
    {
        // make a Guid property "Id"
        public Guid Id { get; init; }

        // crate two string properties "Name" and "Address"
        public string Name { get; init; }
        public decimal Price { get; init; }

        // create DateTimeOffset property "CreatedDate"
        public DateTimeOffset CreatedDate { get; init; }
    }
}