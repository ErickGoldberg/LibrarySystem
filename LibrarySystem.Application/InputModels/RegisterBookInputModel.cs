﻿namespace LibrarySystem.Application.InputModels
{
    public class RegisterBookInputModel
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
    }
}
