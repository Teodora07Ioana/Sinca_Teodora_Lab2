﻿using Sinca_Teodora_Lab2.Models;

namespace Sinca_Teodora_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
