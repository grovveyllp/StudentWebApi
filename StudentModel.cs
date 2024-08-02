﻿namespace FirstApi
{
    public class StudentModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
