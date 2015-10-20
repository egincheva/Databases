﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongDB.Driver.Demos.Models
{
    internal class Book : IEntity
    {
        public Book(string title, string isbn, Author patrickRothfuss)
        {
            this.Title = title;
            this.ISBN = isbn;
            this.Author = patrickRothfuss;
        }

        public Author Author { get; set; }


        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        public string Id { get; set; }

        public string ISBN { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1}) by {2}", this.Title, this.ISBN, this.Author);
        }
    }
}