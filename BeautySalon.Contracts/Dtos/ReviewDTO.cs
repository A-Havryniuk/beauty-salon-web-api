﻿namespace BeautySalon.Contracts.Dtos
{
    public class ReviewDTO
    {

        public int Id { get; set; }
        public string ClientEmail { get; set; }

        public string EmployeeEmail { get; set; }

        public string Text { get; set; }

        public int Rate { get; set; }
    }
}
